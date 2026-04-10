using System;

public class Order
{
    private static int counter = 1; // Auto order number

    // Properties
    public int OrderNo { get; private set; }
    public string OrderDetails { get; set; }
    public int Quantity { get; set; }
    public double Bill { get; private set; }

    // Constructor
    public Order(string details, int quantity, double price)
    {
        OrderNo = counter++;
        OrderDetails = details;
        Quantity = quantity;
        Bill = price * quantity;
    }

    // Method: Pay Bill
    public double PayBill()
    {
        return Bill;
    }

    // Method: Collect Order
    public void CollectOrder()
    {
        Console.WriteLine($"Order {OrderNo} is delivered.");
    }
}