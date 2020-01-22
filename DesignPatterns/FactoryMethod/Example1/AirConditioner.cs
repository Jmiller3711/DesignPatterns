using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory.Example1
{
    public class AirConditioner
    {
        private readonly Dictionary<Actions, AirConditionerFactory> _factories;

        public AirConditioner()
        {
            //option 1: pass in Action, use switch/if statement to create new factory
            

            //option 2: use a dictionary to create factory
            _factories = new Dictionary<Actions, AirConditionerFactory>
            {
                { Actions.Cooling, new CoolingFactory() },
                { Actions.Heating, new HeatingFactory() }
            };

            //option 3: use reflection
            //_factories = new Dictionary<Actions, AirConditionerFactory>();
            //foreach (Actions action in Enum.GetValues(typeof(Actions)))
            //{
            //    var factory = (AirConditionerFactory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(Actions), action) + "Factory"));
            //    _factories.Add(action, factory);
            //}
        }

        public IAirConditioner ExecuteCreation(Actions action, double temperature) => _factories[action].Create(temperature);
    }
}
