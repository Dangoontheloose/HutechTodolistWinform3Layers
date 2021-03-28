using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BAL
{
    public class SignInBAL
    {
        MainDAL dal = new MainDAL();

        /// <summary>
        /// Trả về Account ID nếu đúng tên người dùng và password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>Trả về Account ID nếu đúng, ngược lại trả về kiểu lỗi</returns>
        public int Login_GetAccountIDFromLoginInput(string username, string password)
        {
            if (username == "") { return -2; } //lỗi username trống
            if (password == "") { return -3; } //lỗi password trống
            foreach (char c in username)
            {
                if (!(Char.IsLetter(c) || Char.IsNumber(c))) { return -4; } //lỗi chứa ký tự đặc biệt hoặc khoảng trắng
            }

            int id = dal.GetAccountIDFromLoginInput(username, password); //đăng nhập thành công 

            return id;//trả về Acc ID đẵ đăng nhập thành công
        }
    }
}
