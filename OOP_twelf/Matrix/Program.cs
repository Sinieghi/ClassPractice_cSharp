using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Order of this matrix: ");
            int nc = int.Parse(Console.ReadLine());
            int nl = int.Parse(Console.ReadLine());
            double[,] mtr = new double[nl, nc];
            int n = 0;
            for (int i = 0; i < nl; i++)
            {
                int b = 0;
                while (b < nc)
                {
                    mtr[i, b] = int.Parse(Console.ReadLine());
                    b++;
                }
            }
            n = 0;
            // user choose which number he's want
            for (int i = 0; i < nl; i++)
            {
                int b = 0;
                while (b < nc)
                {
                    Console.Write(mtr[i, b] + " ");
                    b++;
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Chose a number inside of this matrix:");
            int k = int.Parse(Console.ReadLine());


            for (int i = 0; i < nl; i++)
            {
                n = 0;
                while (n < nc)
                {
                    if (mtr[i, n] == k)
                    {
                        Console.WriteLine("");
                        Console.WriteLine($"Position line {i} column {n}");
                        Console.WriteLine(n - 1 < 0 ? "" : $"Left {mtr[i, n - 1]}");
                        Console.WriteLine(n + 1 > nc - 1 ? "" : $"Right {mtr[i, n + 1]}");
                        Console.WriteLine(i - 1 < 0 ? "" : $"Top {mtr[i - 1, n]}");
                        Console.WriteLine(i + 1 > nl - 1 ? "" : $"Bottom {mtr[i + 1, n]}");
                        return;
                    }
                    n++;
                }

            }
        }
    }
}