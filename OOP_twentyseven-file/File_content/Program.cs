using System;
using System.IO;


//Todos esse method File, FileStream e etc.. dessa sessão precisa ser fechados manualmente
//pois a CLR não sabe e não os gerencia para conseguir fechar automaticamente para ti
//porém se instanciadas em um bloco using() elas fecharão automaticamente.
namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"E:\DOC\c#OOP\file_bridge\file1.txt";
            string targetPath = @"E:\DOC\c#OOP\file_bridge\file2.txt";

            // FileStream fs = null;
            //stream basicamente é uma sequência de dados transmitida de um file, ex:"live stream"
            //plataforma de stream twitch,Netflix e etc...  
            StreamReader sr = null;
            // StreamReader s = null;
            try
            {
                FileInfo fileInfo = new(sourcePath);
                // fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string ln in lines)
                {
                    Console.WriteLine(ln);
                }

                //fileStream

                // fs = new(sourcePath, FileMode.Open);
                // sr = new(fs);

                //Instanciando o sr e fs em 1 operação
                // sr = File.OpenText(sourcePath);
                // while (!sr.EndOfStream)
                // {
                //     string line = sr.ReadLine();
                //     Console.WriteLine(line);
                // }

                //Usando using() para fechar automaticamente Files methods
                // using FileStream f = new(sourcePath, FileMode.Open);
                // using StreamReader s = new(f);
                //ou
                using StreamReader s = File.OpenText(sourcePath);
                while (!s.EndOfStream)
                {
                    string l = s.ReadLine();
                    Console.WriteLine(l);
                }


                using StreamWriter sw = File.AppendText(targetPath);
                foreach (string le in lines)
                {
                    sw.WriteLine(le.ToUpper());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                // sr?.Close();
                // fs?.Close();
            }

        }
    }
}