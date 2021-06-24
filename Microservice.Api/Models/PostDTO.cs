using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microservice.API.Models
{
    public class PostDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public int Score { get; set; } = 0;

        [Required]
        [MaxLength(512)]
        public string Details { get; set; }

        [MaxLength(512)]
        public string PhotoUrl { get; set; }        
    }
}
