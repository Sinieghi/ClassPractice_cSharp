using System;
using System.Globalization;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.Console.WriteLine("File path: ");

            string path = @"E:\DOC\c#OOP\file_bridge\in3.csv";
            List<Employee> ls = [];
            using StreamReader sr = File.OpenText(path);
            while (!sr.EndOfStream)
            {
                string[] str = sr.ReadLine().Split(",");
                ls.Add(new Employee(str[0], str[1], double.Parse(str[2], CultureInfo.InvariantCulture)));
            }
            System.Console.WriteLine("Enter a floor value to search: ");
            double avg = double.Parse(Console.ReadLine());

            var names =
             from p in ls
             where p.Salary < avg
             orderby p.Email descending
             select p.Email;

            System.Console.WriteLine(names);

            foreach (string n in names)
            {
                System.Console.WriteLine(n);
            }

            System.Console.WriteLine("Sum of all selected salaries with an initial M: ");

            var salaries =
             from p in ls
             where p.Name?[0] == 'M'
             select p.Salary;

            double? sumS = 0;
            foreach (double s in salaries)
            {
                sumS += s;
            }

            System.Console.WriteLine(sumS);

        }
    }
}