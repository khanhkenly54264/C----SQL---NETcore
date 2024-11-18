namespace Bai02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số giây: ");
            int totalSeconds = Convert.ToInt32(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine($"Thời gian: {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
