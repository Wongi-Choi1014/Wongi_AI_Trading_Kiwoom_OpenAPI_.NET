using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wongi_AI_Trading
{
    public partial class Form2 : Form
    {
        public static PasswordEventHandler PasswordEvent;//비밀번호 전달 함수 선언

        public Form2(String Account)
        {
            InitializeComponent();
            I_Account.Text = Account;
        }
        //form 닫을 때 비밀번호 전달
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PasswordEvent(I_Account.Text, I_Password.Text);
        }
    }
}
