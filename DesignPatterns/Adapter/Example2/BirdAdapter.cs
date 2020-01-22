using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Adapter.Example2
{
    public class BirdAdapter : IToyDuck
    {
        private IBird _bird;

        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        public void Squeak()
        {
            _bird.MakeSound();
        }
    }
}
