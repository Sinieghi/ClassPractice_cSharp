using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("File path: ");

            string path = @"E:\DOC\c#OOP\file_bridge\in3.txt";
            List<Prod> ls = [];
            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split(",");
                ls.Add(new Prod(str[0], double.Parse(str[1], CultureInfo.InvariantCulture)));
            }

            var avg =
            (from p in ls
             select p.Price).DefaultIfEmpty(0.0).Average();

            System.Console.WriteLine("Avg price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names =
             from p in ls
             where p.Price < avg
             orderby p.Name descending
             select p.Name;

            System.Console.WriteLine(names);

            foreach (string n in names)
            {
                System.Console.WriteLine(n);
            }

        }
    }
}