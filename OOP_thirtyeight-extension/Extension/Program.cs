using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new(2024, 01, 22, 16, 50, 10);
            System.Console.WriteLine(dt.ElapsedTime());

            string str = "Good morning for you";
            System.Console.WriteLine(str.Cut(4));
        }
    }
}