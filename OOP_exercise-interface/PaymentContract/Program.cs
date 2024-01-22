using System;
using System.Globalization;

namespace PaymentContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");
            Console.Write("Number: ");
            int n = int.Parse(Console.ReadLine());
            //
            Console.Write("Date(dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //
            Console.Write("Contract value: ");
            double price = double.Parse(Console.ReadLine());
            //
            Console.Write("Enter number of installments: ");
            int inst = int.Parse(Console.ReadLine());
            //
            Contract contract = new(n, date, price);
            ContractService contractService = new(new PaypalService());
            contractService.ProcessContract(contract, inst);

            Console.Write("Installments: ");

            for (int i = 0; i < contract.InstallmentsLi.Count; i++)
            {
                Installments installment = contract.InstallmentsLi[i];
                Console.WriteLine(installment);
            }

        }
    }

}