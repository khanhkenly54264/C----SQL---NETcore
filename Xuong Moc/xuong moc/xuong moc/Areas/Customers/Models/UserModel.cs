using System.ComponentModel.DataAnnotations;

namespace xuong_moc.Areas.Customers.Models
{
    public class UserModel
    {
        // Dùng cho đăng ký
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        // Dùng cho đăng nhập
        [Required]
        [Display(Name = "Username")]
        public string LoginUsername { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }
    }
}

