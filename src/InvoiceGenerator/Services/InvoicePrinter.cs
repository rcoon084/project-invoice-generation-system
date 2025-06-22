using InvoiceGenerator.Models;
using InvoiceGenerator.Services;

namespace InvoiceGenerator.Services;

public class InvoicePrinter
{
    public void print(Invoice toPrint)
    {
        Console.WriteLine("\n\n================================================");
        Console.WriteLine("                INVOICE");
        Console.WriteLine("================================================");
        Console.WriteLine($"Customer: {toPrint.CustomerName}");
        Console.WriteLine($"Id: {toPrint.InvoiceNumber}");
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();

        // Header for the items list
        Console.WriteLine($"{"Item Name",-30} {"Price",10}");
        Console.WriteLine($"{"-----------",-30} {"----------",10}");

        // Loop through each item and print its details
        foreach (var line in toPrint.LineItems)
        {
            Console.WriteLine($"{line.ItemName,-30} {line.ItemPrice,10:C}");
        }


        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");

        Console.WriteLine($"{"TOTAL",-30} {toPrint.TotalAmount,10:C}");
        Console.WriteLine("================================================");
    }


}