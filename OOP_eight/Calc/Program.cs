using System;

namespace Exercise
{
    class Calc
    {
        //o out ele pode iniciar o var
        public static void TripeOut(int a, out int x)
        {
            x = a * 3;
        }
        //Esse ref cria uma ref do param na memoria, basicamente voce pode alterar o valor
        //desse param e ele vai alterar o valor da var que lhe o representa na invocação do method
        public static void Tripe(ref int x)
        {
            x = x * 3;
        }
        public static int Sum(params int[] numbers)
        {
            int i = 0;
            int sum = 0;
            while (i < numbers.Length)
            {
                sum += numbers[i];
                i++;
            }

            return sum;
        }
    }
}