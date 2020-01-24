using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.AbstractFactory.Example1
{
    public class Client
    {
        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Debug.WriteLine(productB.UsefulFunctionB());
            Debug.Write(productB.AnotherUsefulFunctionB(productA));
        }
    }
}
