using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de items");
            int n = int.Parse(Console.ReadLine());
            Product[] a = new Product[n];
            int i = 0;
            while (i < n)
            {
                Console.WriteLine("Valor do item");
                double p = double.Parse(Console.ReadLine());
                Console.WriteLine("Nome do item");
                string nm = Console.ReadLine();
                a[i] = new Product { Name = nm, Price = p };
                i++;
            }
            i = 0;
            double sum = 0;
            while (i < n)
            {
                sum += a[i].Price;
                i++;
            }
            Console.WriteLine(sum / n);
        }
    }
}