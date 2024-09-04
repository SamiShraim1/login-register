using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [MaxLength(40)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(40)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
