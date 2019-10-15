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
        CsvParser parser = new CsvParser();
        public CsvBookService()
        {
            parser.ParseCsv();
            ParseBooks();
            ParseAuthors();
        }
        public void ParseBooks() => BookList.AddRange(parser.GetBooks());
        public void ParseAuthors() => AuthorList.AddRange(parser.GetAuthors());

        public List<Book> UpdateList(List<Book> newList)
        {
            BookList.Clear();
            BookList.AddRange(newList);
            return BookList;
        }
        public List<Author> UpdateList(List<Author> newList)
        {
            AuthorList.Clear();
            AuthorList.AddRange(newList);
            return AuthorList;
        }
        public void AddAuthor(string name)
        {
            AuthorList.Add(new Author(name));
        }

        public void AddBook(string isbn, string title, int yop, double rating, int number)
        {
            BookList.Add(new Book(isbn, title, yop, rating, number));
        }

        public void ConnectBookAndAuthor(Book _book, Author _author)
        {
            if (_book.Authors.Contains(_author) || _author.Books.Contains(_book)) { throw new InvalidOperationException(); }
            _book.Authors.Add(_author);
            _author.Books.Add(_book);
        }
        public IEnumerable<Book> ResetBooks()
        {
            ParseBooks();
            return BookList;
        }
        public IEnumerable<Author> ResetAuthors()
        {
            ParseAuthors();
            return AuthorList;
        }
        public IEnumerable<Book> OrderBooks() => BookList.OrderBy(b => b.Title);
        public IEnumerable<Author> OrderAuthors() => AuthorList.OrderBy(a => a.Name);
        public IEnumerable<Book> OrderDescBooks() => BookList.OrderByDescending(b => b.Title);
        public IEnumerable<Author> OrderDescAuthors() => AuthorList.OrderByDescending(a => a.Name);
        public IEnumerable<Book> AllBooks() => BookList;
        public IEnumerable<Author> AllAuthors() => AuthorList;
        public IEnumerable<Book> BooksByAuthor(string name) => UpdateList(BookList.Where(book => book.Authors.Any(a => a.Name == name)).ToList());
        public IEnumerable<Book> BooksByYear(int year) => UpdateList(BookList.Where(book => book.YearOfPublication == year).ToList());
        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB) => UpdateList(BookList.OrderBy(b => b.YearOfPublication).Where(book => book.YearOfPublication >= yearA && book.YearOfPublication <= yearB).ToList());
        public IEnumerable<Book> LeastFavouriteBooks() => UpdateList( BookList.OrderBy(book => book.Rating).ToList());
        public IEnumerable<Book> MostFavouriteBooks(int number) => UpdateList( BookList.OrderByDescending(book => book.Rating).Take(number).ToList());
        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression) => BookList.Where(expression);
    }
}
