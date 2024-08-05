using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11.Practice3
{
    internal class Book
    {
        private string Name { get; set; }

        private string Author { get; set; }

        public string GetIngo(Book book)
        {
            return $"Вот название книги: {book.Name},а вот Автор книги: {book.Author} ";
        }
    }
}
