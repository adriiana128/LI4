using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace photravel.Models
{
    public class CommentModel
    {
        public int id { get; set; }
        public string texto { get; set; }
        public int score { get; set; }
        public int foto { get; set; }
    }
}
