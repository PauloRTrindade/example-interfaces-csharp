using Course.Entities;
using System.Globalization;

namespace Course.Services
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
            Double BasicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime Date = contract.Date.AddMonths(i);
                Double UpdateQuota = BasicQuota + _onlinePaymentService.Interest(BasicQuota, i);
                double FullQuota = UpdateQuota + _onlinePaymentService.PaymentFee(UpdateQuota);
                contract.AddInstallment(new Installment(Date, FullQuota));
            }
        }
    }
}
