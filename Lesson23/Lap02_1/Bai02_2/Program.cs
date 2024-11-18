namespace Bai02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.Write("Nhập năm: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập tháng: ");
            int month = Convert.ToInt32(Console.ReadLine());

            int days = DateTime.DaysInMonth(year, month);
            Console.WriteLine($"Số ngày trong tháng {month} năm {year} là: {days}");
        }
    }
}
