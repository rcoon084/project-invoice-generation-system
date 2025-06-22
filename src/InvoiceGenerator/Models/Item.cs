namespace InvoiceGenerator.Models;

public class Item
{
    public required string ItemName { get; set; }
    public required decimal ItemPrice { get; set; }

    public Item (){}
}