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
    public class EditUserController : ControllerBase
    {
        // PUT: EditUser
        [HttpPut]
        public Models.UserModel Put([FromBody] Models.UserModel b)
        {
            DBConnect con = new DBConnect();
            con.UpdateUser(b.username, b.password, b.isAdmin, b.name, b.score, b.bio, b.email, b.telemovel);
            return b;
        }

        // DELETE: EditUser
        [HttpDelete]
        public void Delete([FromBody]Models.UserModel a)
        {
            DBConnect con = new DBConnect();
            con.DeleteUser(a.username);
        }
    }
}
