using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Ví dụ 1: InvalidCastException
        try
        {
            object obj = "Đây là một chuỗi";
            int num = (int)obj;  // Ép kiểu không hợp lệ từ chuỗi sang số nguyên
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine("Bắt được InvalidCastException: " + e.Message);
        }

        // Ví dụ 2: IndexOutOfRangeException
        try
        {
            int[] arr = new int[] { 1, 2, 3 };
            int value = arr[5];  // Chỉ số vượt quá giới hạn mảng
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Bắt được IndexOutOfRangeException: " + e.Message);
        }

        // Ví dụ 3: ArrayTypeMismatchException
        try
        {
            object[] objArray = new string[] { "Xin chào", "Thế giới" };
            objArray[0] = 123;  // Lỗi không khớp kiểu, gán số nguyên cho mảng chuỗi
        }
        catch (ArrayTypeMismatchException e)
        {
            Console.WriteLine("Bắt được ArrayTypeMismatchException: " + e.Message);
        }
    }
}