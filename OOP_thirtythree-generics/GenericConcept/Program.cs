using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //The <F> is defined whe you cast this class with the declaration you want
            PrintService<int> printService = new();
            List<Prod> ls = [];

            System.Console.WriteLine("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vet = Console.ReadLine().Split(",");
                string nm = vet[0];
                double y = double.Parse(vet[1]);

                ls.Add(new Prod(nm, y));
                // int y = int.Parse(Console.ReadLine());
                // printService.AddValue(y);
            }
            CalculateService calculateService = new();
            Prod max = calculateService.Max(ls);

            System.Console.WriteLine("max");
            System.Console.WriteLine(max);
            // printService.Print();
            // System.Console.WriteLine("First: " + printService.First());
        }
    }
}