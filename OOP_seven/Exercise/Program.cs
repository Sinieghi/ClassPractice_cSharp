using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Pension p = new Pension();
            Pension[] a = new Pension[p.n];
            for (int i = 0; i < p.n; i++)
            {
                Console.WriteLine("Nome: ");
                string nm = Console.ReadLine();
                Console.WriteLine("Email: ");
                string em = Console.ReadLine();
                double r = 300;
                if (i > 0)
                    p.EmptyRoom(p.n, i, a);

                Console.WriteLine("Escolha um quarto, de 0 a 9");
                int rm = int.Parse(Console.ReadLine());

                a[rm] = new Pension { Name = nm, Email = em, Rent = r, Room = rm };

            }
        }
    }
}