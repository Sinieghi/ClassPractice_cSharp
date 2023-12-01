namespace Bank;

public class Program
{
    public void Main(string[] args)
    {
        try
        {
            Account ac = new Account(15000);
            Console.WriteLine("Enter your account number7 ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Yor balance is {ac.Balance} ");

            Console.WriteLine("Withdraw or deposit? (w/d) ");
            string res = Console.ReadLine();
            Console.WriteLine("Amount? " + res == "w" ? "withdraw" : "deposit");

            double val = double.Parse(Console.ReadLine());

            ac.Number = num;
            if (res == "w") ac.WithDrawLimit(val);
            else ac.Deposit(val);

            Console.WriteLine($" Your balance is {ac.Balance} ");
        }
        catch (DomainException e)
        {

            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

}
