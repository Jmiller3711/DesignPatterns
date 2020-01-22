namespace DesignPatterns.Factory.Example1
{
    public class Cooling : IAirConditioner
    {
        private readonly double _temperature;

        public Cooling(double temperature)
        {
            _temperature = temperature;
        }

        public string Operate()
        {
            return $"Cooling the room to the required temperature of {_temperature} degrees";
        }
    }
}
