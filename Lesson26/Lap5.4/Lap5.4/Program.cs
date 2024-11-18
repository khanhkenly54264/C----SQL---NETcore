

/// <summary>
/// Tạo lớp Employee: Bao gồm các trường id, name, age và các thuộc tính, phương thức hiển thị, constructor cho lớp Employee.
/// Tạo lớp Department: Bao gồm trường name và một mảng Employee.
/// Tạo các indexer: Để truy cập và thao tác với từng Employee trong Department.
/// Kiểm tra chương trình: Trong hàm Main.
/// </summary>

public class NhanVien
{
    public int MaSo { get; set; }
    public string Ten { get; set; }
    public int Tuoi { get; set; }

    public NhanVien(int maSo, string ten, int tuoi)
    {
        MaSo = maSo;
        Ten = ten;
        Tuoi = tuoi;
    }

    public override string ToString()
    {
        return $"Mã Số: {MaSo}, Tên: {Ten}, Tuổi: {Tuoi}";
    }
}

public class PhongBan
{
    public string Ten { get; set; }
    private NhanVien[] nhanViens;

    public PhongBan(string ten, int soLuong)
    {
        Ten = ten;
        nhanViens = new NhanVien[soLuong];
    }

    public NhanVien this[int chiSo]
    {
        get { return nhanViens[chiSo]; }
        set { nhanViens[chiSo] = value; }
    }
}

class ChuongTrinh
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        PhongBan phongBan = new PhongBan("CNTT", 3);
        phongBan[0] = new NhanVien(1, "Văn An", 30);
        phongBan[1] = new NhanVien(2, "Quốc Khánh", 25);
        phongBan[2] = new NhanVien(3, "Trịnh Trần Phương Tứn", 28);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(phongBan[i]);
        }
    }
}
