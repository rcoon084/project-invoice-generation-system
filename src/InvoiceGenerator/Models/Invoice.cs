namespace InvoiceGenerator.Models;

public class Invoice
{
    public int InvoiceNumber { get; set; }
    public required string CustomerName { get; set; }
    public List<Item> LineItems { get; set; } = new(); //Es necesario inicializarla para evitar complicaciones
    public decimal TotalAmount { get; set; }

    public Invoice(){}
}