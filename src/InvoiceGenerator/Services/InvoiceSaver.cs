namespace InvoiceGenerator.Services;

using InvoiceGenerator.Services;
using InvoiceGenerator.Models;

public class InvoiceSaver
{
    public List<Invoice> lastInvoices { get; set; } = new();

    public void save(Invoice invoice)
    {
        lastInvoices.Add(invoice);
    }
}