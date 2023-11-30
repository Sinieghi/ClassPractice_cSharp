using System;

namespace Practice

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Irs> li = [];
            Console.WriteLine("Enter the number of operation: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Operation {i}: ");
                Console.WriteLine("individual or company? (i/c)");
                string cho = Console.ReadLine();
                Console.WriteLine("Name: ");
                string nm = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double y = double.Parse(Console.ReadLine());
                if (cho == "i")
                {
                    Console.WriteLine("How much do you spend with health: ");
                    double h = double.Parse(Console.ReadLine());
                    li.Add(new PhysicalPerson(y, nm, h));
                }
                else
                {
                    Console.WriteLine("Number of employees: ");
                    int e = int.Parse(Console.ReadLine());
                    li.Add(new LegalPerson(y, nm, e));
                }

            }
            int u = 0;
            double t = 0;
            while (u < n)
            {
                Console.WriteLine("TAXES");
                Console.WriteLine($"{li[u].Name}: $ {li[u].CalcTax()}");
                t += li[u].CalcTax();

                if (u == n - 1) Console.WriteLine($"Total: {t}");
                u++;
            }
        }
    }
}