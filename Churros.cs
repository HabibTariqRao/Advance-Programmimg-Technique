using System;

public class Churros
{
    // Properties (Encapsulation)
    public string Name { get; set; }
    public double Price { get; set; }

    // Constructor
    public Churros(string name, double price)
    {
        Name = name;
        Price = price;
    }
}