using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Example1
{
    public class Shop
    {
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }
}
