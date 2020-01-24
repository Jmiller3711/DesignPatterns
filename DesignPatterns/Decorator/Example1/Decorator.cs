using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Example1
{
    public class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }
}
