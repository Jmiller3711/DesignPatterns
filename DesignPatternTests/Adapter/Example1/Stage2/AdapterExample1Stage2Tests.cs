using DesignPatterns.Adapter.Example1.Stage1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Adapter.Example1.Stage2
{
    [TestClass]
    public class AdapterExample1Stage1Tests
    {
        [TestMethod]
        public void AdapterExample1Stage1Test()
        {
            //We have a hole of diameter 12
            var roundHole = new RoundHole(6);

            //We have a peg with diameter 10
            var roundPeg = new RoundPeg(5);

            //Now let's see if round peg can fit in the round hole
            var fits1 = roundHole.Fits(roundPeg);
            Assert.IsTrue(fits1);

            var squarePeg = new SquarePeg(5);
            //var fits2 = roundHole.Fits(squarePeg); //Here is the problem, we also have a square peg, but we can not check to see if this can fit in our round hole
        }
    }
}
