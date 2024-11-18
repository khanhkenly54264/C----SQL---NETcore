namespace Bai02_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Các số có tổng 3 chữ số là chẵn từ 100-999:");
            for (int i = 100; i <= 999; i++)
            {
                int sum = (i / 100) + (i / 10 % 10) + (i % 10);
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
