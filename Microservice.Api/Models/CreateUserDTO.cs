using System.ComponentModel.DataAnnotations;

namespace Microservice.Api.Models
{
    public class CreateUserDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Passw { get; set; }
    }
}
