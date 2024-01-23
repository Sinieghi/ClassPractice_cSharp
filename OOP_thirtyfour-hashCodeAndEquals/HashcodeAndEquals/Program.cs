using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new() { Name = "Larissa", Email = "la@gmail.com" };
            Client b = new() { Name = "Luiz", Email = "lg@gmail.com" };
            System.Console.WriteLine(a.Equals(b));
            System.Console.WriteLine(a.GetHashCode());
            System.Console.WriteLine(b.GetHashCode());
        }
    }
}