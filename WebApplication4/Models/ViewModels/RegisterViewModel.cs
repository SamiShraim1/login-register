using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(40)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(40)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(40)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public string Phone { get; set; }
    }
}
