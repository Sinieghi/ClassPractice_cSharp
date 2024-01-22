
namespace PaymentContract
{
    class PaypalService : IPaymentServices
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int moths)
        {
            return amount * 0.02 * moths;
        }


    }

}