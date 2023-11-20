using System;

namespace Exercise
{
    class Pension
    {


        public int n = 10;
        public double Rent { get; set; }
        public int Room { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }


        public void EmptyRoom(int n, int i, Pension[] a)
        {
            int index = 0;
            Console.WriteLine("Escolha um quarto!");
            Console.WriteLine("Quartos disponíveis");
            while (index < n)
            {
                if (a[index] == null)
                    Console.WriteLine($"quarto {index}");
                else Console.WriteLine("ocupado");
                index++;
            }

        }

        public static implicit operator Pension(string v)
        {
            throw new NotImplementedException();
        }
    }
}