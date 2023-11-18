using System;
using System.Globalization;
namespace Practice
{
    class Calc
    {
        public static double Pi = 3.14;
        public static double Circumference(double ray)
        {
            return 2.0 * Pi * ray;
        }
        public static double Volume(double ray)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(ray, 3.0);
        }
    }
}