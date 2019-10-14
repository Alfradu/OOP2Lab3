using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class CsvBookService : IBookService
    {
        List<Author> AuthorList = new List<Author>();
        List<Book> BookList = new List<Book>();
        public CsvBookService()
        {
            CsvParser parser = new CsvParser();
            parser.ParseCsv();
            AuthorList.AddRange(parser.GetAuthors());
            BookList.AddRange(parser.GetBooks());
        }
        public IEnumerable<Book> AllBooks() => BookList;
        public IEnumerable<Author> AllAuthors() => AuthorList;
        public IEnumerable<Book> BooksByAuthor(string name) => BookList.Where(book => book.Authors.Any(a => a.Name == name));
        public IEnumerable<Book> BooksByYear(int year) => BookList.Where(book => book.YearOfPublication == year);
        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB) => BookList.OrderBy(b => b.YearOfPublication).Where(book => book.YearOfPublication >= yearA && book.YearOfPublication <= yearB);
        public IEnumerable<Book> LeastFavouriteBooks() => BookList.OrderBy(book => book.Rating);
        public IEnumerable<Book> MostFavouriteBooks(int number) => BookList.OrderByDescending(book => book.Rating).Take(number);
        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression) => BookList;

        public void AddAuthor(string name)
        {
            AuthorList.Add(new Author(name));
        }

        public void AddBook(long isbn, string title, int yop, double rating, int number)
        {
            BookList.Add(new Book(isbn, title, yop, rating, number));
        }

        public void ConnectBookAndAuthor(Book _book, Author _author)
        {
            if (_book.Authors.Contains(_author) || _author.Books.Contains(_book)) { throw new InvalidOperationException(); }
            _book.Authors.Add(_author);
            _author.Books.Add(_book);
        }
    }
}
