
namespace PaymentContract
{
    class ContractService(IPaymentServices services)
    {

        public void ProcessContract(Contract contract, int moths)
        {
            double bQ = contract.TotalValue / moths;
            for (int i = 0; i < moths; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updQ = bQ + services.Interest(bQ, i);
                double fullQ = updQ + services.PaymentFee(updQ);
                contract.AddInstallment(new Installments(date, fullQ));
            }

        }
    }

}