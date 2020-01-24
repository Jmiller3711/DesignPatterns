using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Example1
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
