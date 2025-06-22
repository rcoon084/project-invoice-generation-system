namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceNumberGenerator
{
    int lastInvoiceCurrentNumber = 1;
    public int generate()
    {
        Console.WriteLine(lastInvoiceCurrentNumber);
        return lastInvoiceCurrentNumber++;
    }
}