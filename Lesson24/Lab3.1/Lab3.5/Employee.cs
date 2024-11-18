using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int yearOfBirth { get; set; }
        public double salaryLevel { get; set; }
        public double basicSalary {  get; set; }

        public double GetInCome()
        {
            double InCome = salaryLevel * basicSalary;
            return InCome;
        }
        public void Display()
        {
            Console.WriteLine("Dinh danh" + Id);
            Console.WriteLine("Ten" + Name);
            Console.WriteLine("Nam sinh" + yearOfBirth);
            Console.WriteLine("Luong co ban" + basicSalary); 
        }
    }
}
