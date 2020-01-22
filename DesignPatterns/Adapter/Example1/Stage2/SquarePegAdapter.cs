using System;
namespace DesignPatterns.Adapter.Example1.Stage2
{
    public class SquarePegAdapter : RoundPeg
    {
        private SquarePeg _peg;

        public SquarePegAdapter(SquarePeg peg) : base(peg.GetWidth() * Math.Sqrt(2) / 2)
        {
            _peg = peg;
        }
    }
}
