using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookService
{
    public partial class BookForm : Form
    {
        bool lookingAtBooks = true;
        int page = 0;
        const int showPerPage = 50;
        IBookService bookService = SimpleDI.GetService();
        public BookForm()
        {
            InitializeComponent();
            PopulateListBox(bookService.AllBooks());
        }

        private void HideErrors()
        {
            newBookErr.Hide();
            newAuthErr.Hide();
            linkErr.Hide();
        }

        private void PopulateListBox(IEnumerable<Book> books)
        {
            listBox.Items.Clear();
            books.Skip(page * showPerPage).Take(showPerPage).ToList().ForEach(b => listBox.Items.Add(b.Title));
            displayLabel.Text = "(Displaying items " + ((page) * showPerPage + 1) + " to " + books.Take(showPerPage * (page + 1)).ToList().Count + " out of " + books.ToList().Count + ".)";
            lookingAtBooks = true;
            CheckBtnEnabledStatus();
        }
        private void PopulateListBox(IEnumerable<Author> authors)
        {
            listBox.Items.Clear();
            authors.Skip(page * showPerPage).Take(showPerPage).ToList().ForEach(a => listBox.Items.Add(a.Name));
            displayLabel.Text = "(Displaying items " + ((page) * showPerPage + 1) + " to " + authors.Take(showPerPage * (page + 1)).ToList().Count + " out of " + authors.ToList().Count + ".)";
            lookingAtBooks = false;
            CheckBtnEnabledStatus();
        }
        private void CheckBtnEnabledStatus()
        {
            leftBtn.Enabled = page == 0 ? false : true;
            if (lookingAtBooks)
            {
                rightBtn.Enabled = bookService.AllBooks().ToList().Count - (showPerPage * (1+page)) < 1 ? false : true;
            }
            else
            {
                rightBtn.Enabled = bookService.AllAuthors().ToList().Count - (showPerPage * (1+page)) < 1 ? false : true;
            }
        }
        private void ResetPageCount()
        {
            page = 0;
            CheckBtnEnabledStatus();
        }

        private void BookAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _isbn = isbnText.Text;
                string _title = titleText.Text;
                int _yop = Convert.ToInt32(yearPubText.Text);
                bookService.AddBook(_isbn, _title, _yop, 0, 0);
                if (lookingAtBooks)
                {
                    PopulateListBox(bookService.AllBooks());
                }
                isbnText.Clear();
                titleText.Clear();
                yearPubText.Clear();
                HideErrors();
            } catch (Exception)
            {
                newBookErr.Show();
            }
        }

        private void AuthorAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string _name = nameText.Text.Trim();
                bookService.AddAuthor(_name);
                if (!lookingAtBooks)
                {
                    PopulateListBox(bookService.AllAuthors());
                }
                nameText.Clear();
                HideErrors();
            }
            catch (Exception)
            {
                newAuthErr.Show();
            }
        }

        private void MergeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var _book = bookService.AllBooks().Where(b => b.Title == bookNameText.Text).Single();
                var _author = bookService.AllAuthors().Where(a => a.Name == authorNameText.Text).Single();
                bookService.ConnectBookAndAuthor(_book, _author);
                bookNameText.Clear();
                authorNameText.Clear();
                HideErrors();
            } catch (Exception)
            {
                linkErr.Show();
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void DisplayBooksBtn_Click(object sender, EventArgs e)
        {
            bookAuthorSearchText.Clear();
            nameFilterBox.Clear();
            ResetPageCount();
            PopulateListBox(bookService.AllBooks());
        }

        private void DisplayAuthorsBtn_Click(object sender, EventArgs e)
        {
            titleFilterBox.Clear();
            ResetPageCount();
            PopulateListBox(bookService.AllAuthors());
        }

        private void BookAuthorSearchBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            PopulateListBox(bookService.BooksByAuthor(bookAuthorSearchText.Text));
        }

        private void BookYearSearchBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            PopulateListBox(bookService.BooksByYear(decimal.ToInt32(bookYearSearchInt.Value)));
        }

        private void LeastFavBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            PopulateListBox(bookService.LeastFavouriteBooks());
        }

        private void TopRatedBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            PopulateListBox(bookService.MostFavouriteBooks(Convert.ToInt32(topRatedNumber.Value)));
        }

        private void BetweenYearsBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            PopulateListBox(bookService.BooksBetweenYears(Convert.ToInt32(minYears.Value),Convert.ToInt32(maxYears.Value)));
        }

        private void SaveBtn_Click(object sender, EventArgs e) => SaveFile(".txt");
        private void SaveCsvBtn_Click(object sender, EventArgs e) => SaveFile(".csv");
        private void SaveXmlBtn_Click(object sender, EventArgs e) => SaveFile(".xml");
        private void SaveFile(string extension)
        {
            try
            {
                if (lookingAtBooks)
                {
                    List<Book> newList = bookService.AllBooks().Where(b => listBox.Items.Contains(b.Title)).ToList();
                    WriteToFile<Book>.WriteToTextFile(newList, extension, fileSaveBox.Text);
                }
                else
                {
                    List<Author> newList = bookService.AllAuthors().Where(a => listBox.Items.Contains(a.Name)).ToList();
                    WriteToFile<Author>.WriteToTextFile(newList, extension, fileSaveBox.Text);
                }
                saveDataErr.Visible = false;
            }
            catch (Exception ex)
            {
                saveDataErr.Visible = true;
            }
        }
        private void DescendingBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            if (lookingAtBooks)
            {
                PopulateListBox(bookService.OrderDescBooks());
            }
            else
            {
                PopulateListBox(bookService.OrderDescAuthors());
            }
        }

        private void AscendingBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            if (lookingAtBooks)
            {
                PopulateListBox(bookService.OrderBooks());
            }
            else
            {
                PopulateListBox(bookService.OrderAuthors());
            }
        }

        private void ResetSearchBtn_Click(object sender, EventArgs e)
        {
            ResetPageCount();
            if (lookingAtBooks)
            {
                PopulateListBox(bookService.ResetBooks());
            }
            else
            {
                PopulateListBox(bookService.ResetAuthors());
            }
        }

        private void LoadCsvBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ResetPageCount();
                bookService.LoadData(fileLoadBox.Text);
                PopulateListBox(bookService.AllBooks());
                loadDataErr.Visible = false;
            }
            catch (Exception ex)
            {
                loadDataErr.Visible = true;
            }
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.YearOfPublication <= pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating <= RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes <= VotesFilterbox.Value));
            }
        }

        private void Filter2Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.YearOfPublication >= pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating >= RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes >= VotesFilterbox.Value));
            }
        }

        private void Filter3Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.YearOfPublication == pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating == RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes == VotesFilterbox.Value));
            }
            else if (radioISBN.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.ISBN == isbnFilterBox.Text));
            }
            else if (radioName.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.Authors.Any(b => b.Name == nameFilterBox.Text)));
            }
            else if (radioTitle.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.Title == titleFilterBox.Text));
            }
        }

        private void Filter4Btn_Click(object sender, EventArgs e)
        {
            if (radioPubYear.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.YearOfPublication != pubYearFilterBox.Value));
            }
            else if (radioRating.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => (decimal)a.Rating != RatingFilterBox.Value));
            }
            else if (radioVotes.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.NumberOfUserVotes != VotesFilterbox.Value));
            }
            else if (radioISBN.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.ISBN != isbnFilterBox.Text));
            }
            else if (radioName.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.Authors.Any(b => b.Name != nameFilterBox.Text)));
            }
            else if (radioTitle.Checked)
            {
                ResetPageCount();
                PopulateListBox(bookService.FilterBooksBy(a => a.Title != titleFilterBox.Text));
            }
        }
        
        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            if (radioISBN.Checked || radioName.Checked || radioTitle.Checked)
            {
                filterBtn.Enabled = false;
                filter2Btn.Enabled = false;
            }
            else
            {
                filterBtn.Enabled = true;
                filter2Btn.Enabled = true;
            }
        }
        private void LeftBtn_Click(object sender, EventArgs e)
        {
            page--;
            if (lookingAtBooks)
            {
                PopulateListBox(bookService.AllBooks());
            }
            else
            {
                PopulateListBox(bookService.AllAuthors());
            }
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            page++;
            if (lookingAtBooks)
            {
                PopulateListBox(bookService.AllBooks());
            }
            else
            {
                PopulateListBox(bookService.AllAuthors());
            }
        }
    }
}
