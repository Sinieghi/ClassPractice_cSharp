using System.Globalization;

namespace Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department name: ");
            string dpName = Console.ReadLine();
            Console.WriteLine("Enter work data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dp = new(dpName);
            Worker wk = new(name, level, baseSalary, dp);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new(date, valuePerHour, hours);
                wk.AddContract(contract);

            }
            Console.WriteLine("Enter month and year to calculate income (MM/YYY):");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));
            Console.WriteLine("Name: " + wk.Department.Name);
            Console.WriteLine("Income for: " + monthYear + ": " + wk.Income(year, month));
        }
    }
}