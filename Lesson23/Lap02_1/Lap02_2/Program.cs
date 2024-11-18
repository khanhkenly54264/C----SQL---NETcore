namespace Lap02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int number;
            double money = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập thông tin
            Console.Write("Nhập tên thuê bao: ");
            name = Console.ReadLine();
            Console.Write("Nhập số điện sử dụng: ");
            number = Convert.ToInt32(Console.ReadLine());

            // Tính toán số tiền
            if (number <= 50)
            {
                money = number * 1.678;
            }
            else if (number > 50 && number <= 100)
            {
                money = 50 * 1.678 + (number - 50) * 1.734;
            }
            else if (number > 100 && number <= 150)
            {
                money = 50 * 1.678 + 50 * 1.734 + (number - 100) * 2.014;
            }
            else
            {
                money = 50 * 1.678 + 50 * 1.734 + 50 * 2.014 + (number - 150) * 2.536;
            }

            // In thông tin ra màn hình
            Console.WriteLine("\nThông tin tiền điện");
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Số điện sử dụng: {0}", number);
            Console.WriteLine("Số tiền: {0:C}", money);
        }
    }
}
