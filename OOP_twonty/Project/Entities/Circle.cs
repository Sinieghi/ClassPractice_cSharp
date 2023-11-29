using System;

namespace Practice
{
    class Circle(Color color, double radius) : Shape(color)
    {
        public double Radius { get; set; } = radius;

        public override double CalcArea()
        {
            return 2 * 3.14 * Radius;
        }
    }
}