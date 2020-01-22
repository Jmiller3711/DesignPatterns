namespace DesignPatterns.Adapter.Example1.Stage2
{
    public class SquarePeg
    {
        private double Width { get; set; }

        public SquarePeg(double width)
        {
            Width = width;
        }

        public double GetWidth()
        {
            return Width;
        }
    }
}
