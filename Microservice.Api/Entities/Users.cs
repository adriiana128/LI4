using Microservice.API.Entitites;
using System.Collections.Generic;

namespace Microservice.Api.Entities
{
    public class Users : BaseEntity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Passw { get; set; }
        public string Token { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
