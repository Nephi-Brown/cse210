using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("17 Park Row", "Boring", "OH", "USA");
        var address2 = new Address("500 McGregor Avenue", "Winnipeg", "MB", "Canada");

        var customer1 = new Customer("Alice Smith", address1);
        var customer2 = new Customer("Gregory Manton", address2);

        var product1 = new Product("Pineaple", "W029", 6.23m, 2);
        var product2 = new Product("Waters", "W116", 0.65m, 12);
        var product3 = new Product("Steak", "W349", 27.89m, 1);
        var product4 = new Product("Chicken Breast", "W988", 7.38m, 5);
        var product5 = new Product("Spaghetti", "W487", 4.50m, 1);
        var product6 = new Product("Tomato Sauce", "W349", 5.00m, 1);

        var order1 = new Order(customer1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product5);
        order1.AddProduct(product6);

        var order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product1);
        order2.AddProduct(product6);
        order2.AddProduct(product3);
        order2.AddProduct(product2);

        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.TotalCost()}\n");

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }
}