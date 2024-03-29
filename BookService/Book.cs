﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookService
{
    class Book
    {
        public string ISBN { get; set; } 
        public string Title { get; set; } 
        public int YearOfPublication { get; set; } 
        public double Rating { get; set; } 
        public int NumberOfUserVotes { get; set; } 
        public ICollection<Author> Authors { get; set; } 

        public Book(string isbn, string title, int yearOfPublication, double rating, int numberOfUserVotes)
        {
            ISBN = isbn;
            Title = title;
            YearOfPublication = yearOfPublication;
            Rating = rating;
            NumberOfUserVotes = numberOfUserVotes;
            Authors = new List<Author>();
        }

        public Book()
        {
        }

        public override string ToString()
        {
            string nameTot = "";
            foreach (Author name in Authors)
            {
                nameTot += name.Name + ".\r\n";
            }
            return nameTot;
        }
    }
}
