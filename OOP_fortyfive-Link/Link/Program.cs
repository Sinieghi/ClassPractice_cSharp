using System;

namespace Practice
{
    class Program
    {
        static void Print<T>(string msg, IEnumerable<T> coll)
        {
            System.Console.WriteLine(msg);

            foreach (T ob in coll)
            {
                System.Console.WriteLine(ob);

            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new() { Id = 1, Name = "Tools", Tier = 3 };
            Category c2 = new() { Id = 2, Name = "PC", Tier = 1 };
            Category c3 = new() { Id = 3, Name = "Phone", Tier = 2 };

            List<Prod> prods = [
                new Prod() { Id = 1, Category = c1, Name = "Chainsaw", Price = 2000.0 },
                new Prod() { Id = 2, Category = c2, Name = "Alienware", Price = 3000.0 },
                new Prod() { Id = 4, Category = c3, Name = "Iphone", Price = 1000.0 },
                new Prod() { Id = 5, Category = c1, Name = "Pincel", Price = 50.0 },
                new Prod() { Id = 6, Category = c2, Name = "Logitech", Price = 600.0 },
                new Prod() { Id = 7, Category = c2, Name = "Hyper", Price = 600.0 },
                ];

            // var r1 = prods.Where(x => x.Price > 900 && x.Category?.Tier == 3);
            //using SQL notation
            var r1 =
             from p in prods
             where p.Category?.Tier == 3 && p.Price < 900
             select p;

            // var r2 = prods.Where(x => x.Category?.Name == "Tools").Select(p => p.Name);
            var r2 =
             from p in prods
             where p.Category?.Name == "Tools"
             select p.Name;


            // var r3 = prods.Where(x => x.Name?[0] == 'H').Select(p => p.Name);
            var r3 =
             from p in prods
             where p.Name?[0] == 'H'
             select new
             {
                 p.Name,
                 p.Price,
                 CategoryName = p.Category?.Name
             };

            // var r4 = prods.Where(x => x.Category?.Tier == 1).OrderBy(p => p.Price).ThenBy(n => n.Name);
            var r4 =
             from p in prods
             where p.Category?.Tier == 1
             orderby p.Name
             orderby p.Price
             select p;

            // var r5 = r4.Skip(2).Take(4);
            var r5 =
             (from p in r4
              select p).Skip(2).Take(4);


            // var r6 = prods.First();
            var r6 =
             (from p in prods
              select p).First();

            Print("T1 Price > 900", r1);
            Print("Tools", r2);
            Print("Starts with H", r3);
            Print("T1 price then name", r4);
            Print("T1 price then name paginated", r5);
            System.Console.WriteLine("f item" + r6);

            //returns null if not found any item instead crash
            var r7 = prods.FirstOrDefault();
            var r8 = prods.Where(p => p.Id == 3).SingleOrDefault();

            var r10 = prods.Max(p => p.Price);
            var r11 = prods.Min(p => p.Price);

            System.Console.WriteLine("Max price " + r10);
            System.Console.WriteLine("Min price " + r11);

            var r12 = prods.Where(p => p.Category?.Id == 1).Sum(p => p.Price);
            System.Console.WriteLine("Category 1 sum prices: " + r12);
            var r13 = prods.Where(p => p.Category?.Id == 1).Average(p => p.Price);
            System.Console.WriteLine("Category 1 Average prices: " + r13);
            //avoiding crash on average operator
            var r14 = prods.Where(p => p.Category?.Id == 10).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            System.Console.WriteLine(r14);

            //aggregate is the same as reduce on js, unfortunately i normally don't use built in methods
            var r15 = prods.Where(p => p.Category?.Id == 1).Select(p => p.Price)
            //first arg is to avoid crash, but be aware of declarations double, string and etc...
            .Aggregate(0.0, (x, y) => x + y);
            System.Console.WriteLine(r15);

            // var r16 = prods.GroupBy(p => p.Category);
            var r16 =
             from p in prods
             group p by p.Category;


            foreach (IGrouping<Category, Prod> g in r16)
            {
                System.Console.WriteLine(g.Key.Name + ": ");
                foreach (Prod p in g)
                {
                    System.Console.WriteLine(p);
                }
                System.Console.WriteLine();
            }

        }
    }
}