using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Decorator.Example1;

namespace DesignPatternTests.Decorator.Example1
{
    [TestClass]
    public class DecoratorExample1Tests
    {
        [TestMethod]
        public void DecoratorExampleTest()
        {
            var mainApp = new MainApp();
            mainApp.Main();
        }
    }
}
