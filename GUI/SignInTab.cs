using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
namespace GUI
{
    public partial class SignInTab : UserControl
    {
        SignInBAL bal_si;

        public string Username { get => txt_username.Text; set => txt_username.Text = value; }
        public string Password { get => txt_password.Text; set => txt_password.Text = value; }

        public int accID;
        public SignInTab()
        {
            InitializeComponent();
            bal_si = new SignInBAL();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            int signInState = bal_si.Login_GetAccountIDFromLoginInput(Username, Password);
            switch (signInState)
            {
                case -1:
                    MessageBox.Show("Username hoặc mật khẩu sai!");
                    break;
                case -2:
                    MessageBox.Show("Username không được dể trống!");
                    break;
                case -3:
                    MessageBox.Show("Password không được để trống!");
                    break;
                case -4:
                    MessageBox.Show("Không thể dùng kí tự đặc biệt hoặc khoảng trắng!");
                    break;
                default:
                    MessageBox.Show("Đăng nhập thành công!");
                    accID = signInState;
                    OnLogInSuccess();
                    break;
            }

        }



        public event EventHandler LogInSuccess;

        protected virtual void OnLogInSuccess() => LogInSuccess?.Invoke(this, EventArgs.Empty);
    }
}
