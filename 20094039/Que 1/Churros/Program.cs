using System;
using System.Collections.Generic;

class Program
{
    static Queue<Order> orderQueue = new Queue<Order>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n--- Delicious Churros ---");
            Console.WriteLine("1. Place Order");
            Console.WriteLine("2. Deliver Order");
            Console.WriteLine("0. Exit");
            Console.Write("Choose option: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlaceOrder();
                    break;

                case 2:
                    DeliverOrder();
                    break;

                case 0:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 0);
    }

    static void PlaceOrder()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Plain Sugar (€6)");
        Console.WriteLine("2. Cinnamon Sugar (€6)");
        Console.WriteLine("3. Chocolate (€8)");
        Console.WriteLine("4. Nutella (€8)");

        Console.Write("Select item: ");
        int item = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter quantity: ");
        int qty = Convert.ToInt32(Console.ReadLine());

        Churros churros = null;

        switch (item)
        {
            case 1:
                churros = new Churros("Plain Sugar", 6);
                break;
            case 2:
                churros = new Churros("Cinnamon Sugar", 6);
                break;
            case 3:
                churros = new Churros("Chocolate", 8);
                break;
            case 4:
                churros = new Churros("Nutella", 8);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Order order = new Order(churros.Name, qty, churros.Price);

        Console.WriteLine($"\nOrder Placed Successfully!");
        Console.WriteLine($"Order Number: {order.OrderNo}");
        Console.WriteLine($"Total Bill: €{order.PayBill()}");

        orderQueue.Enqueue(order);
    }

    static void DeliverOrder()
    {
        if (orderQueue.Count > 0)
        {
            Order order = orderQueue.Dequeue();
            order.CollectOrder();
        }
        else
        {
            Console.WriteLine("No orders in queue.");
        }
    }
}
