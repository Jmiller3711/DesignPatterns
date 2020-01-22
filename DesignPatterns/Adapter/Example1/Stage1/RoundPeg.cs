namespace DesignPatterns.Adapter.Example1.Stage1
{
    public class RoundPeg
    {
        private double Radius { get; } 
        public RoundPeg(double radius)
        {
            Radius = radius;
        }

        public double GetRadius()
        {
            return Radius;
        }
    }
}
