using System.Collections;

namespace Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("ANH ANH");

            string[] str = { "Tung", "Cuc", "Truc", "Mai" };
            arrayList.AddRange(str);

            printArray(arrayList);

            arrayList.Insert(0, "NTU");
            printArray(arrayList);

            arrayList.Remove("NTU");
            printArray(arrayList);

            arrayList.RemoveAt(1);
            printArray(arrayList);

            arrayList.AddRange(str);
            printArray(arrayList);
            arrayList.Sort();
            printArray(arrayList);
        }
        static void printArray(ArrayList arrayList)
        {
            Console.WriteLine("đâsada");
            foreach (var i in arrayList)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
