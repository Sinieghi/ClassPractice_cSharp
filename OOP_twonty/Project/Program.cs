using System;
using System.Globalization;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> li = [];
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape {i}");
                Console.WriteLine("Rectangle or Circle? (r/c)");
                string ch = Console.ReadLine();
                Console.WriteLine("Color (Black/Blue/Red)");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (ch == "r")
                {
                    Console.Write("Width: ");
                    double wid = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double hei = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    li.Add(new Rectangle(color, wid, hei));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    li.Add(new Circle(color, radius));
                }
            }
            int u = 0;
            while (u < n)
            {
                Console.WriteLine(li[u].CalcArea());
                u++;
            }
        }
    }
}