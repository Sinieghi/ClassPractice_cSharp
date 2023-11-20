using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // double[,] mtr = new double[3, 4];
            //quantidade de linhas
            // System.Console.WriteLine(mtr.Rank);
            //quantidade de linhas
            // System.Console.WriteLine(mtr.GetLength(0));
            //quantidade de colunas
            // System.Console.WriteLine(mtr.GetLength(1));
            Console.WriteLine("Ordem da matriz: ");
            int nc = int.Parse(Console.ReadLine());

            double[,] mtr = new double[nc, nc];
            int n = 0;
            for (int i = 0; i < nc; i++)
            {
                if (n != nc)
                {

                    Console.WriteLine($"Coluna {i}");
                    int nl = int.Parse(Console.ReadLine());
                    mtr[n, i] = nl;
                    if (i == nc - 1)
                    {
                        n++;
                        i = -1;
                    }
                }
            }
            n = 0;
            while (n < nc)
            {
                Console.WriteLine(mtr[n, n]);
                n++;
            }
            n = 0;
            int x = 0;
            int b = 0;
            List<double> nVal = new List<double>() { };
            while (n < nc)
            {
                if (x != nc)
                {
                    if (mtr[x, n] < 0)
                    {
                        nVal.Add(mtr[x, n]);
                        b++;
                    }
                    if (n == nc - 1)
                    {
                        x++;
                        n = -1;
                    }
                }
                n++;
            }
            n = 0;
            while (n < nVal.Count)
            {

                Console.WriteLine(nVal);
                n++;
            }
        }
    }

}