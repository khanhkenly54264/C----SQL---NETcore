namespace Lab3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book("Nguyen Tuan Anh","Dac Nhan Tam", 10, "VN", 50);
            b1.Display();

            b2.Display();
            b1.flipPageBackward();
            b2.flipPageForward();
            Console.ReadKey();
        }
    }
}
