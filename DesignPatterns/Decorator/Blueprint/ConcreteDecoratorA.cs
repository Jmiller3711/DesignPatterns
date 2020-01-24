using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Decorator.Blueprint
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Debug.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
