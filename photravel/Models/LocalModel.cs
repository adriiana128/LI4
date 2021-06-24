using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photravel.Models
{
    public class LocalModel
    {
        public int id { get; set; }
        public int score { get; set; }
        public string username { get; set; }
        public string local { get; set; }
        public string patth { get; set; }
        public string descricao { get; set; }

        public string locals { get; set; }
    }
}
