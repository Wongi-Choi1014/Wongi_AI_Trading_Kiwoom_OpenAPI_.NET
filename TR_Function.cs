using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wongi_AI_Trading
{
    //주문 필요 Parameter
    class Order_Input
    {
        public string Account { get; set; }

    }

    //TR 요청 함수 Class
    class TR_Function
    {
        private int _scrNum = 5000;
        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI_Tr;
        private Log_Interface e_Log;

        public TR_Function(ref Log_Interface form)
        {
            e_Log = form;
        }
        public string GetScrNum()
        {
            if (_scrNum < 9999)
                _scrNum++;
            else
                _scrNum = 5000;

            return _scrNum.ToString();
        }
        /*
        private void Order(Order_Input input, AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI_Tr)
        {
            // =================================================
            // 계좌번호 입력 여부 확인
            if (input.Account.Length != 10)
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
        }*/
    }
}
