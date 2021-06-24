using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace photravel.Controller
{
    [Route("[controller]/{id}")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
      
        // GET: api/Photos/5
        [HttpGet]
/*        public Models.PhotoModel Get(int id)
        {
            //colocar com o array dos comentarios.
            DBConnect con = new DBConnect();
            return a;
        }
*/

        //get fotos consoante o user


        // POST: api/Photo
        [HttpPost]
        public Models.PhotoModel Post([FromBody] Models.PhotoModel b)
        {
            DBConnect con = new DBConnect();
            con.InsertFoto(b.id, b.score, b.username, b.local, b.data, b.descricao);
            return b;
        }

        // PUT: api/Photo
        [HttpPut]
        public Models.PhotoModel Put([FromBody] Models.PhotoModel b)
        {
            DBConnect con = new DBConnect();
            con.UpdateFoto(b.id, b.score, b.username, b.local, b.data, b.descricao);
            return b;
        }

        // DELETE: api/Photo
        [HttpDelete]
        public void Delete([FromBody] Models.PhotoModel a)
        {
            DBConnect con = new DBConnect();
            con.DeleteFoto(a.id);
        }
    }
}
