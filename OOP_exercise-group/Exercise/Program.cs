using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\DOC\c#OOP\file_bridge\student_id.txt";
            HashSet<int> setA = [];
            HashSet<int> setB = [];
            HashSet<int> setC = [];
            using StreamReader sr = File.OpenText(path);
            int k = -1;
            int d = 0;
            while (!sr.EndOfStream)
            {
                int u = 0;
                string f = sr.ReadLine();
                if (f == "Room A")
                {
                    u = 1;
                    k = 0;
                };
                if (f == "Room B")
                {
                    d = 0;
                    u = 1;
                    k = 1;
                };
                if (f == "Room C")
                {
                    d = 0;
                    u = 1;
                    k = 2;
                };

                if (u == 0)
                {
                    int v = int.Parse(f);
                    if (k == 0) setA.Add(v);
                    if (k == 1) setB.Add(v);
                    if (k == 2) setC.Add(v);

                    d++;
                }

            }
            HashSet<int> allSet = new(setA);
            allSet.UnionWith(setB);
            allSet.UnionWith(setC);
            System.Console.WriteLine(allSet.Count);
            // for (int i = 0; i < ids.Length; i++)
            // {
            //     if (ids.Length / 3 <= i) roomA[i] = ids[i];
            //     else if (ids.Length / 2 <= i) roomB[i] = ids[i];
            //     else roomC[i] = ids[i];
            // }

            // System.Console.WriteLine(roomA.Length);
            // System.Console.WriteLine(roomB.Length);
            // System.Console.WriteLine(roomC.Length);

        }
    }
}