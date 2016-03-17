using System.ComponentModel.DataAnnotations;

namespace UserApp.Models
{
    public class User
    {
        [Required]
        [MaxLength(256)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [MaxLength(256)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}