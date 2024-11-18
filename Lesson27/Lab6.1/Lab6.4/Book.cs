using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Year { get; set; }
        public Decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n" +
                   $"Title: {Title}\n" +
                   $"Author: {Author}\n" +
                   $"Publisher: {Publisher}\n" +
                   $"Year: {Year:yyyy}\n" +
                   $"Price: {Price:C}";
        }
    }
}
