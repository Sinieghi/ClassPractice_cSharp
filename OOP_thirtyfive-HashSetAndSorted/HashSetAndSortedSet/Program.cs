using System;
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = [];
            SortedSet<int> ints = [0, 6, 4, 922, 1, 2, 65, 6];
            SortedSet<int> ints1 = [3, 6, 4, 33, 66, 49, 8, 525];

            //union merge and ignore elements that already exist
            SortedSet<int> sm = new(ints);
            sm.UnionWith(ints1);
            PrintCollection(sm);

            //return only element that exist in both instance
            SortedSet<int> sm1 = new(ints);
            sm1.IntersectWith(ints1);
            PrintCollection(sm1);

            //difference basically use inc array to remove values
            SortedSet<int> sm3 = new(ints);
            sm3.ExceptWith(ints1);
            PrintCollection(sm3);

            set.Add("TV");
            set.Add("Phone");
            set.Add("PC");

            //this Contains method user GetHashCode then Equals to check
            //Equals is 100% efficient but is slower than GetHashCode
            //thats why normally use GetHashCode before Equals.
            //note:GetHashCode is faster than Equals but is not 100% efficient 

            System.Console.WriteLine(set.Contains("TV"));

            foreach (string st in set)
            {
                System.Console.WriteLine(st);
            }

        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {

            foreach (T col in collection)
            {
                System.Console.WriteLine(col + " ");

            }
            System.Console.WriteLine();

        }
    }
}