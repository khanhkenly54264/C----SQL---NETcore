namespace Lap02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            Console.WriteLine("Nhập vào ký tự:");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine("{0} là nguyên âm.", ch);
                    break;
                default:
                    Console.WriteLine("{0} là phụ âm.", ch);
                    break;
            }
        }
    }
}
