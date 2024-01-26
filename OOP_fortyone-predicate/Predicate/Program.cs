using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prod> list = [];
            list.Add(new Prod("Tv", 900.00));
            list.Add(new Prod("Mouse", 50.00));
            list.Add(new Prod("Tablet", 350.50));
            list.Add(new Prod("HD Case", 80.90));
            //i always prefer lambda, but for this example we using predicate
            // list.RemoveAll(pr => pr.Price >= 100.0);
            list.RemoveAll(ProductTest);
            foreach (Prod item in list)
            {
                System.Console.WriteLine(item);
            }
        }
        public static bool ProductTest(Prod pr)
        {
            return pr.Price >= 100.0;
        }
    }
}