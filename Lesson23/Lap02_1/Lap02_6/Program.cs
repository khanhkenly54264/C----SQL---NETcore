namespace Lap02_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo và khởi tạo mảng tên
            string[] names = { "Thang", "Long", "Hoa", "Dao" };

            Console.Write("Danh sách sinh viên:\n");

            // Duyệt qua mảng và in ra từng tên
            foreach (var n in names)
            {
                Console.WriteLine(n);
            }
        }
    }
}
