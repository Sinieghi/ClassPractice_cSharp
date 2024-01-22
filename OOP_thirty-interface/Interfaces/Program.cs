using System;
using System.Globalization;
using System.IO;

namespace InterfacesPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car model");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new(start, finish, new Vehicle(model));

            //BrasilTaxServices está realizando um upcast na ITaxServices
            RentalServices rentalServices = new(hour, day, new BrasilTaxServices());

            rentalServices.ProcessInvoices(carRental);

            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }

}