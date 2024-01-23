using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Shape shape1 = new Circle() { Radius = 3.0, Color = Color.White };
            // Shape shape2 = new Rectangle() { Width = 5, Height = 4, Color = Color.Black };
            AbstractShape shape1 = new Circle() { Radius = 3.0, Color = Color.White };
            AbstractShape shape2 = new Rectangle() { Width = 5, Height = 4, Color = Color.Black };
            System.Console.WriteLine(shape1);
            System.Console.WriteLine(shape2);
        }
    }

}