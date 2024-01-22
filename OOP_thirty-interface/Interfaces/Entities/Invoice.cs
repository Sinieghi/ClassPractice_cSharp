

using System.ComponentModel;
using System.Globalization;

namespace InterfacesPractice
{
    class Invoice(double basicPayment, double tax)
    {
        public double BasicPayment { get; set; } = basicPayment;
        public double Tax { get; set; } = tax;

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}