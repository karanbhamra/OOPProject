using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "You must specify password between 5 and 20 characters")]
        public string Password { get; set; }
    }
}
