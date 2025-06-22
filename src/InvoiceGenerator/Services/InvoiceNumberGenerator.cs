namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceNumberGenerator
{
    int lastInvoiceCurrentNumber = 0;
    public int generate()
    {
        return lastInvoiceCurrentNumber++;
    }
}