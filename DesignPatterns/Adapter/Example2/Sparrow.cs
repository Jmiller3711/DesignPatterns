using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Adapter.Example2
{
    public class Sparrow : IBird
    {
        public void Fly()
        {
            Debug.WriteLine("Sparrow flying");
        }

        public void MakeSound()
        {
            Debug.WriteLine("Sparrow sound");
        }
    }
}
