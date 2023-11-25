namespace Exercise
{
    //sealed remove a possibilidade de se herdar essa class
    sealed class SavingsAccount : Account
    {
        public double InterestRate { get; protected set; }



        public SavingsAccount(int number, string holder, double balance, double interestRate)
        : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public SavingsAccount(int number, string holder, double balance) : base(number, holder, balance)
        {
        }
        //com esse override voce pode usar o mesmo method da super class e reescrever na herdeira só que precisa do virtual na super
        // public override void Withdraw(double amount)
        // {
        //     Balance -= amount;
        // }
        //uma outra possibilidade é usar o base, nesse caso tu aproveita o que esta sendo executado na super
        //e adiciona mais funcionalidade ao method
        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 3;
        }
        public void updateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}