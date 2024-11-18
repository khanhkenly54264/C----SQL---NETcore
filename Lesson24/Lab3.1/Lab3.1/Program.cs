namespace Lab3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "Black";
            myCar.year = 1995;
            System.Console.WriteLine("Thong tin chi tiet");
            System.Console.WriteLine("Make:" +  myCar.make);
            System.Console.WriteLine("Model:" + myCar.model);
            System.Console.WriteLine("Color:" + myCar.color);
            System.Console.WriteLine("Year release:" + myCar.year);
            myCar.Start();
            myCar.Stop();   
        }
    }
}
