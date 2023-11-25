namespace Proj
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hour { get; set; }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            Hour = hours;
            ValuePerHour = valuePerHour;
        }
        public HourContract() { }

        public double TotalValue()
        {
            return Hour * ValuePerHour;
        }
    }
}