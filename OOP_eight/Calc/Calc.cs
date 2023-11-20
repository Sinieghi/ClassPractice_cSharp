using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = Calc.Sum(6, 4, 9, 99, 55);
            int x;
            // o method vai alterar o valor dessa var sem precisar retornar um valor para substituir
            //o anterior.
            Calc.Tripe(ref f);
            Console.WriteLine(f);
            //no out ele vai iniciar essa var la dentro do method
            Calc.TripeOut(f, out x);
            Console.WriteLine(x);
        }
    }
}