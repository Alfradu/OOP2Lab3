using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    interface IBookService
    {
        IEnumerable<Book> ResetBooks();
        IEnumerable<Author> ResetAuthors();
        IEnumerable<Book> AllBooks();
        IEnumerable<Author> AllAuthors();
        IEnumerable<Book> OrderBooks();
        IEnumerable<Author> OrderAuthors();
        IEnumerable<Book> OrderDescBooks();
        IEnumerable<Author> OrderDescAuthors();
        IEnumerable<Book> BooksByAuthor(string name);
        IEnumerable<Book> BooksByYear(int year);
        IEnumerable<Book> BooksBetweenYears(int yearA, int yearB);
        IEnumerable<Book> LeastFavouriteBooks();
        IEnumerable<Book> MostFavouriteBooks(int number);
        IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression);
        void AddBook(string isbn, string title, int yop, double rating, int number);
        void AddAuthor(string name);
        void ConnectBookAndAuthor(Book book, Author author);
    }
}
