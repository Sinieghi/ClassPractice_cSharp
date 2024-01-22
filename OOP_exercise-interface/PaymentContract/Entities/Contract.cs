using System.Globalization;

namespace PaymentContract
{
    class Contract(int number, DateTime date, double totalValue)
    {
        public int Number { get; set; } = number;

        public DateTime Date { get; set; } = date;

        public double TotalValue { get; set; } = totalValue;
        public List<Installments> InstallmentsLi { get; set; } = [];


        public void AddInstallment(Installments installment)
        {
            this.InstallmentsLi.Add(installment);
        }

    }

}