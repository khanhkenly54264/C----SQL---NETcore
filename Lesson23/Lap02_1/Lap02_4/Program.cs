namespace Lap02_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến đánh dấu
            bool check;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Các số nguyên tố từ 2-100: ");

            // Duyệt từ 2-100 để tìm số nguyên tố
            for (int i = 2; i <= 100; i++)
            {
                check = true; // Giả sử i là số nguyên tố

                // Kiểm tra số i có phải là số nguyên tố không
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0) // Nếu chia hết tức là không phải số nguyên tố
                    {
                        check = false;
                        break; // Không kiểm tra các trường hợp tiếp theo
                    }
                }

                if (check) // Nếu là số nguyên tố thì in ra
                    Console.Write(i + " ");
            }
    }
}
