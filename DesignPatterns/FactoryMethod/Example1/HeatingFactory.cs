namespace DesignPatterns.Factory.Example1
{
    public class HeatingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temperature) => new Heating(temperature);
    }
}
