namespace Lap02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id, name;
            DateTime birthday;
            double mark1, mark2, mark3;
            // Khai báo các biến để lưu trữ thông tin sinh viên và điểm số
            Console.WriteLine("Nhập mã số:");
            id = Console.ReadLine();
            Console.WriteLine("Nhập tên:");
            name = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh:");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 1:");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 2:");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn 3:");
            mark3 = Convert.ToDouble(Console.ReadLine());

            // Tính trung bình cộng của ba điểm số
            double average = (mark1 + mark2 + mark3) / 3;

            // Hiển thị thông tin sinh viên
            Console.WriteLine("\nThông tin sinh viên");
            Console.WriteLine("Mã số: {0}", id);
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Ngày sinh: {0:dd/MM/yyyy}", birthday);
            Console.WriteLine("Điểm trung bình: {0:F2}", average);
        }
    }
}
