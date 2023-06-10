using Course.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Installment installment = new Installment(DateTime.Now, 500.00);

        Console.WriteLine(installment.DueDate + ", " + installment.Amount.ToString("F2", CultureInfo.InvariantCulture));
    }
}