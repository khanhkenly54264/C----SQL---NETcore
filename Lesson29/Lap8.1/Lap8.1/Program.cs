namespace lab_ex8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Khởi tạo mảng 10 quyển sách
            List<Book> books = new List<Book>()
        {
            new Book(1, "Lập trình C#", "Nguyen Van Anh", 1500, "Giáo Dục", 2015),
            new Book(2, "Lập trình Java", "Nguyen Van Bằng", 2500, "Giáo Dục", 2015),
            new Book(3, "Cơ sở dữ liệu", "Tran Van Cảnh", 3500, "Giáo Dục", 2010),
            new Book(4, "Thuật toán", "Le Thi Dịu", 4500, "Khoa Học", 2018),
            new Book(5, "Lập trình Python", "Nguyen Van An", 2000, "Khoa Học", 2020),
            new Book(6, "Xử lý dữ liệu", "Nguyen Thi Ánh", 5000, "Giáo Dục", 2019),
            new Book(7, "Giải tích", "Nguyen Van Khôi", 1200, "Giáo Dục", 2005),
            new Book(8, "Vật lý đại cương", "Tran Van Giang", 1800, "Khoa Học", 2021),
            new Book(9, "Lập trình C++", "Nguyen Van A", 3200, "Giáo Dục", 2015),
            new Book(10, "Thiết kế web", "Nguyen Van Hanh", 2900, "Tin Học", 2017)
        };

            // 1. Hiển thị tất cả các quyển sách
            Console.WriteLine("Tất cả các quyển sách:");
            books.ForEach(book => Console.WriteLine(book.ToString()));

            // 2. Hiển thị những quyển sách có giá từ 1000-5000
            var booksInPriceRange = books.Where(book => book.Price >= 1000 && book.Price <= 5000);
            Console.WriteLine("\nNhững quyển sách có giá từ 1000-5000:");
            foreach (var book in booksInPriceRange)
            {
                Console.WriteLine(book.ToString());
            }

            // 3. Hiển thị những quyển sách xuất bản năm 2015
            var booksIn2015 = books.Where(book => book.Year == 2015);
            Console.WriteLine("\nNhững quyển sách xuất bản năm 2015:");
            foreach (var book in booksIn2015)
            {
                Console.WriteLine(book.ToString());
            }

            // 4. Hiển thị những quyển sách có tên "Lập trình"
            var booksWithLapTrinh = books.Where(book => book.Name.Contains("Lập trình"));
            Console.WriteLine("\nNhững quyển sách có tên 'Lập trình':");
            foreach (var book in booksWithLapTrinh)
            {
                Console.WriteLine(book.ToString());
            }

            // 5. Đếm các quyển sách của nhà xuất bản "Giáo Dục"
            int countGiaoDucBooks = books.Count(book => book.Publisher == "Giáo Dục");
            Console.WriteLine($"\nSố lượng sách của nhà xuất bản 'Giáo Dục': {countGiaoDucBooks}");
        }
    }
}
