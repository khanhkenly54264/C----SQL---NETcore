namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string name = "";
            byte age = 18;
            char gender = 'M';
            const float percent = 75.50F;

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Age: ", age);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Percentage: {0}", percent);
            Console.Read();
        }
    }
}
