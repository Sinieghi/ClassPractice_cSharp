using System;
namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products");
            int n = int.Parse(Console.ReadLine());
            Product[] pr = new Product[n];
            pr[0] = new Product("Luiz", 500);
            Console.WriteLine(pr[0].priceTag());
            string prD;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Specify the type of prod (c/u/i)");
                prD = Console.ReadLine();
                Console.WriteLine("Name");
                string nm = Console.ReadLine();
                Console.WriteLine("Price: ");
                double pic = double.Parse(Console.ReadLine());
                if (prD == "i")
                {
                    Console.WriteLine("Custom fee: ");
                    double cF = double.Parse(Console.ReadLine());
                    pr[i] = new ImportedProduct(nm, pic, cF);

                }
                else if (prD == "u")
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime cF = DateTime.Parse(Console.ReadLine());
                    pr[i] = new UserProduct(nm, pic, cF);

                }
                else
                {
                    pr[i] = new Product(nm, pic);
                }
                if (i == n - 1)
                {
                    int e = 0;
                    while (e < n)
                    {
                        Console.WriteLine("Price tags");
                        Console.WriteLine();
                        Console.WriteLine(pr[e].Name + " " + pr[e].priceTag());
                        e++;
                    }
                }
            }

        }
    }

}
