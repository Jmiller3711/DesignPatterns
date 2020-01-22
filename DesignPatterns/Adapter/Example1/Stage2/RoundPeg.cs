namespace DesignPatterns.Adapter.Example1.Stage2
{
    public class RoundPeg
    {
        private double Radius { get; set; } 
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
