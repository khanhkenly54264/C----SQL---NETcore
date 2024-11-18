namespace lab_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khoi tao Customer
            var customers = new Customer[]
            {
                new Customer { ID = 5, Name = "Sam" },
                new Customer { ID = 6, Name = "Dave" },
                new Customer { ID = 7, Name = "Julia" },
                new Customer { ID = 8, Name = "Sue" },
            };
            //khoi tao Order
            var orders = new Order[]
            {
                new Order {ID = 5, Product = "Book"},
                new Order {ID = 6, Product = "Game" },
                new Order {ID = 7,Product="Computer" },
                new Order {ID = 8,Product="Shirt" }
            };
            //su dung truy van va join 2 tap du lieu dua tren ID
            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };
            //hien thi ten khach hang va nhom san pham
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);
            }
        }
    }
}
