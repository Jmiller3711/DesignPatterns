using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Builder.Blueprint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Builder.Blueprint
{
    [TestClass]
    public class BuilderBlueprintTests
    {
        [TestMethod]
        public void BuilderBlueprintTest()
        {
            var main = new MainApp();
            main.Main();
        }
    }
}
