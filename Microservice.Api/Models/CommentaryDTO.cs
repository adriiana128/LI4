using System.ComponentModel.DataAnnotations;

namespace Microservice.API.Models
{
    public class CommentaryDTO
    {
        [Required]
        public int Id { get; set; }

        public int Score { get; set; }

        [Required]
        [MaxLength(512)]
        public string Comment { get; set; }
    }
}