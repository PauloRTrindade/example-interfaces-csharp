using System.Globalization;
using System.Text;

namespace Course.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> installments { get; private set; } = new List<Installment>();

        public Contract(int number, DateTime date, double totalValue, List<Installment> installments)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            installments = installments;
        }

        public void AddInstallment(Installment installment)
        {
            installments.Add(installment);
        }

        public void RemoveInstallment(Installment installment)
        {
            installments.Remove(installment);
        }
    }
}
