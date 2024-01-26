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

            // Func<Prod, string> func = (p)=>p.Name.ToUpper();
            static string func(Prod p) => p.Name.ToUpper();

            List<string> res = list.Select(func).ToList();

            foreach (string item in res)
            {
                System.Console.WriteLine(item);
            }
        }
        // static string Upper(Prod p)
        // {
        //     return p.Name.ToUpper();
        // }
    }
}