using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._6
{
    internal class Book
    {
        private string author;
        private string title;
        private int pages;
        private string isbn;
        private int currentpage;

        public Book() 
        {
            author = "";
            pages = 0;
            isbn = "";
            title = "";
            currentpage = 1;
        }

        public Book(string author, string title, int pages, string isbn, int currentpage)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.isbn = isbn;
            this.currentpage = currentpage;
        }

        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
        public int Pages { get => pages; set => pages = value; }
        public string Isbn { get => isbn; set => isbn = value; }
        public int Currentpage { get => currentpage; set => currentpage = value; }

        public void Display()
        {
            Console.WriteLine("Tac gia:" + author);
            Console.WriteLine("Trang:" + pages);
            Console.WriteLine("Isbn:" + isbn);
            Console.WriteLine("Tieu de:" +  title);
            Console.WriteLine("Trang hien tai:" + currentpage);
        }
        public void flipPageForward()
        {
            Console.WriteLine("Lat sang trang truoc");
        }
        public void flipPageBackward()
        {
            Console.WriteLine("Lat sang trang sau");
        }
    }
}
