using System;

namespace Practice
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }

}