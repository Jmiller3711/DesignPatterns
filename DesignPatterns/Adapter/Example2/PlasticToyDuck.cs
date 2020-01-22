using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Adapter.Example2
{
    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Debug.WriteLine("Squeak");
        }
    }
}
