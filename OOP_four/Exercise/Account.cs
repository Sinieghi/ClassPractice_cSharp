using System;
namespace Exercise
{
    class Account
    {

        public Account(string password, int accountNum)
        {
            AccountNum = accountNum;
            Password = password;
        }

        public Account(string password, int accountNum, int balance) : this(password, accountNum)
        {
            Balance = balance;
        }

        public Account(string password, int accountNum, string name) : this(password, accountNum)
        {
            Name = name;
        }

        public Account(string password, int accountNum, string name, float balance) : this(password, accountNum)
        {
            Name = name;
            Balance = balance;
        }

        public bool IsNewAccount = false;
        public string Name { get; set; }
        public int AccountNum { get; private set; }
        private double _balance = 0;
        public string Password { private get; set; }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (_balance < 0)
                {
                    Console.WriteLine("Seu saldo está abaixo de 0");
                    return;
                }
                if (value < 0) value -= 5;
                _balance = value;
            }
        }


    }
}