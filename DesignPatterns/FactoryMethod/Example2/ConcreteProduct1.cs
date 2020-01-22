using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethod.Example2
{
    // Concrete Products provide various implementations of the Product
    // interface.
    class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "result of ConcreteProduct1";
        }
    }
}
