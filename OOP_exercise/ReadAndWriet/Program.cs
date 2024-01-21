using System;
using System.Globalization;
using System.IO;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\DOC\c#OOP\file_bridge\exercise1.txt";
            string targetPath = @"E:\DOC\c#OOP\file_bridge\exercise2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath);
                string prodName = "";
                string pp = "";
                string pq = "";
                double finalPrice = 0;
                for (int i = 0; i < lines.Length; i++)
                {
                    int count = 0;
                    for (int u = 0; u < lines[i].Length; u++)
                    {
                        if (lines[i][u] == ',') count++;
                        else
                        {
                            if (count == 0) prodName += lines[i][u];
                            if (count == 1) pp += lines[i][u];
                            if (count == 2) pq += lines[i][u];
                        }
                    }

                    double prodPrice = double.Parse(pp, CultureInfo.InvariantCulture);
                    int prodQtn = int.Parse(pq);
                    Console.WriteLine(pp);
                    Console.WriteLine(pq);
                    pp = "";
                    pq = "";
                    finalPrice = prodPrice * prodQtn;
                    Console.WriteLine(finalPrice);
                    using StreamWriter sr = File.AppendText(targetPath);
                    sr.WriteLine(prodName + ", " + finalPrice);
                    prodName = "";
                }



            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}