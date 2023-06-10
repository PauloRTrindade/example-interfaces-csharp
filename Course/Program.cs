using Course.Entities;
using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {
        Contract contract = new Contract(8020, DateTime.Now, 200.00, new List<Installment>());

        int N = 2;

        for (int i = 0; i < N; i++)
        {
            ;
            DateTime DueDate = DateTime.Now;
            double Value = 200.00;

            contract.AddInstallment(new Installment(DueDate, Value));
        }

        Console.WriteLine(contract);
    }
}