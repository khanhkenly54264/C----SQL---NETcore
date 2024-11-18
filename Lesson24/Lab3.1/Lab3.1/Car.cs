using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;
        public void Start()
        {
            System.Console.WriteLine(model + "Khoi dong");
        }
        public void Stop() 
        {
            System.Console.WriteLine(model + "dung");
        }

    }
}
