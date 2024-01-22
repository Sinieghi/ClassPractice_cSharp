
using System.Globalization;

namespace PaymentContract
{
    class Installments(DateTime date, double amount)
    {

        public double Amount { get; set; } = amount;
        public DateTime DueDate { get; set; } = date;


        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
            + "-"
            + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }

    }

}