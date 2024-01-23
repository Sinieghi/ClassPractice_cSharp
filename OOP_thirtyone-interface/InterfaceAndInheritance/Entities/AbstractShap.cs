using System;
using System.Globalization;

namespace Practice
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }

}