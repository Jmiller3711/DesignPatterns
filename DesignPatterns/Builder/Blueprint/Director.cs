using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder.Blueprint
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
