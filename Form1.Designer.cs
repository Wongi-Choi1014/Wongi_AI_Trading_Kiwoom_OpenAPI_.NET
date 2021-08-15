
namespace Wongi_AI_Trading
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Log = new System.Windows.Forms.ListBox();
            this.Password_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.이름 = new System.Windows.Forms.Label();
            this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.종목명 = new System.Windows.Forms.TextBox();
            this.종목코드 = new System.Windows.Forms.TextBox();
            this.조회기간 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn주문 = new System.Windows.Forms.Button();
            this.cbo매매구분 = new System.Windows.Forms.ComboBox();
            this.cbo거래구분 = new System.Windows.Forms.ComboBox();
            this.txt원주문번호 = new System.Windows.Forms.TextBox();
            this.txt주문가격 = new System.Windows.Forms.TextBox();
            this.txt주문수량 = new System.Windows.Forms.TextBox();
            this.txt주문종목코드 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.group실시간등록해제 = new System.Windows.Forms.GroupBox();
            this.btn실시간해제 = new System.Windows.Forms.Button();
            this.btn실시간등록 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt실시간종목코드 = new System.Windows.Forms.TextBox();
            this.차트_조회 = new System.Windows.Forms.Button();
            this.현재가_조회 = new System.Windows.Forms.Button();
            this.기간조회 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Deposit = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Start_Algorithm = new System.Windows.Forms.Button();
            this.Select_Algorithm = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Password_status = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cbo계좌 = new System.Windows.Forms.ComboBox();
            this.test2 = new System.Windows.Forms.Button();
            this.test3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.group실시간등록해제.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 17;
            this.Log.Location = new System.Drawing.Point(679, 316);
            this.Log.Name = "Log";
            this.Log.ScrollAlwaysVisible = true;
            this.Log.Size = new System.Drawing.Size(346, 242);
            this.Log.TabIndex = 2;
            // 
            // Password_btn
            // 
            this.Password_btn.Location = new System.Drawing.Point(27, 42);
            this.Password_btn.Name = "Password_btn";
            this.Password_btn.Size = new System.Drawing.Size(120, 27);
            this.Password_btn.TabIndex = 5;
            this.Password_btn.Text = "계좌/비밀번호 입력";
            this.Password_btn.UseVisualStyleBackColor = true;
            this.Password_btn.Click += new System.EventHandler(this.Password_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "이름 :";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID.Location = new System.Drawing.Point(85, 94);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(0, 17);
            this.ID.TabIndex = 8;
            // 
            // 이름
            // 
            this.이름.AutoSize = true;
            this.이름.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.이름.Location = new System.Drawing.Point(85, 125);
            this.이름.Name = "이름";
            this.이름.Size = new System.Drawing.Size(0, 17);
            this.이름.TabIndex = 9;
            // 
            // axKHOpenAPI
            // 
            this.axKHOpenAPI.Enabled = true;
            this.axKHOpenAPI.Location = new System.Drawing.Point(0, 544);
            this.axKHOpenAPI.Name = "axKHOpenAPI";
            this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
            this.axKHOpenAPI.Size = new System.Drawing.Size(125, 25);
            this.axKHOpenAPI.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(25, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "종목명 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(25, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "종목코드 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(25, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "조회기간 :";
            // 
            // 종목명
            // 
            this.종목명.Location = new System.Drawing.Point(92, 216);
            this.종목명.Name = "종목명";
            this.종목명.Size = new System.Drawing.Size(100, 25);
            this.종목명.TabIndex = 13;
            // 
            // 종목코드
            // 
            this.종목코드.Location = new System.Drawing.Point(92, 185);
            this.종목코드.Name = "종목코드";
            this.종목코드.Size = new System.Drawing.Size(100, 25);
            this.종목코드.TabIndex = 14;
            // 
            // 조회기간
            // 
            this.조회기간.CalendarFont = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.조회기간.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.조회기간.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.조회기간.Location = new System.Drawing.Point(92, 246);
            this.조회기간.Name = "조회기간";
            this.조회기간.Size = new System.Drawing.Size(100, 25);
            this.조회기간.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn주문);
            this.groupBox1.Controls.Add(this.cbo매매구분);
            this.groupBox1.Controls.Add(this.cbo거래구분);
            this.groupBox1.Controls.Add(this.txt원주문번호);
            this.groupBox1.Controls.Add(this.txt주문가격);
            this.groupBox1.Controls.Add(this.txt주문수량);
            this.groupBox1.Controls.Add(this.txt주문종목코드);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(22, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 246);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "주문입력";
            // 
            // btn주문
            // 
            this.btn주문.Location = new System.Drawing.Point(27, 197);
            this.btn주문.Name = "btn주문";
            this.btn주문.Size = new System.Drawing.Size(198, 30);
            this.btn주문.TabIndex = 12;
            this.btn주문.Text = "주     문";
            this.btn주문.UseVisualStyleBackColor = true;
            this.btn주문.Click += new System.EventHandler(this.btn주문_Click);
            // 
            // cbo매매구분
            // 
            this.cbo매매구분.FormattingEnabled = true;
            this.cbo매매구분.Location = new System.Drawing.Point(84, 78);
            this.cbo매매구분.Name = "cbo매매구분";
            this.cbo매매구분.Size = new System.Drawing.Size(141, 25);
            this.cbo매매구분.TabIndex = 11;
            // 
            // cbo거래구분
            // 
            this.cbo거래구분.FormattingEnabled = true;
            this.cbo거래구분.Location = new System.Drawing.Point(84, 47);
            this.cbo거래구분.Name = "cbo거래구분";
            this.cbo거래구분.Size = new System.Drawing.Size(141, 25);
            this.cbo거래구분.TabIndex = 10;
            // 
            // txt원주문번호
            // 
            this.txt원주문번호.Location = new System.Drawing.Point(84, 159);
            this.txt원주문번호.Name = "txt원주문번호";
            this.txt원주문번호.Size = new System.Drawing.Size(141, 25);
            this.txt원주문번호.TabIndex = 9;
            // 
            // txt주문가격
            // 
            this.txt주문가격.Location = new System.Drawing.Point(84, 134);
            this.txt주문가격.Name = "txt주문가격";
            this.txt주문가격.Size = new System.Drawing.Size(141, 25);
            this.txt주문가격.TabIndex = 8;
            // 
            // txt주문수량
            // 
            this.txt주문수량.Location = new System.Drawing.Point(84, 107);
            this.txt주문수량.Name = "txt주문수량";
            this.txt주문수량.Size = new System.Drawing.Size(141, 25);
            this.txt주문수량.TabIndex = 7;
            this.txt주문수량.Text = "10";
            // 
            // txt주문종목코드
            // 
            this.txt주문종목코드.Location = new System.Drawing.Point(84, 20);
            this.txt주문종목코드.Name = "txt주문종목코드";
            this.txt주문종목코드.Size = new System.Drawing.Size(141, 25);
            this.txt주문종목코드.TabIndex = 6;
            this.txt주문종목코드.Text = "039490";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "원주문번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "주문가격";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "주문수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "매매구분";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "거래구분";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "종목코드";
            // 
            // group실시간등록해제
            // 
            this.group실시간등록해제.Controls.Add(this.btn실시간해제);
            this.group실시간등록해제.Controls.Add(this.btn실시간등록);
            this.group실시간등록해제.Controls.Add(this.label13);
            this.group실시간등록해제.Controls.Add(this.txt실시간종목코드);
            this.group실시간등록해제.Location = new System.Drawing.Point(283, 42);
            this.group실시간등록해제.Name = "group실시간등록해제";
            this.group실시간등록해제.Size = new System.Drawing.Size(212, 100);
            this.group실시간등록해제.TabIndex = 26;
            this.group실시간등록해제.TabStop = false;
            this.group실시간등록해제.Text = "실시간 등록 해제";
            // 
            // btn실시간해제
            // 
            this.btn실시간해제.Location = new System.Drawing.Point(131, 70);
            this.btn실시간해제.Name = "btn실시간해제";
            this.btn실시간해제.Size = new System.Drawing.Size(75, 23);
            this.btn실시간해제.TabIndex = 29;
            this.btn실시간해제.Text = "실시간해제";
            this.btn실시간해제.UseVisualStyleBackColor = true;
            // 
            // btn실시간등록
            // 
            this.btn실시간등록.Location = new System.Drawing.Point(8, 70);
            this.btn실시간등록.Name = "btn실시간등록";
            this.btn실시간등록.Size = new System.Drawing.Size(75, 23);
            this.btn실시간등록.TabIndex = 28;
            this.btn실시간등록.Text = "실시간등록";
            this.btn실시간등록.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "종목코드 : ";
            // 
            // txt실시간종목코드
            // 
            this.txt실시간종목코드.Location = new System.Drawing.Point(8, 44);
            this.txt실시간종목코드.Name = "txt실시간종목코드";
            this.txt실시간종목코드.Size = new System.Drawing.Size(198, 25);
            this.txt실시간종목코드.TabIndex = 0;
            // 
            // 차트_조회
            // 
            this.차트_조회.Location = new System.Drawing.Point(7, 20);
            this.차트_조회.Name = "차트_조회";
            this.차트_조회.Size = new System.Drawing.Size(198, 27);
            this.차트_조회.TabIndex = 27;
            this.차트_조회.Text = "차트 Plot";
            this.차트_조회.UseVisualStyleBackColor = true;
            // 
            // 현재가_조회
            // 
            this.현재가_조회.Location = new System.Drawing.Point(8, 53);
            this.현재가_조회.Name = "현재가_조회";
            this.현재가_조회.Size = new System.Drawing.Size(197, 27);
            this.현재가_조회.TabIndex = 28;
            this.현재가_조회.Text = "현재가";
            this.현재가_조회.UseVisualStyleBackColor = true;
            this.현재가_조회.Click += new System.EventHandler(this.현재가_조회_Click);
            // 
            // 기간조회
            // 
            this.기간조회.Location = new System.Drawing.Point(8, 86);
            this.기간조회.Name = "기간조회";
            this.기간조회.Size = new System.Drawing.Size(197, 27);
            this.기간조회.TabIndex = 29;
            this.기간조회.Text = "기간 가격";
            this.기간조회.UseVisualStyleBackColor = true;
            this.기간조회.Click += new System.EventHandler(this.기간조회_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.차트_조회);
            this.groupBox2.Controls.Add(this.현재가_조회);
            this.groupBox2.Controls.Add(this.기간조회);
            this.groupBox2.Location = new System.Drawing.Point(283, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 123);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "조회";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Deposit);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Start_Algorithm);
            this.groupBox3.Controls.Add(this.Select_Algorithm);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(283, 277);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 113);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "알고리즘 매매";
            // 
            // Deposit
            // 
            this.Deposit.FormattingEnabled = true;
            this.Deposit.Items.AddRange(new object[] {
            "100%",
            "90%",
            "80%",
            "70%",
            "60%",
            "50%",
            "40%",
            "30%",
            "20%",
            "10%"});
            this.Deposit.Location = new System.Drawing.Point(65, 44);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(141, 25);
            this.Deposit.TabIndex = 19;
            this.Deposit.Text = "100%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(6, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "예수금:";
            // 
            // Start_Algorithm
            // 
            this.Start_Algorithm.Location = new System.Drawing.Point(8, 75);
            this.Start_Algorithm.Name = "Start_Algorithm";
            this.Start_Algorithm.Size = new System.Drawing.Size(197, 30);
            this.Start_Algorithm.TabIndex = 17;
            this.Start_Algorithm.Text = "알고리즘 매매 Start";
            this.Start_Algorithm.UseVisualStyleBackColor = true;
            this.Start_Algorithm.Click += new System.EventHandler(this.Start_Algorithm_Click);
            // 
            // Select_Algorithm
            // 
            this.Select_Algorithm.FormattingEnabled = true;
            this.Select_Algorithm.Location = new System.Drawing.Point(65, 16);
            this.Select_Algorithm.Name = "Select_Algorithm";
            this.Select_Algorithm.Size = new System.Drawing.Size(141, 25);
            this.Select_Algorithm.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(6, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "알고리즘 :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chart1);
            this.groupBox4.Location = new System.Drawing.Point(679, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(346, 268);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "차트";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.DockedToChartArea = "ChartArea1";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 17);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(335, 245);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Password_status
            // 
            this.Password_status.BackColor = System.Drawing.Color.Red;
            this.Password_status.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Password_status.Location = new System.Drawing.Point(147, 42);
            this.Password_status.Name = "Password_status";
            this.Password_status.Size = new System.Drawing.Size(41, 27);
            this.Password_status.TabIndex = 33;
            this.Password_status.Text = "OFF";
            this.Password_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(290, 393);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(205, 23);
            this.test.TabIndex = 34;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(25, 156);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "계좌번호 : ";
            // 
            // cbo계좌
            // 
            this.cbo계좌.FormattingEnabled = true;
            this.cbo계좌.Location = new System.Drawing.Point(92, 153);
            this.cbo계좌.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo계좌.Name = "cbo계좌";
            this.cbo계좌.Size = new System.Drawing.Size(138, 25);
            this.cbo계좌.TabIndex = 38;
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(290, 421);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(205, 23);
            this.test2.TabIndex = 39;
            this.test2.Text = "test2";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(290, 450);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(205, 23);
            this.test3.TabIndex = 40;
            this.test3.Text = "test3";
            this.test3.UseVisualStyleBackColor = true;
            this.test3.Click += new System.EventHandler(this.test3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 560);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.cbo계좌);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.test);
            this.Controls.Add(this.Password_status);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.group실시간등록해제);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.조회기간);
            this.Controls.Add(this.종목코드);
            this.Controls.Add(this.종목명);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.이름);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password_btn);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.axKHOpenAPI);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Wongi AI Trading";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.group실시간등록해제.ResumeLayout(false);
            this.group실시간등록해제.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Button Password_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label 이름;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox 종목명;
        private System.Windows.Forms.TextBox 종목코드;
        private System.Windows.Forms.DateTimePicker 조회기간;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn주문;
        private System.Windows.Forms.ComboBox cbo매매구분;
        private System.Windows.Forms.ComboBox cbo거래구분;
        private System.Windows.Forms.TextBox txt원주문번호;
        private System.Windows.Forms.TextBox txt주문가격;
        private System.Windows.Forms.TextBox txt주문수량;
        private System.Windows.Forms.TextBox txt주문종목코드;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox group실시간등록해제;
        private System.Windows.Forms.Button btn실시간해제;
        private System.Windows.Forms.Button btn실시간등록;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt실시간종목코드;
        private System.Windows.Forms.Button 차트_조회;
        private System.Windows.Forms.Button 현재가_조회;
        private System.Windows.Forms.Button 기간조회;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Start_Algorithm;
        private System.Windows.Forms.ComboBox Select_Algorithm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label Password_status;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox Deposit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbo계좌;
        private System.Windows.Forms.Button test2;
        private System.Windows.Forms.Button test3;
    }
}

