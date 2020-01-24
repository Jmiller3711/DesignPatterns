using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Example1
{
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2";
        }
    }
}
