using Course.Entities;
using Course.Services;
using System.Globalization;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Enter contract data");
        Console.Write("Number: ");
        int Number = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime Date = DateTime.Parse(Console.ReadLine());
        Console.Write("Contract value: ");
        double ContractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Enter number of installments: ");
        int NumberInstallments = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Contract contract = new Contract(Number, Date, ContractValue, new List<Installment>());

        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(contract, NumberInstallments);

        Console.WriteLine();
        Console.WriteLine("Installments");
        foreach (Installment installment in contract.installments)
        {
            Console.WriteLine(installment);
        }
    }
}