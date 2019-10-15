using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class InMemoryBookService : IBookService
    {
        List<Author> AuthorList = new List<Author>();
        List<Book> BookList = new List<Book>();

        public InMemoryBookService()
        {
            AuthorList.Add(new Author("Weill"));
            AuthorList.Add(new Author("Everett Rogers"));
            AuthorList.Add(new Author("Grunde Haug"));
            BookList.Add(new Book("123123123", "Leveraging the new infrastructure",2001,10,1));
            BookList.Add(new Book("568568567", "Strategi planning for is",2010,1,6));
            BookList.Add(new Book("234345443", "Diffusion of innovations",2014,5,23));
            BookList.Add(new Book("234546443", "Som man frågar får man svar",2003,13,7));
            ConnectBookAndAuthor(BookList[0], AuthorList[2]);
            ConnectBookAndAuthor(BookList[1], AuthorList[0]);
            ConnectBookAndAuthor(BookList[2], AuthorList[1]);
            ConnectBookAndAuthor(BookList[3], AuthorList[2]);
        }

        public void ConnectBookAndAuthor(Book _book, Author _author)
        {
            if (_book.Authors.Contains(_author) || _author.Books.Contains(_book)){ throw new InvalidOperationException(); }
            _book.Authors.Add(_author);
            _author.Books.Add(_book);
        }

        public IEnumerable<Book> AllBooks() => BookList;
        public IEnumerable<Author> AllAuthors() => AuthorList;
        public IEnumerable<Book> BooksByAuthor(string name) => BookList.Where(book => book.Authors.Any(a => a.Name == name));
        public IEnumerable<Book> BooksByYear(int year) => BookList.Where(book => book.YearOfPublication == year);

        public void AddBook(string isbn, string title, int yearOfPublication, double rating, int number)
        {
            BookList.Add(new Book(isbn, title, yearOfPublication, rating, number));
        }
        public void AddAuthor(string name)
        {
            AuthorList.Add(new Author(name));
        }

        public IEnumerable<Book> BooksBetweenYears(int yearA, int yearB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> LeastFavouriteBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> MostFavouriteBooks(int number)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> FilterBooksBy(Func<Book, bool> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> ResetBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> ResetAuthors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> OrderBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> OrderAuthors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> OrderDescBooks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> OrderDescAuthors()
        {
            throw new NotImplementedException();
        }
    }
}
