using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photravel.Models
{
    public class PhotoModel
    {
        public int id { get; set; }
        public int score { get; set; }
        public string username { get; set; }
        public int local { get; set; }
        public string data { get; set; }
        public string descricao { get; set; }
    }
}
