using System;
namespace Practice
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Room number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd/MM/yyyy)");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-out date (dd/MM/yyyy)");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(num, checkIn, checkOut);
                Console.WriteLine("Reservation: " + res);

            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}