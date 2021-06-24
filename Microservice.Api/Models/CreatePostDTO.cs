using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Microservice.Api.Models
{
    public class CreatePostDTO
    {
        [Required]
        public int Score { get; set; } = 0;

        [Required]
        [MaxLength(512)]
        public string Details { get; set; }

        [MaxLength(512)]
        public string PhotoUrl { get; set; }

        [Required]
        public int PlaceId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
