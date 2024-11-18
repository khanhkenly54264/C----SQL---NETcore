namespace Lap05_01
{
    /// <summary>
    /// Mội số thao tác với mảng 1 chièu
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // khai báo và khỏi tạo mảng 1 chiều
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //duyệt mảng và in ra
            Console.WriteLine("các phần tử của mảng");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}  ,", array[i]);
            }
            //tìm phần tửu lớn nhất
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            Console.WriteLine("\nPhần tử lớn nhất trong mảng là {0}", max);

            // kiểm tra đối xứng 
            bool kt = true;
            int cout = array.Length;
            for (int i = 0; i < cout; i++)
            {
                if (array[i] != array[cout - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                Console.WriteLine("Mảng Là Đối Xứng");
            }
            else
            {
                Console.WriteLine("Mảng Không Đối Xứng");
            }
        }
    }
}