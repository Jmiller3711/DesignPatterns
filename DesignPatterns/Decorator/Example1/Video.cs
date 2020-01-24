using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Decorator.Example1
{
    public class Video : LibraryItem
    {
        private readonly string _director;
        private readonly string _title;
        private readonly int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            _director = director;
            _title = title;
            _playTime = playTime;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Debug.WriteLine("\nVideo ----- ");
            Debug.WriteLine($" Director: {_director}");
            Debug.WriteLine($" Title: {_title}");
            Debug.WriteLine($" # Copies: {NumCopies}");
            Debug.WriteLine($" Playtime: {_playTime}\n");
        }
    }
}
