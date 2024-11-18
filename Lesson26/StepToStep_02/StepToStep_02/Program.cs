namespace Lap05_02
{
    /// <summary>
    /// mảng 2 chiều
    /// khởi tạo mảng 2 chiều 4x3
    /// duyệt mảng và in theo ma trận
    /// in ra các phần tử có chỉ số hàng bằng chỉ số cột
    /// in ra phần tử lớn nhất của mỗi hàng
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("mảng 2 chiều");
            int[,] array =
            {
                {4,6,9 },
                {2,4,5 },
                {9,2,6 },
                {1,6,3 }
            };
            //duyệt mảng và in ra
            printArray(array);
            printArrayXY(array);
            printArrayMax(array);
        }

        // Các phần tử trong mảng
        static void printArray(int[,] array)
        {
            Console.WriteLine("các phần tử trong mảng\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(" {0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
        // In ra phần tử theo hàng và cột
        static void printArrayXY(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.Write("{0}  ,", array[i, j]);
                    }
                }
            }
        }

        // in ra phần tử lớn nhất của hàng
        static void printArrayMax(int[,] array)
        {
            for(int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i,0];
                for(int j=0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine("\n Phẩn tử lớn nhất bằng {0} là :{1}", i, max);
            }
        }
    }
}