namespace Bai02_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Nhập ba cạnh a, b, c
            Console.WriteLine("Nhập độ dài cạnh a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập độ dài cạnh b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập độ dài cạnh c:");
            int c = int.Parse(Console.ReadLine());

            // Kiểm tra điều kiện để a, b, c tạo thành một tam giác
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a, b, c là ba cạnh của một tam giác.");

                // Kiểm tra loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Đây là tam giác đều.");
                }
                else if (a == b && b == c && a == c)
                {
                    // Tam giác cân
                    if (IsRightTriangle(a, b, c))
                    {
                        Console.WriteLine("Đây là tam giác vuông cân.");
                    }
                    else
                    {
                        Console.WriteLine("Đây là tam giác cân.");
                    }
                }
                else if (IsRightTriangle(a, b, c))
                {
                    Console.WriteLine("Đây là tam giác vuông.");
                }
                else
                {
                    Console.WriteLine("Đây là tam giác thường.");
                }


            }
            else
            {
                Console.WriteLine("a, b, c không tạo thành một tam giác.");
            }

            // Phương thức kiểm tra tam giác vuông
            static bool IsRightTriangle(int a, int b, int c)
            {
                // Kiểm tra theo định lý Pythagoras
                return (a * a + b * b == c * c) || (a * a + c * c == b * b) || (b * b + c * c == a * a);
            }
        }
    }
}
