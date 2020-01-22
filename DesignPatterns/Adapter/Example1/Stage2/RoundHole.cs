namespace DesignPatterns.Adapter.Example1.Stage2
{
    public class RoundHole
    {
        private double Radius { get; }

        public RoundHole(double radius)
        {
            Radius = radius;
        }

        public double GetRadius()
        {
            return Radius;
        }

        public bool Fits(RoundPeg roundPeg)
        {
            return this.GetRadius() >= roundPeg.GetRadius();
        }
    }
}
