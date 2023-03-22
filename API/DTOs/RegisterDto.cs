using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{ 
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required] 
        public DateOnly? DateOfBirth { get; set;} // optional to make requirde work
        
        [Required]
        // [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}