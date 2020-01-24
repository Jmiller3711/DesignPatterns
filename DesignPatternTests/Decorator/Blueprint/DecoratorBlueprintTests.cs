using DesignPatterns.Decorator.Blueprint;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Decorator.Blueprint
{
    [TestClass]
    public class DecoratorBlueprintTests
    {
        [TestMethod]
        public void DecoratorBluePrintTest()
        {
            var client = new Client();
            client.Main();
        }
    }
}
