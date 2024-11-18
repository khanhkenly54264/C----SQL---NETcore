namespace Lap02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập a, b, c
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            while (a == 0)
            {
                Console.WriteLine("a phải khác 0. Nhập lại a:");
                a = Convert.ToDouble(Console.ReadLine());
            }
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            // Tính delta
            delta = b * b - 4 * a * c;

            // Biện luận
            if (delta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm");
            }
            else if (delta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép");
                Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("Phương trình có 2 nghiệm");
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
