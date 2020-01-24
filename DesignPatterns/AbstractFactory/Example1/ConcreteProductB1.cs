﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory.Example1
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B1";
        }

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();
            return $"The result of the B1 collaborating with the ({result})";
        }
    }
}
