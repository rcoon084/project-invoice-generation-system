# Invoice Generator

This is a simple console-based application for generating invoices. It allows users to create new invoices with multiple items and view a list of all previously created invoices.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

* [.NET SDK](httpss://dotnet.microsoft.com/download)

### Running the application

1.  **Clone the repository or download the source code.**
2.  **Navigate to the project directory in your terminal.**
3.  **Run the application using the .NET CLI:**
    ```bash
    dotnet run
    ```
4.  **Follow the on-screen prompts to:**
    * Create a new invoice.
    * View all saved invoices.
    * Exit the application.

## Features

* **Create Invoices**: Add a new invoice by specifying the customer's name and the details of each item (name and price).
* **Save Invoices**: Automatically saves every created invoice in-memory.
* **View All Invoices**: Displays a formatted list of all the invoices that have been created during the session.
* **Sequential Invoice Numbers**: Automatically assigns an incremental invoice number to each new invoice.

## Project Structure

The project is organized into several classes, each with a specific responsibility:

| File Name | Description |
| :--- | :--- |
| `Program.cs` | The main entry point of the application. It contains the main loop and user interface logic to navigate the menu. |
| `Invoice.cs` | The model class that represents an invoice, including properties for the invoice number, customer name, line items, and total amount. |
| `Item.cs` | The model class for an item on an invoice, with properties for the item's name and price. |
| `InvoiceService.cs` | Handles the business logic for creating a new invoice by gathering user input for customer name and item details. |
| `InvoicePrinter.cs` | Manages the display of invoices to the console, with methods for printing a single formatted invoice or all saved invoices. |
| `InvoiceSaver.cs` | Responsible for in-memory storage of the invoices that are created by adding them to a list. |
| `InvoiceNumberGenerator.cs`| Generates a unique, sequential number for each new invoice, starting from 1 and incrementing. |
| `InvoiceCalculator.cs` | Calculates the total amount for an invoice by summing the prices of all its items. |