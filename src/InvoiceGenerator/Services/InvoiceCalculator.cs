namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceCalculator
{
    private decimal total = 0;

    public decimal calculate(int quantity, List<Item> items)
    {
        for (int i = 0; i < quantity; i++)
        {
            total += items[i].ItemPrice;
        }

        return total;
    }

}