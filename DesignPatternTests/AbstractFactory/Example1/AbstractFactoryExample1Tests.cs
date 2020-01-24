using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DesignPatterns.AbstractFactory.Example1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.AbstractFactory.Example1
{
    [TestClass]
    public class AbstractFactoryExample1Tests
    {
        [TestMethod]
        public void AbstractFactporyExampleTest()
        {
            var client = new Client();

            Debug.WriteLine("Client: Testing client code with the first factory type...");
            client.ClientMethod(new ConcreteFactory1());

            Debug.WriteLine("Client: Testing client code with the second factory type...");
            client.ClientMethod(new ConcreteFactory2());
        }
    }
}
