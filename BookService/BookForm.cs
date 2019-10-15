using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookService
{
    public partial class BookForm : Form
    {
        bool lookingAtBooks = true;
        IBookService bookService = SimpleDI.GetService();
        public BookForm()
        {
            InitializeComponent();
            populateListBox(bookService.AllBooks());
        }

        private void hideErrors()
        {
            newBookErr.Hide();
            newAuthErr.Hide();
            linkErr.Hide();
        }

        private void populateListBox(IEnumerable<Book> books)
        {
            listBox.Items.Clear();
            books.ToList().ForEach(b => listBox.Items.Add(b.Title));
            lookingAtBooks = true;
        }
        private void populateListBox(IEnumerable<Author> authors)
        {
            listBox.Items.Clear();
            authors.ToList().ForEach(a => listBox.Items.Add(a.Name));
            lookingAtBooks = false;
        }
        
        private void bookAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _isbn = isbnText.Text;
                string _title = titleText.Text;
                int _yop = Convert.ToInt32(yearPubText.Text);
                bookService.AddBook(_isbn, _title, _yop, 0, 0);
                if (lookingAtBooks)
                {
                    populateListBox(bookService.AllBooks());
                }
                isbnText.Clear();
                titleText.Clear();
                yearPubText.Clear();
                hideErrors();
            } catch (Exception)
            {
                newBookErr.Show();
            }
        }

        private void authorAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = nameText.Text.Trim();
                bookService.AddAuthor(_name);
                if (!lookingAtBooks)
                {
                    populateListBox(bookService.AllAuthors());
                }
                nameText.Clear();
                hideErrors();
            }
            catch (Exception)
            {
                newAuthErr.Show();
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var _book = bookService.AllBooks().Where(b => b.Title == bookNameText.Text).Single();
                var _author = bookService.AllAuthors().Where(a => a.Name == authorNameText.Text).Single();
                bookService.ConnectBookAndAuthor(_book, _author);
                bookNameText.Clear();
                authorNameText.Clear();
                hideErrors();
            } catch (Exception)
            {
                linkErr.Show();
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != ListBox.NoMatches)
            {
                if (lookingAtBooks)
                {
                    Book book = bookService.AllBooks().Where(b => b.Title == listBox.SelectedItem.ToString()).First();
                    titleFilterBox.Text = book.Title;
                    infoTextBox.Text = string.Format("Title: {0}\r\n" +
                        "ISBN: {1}\r\n" +
                        "User votes: {2}\r\n" +
                        "Rating: {3}\r\n" +
                        "Year of Publication: {4}\r\n" +
                        "Author(s): {5}", book.Title, book.ISBN, book.NumberOfUserVotes, book.Rating, book.YearOfPublication, book.ToString());
                }
                else
                {
                    Author author = bookService.AllAuthors().Where(a => a.Name == listBox.SelectedItem.ToString()).First();
                    bookAuthorSearchText.Text = author.Name;
                    nameFilterBox.Text = author.Name;
                    infoTextBox.Text = string.Format("Author: {0}\r\n" +
                        "Book(s): {1}", author.Name, author.ToString());
                }
            }
        }

        private void displayBooksBtn_Click(object sender, EventArgs e)
        {
            bookAuthorSearchText.Clear();
            nameFilterBox.Clear();
            populateListBox(bookService.AllBooks());
        }

        private void displayAuthorsBtn_Click(object sender, EventArgs e)
        {
            titleFilterBox.Clear();
            populateListBox(bookService.AllAuthors());
        }

        private void bookAuthorSearchBtn_Click(object sender, EventArgs e)
        {
            populateListBox(bookService.BooksByAuthor(bookAuthorSearchText.Text));
        }

        private void bookYearSearchBtn_Click(object sender, EventArgs e)
        {
            populateListBox(bookService.BooksByYear(decimal.ToInt32(bookYearSearchInt.Value)));
        }

        private void leastFavBtn_Click(object sender, EventArgs e)
        {
            populateListBox(bookService.LeastFavouriteBooks());
        }

        private void topRatedBtn_Click(object sender, EventArgs e)
        {
            populateListBox(bookService.MostFavouriteBooks(Convert.ToInt32(topRatedNumber.Value)));
        }

        private void betweenYearsBtn_Click(object sender, EventArgs e)
        {
            populateListBox(bookService.BooksBetweenYears(Convert.ToInt32(minYears.Value),Convert.ToInt32(maxYears.Value)));
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (lookingAtBooks)
            {
                List<Book> newList = bookService.AllBooks().Where(b => listBox.Items.Contains(b.Title)).ToList();
                WriteToFile<Book>.WriteToTextFile(newList);
            }
            else
            {
                List<Author> newList = bookService.AllAuthors().Where(a => listBox.Items.Contains(a.Name)).ToList();
                WriteToFile<Author>.WriteToTextFile(newList);
            }
        }

        private void descendingBtn_Click(object sender, EventArgs e)
        {
            if (lookingAtBooks)
            {
                populateListBox(bookService.OrderDescBooks());
            }
            else
            {
                populateListBox(bookService.OrderDescAuthors());
            }
        }

        private void ascendingBtn_Click(object sender, EventArgs e)
        {
            if (lookingAtBooks)
            {
                populateListBox(bookService.OrderBooks());
            }
            else
            {
                populateListBox(bookService.OrderAuthors());
            }
        }

        private void resetSearchBtn_Click(object sender, EventArgs e)
        {
            if (lookingAtBooks)
            {
                populateListBox(bookService.ResetBooks());
            }
            else
            {
                populateListBox(bookService.ResetAuthors());
            }
        }

        private void loadCsvBtn_Click(object sender, EventArgs e)
        {
            bookService = SimpleDI.GetService();
            populateListBox(bookService.AllBooks());
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.YearOfPublication <= pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating <= RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes <= VotesFilterbox.Value));
            }
        }

        private void filter2Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.YearOfPublication >= pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating >= RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes >= VotesFilterbox.Value));
            }
        }

        private void filter3Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.YearOfPublication == pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating == RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes == VotesFilterbox.Value));
            }
            else if (radioISBN.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.ISBN == isbnFilterBox.Text));
            }
            else if (radioName.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.Authors.Any(b => b.Name == nameFilterBox.Text)));
            }
            else if (radioTitle.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.Title == titleFilterBox.Text));
            }
        }

        private void filter4Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.YearOfPublication != pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating != RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes != VotesFilterbox.Value));
            }
            else if (radioISBN.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.ISBN != isbnFilterBox.Text));
            }
            else if (radioName.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.Authors.Any(b => b.Name != nameFilterBox.Text)));
            }
            else if (radioTitle.Checked)
            {
                populateListBox(bookService.FilterBooksBy(a => a.Title != titleFilterBox.Text));
            }
        }
    }
}
