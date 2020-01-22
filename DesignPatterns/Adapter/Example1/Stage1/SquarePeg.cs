namespace DesignPatterns.Adapter.Example1.Stage1
{
    public class SquarePeg
    {
        public double Width { get; set; }

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
