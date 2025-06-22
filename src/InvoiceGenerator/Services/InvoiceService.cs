namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceService
{
    private int quantity;
    public List<string> Names { get; set; }
    public List<decimal> Prices { get; set; }
    public List<Item> items { get; set; }

    public InvoiceService()
    {
        Names = new List<string>();
        Prices = new List<decimal>();
        items = new List<Item>();
    }

    public void startService(int quantity)
    {
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

        Console.WriteLine(calculator.calculate(quantity, Prices));

    }
}