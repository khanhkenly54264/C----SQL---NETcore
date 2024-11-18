using System;

namespace DongVat
{
    // AnCo
    namespace AnCo
    {
        public class Bo
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Bo(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Trau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Trau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }

        public class De
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public De(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }
    }

    // AnThit
    namespace AnThit
    {
        public class CaSau
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public CaSau(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Ho
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public Ho(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }

        public class SuTu
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Weight { get; set; }

            public SuTu(int id, string name, double weight)
            {
                ID = id;
                Name = name;
                Weight = weight;
            }
        }
    }


    // Test
    class Program
    {
        static void Main(string[] args)
        {
            // AnCo 
            AnCo.Bo bo = new AnCo.Bo(1, "Bo", 400);
            Console.WriteLine($"Animal: {bo.Name}, ID: {bo.ID}, Weight: {bo.Weight}kg");

            AnCo.Trau trau = new AnCo.Trau(2, "Trau", 500);
            Console.WriteLine($"Animal: {trau.Name}, ID: {trau.ID}, Weight: {trau.Weight}kg");

            AnCo.De de = new AnCo.De(3, "De", 60);
            Console.WriteLine($"Animal: {de.Name}, ID: {de.ID}, Weight: {de.Weight}kg");

            // AnThit
            AnThit.CaSau caSau = new AnThit.CaSau(4, "CaSau", 300);
            Console.WriteLine($"Animal: {caSau.Name}, ID: {caSau.ID}, Weight: {caSau.Weight}kg");

            AnThit.Ho ho = new AnThit.Ho(5, "Ho", 250);
            Console.WriteLine($"Animal: {ho.Name}, ID: {ho.ID}, Weight: {ho.Weight}kg");

            AnThit.SuTu suTu = new AnThit.SuTu(6, "SuTu", 200);
            Console.WriteLine($"Animal: {suTu.Name}, ID: {suTu.ID}, Weight: {suTu.Weight}kg");
        }
    }
}
