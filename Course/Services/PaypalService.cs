namespace Course.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int months)
        {
            double installment = amount / months;
            for (int i = 0; i < months; i++)
            {
                installment += installment * 0.01 * i++;
            }
            return installment;
        }

        public double PaymentFee(double amount)
        {
            return amount += amount * 0.02;
        }
    }
}
