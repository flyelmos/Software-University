﻿namespace _5.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string IsbnNumber { get; set; }

        public double Price { get; set; }
    }
}