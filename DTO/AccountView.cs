using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountView
    {
        public int AccID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Type { get; set; }
    }
}
