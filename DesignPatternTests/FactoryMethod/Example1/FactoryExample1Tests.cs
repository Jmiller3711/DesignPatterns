using DesignPatterns.Factory.Example1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Factory.Example1
{
    [TestClass]
    public class FactoryExample1Tests
    {
        [TestMethod]
        public void CoolingTest()
        {
            var temperature = 65;
            var action = Actions.Cooling;
            var factory = new AirConditioner().ExecuteCreation(action, temperature);
            var message = factory.Operate();
            Assert.AreEqual(message, $"{action.ToString()} the room to the required temperature of {temperature} degrees");
        }

        [TestMethod]
        public void HeatingTest()
        {
            var temperature = 74;
            var action = Actions.Heating;
            var factory = new AirConditioner().ExecuteCreation(action, temperature);
            var message = factory.Operate();
            Assert.AreEqual(message, $"{action.ToString()} the room to the required temperature of {temperature} degrees");
        }
    }
}
