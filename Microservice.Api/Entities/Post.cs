using Microservice.API.Entitites;
using System.Collections.Generic;

namespace Microservice.Api.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Commentaries = new HashSet<Commentary>();
        }

        public int Score { get; set; }
        public string Details { get; set; }
        public string PhotoUrl { get; set; }
        public int PlaceId { get; set; }
        public int UserId { get; set; }

        public Place Place { get; set; }
        public Users Users { get; set; }

        public ICollection<Commentary> Commentaries { get; set; }
    }
}
