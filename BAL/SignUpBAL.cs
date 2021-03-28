using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BAL
{
    public class SignUpBAL
    {
        MainDAL dal = new MainDAL();

        /// <summary>
        /// Kiểm tra tính hợp lệ từ người dùng trước khi tạo tk 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="passconfirm"></param>
        /// <returns>Trả về mã lỗi(int) hoặc trạng thái tạo tk thành công cho View xử lý</returns>
        public int SignUp_CreateAccountFromUserInput(string username, string password, string passconfirm)
        {
            if (username == "") { return -2; } //lỗi username trống
            if (password == "") { return -3; } //lỗi password trống
            if (passconfirm == "" || passconfirm != password) { return -4; } //lỗi xác nhận mật khẩu thiếu hoặc không trùng với mật khẩu
            foreach (char c in username)
            {
                if (!(Char.IsLetter(c) || Char.IsNumber(c))) { return -5; } //Lỗi chứa ký tự đặc biệt hoặc khoảng trắng
            }
            if (!dal.AccountUsernameAvailable(username)) { return -6; } //Lỗi username không khả dụng
            

            if (dal.CreateAcc(username, password)) { return 1; } //Trạng thái tạo tài khoản thành công

            return -1;

        }
    }
}
