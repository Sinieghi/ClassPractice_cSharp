using System;


namespace InterfacesPractice
{
    class CarRental(DateTime start, DateTime finish, Vehicle vehicle)
    {
        public DateTime Start { get; set; } = start;
        public DateTime Finish { get; set; } = finish;
        public Vehicle Vehicle { get; set; } = vehicle;
        public Invoice Invoice { get; set; }
    }

}