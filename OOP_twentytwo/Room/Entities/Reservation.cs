using System;
namespace Practice
{
    class Reservation
    {
        public int RooNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkout)
        {
            if (checkout < checkIn)
            {
                throw new DomainException("Checkout date must be after check-in! ");
            }
            RooNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkout;

        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Reservation dates for update must be in future! ");
            }
            if (checkOut < checkIn)
            {
                throw new DomainException("Checkout date must be after check-in! ");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RooNumber + "check-in: "
            + CheckIn.ToString("dd/MM/yyyy") + ", check-out: "
            + CheckOut.ToString("dd/MM/yyyy") + ' ' + Duration() + " nights";
        }
    }
}