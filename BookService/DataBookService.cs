using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class DataBookService : IBookService
    {
        List<Author> AuthorList = new List<Author>();
        List<Book> BookList = new List<Book>();
        DataParser parser = new DataParser();
        public DataBookService()
        {
            LoadData("books.csv");
        }
        public void LoadData(string name)
        {
            parser.ParseData(name);
            ParseBooks();
            ParseAuthors();
        }
        public List<Book> ParseBooks()
        {
            BookList.Clear();
            BookList.AddRange(parser.GetBooks());
            return BookList;
        }
        public List<Author> ParseAuthors()
        {
            AuthorList.Clear();
            AuthorList.AddRange(parser.GetAuthors());
            return AuthorList;
        }
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
        public IEnumerable<Book> ResetBooks() => ParseBooks();
        public IEnumerable<Author> ResetAuthors() => ParseAuthors();
        public IEnumerable<Book> OrderBooks() => UpdateList(BookList.OrderBy(b => b.Title).ToList());
        public IEnumerable<Author> OrderAuthors() => UpdateList(AuthorList.OrderBy(a => a.Name).ToList());
        public IEnumerable<Book> OrderDescBooks() => UpdateList(BookList.OrderByDescending(b => b.Title).ToList());
        public IEnumerable<Author> OrderDescAuthors() => UpdateList(AuthorList.OrderByDescending(a => a.Name).ToList());
        public IEnumerable<Book> AllBooks() => BookList;
        public IEnumerable<Author> AllAuthors() => AuthorList;
        public IEnumerable<Book> BooksByAuthor(string name) => UpdateList(BookList.Where(book => book.Authors.Any(a => a.Name == name)).ToList());
        public IEnumerable<Book> BooksByYear(int year) => UpdateList(BookList.Where(book => book.YearOfPublication == year).ToList());
        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB) => UpdateList(BookList.OrderBy(b => b.YearOfPublication).Where(book => book.YearOfPublication >= yearA && book.YearOfPublication <= yearB).ToList());
        public IEnumerable<Book> LeastFavouriteBooks() => UpdateList( BookList.OrderBy(book => book.Rating).ToList());
        public IEnumerable<Book> MostFavouriteBooks(int number) => UpdateList( BookList.OrderByDescending(book => book.Rating).Take(number).ToList());
        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression) => UpdateList(BookList.Where(expression).ToList());
    }
}
