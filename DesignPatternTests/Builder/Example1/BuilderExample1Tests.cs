using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Builder.Example1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Builder.Example1
{
    [TestClass]
    public class BuilderExample1Tests
    {
        [TestMethod]
        public void BuilderExample1Test()
        {
            var mainApp = new MainApp();
            mainApp.Main();
        }
    }
}
