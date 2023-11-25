
using System;

namespace Exercise
{
    class BusinessAccount(int number, string holder, double balance, double loansLimit) : Account(number, holder, balance)
    {
        public double LoanLimit { get; set; } = loansLimit;

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
                Balance += amount;
        }
    }
}