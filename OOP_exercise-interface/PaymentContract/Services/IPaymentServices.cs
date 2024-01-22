
namespace PaymentContract
{
    interface IPaymentServices
    {
        double PaymentFee(double amount);
        double Interest(double amount, int moths);
    }

}