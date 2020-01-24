using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Builder.Blueprint
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Debug.WriteLine("\nProduct Parts -------");
            foreach (string part in _parts)
            {
                Debug.WriteLine(part);
            }
        }
    }
}
