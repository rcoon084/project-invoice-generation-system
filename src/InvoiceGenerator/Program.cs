using InvoiceGenerator.Services;


InvoiceNumberGenerator idGenerator = new();
InvoiceSaver saver = new();
InvoicePrinter invoicePrinter = new();
while (true)
{
    Console.WriteLine("Welcome to the Invoice Generator. Please choose an option: \n");
    Console.WriteLine("1. Create an Invoice.\n2. See all invoices\n0. Exit.");
    Console.WriteLine();

    string answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            InvoiceService invoiceService = new(idGenerator, saver);
            invoicePrinter.printOne(invoiceService.startService());
            break;
        case "2":
            invoicePrinter.printAll(saver);
            break;
        case "0":
            return;
        default:
            break;
    }

}