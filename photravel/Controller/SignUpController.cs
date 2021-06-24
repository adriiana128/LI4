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
    public class SignUpController : ControllerBase
    {
        // POST: SignUp
        [HttpPost]
        public Models.UserModel Post([FromBody] Models.UserModel b)
        {
            DBConnect con = new DBConnect();
            con.InsertUser(b.username, b.password, b.isAdmin, b.name, b.score, b.bio, b.email, b.telemovel);
            return b;
        }
    }
}
