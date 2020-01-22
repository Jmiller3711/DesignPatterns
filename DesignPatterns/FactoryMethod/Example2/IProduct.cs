using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.Example2
{
    // The Product interface declares the operations that all concrete products
    // must implement.
    public interface IProduct
    {
        string Operation();
    }
}
