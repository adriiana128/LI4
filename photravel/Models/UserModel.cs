using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photravel.Models
{
    public class UserModel
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int isAdmin { get; set; }
        public string name { get; set; }
        public int score { get; set; }
        public string bio { get; set; }
        public string telemovel { get; set; }
    }
}
