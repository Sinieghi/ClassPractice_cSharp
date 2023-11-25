namespace Exercise
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }

        public double Balance { get; protected set; }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        //virtual libera o method para ser reescrito em todos as herdeiras
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}