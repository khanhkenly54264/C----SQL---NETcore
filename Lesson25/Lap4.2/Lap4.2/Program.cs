using System;

public abstract class NhanVien
{
    public string Ten { get; set; }
    public string DiaChi { get; set; }

    // Constructor
    public NhanVien(string ten, string diaChi)
    {
        Ten = ten;                                                                                                                           
        DiaChi = diaChi;
    }

    // Phương thức abstract để tính lương
    public abstract double TinhLuong();

    // Phương thức abstract để hiển thị thông tin
    public abstract void HienThi();
};

public class NhanVienBanHang : NhanVien
{
    public int SoLuongBanDuoc { get; set; }

    // Constructor
    public NhanVienBanHang(string ten, string diaChi, int soLuongBanDuoc)
        : base(ten, diaChi)
    {
        SoLuongBanDuoc = soLuongBanDuoc;
    }

    // Phương thức tính lương dựa trên số lượng bán được
    public override double TinhLuong()
    {
        return SoLuongBanDuoc * 25000;
    }

    // Phương thức hiển thị thông tin
    public override void HienThi()
    {
        Console.WriteLine("Nhân viên bán hàng: " + Ten);
        Console.WriteLine("Địa chỉ: " + DiaChi);
        Console.WriteLine("Số lượng bán được: " + SoLuongBanDuoc);
        Console.WriteLine("Lương: " + TinhLuong() + " VND");
    }
};

public class CongNhan : NhanVien
{
    public int SoLuongSanPham { get; set; }

    // Constructor
    public CongNhan(string ten, string diaChi, int soLuongSanPham)
        : base(ten, diaChi)
    {
        SoLuongSanPham = soLuongSanPham;
    }

    // Phương thức tính lương dựa trên số lượng sản phẩm
    public override double TinhLuong()
    {
        return SoLuongSanPham * 30000; // Ví dụ: 30.000 VND cho mỗi sản phẩm
    }

    // Phương thức hiển thị thông tin
    public override void HienThi()
    {
        Console.WriteLine("Công nhân: " + Ten);
        Console.WriteLine("Địa chỉ: " + DiaChi);
        Console.WriteLine("Số lượng sản phẩm: " + SoLuongSanPham);
        Console.WriteLine("Lương: " + TinhLuong() + " VND");
    }
};

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Tạo đối tượng NhanVienBanHang
        NhanVienBanHang nvBanHang = new NhanVienBanHang("Nguyen Van A", "123 Đường ABC", 100);
        nvBanHang.HienThi();

        Console.WriteLine();

        // Tạo đối tượng CongNhan
        CongNhan congNhan = new CongNhan("Tran Van B", "456 Đường XYZ", 150);
        congNhan.HienThi();
    }
}



