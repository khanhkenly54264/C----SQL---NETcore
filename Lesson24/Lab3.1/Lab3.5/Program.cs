namespace Lab3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Nguyen Tuan Anh";
            employee.salaryLevel = 50;
            employee.basicSalary = 300;
            employee.Display();
            double InCome = employee.GetInCome();
            Console.WriteLine("Thu nhap: {0}", InCome);
            Console.ReadLine();
        }
    }
}
