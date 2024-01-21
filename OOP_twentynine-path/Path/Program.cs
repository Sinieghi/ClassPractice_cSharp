using System;
using System.IO;

namespace PathPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\DOC\c#OOP\path_bridge\server\src\app.py";
            Console.WriteLine("Dir Separate char " + Path.DirectorySeparatorChar);
            Console.WriteLine("Dir Separate " + Path.PathSeparator);
            Console.WriteLine("Dir name " + Path.GetDirectoryName(sourcePath));
            Console.WriteLine("File name " + Path.GetFileName(sourcePath));
            Console.WriteLine("File name without ext " + Path.GetFileNameWithoutExtension(sourcePath));
            Console.WriteLine("File ext " + Path.GetExtension(sourcePath));
            Console.WriteLine("File full path " + Path.GetFullPath(sourcePath));
            Console.WriteLine("Temp path " + Path.GetTempPath());
        }
    }
}
