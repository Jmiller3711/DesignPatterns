using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.FactoryMethod.Example2;


namespace DesignPatternTests.FactoryMethod.Example2
{
    [TestClass]
    public class FactoryMethodExample2Tests
    {
        [TestMethod]
        public void FactoryMethodExample2Test()
        {
            var client = new Client();

            var creator1 = client.ClientCode(new ConcreteCreator1());
            Assert.AreEqual(creator1, "Creator: The same creator's code has just worked with result of ConcreteProduct1");

            var creator2 = client.ClientCode(new ConcreteCreator2());
            Assert.AreEqual(creator2, "Creator: The same creator's code has just worked with result of ConcreteProduct2");
        }
    }
}
