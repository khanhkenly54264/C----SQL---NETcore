using System;
using System.Linq;

/// <summary>
/// Khai báo và khởi tạo một mảng 2 chiều với 4 dòng và 4 cột.
///  In mảng theo hàng và cột.
///  Tính tổng các phần tử mà có chỉ số hàng = chỉ số cột.
///  In ra các phần tử nhỏ nhất trên cột.
///  Liệt kê các phần tử chia hết cho 7.
///  Tìm tổng các phần tử nằm trên đường viền của mảng.
///   Chuyển thành mảng 1 chiều rồi sắp xếp tăng dần.
/// </summary>
class ChuongTrinh
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        // 1. Khai báo và khởi tạo mảng 2 chiều với 4 dòng và 4 cột
        int[,] mang2Chieu = {
            { 5, 8, 3, 12 },
            { 14, 6, 9, 1 },
            { 2, 7, 15, 4 },
            { 10, 11, 13, 16 }
        };

        int soDong = mang2Chieu.GetLength(0);
        int soCot = mang2Chieu.GetLength(1);

        // 2. In mảng theo hàng cột
        Console.WriteLine("Mảng 2 chiều:");
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                Console.Write(mang2Chieu[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // 3. Tính tổng các phần tử mà có chỉ số hàng = chỉ số cột (đường chéo chính)
        int tongDuongCheoChinh = 0;
        for (int i = 0; i < Math.Min(soDong, soCot); i++)
        {
            tongDuongCheoChinh += mang2Chieu[i, i];
        }
        Console.WriteLine("Tổng các phần tử trên đường chéo chính: " + tongDuongCheoChinh);

        // 4. In ra các phần tử nhỏ nhất trên từng cột
        Console.WriteLine("Phần tử nhỏ nhất trên mỗi cột:");
        for (int j = 0; j < soCot; j++)
        {
            int minCot = int.MaxValue;
            for (int i = 0; i < soDong; i++)
            {
                if (mang2Chieu[i, j] < minCot)
                    minCot = mang2Chieu[i, j];
            }
            Console.WriteLine("Cột " + j + ": " + minCot);
        }

        // 5. Liệt kê các phần tử chia hết cho 7
        Console.WriteLine("Các phần tử chia hết cho 7:");
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                if (mang2Chieu[i, j] % 7 == 0)
                    Console.Write(mang2Chieu[i, j] + " ");
            }
        }
        Console.WriteLine();

        // 6. Tìm tổng các phần tử nằm trên đường viền của mảng
        int tongDuongVien = 0;
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                if (i == 0 || i == soDong - 1 || j == 0 || j == soCot - 1)
                    tongDuongVien += mang2Chieu[i, j];
            }
        }
        Console.WriteLine("Tổng các phần tử nằm trên đường viền của mảng: " + tongDuongVien);

        // 7. Chuyển mảng thành mảng 1 chiều rồi sắp xếp tăng dần
        int[] mang1Chieu = new int[soDong * soCot];
        int index = 0;
        for (int i = 0; i < soDong; i++)
        {
            for (int j = 0; j < soCot; j++)
            {
                mang1Chieu[index++] = mang2Chieu[i, j];
            }
        }

        Array.Sort(mang1Chieu);
        Console.WriteLine("Mảng 1 chiều sau khi sắp xếp tăng dần: " + string.Join(", ", mang1Chieu));
    }
}
