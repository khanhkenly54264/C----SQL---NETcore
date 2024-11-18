namespace Bai02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.Write("Nhập số lượng nhân viên: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double totalSalary = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập Id: ");
                string id = Console.ReadLine();
                Console.Write("Nhập tên: ");
                string name = Console.ReadLine();
                Console.Write("Nhập địa chỉ: ");
                string address = Console.ReadLine();
                Console.Write("Nhập ngày sinh: ");
                string birthday = Console.ReadLine();
                Console.Write("Nhập lương: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhập thưởng: ");
                double bonus = Convert.ToDouble(Console.ReadLine());

                double total = salary + bonus;
                totalSalary += total;

                Console.WriteLine($"Id: {id}, Tên: {name}, Địa chỉ: {address}, Ngày sinh: {birthday}, Lương: {salary}, Thưởng: {bonus}, Tổng: {total}");
            }

            Console.WriteLine($"Tổng lương và thưởng của tất cả nhân viên: {totalSalary}");
        }
    }
}
