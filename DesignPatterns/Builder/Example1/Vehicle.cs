using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Builder.Example1
{
    public class Vehicle
    {
        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Debug.WriteLine("\n---------------------------");
            Debug.WriteLine($"Vehicle Type: {_vehicleType}");
            Debug.WriteLine($" Frame : {_parts["frame"]}" );
            Debug.WriteLine($" Engine : {_parts["engine"]}");
            Debug.WriteLine($" #Wheels: {_parts["wheels"]}");
            Debug.WriteLine($" #Doors : {_parts["doors"]}");
        }
    }
}
