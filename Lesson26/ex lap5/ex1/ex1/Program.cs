using System.ComponentModel.Design;

namespace Ex1
{
    /// <summary>
    /// tạo dúng dụng C# và thực hiện các công việc sau
    /// Khởi tạo mảng 1 chiều sô nguyên ồm 10 phần tử
    /// tìm phẩn tử nhỏ nhất của mảng
    /// đảo ngược mảng
    /// sắp xếp mảng tắng dần hoặc giảm dần
    /// tìm các phần tử là số nguyên tố
    /// im ra số lượng các số duong liên tiếp nhiều nhất
    /// tính trung bình công các phần tử dương
    /// kiểm tra xem mảng có chứa các phần tử âm dương đan xem không
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Thực hiện các công việc sau");
            int[] arrays = { 1, 55, 32, -13, 51, 23, 12, 24, 26, 54 };
            int chon = 0;
            do
            {
                menu();
                Console.WriteLine("Mời bạn chọn");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1.Tìm phẩn tử nhỏ nhất của mảng");
                        minArray(arrays);
                        break;
                    case 2:
                        Console.WriteLine("2.Đảo ngược mảng");
                        reverseArray(arrays);
                        break;
                    case 3:
                        Console.WriteLine("3.Sắp xếp mảng tăng dần hoặc giảm dần");
                        SortArray(arrays);
                        break;
                    case 4:
                        printPrime(arrays);
                        Console.WriteLine("4.Tìm các phần tử là số nguyên tố");
                        break;
                    case 5:
                        Console.WriteLine("5.Im ra số lượng các số duong liên tiếp nhiều nhất");
                        MaxConsecutivePositive(arrays);
                        break;
                    case 6:
                        agvPositive(arrays);
                        Console.WriteLine("6.Tính trung bình công các phần tử dương");
                        break;
                    case 7:
                        Console.WriteLine("7.Kiểm tra xem mảng có chứa các phần tử âm dương đan xem không");
                        bool danXen = KiemTraDanXen(arrays);
                        Console.WriteLine("Mảng có chứa phần tử âm dương đan xen: " + (danXen ? "Có" : "Không"));
                        break;
                    case 8:
                        Console.WriteLine("8.Kết thúc");
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng !");
                        break;
                }
            } while (chon != 8);

            static void menu()
            {
                Console.WriteLine("================= MENU ================");
                Console.WriteLine("1.Tìm phẩn tử nhỏ nhất của mảng");
                Console.WriteLine("2.Đảo ngược mảng");
                Console.WriteLine("3.Sắp xếp mảng tăng dần hoặc giảm dần");
                Console.WriteLine("4.Tìm các phần tử là số nguyên tố");
                Console.WriteLine("5.Im ra số lượng các số duong liên tiếp nhiều nhất");
                Console.WriteLine("6.Tính trung bình công các phần tử dương");
                Console.WriteLine("7.Kiểm tra xem mảng có chứa các phần tử âm dương đan xem không");
                Console.WriteLine("8.Kết thúc");
            }
            //số nhỏ nhất của mảng
            static void minArray(int[] arrays)
            {
                int min = arrays.Min();
                Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + min);
            }
            //đảo ngược
            static void reverseArray(int[] arrays)
            {
                Console.WriteLine("Array:{0} ", String.Join(" , ", arrays));
                Array.Reverse(arrays);
                Console.Write("Các phần tử của mảng sau khi đảo ngược là:");
                for (int i = 0; i < arrays.Length; i++)
                {
                    Console.Write(" {0} ,", arrays[i]);
                }
                Console.WriteLine();
            }
            ///
            /// in ra mang tăng giảm
            ///
            static void SortArray(int[] arrays)
            {
                Console.WriteLine("Array:{0} ", String.Join(" , ", arrays));
                Array.Sort(arrays);
                Console.WriteLine("Mảng tăng dần:{0} ", String.Join(" , ", arrays));
                Array.Reverse(arrays);
                Console.WriteLine("Mảng giảm dần:{0} ", String.Join(" , ", arrays));
            }
            // số nguyên tố trong mảng
            static void printPrime(int[] arrays)
            {
                Console.WriteLine("Mảng tăng dần:{0} ", String.Join(" , ", arrays));
                Console.WriteLine("Các số nguyên tố trong mảng là:");
                foreach (int num in arrays)
                {
                    if (IsPrime(num))
                        Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            static bool IsPrime(int num)
            {
                if (num < 2) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }
            //Số lượng các số dương liên tiếp nhiều nhất
            static void MaxConsecutivePositive(int[] arrays)
            {
                Console.WriteLine("Mảng :{0} ", String.Join(" , ", arrays));
                int maxCount = 0, currentCount = 0;
                foreach (var num in arrays)
                {
                    if (num > 0)
                        currentCount++;
                    else
                        currentCount = 0;

                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                Console.WriteLine("Số lượng các số dương liên tiếp nhiều nhất: " + maxCount);
            }
            //trung bình công số dương
            static void agvPositive(int[] arrays)
            {
                double tong = 0;
                int count = 0;
                for (int i = 0; i < arrays.Length; i++)
                {
                    if (arrays[i] > 0)
                    {
                        tong = tong + arrays[i];
                        count++;
                    }
                }
                Console.WriteLine("Trung bình cộng các phần tử dương: {0}", tong / count);
            }
            //Kiem tran mang co phan tu am dan xen khong
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
    }
}