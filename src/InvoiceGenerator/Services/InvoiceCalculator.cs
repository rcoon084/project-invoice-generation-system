namespace InvoiceGenerator.Services;

using InvoiceGenerator.Models;

public class InvoiceCalculator
{
    private decimal total = 0;

    public decimal calculate(int quantity, List<decimal> prices)
    {
        for (int i = 0; i < quantity; i++)
        {
            total += prices[i];
        }

        return total;
    }

}