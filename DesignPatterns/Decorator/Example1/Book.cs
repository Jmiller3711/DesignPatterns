using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Decorator.Example1
{
    public class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Debug.WriteLine("\nBook ------ ");
            Debug.WriteLine($" Author: {_author}");
            Debug.WriteLine($" Title: {_title}");
            Debug.WriteLine($" # Copies: {NumCopies}\n");
        }
    }
}
