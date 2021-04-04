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
    public partial class CreateUserForm : Form
    {
        public string Username { get => txt_username.Text; set => txt_username.Text = value; }
        public string Password { get => txt_password.Text; set => txt_password.Text = value; }
        public string PassConfirm { get => txt_passconfirm.Text; set => txt_passconfirm.Text = value; }

        SignUpBAL bal_su;
        public CreateUserForm()
        {
            InitializeComponent();
            bal_su = new SignUpBAL();
        }

        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            int signUpState = bal_su.SignUp_CreateAccountFromUserInput(Username, Password, PassConfirm);
            switch (signUpState)
            {
                case -2:
                    MessageBox.Show("Username không được để trống!");
                    break;
                case -3:
                    MessageBox.Show("Mật khẩu không được để trống!");
                    break;
                case -4:
                    MessageBox.Show("Nhập lại xác nhận mật khẩu!");
                    break;
                case -5:
                    MessageBox.Show("Username không thể chứa kí tự đặc biệt hoặc khoảng trắng!");
                    break;
                case -6:
                    MessageBox.Show("Username đã tồn tại!");
                    break;
                case 1:
                    MessageBox.Show("Tạo tài khoản thành công!");
                    break;
                default:
                    MessageBox.Show("Tạo tài khoản thất bại!");
                    break;
            }

            if (signUpState == 1)
            {
                this.Close();
            }
        }
    }
}
