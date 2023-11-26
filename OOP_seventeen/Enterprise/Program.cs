using System;
using System.Globalization;
namespace Enterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees");
            int n = int.Parse(Console.ReadLine());
            Employee[] p = new Employee[n];

            //using list
            // List<Employee> list = [];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employ {i}");
                Console.WriteLine("Is outsourced (y/n)?");
                string Ot = Console.ReadLine();

                Console.WriteLine("Name");
                string nm = Console.ReadLine();
                Console.WriteLine("Hour");
                int hr = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour");
                double vp = double.Parse(Console.ReadLine());
                Console.WriteLine("Additional charge");
                double ac = double.Parse(Console.ReadLine());


                if (Ot == "y" || Ot == "Y")
                {
                    p[i] = new OutsourceEmployee(nm, Ot, hr, vp, ac);
                    p[i].CalcWage();
                }
                else
                {
                    p[i] = new Employee(nm, Ot, hr, vp);
                    p[i].CalcWage();
                }

            }
            int u = 0;
            n = p.Length;
            while (u < n)
            {
                Console.WriteLine("PAYMENTS: ");
                Console.WriteLine(p[u].Name + " - $" + p[u].CalcWage().ToString("F2", CultureInfo.InvariantCulture));
                u++;
            }
        }
    }
}