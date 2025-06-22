using InvoiceGenerator.Services;


while (true)
{
    Console.WriteLine("Welcome to the Invoice Generator. Please choose an option: \n");
    Console.WriteLine("1. Create an Invoice.\n2. See all invoices\n0. Exit.");
    Console.WriteLine();

    InvoiceService invoiceService = new();

    invoiceService.startService(2);
}