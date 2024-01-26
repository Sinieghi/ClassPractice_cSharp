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

            //action basically store a void method
            // Action<Prod> action = p => { p.Price += p.Price * 0.1; };
            static void action(Prod p) { p.Price += p.Price * 0.1; }

            // Action<Prod> action = UpdatePrice;

            list.ForEach(action);

            foreach (Prod p in list)
            {
                System.Console.WriteLine(p.Price);
            }
        }

        static void UpdatePrice(Prod p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}