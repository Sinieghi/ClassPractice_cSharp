using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //data source

            int[] num = [1, 2, 3, 8, 4, 6, 4, 6, 5, 61, 2];

            //query expression
            IEnumerable<int> res = num.Where(p => p % 2 == 0).Select(p => p * 10);

            //

            foreach (int item in res)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}