using System.ComponentModel.DataAnnotations;

namespace Microservice.Api.Models
{
    public class CreateCommentaryDTO
    {
        public int Score { get; set; } = 0;

        [Required]
        [MaxLength(512)]
        public string Comment { get; set; }

        [Required]
        public int PostId { get; set; }
    }
}
