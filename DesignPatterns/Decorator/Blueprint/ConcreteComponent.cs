using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Decorator.Blueprint
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Debug.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
