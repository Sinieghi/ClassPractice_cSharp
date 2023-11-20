using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ls = ["Luiz", "Ana", "DUde"];

            ls.Insert(2, "Gui");
            int i = 0;
            while (i < ls.Count)
            {

                Console.WriteLine(ls[i][2]);
                i++;
            }
            // string s = ls.Find(x => x[0] == "L");
            // string s = ls.FindAll(x => x.Length == 5);
            // string s = ls.RemoveAt(x => x.Length == 5);
            // string s = ls.Remove(x => x.Length == 5);
            // string s = ls.RemoveAll(5);
            // string s = ls.RemoveRange(2,2);
        }
    }
}