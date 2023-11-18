using System;
using System.Globalization;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entre o valor: ");
            double ray = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //usando static funciona igual ao jS
            double circ = Calc.Circumference(ray);
            double vol = Calc.Volume(ray);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

    }
}