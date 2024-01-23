using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"E:\DOC\c#OOP\file_bridge\file3.txt";

            try
            {
                using StreamReader sr = File.OpenText(path);
                List<Employee> list = [];
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }
                list.Sort();
                foreach (Employee e in list)
                {
                    System.Console.WriteLine(e);
                }
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
                throw e;
            }

        }
    }
}