using System;

namespace Practice
{
    delegate double BinaryNumOperation(double n1, double n2);
    delegate void BinaryNumOperationMulticast(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 15;

            //Basically delegate is a reference to function with type safety
            //that means the way you declare matter when you point to some
            //function, you can't store any function that diverges from the
            //initial delegates declaration, like in this example he can story only
            //methods that returns a double and accept 2 double as an argument 
            BinaryNumOperation op = CalculationService.Sum;

            //Multi casting on delegates, it's useful if you return void is recommended actually
            //but you probably can do cool things returning something  
            BinaryNumOperationMulticast opm = CalculationService.ShowSum;
            opm += CalculationService.ShowMax;
            opm(a, b);
            double result = op(a, b);
            System.Console.WriteLine(result);

        }
    }
}