using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookService
{
    class WriteToFile<T>
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory + @"\" + "../../files/";
        public static void WriteToTextFile(IEnumerable<T> list, string extension, string fileName)
        {
            List<string> s = new List<string>();
            if (list.GetType() == typeof(List<Book>))
            {
                List<Book> bookList = (List<Book>)list;
                foreach(Book book in bookList)
                {
                    s.Add(book.ISBN+";"+string.Join(", ",book.Authors.Select(a => a.Name)) + ";"+book.YearOfPublication + ";"+book.Title + ";"+book.Rating + ";"+book.NumberOfUserVotes);
                    // TODO: add to TOSTRING() method.
                }
            }
            else if (list.GetType() == typeof(List<Author>))
            {
                List<Book> bookList = new List<Book>();
                foreach(Author author in (List<Author>)list)
                {
                    foreach(Book book in author.Books)
                    {
                        if (!bookList.Contains(book)){
                            bookList.Add(book);
                        }
                    }
                }
                foreach (Book book in bookList)
                {
                    s.Add(book.ISBN + ";" + string.Join(", ", book.Authors.Select(a => a.Name)) + ";" + book.YearOfPublication + ";" + book.Title + ";" + book.Rating + ";" + book.NumberOfUserVotes);
                }
            }
            else
            {
                s.Add("Error writing to file.");
            }
            bool append = false;
            if (File.Exists(path)) { append = true; } 
            using (StreamWriter output = new StreamWriter(Path.Combine(path+fileName+extension), append)) 
            {
                foreach (string line in s)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}
