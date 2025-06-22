namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceNumberGenerator
{
    int lastInvoiceCurrentNumber = 0;
    public void generate(Invoice invoice)
    {
        invoice.InvoiceNumber = lastInvoiceCurrentNumber++;
    }
}