using System;
using System.Globalization;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            double[] array = new double[n];
            while (i < n)
            {
                array[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                i++;
            }
            double sum = 0.0;
            i = 0;
            while (i < n)
            {
                sum += array[i];
                i++;
            }
            Console.WriteLine(sum / n);
        }
    }

}