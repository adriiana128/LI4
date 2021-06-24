using Microservice.API.Entitites;

namespace Microservice.Api.Entities
{
    public class Commentary : BaseEntity
    {
        public string Comment { get; set; }
        public int Score { get; set; }
        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
