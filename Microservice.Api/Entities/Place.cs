using Microservice.API.Entitites;
using System.Collections.Generic;

namespace Microservice.Api.Entities
{
    public class Place : BaseEntity
    {
        public string Addresses { get; set; }
        public int Score { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
