namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceCalculator
{
    public decimal calculate(int quantity, List<Item> items)
    {
        decimal total = 0;
        for (int i = 0; i < quantity; i++)
        {
            total += items[i].ItemPrice;
        }

        return total;
    }

}