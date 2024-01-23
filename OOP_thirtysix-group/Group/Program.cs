using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //you could use HashSort, but will use this for faster operation
            HashSet<LogRecord> set = [];

            Console.WriteLine("Enter file path");
            string? path = Console.ReadLine();

            try
            {
                using StreamReader sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    int k = -1;
                    string s1 = "";
                    string s2 = "";
                    string l = sr.ReadLine();
                    for (int i = 0; i < l.Length; i++)
                    {
                        if (l[i] == ' ') { i++; k = i; }
                        if (k == -1) { s1 += l[i]; }
                        else s2 += l[i];
                    }

                    DateTime date = DateTime.Parse(s2);
                    set.Add(new LogRecord { Name = s1, Instant = date });

                }

                Console.WriteLine(set.Count);

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }
}