using System;
namespace Exercise
{
    class Client
    {
        static void Main(string[] args)
        {

            int bl;
            string Action;
            string pass;
            string nm;

            Console.WriteLine("Deseja criar uma conta ou já está registrado? ");
            Console.WriteLine("Digite 1 se sim ou 2 para não e 3 para atualizar dados cadastrais");
            int Response = int.Parse(Console.ReadLine());

            if (Response != 1 && Response != 2 && Response != 3)
            {
                Console.WriteLine("Valor inválido");
                return;
            }

            pass = PassHandler(false);
            int acN = AcNHandler();
            Account ac = new Account(pass, acN);

            if (Response == 1)
            {

                Console.WriteLine("Deseja fazer um depósito de qualquer valor ou sacar? 1 para sacar 2 para depósito ");
                bool Chose = Console.ReadLine() == "2" && true || false;
                if (Chose)
                {
                    Action = "depósito";
                    Console.WriteLine("Valo a ser depositado: ");
                    bl = int.Parse(Console.ReadLine());
                }
                else
                {
                    Action = "saque";
                    Console.WriteLine("Valo a ser sacado: ");
                    bl = -int.Parse(Console.ReadLine());
                }
                ac = new Account(pass, acN, bl);

            }
            else if (Response == 3)
            {
                Action = "atualização de dados";
                Console.WriteLine("Digite seu nome: ");
                nm = Console.ReadLine();
                Console.WriteLine("Deseja modificar a senha também? Responder sim ou não");
                bool isChange = Console.ReadLine() == "sim" && true || false;
                if (isChange)
                {
                    pass = PassHandler(true);
                }
                ac = new Account(pass, acN, nm);
            }
            else
            {
                Action = "criação de conta";
                Console.WriteLine("Informe um numero para a conta de 4 dígitos: ");
                acN = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite seu nome: ");
                nm = Console.ReadLine();
                Console.WriteLine("Agora informe um senha: ");
                pass = PassHandler(false);
                Console.WriteLine("Deseja fazer um depósito de qualquer valor? ");
                bl = int.Parse(Console.ReadLine());

                ac = new Account(pass, acN, nm, bl);
            }
            Console.WriteLine(ac.AccountNum);
            Console.WriteLine(ac.Name);
            Console.WriteLine(ac.Balance);
            NotifyUser(Action);

        }

        static void NotifyUser(string action)
        {

            // Console.WriteLine($"Pronto ação {action} realizada com sucesso");
            // if (action == "saque")
            // {

            //     Console.WriteLine($"Valor sacado {ac.Balance}");
            // }
            // else if (action == "depósito")
            // {

            //     Console.WriteLine($"{ac.Balance}");
            // }

            // Console.WriteLine($"Titular: {ac.Name} saldo conta {ac.AccountNum}");
        }

        static string PassHandler(bool isChange)
        {
            if (isChange)
            {
                Console.WriteLine("Nova senha: ");

            }
            else
            {
                Console.WriteLine("Digite sua senha: ");

            }
            string pass = Console.ReadLine().ToString();
            return pass;
        }
        static int AcNHandler()
        {
            Console.WriteLine("Informe um numero para a conta de 4 dígitos: ");
            int acN = int.Parse(Console.ReadLine());
            return acN;
        }

    }
}