namespace InterfacesPractice
{
    class RentalServices(double pricePerHour, double pricePerDay, ITaxServices taxServices)
    {
        public double PricePerHour { get; private set; } = pricePerHour;
        public double PricePerDay { get; private set; } = pricePerDay;
        private ITaxServices _taxService = taxServices;
        public void ProcessInvoices(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new(basicPayment, tax);
        }
    }

}