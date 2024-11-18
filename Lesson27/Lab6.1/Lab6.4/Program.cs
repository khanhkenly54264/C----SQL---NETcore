using System.Collections;

namespace Lab6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList bookLst = new ArrayList();
            bookLst.Add(new Book { Id = 1, Title = "C# Programming", Author = "Author A", Publisher = "Publisher X", Year = new DateTime(2020, 1, 1), Price = 15.99M });
            bookLst.Add(new Book { Id = 2, Title = "Java Programming", Author = "Author B", Publisher = "Publisher Y", Year = new DateTime(2019, 5, 10), Price = 12.50M });
            bookLst.Add(new Book { Id = 3, Title = "Python Programming", Author = "Author C", Publisher = "Publisher Z", Year = new DateTime(2021, 3, 3), Price = 18.75M });
            bookLst.Add(new Book { Id = 4, Title = "JavaScript Basics", Author = "Author D", Publisher = "Nhi Dong", Year = new DateTime(2018, 7, 20), Price = 10.99M });
            bookLst.Add(new Book { Id = 5, Title = "Data Structures", Author = "Author E", Publisher = "Publisher V", Year = new DateTime(2022, 9, 15), Price = 20.00M });
            bookLst.Add(new Book { Id = 6, Title = "Algorithms", Author = "Author F", Publisher = "Nhi Dong", Year = new DateTime(2014, 11, 30), Price = 22.50M });
            bookLst.Add(new Book { Id = 7, Title = "Operating Systems", Author = "Author G", Publisher = "Publisher T", Year = new DateTime(2023, 2, 18), Price = 19.99M });
            bookLst.Add(new Book { Id = 8, Title = "Computer Networks", Author = "Author H", Publisher = "Publisher S", Year = new DateTime(2014, 8, 5), Price = 13.75M });
            bookLst.Add(new Book { Id = 9, Title = "Database Systems", Author = "Author I", Publisher = "Publisher R", Year = new DateTime(2014, 4, 22), Price = 17.99M });
            bookLst.Add(new Book { Id = 10, Title = "Machine Learning", Author = "Author J", Publisher = "Nhi Dong", Year = new DateTime(2024, 1, 1), Price = 25.99M });

            // Sắp xếp danh sách theo giá sách (Price) tăng dần
            var sortedBooks = bookLst.Cast<Book>().OrderBy(book => book.Price).ToList();

            // In ra danh sách sách sau khi sắp xếp
            Console.WriteLine("Danh sách sách theo giá tăng dần:");
            foreach (var book in sortedBooks)
            {
                Console.WriteLine(book);
                Console.WriteLine(); // Dòng trống giữa các quyển sách
            }
            // Tìm sách theo tiêu đề mà người dùng nhập vào
            Console.WriteLine("Nhập tiêu đề sách cần tìm:");
            string titleToSearch = Console.ReadLine();

            var foundBook = sortedBooks.FirstOrDefault(book => book.Title.Equals(titleToSearch, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                Console.WriteLine("Đã tìm thấy sách:");
                Console.WriteLine(foundBook);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sách có tiêu đề: {titleToSearch}");
            }
            var booksIn2014 = bookLst.Cast<Book>().Where(book => book.Year.Year == 2014).ToList();

            if (booksIn2014.Count > 0)
            {
                Console.WriteLine("Danh sách sách xuất bản năm 2014:");
                foreach (var book in booksIn2014)
                {
                    Console.WriteLine(book);
                    Console.WriteLine(); // Dòng trống giữa các quyển sách
                }
            }
            else
            {
                Console.WriteLine("Không có sách nào xuất bản năm 2014.");
            }
            bookLst.Remove(bookLst.Cast<Book>().FirstOrDefault(book => book.Publisher == "Nhi Dong"));
            // In ra danh sách sau khi xóa
            Console.WriteLine("Danh sách sách sau khi xóa những sách có Publisher là 'Nhi Dong':");
            foreach (var book in bookLst.Cast<Book>())
            {
                Console.WriteLine(book);
                Console.WriteLine(); // Dòng trống giữa các quyển sách
            }
        }
    }
}
