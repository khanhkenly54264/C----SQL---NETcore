using System;
using System.Linq;

/// <summary>
/// Khởi tạo một mảng 1 chiều số nguyên gồm 10 phần tử.
/// Tìm phần tử nhỏ nhất của mảng.
///  Đảo ngược mảng.
///  Sắp xếp mảng tăng hoặc giảm.
///  Tìm phần tử là số nguyên tố.
///  In ra số lượng các số dương liên tiếp nhiều nhất
///  Tính trung bình cộng các phần tử dương.
///   Kiểm tra xem mảng có phải chứa các phần tử âm dương, đan xen nhau không.
/// </summary>
class ChuongTrinh
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        // 1. Khởi tạo một mảng 1 chiều gồm 10 phần tử
        int[] mang = { 7, -3, 2, 10, -1, 4, 0, 5, -6, 8 };

        // 2. Tìm phần tử nhỏ nhất của mảng
        int nhoNhat = mang.Min();
        Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + nhoNhat);

        // 3. Đảo ngược mảng
        Array.Reverse(mang);
        Console.WriteLine("Mảng sau khi đảo ngược: " + string.Join(", ", mang));

        // 4. Sắp xếp mảng tăng dần
        Array.Sort(mang);
        Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", mang));

        // Sắp xếp giảm dần
        Array.Sort(mang, (a, b) => b.CompareTo(a));
        Console.WriteLine("Mảng sau khi sắp xếp giảm dần: " + string.Join(", ", mang));

        // 5. Tìm các phần tử là số nguyên tố
        Console.WriteLine("Các số nguyên tố trong mảng: ");
        foreach (int so in mang)
        {
            if (LaSoNguyenTo(so))
                Console.Write(so + " ");
        }
        Console.WriteLine();

        // 6. In ra số lượng các số dương liên tiếp nhiều nhất
        int maxLienTiep = DemSoDuongLienTiep(mang);
        Console.WriteLine("Số lượng số dương liên tiếp nhiều nhất: " + maxLienTiep);

        // 7. Tính trung bình cộng các phần tử dương
        double trungBinhCong = mang.Where(x => x > 0).Average();
        Console.WriteLine("Trung bình cộng các phần tử dương: " + trungBinhCong);

        // 8. Kiểm tra xem mảng có chứa các phần tử âm dương đan xen nhau không
        bool danXen = KiemTraDanXen(mang);
        Console.WriteLine("Mảng có chứa phần tử âm dương đan xen: " + (danXen ? "Có" : "Không"));
    }

    // Hàm kiểm tra số nguyên tố
    static bool LaSoNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Hàm đếm số dương liên tiếp nhiều nhất
    static int DemSoDuongLienTiep(int[] mang)
    {
        int max = 0, dem = 0;
        foreach (int so in mang)
        {
            if (so > 0)
                dem++;
            else
            {
                max = Math.Max(max, dem);
                dem = 0;
            }
        }
        return Math.Max(max, dem);
    }

    // Hàm kiểm tra mảng có đan xen âm dương không
    static bool KiemTraDanXen(int[] mang)
    {
        for (int i = 1; i < mang.Length; i++)
        {
            if ((mang[i - 1] > 0 && mang[i] > 0) || (mang[i - 1] < 0 && mang[i] < 0))
                return false;
        }
        return true;
    }
}
