using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DesignPatterns.Decorator.Blueprint
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Debug.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
        }
    }
}
