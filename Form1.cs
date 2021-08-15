using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KiwoomCode;
using Algorithm;
using System.Threading;


namespace Wongi_AI_Trading
{
    public delegate void PasswordEventHandler(string Acc, string Pass);
    public delegate void SafeCallDelegate(string format, params Object[] args);

    public partial class Form1 : Form, Log_Interface
    {
        //Initial 설정 (Form간 데이터 주고받기 / OpenAPI Event 발생에 따른 함수 추가)

        public Form1()
        {
            InitializeComponent();
            Form2.PasswordEvent += new PasswordEventHandler(Password_Process);
            this.axKHOpenAPI.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI_OnEventConnect);
            this.axKHOpenAPI.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.axKHOpenAPI_OnReceiveTrData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // =================================================
            // 거래구분목록 지정
            for (int i = 0; i < 12; i++)
                cbo거래구분.Items.Add(KOACode.hogaGb[i].name);

            cbo거래구분.SelectedIndex = 0;


            // =================================================
            // 주문유형
            for (int i = 0; i < 5; i++)
                cbo매매구분.Items.Add(KOACode.orderType[i].name);

            cbo매매구분.SelectedIndex = 0;


            // =================================================
            // 알고리즘 유형
            for (int i = 0; i < Algorithm_Info.Algorithm_num; i++)
                Select_Algorithm.Items.Add(Algorithm_Info.Algorithm_Code[i]);

            Select_Algorithm.SelectedIndex = 0;

        }

        //Log번호, 계좌, 비밀번호, 화면번호 Parameter
        private int log_num = 0;
        private static string Account="0";
        private static string Password = "0000";
        private int _scrNum = 5000;

        private string Chart_name, Chart_Code;
        private int[] Chart_Price = new int[600];
        private string[] Chart_Date = new string[600];
        private static int Chart_On = 0;

        //
        급상승_Day_Trading Algorithm_급상승_Day_Trading;
        //

        //화면번호 생성 함수
        private string GetScrNum()
        {
            if (_scrNum < 9999)
                _scrNum++;
            else
                _scrNum = 5000;

            return _scrNum.ToString();
        }

        
        public void Logger(string format, params Object[] args) //Log 출력 함수(Str 배열을 받아 합쳐 출력)
        {
            if (Log.InvokeRequired)
            {
                var d = new SafeCallDelegate(Logger);
                Invoke(d, new object[] { format, args });
            }
            else
            {
                string message = String.Format(format, args);
                Log.Items.Add(log_num.ToString() + ":\t" + message);
                Log.SelectedIndex = Log.Items.Count - 1;
                log_num++;
            }
        }

        //로그인 동작
        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (로그인ToolStripMenuItem.Text == "로그인")
            {
                if (axKHOpenAPI.CommConnect() == 0)
                {
                    Logger("로그인 시작");
                }
                else
                {
                    Logger("로그인 창 열기 실패");
                }
            }
            else
            {
                axKHOpenAPI.CommTerminate();
                Logger("로그아웃");
                로그인ToolStripMenuItem.Text = "로그인";
            }
        }
        //로그인 Event 동작
        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (Error.IsError(e.nErrCode))
            {
                Logger("[로그인 처리결과] " + Error.GetErrorMessage());
                로그인ToolStripMenuItem.Text = "로그아웃";
                계좌조회();
                Password_Process(cbo계좌.Text, "0000");
            }
            else
            {
                Logger("[로그인 처리결과] " + Error.GetErrorMessage());
            }
        }

        //비밀번호 입력을 위한 Subform Plot
        private void Password_btn_Click(object sender, EventArgs e)
        {
            //자식 Form 생성
            Form2 Password_form = new Form2(cbo계좌.Text);
            Password_form.ShowDialog();
        }

        //Subform에서 비밀번호를 전달하는 함수
        private void Password_Process(string Acc, string Pass)
        {
            Account = Acc;
            Password = Pass;
            User_Info.user.Account = Acc;
            User_Info.user.Password = Pass;
            Logger("계좌 / 비밀번호 입력 완료");
            Password_status.Text = "ON";
            Password_status.BackColor = System.Drawing.Color.Green;
        }

        //현재가 조회 동작
        private void 현재가_조회_Click(object sender, EventArgs e)
        {
            axKHOpenAPI.SetInputValue("종목코드", 종목코드.Text.Trim());

            int nRet = axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, GetScrNum());
            _scrNum++;

            if (Error.IsError(nRet))
            {
                Logger("[OPT10001] : " + Error.GetErrorMessage());
            }
            else
            {
                Logger("[OPT10001] : " + Error.GetErrorMessage());
            }
        }

        //기간 가격 조회 및 차트 출력
        private void 기간조회_Click(object sender, EventArgs e)
        {
            axKHOpenAPI.SetInputValue("종목코드", 종목코드.Text.Trim());
            axKHOpenAPI.SetInputValue("기준일자", 조회기간.Value.ToString("yyyyMMdd").Trim());
            axKHOpenAPI.SetInputValue("수정주가구분", "1");

            Chart_On = 1;
            int nRet = axKHOpenAPI.CommRqData("주식일봉차트조회", "OPT10081", 0, GetScrNum());
            _scrNum++;

            if (Error.IsError(nRet))
            {
                Logger("[OPT10081] : " + Error.GetErrorMessage());
            }
            else
            {
                Logger("[OPT10081] : " + Error.GetErrorMessage());
            }
        }

        //API로 부터 주문/ 조회 등 데이터 수신 시 Event 동작
        private void axKHOpenAPI_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

            if (e.sRQName == "주식주문")
            {
                string s원주문번호 = axKHOpenAPI.GetCommData(e.sTrCode, "", 0, "").Trim();

                long n원주문번호 = 0;
                bool canConvert = long.TryParse(s원주문번호, out n원주문번호);

                if (canConvert == true)
                    txt원주문번호.Text = s원주문번호;
                else
                    Logger("잘못된 원주문번호 입니다");

            }
            // OPT1001 : 주식기본정보
            else if (e.sRQName == "주식기본정보")
            {
                Logger("{0} | 현재가:{1:N0} | 등락율:{2} | 거래량:{3:N0} ",
                       axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim(),
                       Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", 0, "현재가").Trim()),
                       axKHOpenAPI.GetCommData(e.sTrCode, "", 0, "등락율").Trim(),
                       Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", 0, "거래량").Trim()));
                /*
                if (Chart_On == 1)
                {
                    Chart_name = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "종목명").Trim();
                    chart1.Series[Chart_Code].LegendText = Chart_name;
                    Chart_On = 0;
                }*/
            }
            // OPT10081 : 주식일봉차트조회
            else if (e.sRQName == "주식일봉차트조회")
            {
                int nCnt = axKHOpenAPI.GetRepeatCnt(e.sTrCode, e.sRQName);

                for (int i = 0; i < nCnt; i++)
                {
                    Logger("{0} | 현재가:{1:N0} | 거래량:{2:N0} | 시가:{3:N0} | 고가:{4:N0} | 저가:{5:N0} ",
                        axKHOpenAPI.GetCommData(e.sTrCode, "", i, "일자").Trim(),
                        Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "현재가").Trim()),
                        Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "거래량").Trim()),
                        Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "시가").Trim()),
                        Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "고가").Trim()),
                        Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "저가").Trim()));
                    Chart_Price[i] = Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "현재가").Trim());
                    Chart_Date[i] = axKHOpenAPI.GetCommData(e.sTrCode, "", i, "일자").Trim();
                    //Chart_Date[i] = Int32.Parse(axKHOpenAPI.GetCommData(e.sTrCode, "", i, "일자").Trim());
                }
                if (Chart_On == 1)
                {
                    Chart_Code = axKHOpenAPI.GetCommData(e.sTrCode, e.sRQName, 0, "종목코드").Trim();
                    chart1.Series.Clear();
                    chart1.Titles.Clear();
                    Series chart = chart1.Series.Add(Chart_Code);
                    chart1.Titles.Add("종목 기간 차트");
                    for (int i = nCnt-1; i >= 0; i--)   // for문으로 차트 차트 출력
                    {
                        chart.Points.AddXY(Chart_Date[i], Chart_Price[i]); // 차트 한줄 출력해주는 코드
                    }

                    chart.ChartType = SeriesChartType.Line; // 그래프를 라인으로 출력
                    Chart_name = axKHOpenAPI.GetMasterCodeName(종목코드.Text.Trim());
                    chart1.Series[Chart_Code].LegendText = Chart_name;
                    Chart_On = 0;
                    /*axKHOpenAPI.SetInputValue("종목코드", 종목코드.Text.Trim());
                    int nRet = axKHOpenAPI.CommRqData("주식기본정보", "OPT10001", 0, GetScrNum());
                    _scrNum++;*/
                }
            }

        }

        private void btn주문_Click(object sender, EventArgs e)
        {
            
            // =================================================
            // 계좌번호 입력 여부 확인
            if (Account.Length != 10)
            {
                Logger("계좌번호 10자리를 입력해 주세요");

                return;
            }

            // =================================================
            // 종목코드 입력 여부 확인
            if (txt주문종목코드.TextLength != 6)
            {
                Logger("종목코드 6자리를 입력해 주세요");

                return;
            }

            // =================================================
            // 주문수량 입력 여부 확인
            int n주문수량;

            if (txt주문수량.TextLength > 0)
            {
                n주문수량 = Int32.Parse(txt주문수량.Text.Trim());
            }
            else
            {
                Logger("주문수량을 입력하지 않았습니다");

                return;
            }

            if (n주문수량 < 1)
            {
                Logger("주문수량이 1보다 작습니다");

                return;
            }

            // =================================================
            // 거래구분 취득
            // 0:지정가, 3:시장가, 5:조건부지정가, 6:최유리지정가, 7:최우선지정가,
            // 10:지정가IOC, 13:시장가IOC, 16:최유리IOC, 20:지정가FOK, 23:시장가FOK,
            // 26:최유리FOK, 61:장개시전시간외, 62:시간외단일가매매, 81:시간외종가

            string s거래구분;
            s거래구분 = KOACode.hogaGb[cbo거래구분.SelectedIndex].code;

            // =================================================
            // 주문가격 입력 여부

            int n주문가격 = 0;

            if (txt주문가격.TextLength > 0)
            {
                n주문가격 = Int32.Parse(txt주문가격.Text.Trim());
            }

            if (s거래구분 == "3" || s거래구분 == "13" || s거래구분 == "23" && n주문가격 < 1)
            {
                Logger("주문가격이 1보다 작습니다");
            }

            // =================================================
            // 매매구분 취득
            // (1:신규매수, 2:신규매도 3:매수취소, 
            // 4:매도취소, 5:매수정정, 6:매도정정)

            int n매매구분;
            n매매구분 = KOACode.orderType[cbo매매구분.SelectedIndex].code;

            // =================================================
            // 원주문번호 입력 여부

            if (n매매구분 > 2 && txt원주문번호.TextLength < 1)
            {
                Logger("원주문번호를 입력해주세요");
            }


            // =================================================
            // 주식주문
            int lRet;

            lRet = axKHOpenAPI.SendOrder("주식주문", GetScrNum(), Account.Trim(),
                                        n매매구분, txt주문종목코드.Text.Trim(), n주문수량,
                                        n주문가격, s거래구분, txt원주문번호.Text.Trim());

            if (lRet == 0)
            {
                Logger("주문이 전송 되었습니다");
            }
            else
            {
                Logger("주문이 전송 실패 하였습니다. [에러] : " + lRet);
            }
        }
        //계좌 데이터 조회 함수
        private void 계좌조회()
        {
            ID.Text = axKHOpenAPI.GetLoginInfo("USER_ID");
            이름.Text = axKHOpenAPI.GetLoginInfo("USER_NAME");

            string[] arr계좌 = axKHOpenAPI.GetLoginInfo("ACCNO").Split(';');

            cbo계좌.Items.AddRange(arr계좌);
            cbo계좌.SelectedIndex = 0;
        }
        double convert_percent(string txt)
        {
            double percent = double.Parse(txt.Split('%')[0]) / 100;
            return percent;
        }

        private void test2_Click(object sender, EventArgs e)
        {
            Algorithm_급상승_Day_Trading = new 급상승_Day_Trading(ref axKHOpenAPI, convert_percent(Deposit.Text), this);
            Algorithm_급상승_Day_Trading.Test();
            //a.Increase_Stock_Search();
        }
        //Percent String -> Double 변환
        
        private void test3_Click(object sender, EventArgs e)
        {
            if (Algorithm_급상승_Day_Trading == null)
            {
                Algorithm_급상승_Day_Trading = new 급상승_Day_Trading(ref axKHOpenAPI, convert_percent(Deposit.Text), this);
                Algorithm_급상승_Day_Trading.Program_On = true;
                //Algorithm_급상승_Day_Trading.Program_off();
            }
            //Algorithm_급상승_Day_Trading.Day_End();

            //Algorithm_급상승_Day_Trading.Get_Deposit();
            //Algorithm_급상승_Day_Trading.Get_Income();
            //Algorithm_급상승_Day_Trading.Get_Account_Income();
            //Algorithm_급상승_Day_Trading.Get_Stock_Income();


            //Algorithm_급상승_Day_Trading.Increase_Stock_Search();
            //
            //Algorithm_급상승_Day_Trading.Get_Deposit();

            //Logger(str_test+DateTime.Now);

            /*for (int i = 0; i < 500; i++)
            {
                Logger("종목코드:{0:N0} | 현재가:{1:N0} | 등락율:{2}",
                        a.Stock_Code[i], a.Purchase_Price[i], a.Increase_percent[i]);
            }*/
        }

        private void Start_Algorithm_Click(object sender, EventArgs e)
        {
            if (Select_Algorithm.Text == Algorithm_Info.Algorithm_Code[0])
            {
                Algorithm_급상승_Day_Trading = new 급상승_Day_Trading(ref axKHOpenAPI, convert_percent(Deposit.Text), this);
                Logger("급상승_Day_Trading 알고리즘 Start!");
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeZoneInfo hwZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            now = TimeZoneInfo.ConvertTime(now, TimeZoneInfo.Local, hwZone);
            DateTime nowtime = DateTime.ParseExact("2000", "HHmm", System.Globalization.CultureInfo.InvariantCulture);

            if (nowtime > now)
                MessageBox.Show(nowtime.ToString());
            else
                MessageBox.Show(now.ToString());
        }
    }
}
