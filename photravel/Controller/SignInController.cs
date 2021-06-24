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
    public class SignInController : ControllerBase
    {
        // Post: SignIn
        [HttpPost]
        public Models.UserModel Post([FromBody] Models.UserModel a)
        {
            DBConnect con = new DBConnect();
            List<string>[] aux = con.Select_User(a.email);
               if (a.password == aux[1].ToArray()[0])
               {
                a.username = aux[0].ToArray()[0];
                a.isAdmin = Int32.Parse(aux[2].ToArray()[0]);
                a.score = Int32.Parse(aux[4].ToArray()[0]);
                a.bio = aux[5].ToArray()[0];
                return a;
               }
               else return null;
        }
    }
}