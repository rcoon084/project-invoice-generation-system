namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceService
{
    private int quantity;
    private string customerName;
    public List<string> Names { get; set; }
    public List<decimal> Prices { get; set; }
    public List<Item> items { get; set; }

    public InvoiceNumberGenerator idGenerator;
    public InvoiceSaver saver;

    public InvoiceService(InvoiceNumberGenerator id, InvoiceSaver invoiceSaver)
    {
        Names = new List<string>();
        Prices = new List<decimal>();
        items = new List<Item>();
        idGenerator = id;
        saver = invoiceSaver;
    }

    public Invoice startService(int quantity)
    {
        customerName = null;
        while (string.IsNullOrWhiteSpace(customerName))
        {
            Console.WriteLine($"Please enter the customer's name: ");
            customerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                Console.WriteLine("The customer's name cannot be empty. Please try again.");
            }
        }

        Console.WriteLine($"Please enter your {quantity} Items: ");

        for (int i = 0; i < quantity; i++)
        {
            string name = null;
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine($"Enter the item number {i + 1}'s name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Item name cannot be empty. Please try again.");
                }
            }
            Names.Add(name);
            decimal price = 0;
            bool isValidPrice = false;
            while (!isValidPrice)
            {
                Console.WriteLine($"Enter the item number {i + 1}'s price: ");
                string priceInput = Console.ReadLine();
                isValidPrice = decimal.TryParse(priceInput, out price);

                if (!isValidPrice)
                {
                    Console.WriteLine("Invalid price format. Please enter a valid number (e.g., 29.99).");
                }
            }
            Prices.Add(price);

            Item itemActual = new Item
            {
                ItemName = Names[i],
                ItemPrice = Prices[i]
            };

            items.Add(itemActual);
        }

        InvoiceCalculator calculator = new();

        Invoice newInvoice = new Invoice
        {
            InvoiceNumber = idGenerator.generate(),
            CustomerName = customerName,
            LineItems = items,
            TotalAmount = calculator.calculate(quantity, items)
        };

        saver.save(newInvoice);
        return newInvoice;

    }
}