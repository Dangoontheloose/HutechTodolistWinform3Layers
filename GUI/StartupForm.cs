using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class StartupForm : Form
    {

        SignInTab siTab;
        //SignUpTab suTab;
        public StartupForm()
        {
            InitializeComponent();
            siTab = new SignInTab();
            //suTab = new SignUpTab();

            siTab.LogInSuccess += SiTab_LogInSuccess;
        }

        //hàm switch giữa 2 tab
        private void SwitchTab(UserControl tab)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(tab);
        }


        //Hàm gọi khi đăng nhập thành công
        private void SiTab_LogInSuccess(object sender, EventArgs e)
        {

            SignInTab s = sender as SignInTab;
            //Khởi tạo hàm main với acc ID của tài khoản đã đăng nhập từ tab sign in
            if (s.accType == 1)
            {
                MainAdmin main = new MainAdmin(s.accID);
                main.FormClosed += Main_FormClosed;
                main.Show();
                this.Hide();

            }
            else
            {

                Main main = new Main(s.accID);
                main.FormClosed += Main_FormClosed;
                main.Show();
                this.Hide();
                //Ẩn form đăng nhập
            }

        }

        //Hàm gọi mỗi khi form main đóng
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hiển thị lại form đăng nhập
            this.Show();
            //reset các trường
            siTab.Password = "";
        }


        //private void btn_SignUpTab_Click(object sender, EventArgs e)
        //{
        //    SwitchTab(suTab);
        //}

        private void StartupForm_Load(object sender, EventArgs e)
        {
            SwitchTab(siTab);
        }
    }
}
