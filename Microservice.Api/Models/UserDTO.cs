using Microservice.API.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microservice.Api.Models
{
    public class UserDTO
    {
        [Required]
        public int Id { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Username { get; set; }

        [Required]
        public string Token { get; set; }
        
        [Required]
        public ICollection<PostDTO> Posts { get; set; }
    }
}
