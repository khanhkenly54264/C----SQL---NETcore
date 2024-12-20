namespace xuong_moc.Models
{
    public class Customer
    {
        public int Id { get; set; } // Khóa chính
        public string Name { get; set; } // Tên khách hàng
        public string Username { get; set; } // Tên đăng nhập
        public string Password { get; set; } // Mật khẩu
        public string Address { get; set; } // Địa chỉ
        public string Email { get; set; } // Email
        public string Phone { get; set; } // Số điện thoại
        public string Avatar { get; set; } // Ảnh đại diện
        public DateTime CreatedDate { get; set; } // Ngày tạo
        public string CreatedBy { get; set; } // Người tạo
        public bool IsActive { get; set; } // Trạng thái hoạt động
    }
}
