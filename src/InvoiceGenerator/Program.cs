using InvoiceGenerator.Services;


while (true)
{
    Console.WriteLine("Welcome to the Invoice Generator. Please choose an option: \n");
    Console.WriteLine("1. Create an Invoice.\n2. See all invoices\n0. Exit.");
    Console.WriteLine();

    string answer = Console.ReadLine();
    switch (answer)
    {
        case "1":
            InvoiceNumberGenerator idGenerator = new();
            InvoiceService invoiceService = new(idGenerator);
            InvoicePrinter invoicePrinter = new();
            invoicePrinter.print(invoiceService.startService(2));
            break;
        case "2":
            break;
        case "0":
            return;
        default:
            break;
    }

}