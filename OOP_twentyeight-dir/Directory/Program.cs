using System;
using System.IO;

namespace DirectoryPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            string sourcePath = @"E:\DOC\c#OOP\Dir_bridge";
            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("folders");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }
                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("folders");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(sourcePath + "/new_folder");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }
    }

}
