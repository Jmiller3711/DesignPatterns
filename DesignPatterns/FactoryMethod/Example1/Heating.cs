namespace DesignPatterns.Factory.Example1
{
    public class Heating : IAirConditioner
    {
        private readonly double _temperature;

        public Heating(double temperature)
        {
            _temperature = temperature;
        }

        public string Operate()
        {
            return $"Heating the room to the required temperature of {_temperature} degrees";
        }
    }
}
