using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wongi_AI_Trading
{
    class User_Info
    {
        public static User_Info user = new User_Info();

        public string Account { get; set; }
        public string Account_Type { get; set; }
        public string Password { get; set; }
    }
}
