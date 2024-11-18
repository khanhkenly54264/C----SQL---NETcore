namespace Lab3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20; int b= 30;
            double area;
            Utility u = new Utility();
            Console.WriteLine("Truoc khi hoan vi a={0}, b={1}",a,b);
            u.SwapFake(a,b);
            Console.WriteLine("Sau khi hoan vi dang fake a={0}, b={1}", a, b);
            u.SwapReally(ref a, ref b);
            Console.WriteLine("Sau khi hoan vi dang really a={0}, b={1}", a, b);
            u.AreaCircle(100,out area);
            Console.WriteLine("Chu vi hinh tron ban kinh 100 la: {0}", area);
        }
    }
}
