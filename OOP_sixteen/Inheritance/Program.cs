using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Account ac = new(1000, "Luiz", 20);
            BusinessAccount bac = new(10000, "Ana", 0.0, 6699);


            //upcast
            Account ac0 = new SavingsAccount(106, "Alex", 500, 0.02);
            ac.Withdraw(5);
            ac0.Withdraw(200);
            Console.WriteLine(ac.Balance);
            Console.WriteLine(ac0.Balance);
            Account ac1 = bac;
            Account ac2 = new BusinessAccount(1166, "Junior", 0.0, 230);
            Account ac3 = new SavingsAccount(1002, "Joao", 0.0, 0.00);
            //downcast
            BusinessAccount acc4 = (BusinessAccount)ac2;
            acc4.Loan(200);

            if (ac3 is BusinessAccount)
            {
                BusinessAccount ac5 = (BusinessAccount)ac3;
                ac5.Loan(205);
            }
            if (ac3 is SavingsAccount)
            {
                SavingsAccount ac5 = (SavingsAccount)ac3;
                //ou 
                SavingsAccount ac6 = ac3 as SavingsAccount;
                ac5.updateBalance();

                ac6.updateBalance();
            }
        }
    }
}