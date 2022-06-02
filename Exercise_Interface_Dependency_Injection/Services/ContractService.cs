using Exercise_Interface_Dependency_Injection.Entities;

namespace Exercise_Interface_Dependency_Injection.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.ContractValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double quotaWithInterest = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = quotaWithInterest + _onlinePaymentService.PaymentFee(quotaWithInterest);
                contract.AddInstallment(new Installment(dueDate, fullQuota));
            }
        }
    }
}
