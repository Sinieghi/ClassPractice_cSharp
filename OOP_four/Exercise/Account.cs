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
        private int _accountNum;
        private double _balance = 0;
        public string _password;
        public string Password
        {
            private get
            {
                return _password;
            }
            set
            {
                if (value.Length != 4)
                {

                    Console.WriteLine("A senha precisa ter 4 dígitos");
                    return;
                }
                else
                    _password = value;
            }
        }
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
        public int AccountNum
        {
            get
            {

                return _accountNum;
            }
            set
            {
                if (value.ToString().Length != 4)
                {
                    Console.WriteLine("Numero da conta precisa ter 4 dígitos");
                    return;
                }
                else
                    _accountNum = value;
            }
        }


    }
}