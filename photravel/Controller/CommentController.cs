using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace photravel.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {       
        // POST: Comment
        [HttpPost]
        public Models.CommentModel Post([FromBody] Models.CommentModel a)
        {
            DBConnect con = new DBConnect();
            con.InsertComentario(a.id, a.texto, a.score, a.foto);
            return a;

        }

        // DELETE: Comment
        [HttpDelete]
        public void Delete([FromBody] Models.CommentModel a)
        {
            DBConnect con = new DBConnect();
            con.DeleteComentario(a.id);

        }
    }
}
