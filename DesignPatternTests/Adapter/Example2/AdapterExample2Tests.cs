using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DesignPatterns.Adapter.Example2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTests.Adapter.Example2
{
    [TestClass]
    public class AdapterExample2Tests
    {
        [TestMethod]
        public void AdapterExample2Test()
        {
            //Create a Sparrow : IBird
            Debug.WriteLine("Sparrow...");
            var sparrow = new Sparrow();
            sparrow.Fly();
            sparrow.MakeSound();

            //Create a PlasticToyDuck : IToyDuck
            Debug.WriteLine("PlasticToyDuck...");
            var plasticToyDuck = new PlasticToyDuck();
            plasticToyDuck.Squeak();

            // Wrap a bird in a birdAdapter so that it  behaves like a toy duck
            var birdAdapter = new BirdAdapter(sparrow);

            // toy duck behaving like a bird  
            Debug.WriteLine("BirdAdapter...");
            birdAdapter.Squeak();
        }
    }
}
