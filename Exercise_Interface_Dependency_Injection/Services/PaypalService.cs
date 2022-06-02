

namespace Exercise_Interface_Dependency_Injection.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private const double FeeParcentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeeParcentage;
        }
    }
}
