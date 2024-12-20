using System.ComponentModel.DataAnnotations;

namespace xuong_moc.Areas.CustomerA.Models
{
    public class CustomerLogin
    {
        [Required(ErrorMessage = "Địa chỉ Email không được để trống")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

