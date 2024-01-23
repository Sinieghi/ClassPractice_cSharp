using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Prod> set = [];

            set.Add(new Prod("Phone", 9000));
            set.Add(new Prod("PC", 20000));

            Prod prod = new("Phone", 9000);

            //false because the memory address is not equals 
            // System.Console.WriteLine(set.Contains(prod));

            //But with HashCode you can actually find based on hashValue
            //Prod GetHashCode and Equals make this be true, because
            //hash and equals does not care about memory address
            System.Console.WriteLine(set.Contains(prod));

            //This Point bring a new type "struct", and basically
            //struct is just content, they don't have reference to point
            //So you don't need GetHashCode and Equals methods to check
            //if a value from a instance A is equal to values from instance B 
            HashSet<Point> c = [];

            c.Add(new Point(3, 5));
            c.Add(new Point(9, 11));

            Point p = new(3, 5);

            System.Console.WriteLine(c.Contains(p));

            // set.Add("Luiz");
            // set.Add("Why");
        }
    }
}