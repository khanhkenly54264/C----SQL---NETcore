namespace Lap02_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến tổng
            int sum = 0;

            // Duyệt từ 1-100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 3 != 0)
                {
                    sum += i;
                }
            }
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // In kết quả
            Console.WriteLine("Tổng các số chẵn không chia hết cho 3 từ 1-100 là: {0}", sum);
        }
    }
}
