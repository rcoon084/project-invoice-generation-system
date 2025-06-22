namespace InvoiceGenerator.Models;

public class Item
{
    required string ItemName { get; set; }
    required decimal ItemPrice { get; set; }
    required int ItemID { get; set; }

    public Item (){}
}