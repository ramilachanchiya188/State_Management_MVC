using System.ComponentModel.DataAnnotations;

namespace MovieStoreMvc.Models.DTO
{
    public class RegistrationModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }
        [Required]
        [RegularExpression("^(?=.*[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*[#$^+=!*()])")]

        public string Password { get; set; }
        [Required]
        public string PasswordConfirm { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
