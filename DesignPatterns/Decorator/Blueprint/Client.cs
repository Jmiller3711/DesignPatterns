using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorator.Blueprint
{
    public class Client
    {
        public void Main()
        {
            //Create ConcreteComponent and two Decorators
            var c = new ConcreteComponent(); //inherits Component. Operation() outputs "ConcreteComponent.Operation()"
            var decoratorA = new ConcreteDecoratorA(); //inherits Decorator. Decorator inherits Component. Operation() outputs "ConcreteDecoratorA.Operation()"
            var decoratorB = new ConcreteDecoratorB(); //inherits Decorator. Decorator inherits Component. Operation() outputs "ConcreteDecoratorB.Operation()"

            //Link decorators
            decoratorA.SetComponent(c); //SetComponent() is on Decorator class. 
            decoratorB.SetComponent(decoratorA); //SetComponent() is on Decorator class. 

            decoratorB.Operation();
        }
    }
}
