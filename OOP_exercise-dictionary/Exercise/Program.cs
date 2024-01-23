using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\DOC\c#OOP\file_bridge\in2.txt";
            try
            {
                Dictionary<string, int> keys = [];
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    int k = -1;
                    string sr1 = "";
                    string sr2 = "";
                    string? fStr = sr.ReadLine();
                    for (int i = 0; i < fStr?.Length; i++)
                    {
                        if (fStr[i] == ',') { k = i; i++; }
                        if (k == -1) { sr1 += fStr[i]; }
                        else sr2 += fStr[i];
                    }
                    keys[sr1] = int.Parse(sr2);
                }
                System.Console.WriteLine("All search results");
                foreach (KeyValuePair<string, int> k in keys)
                {
                    System.Console.WriteLine(k.Key + ": " + k.Value);
                }
                System.Console.WriteLine("total: " + keys.Count);
            }
            catch (IOException e)
            {
                System.Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}