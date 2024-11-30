using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 101, 799.99, 1);
        Product product2 = new Product("Mouse", 102, 19.99, 2);
        Product product3 = new Product("Keyboard", 103, 49.99, 1);
        Address address1 = new Address("4259 Jarvis St", "Buffalo", "NY", "USA");
        Customer customer1 = new Customer("Tony Stark", address1);
        List<Product> products1 = new List<Product> { product1, product2, product3 };
        Order order1 = new Order(products1, customer1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Address address2 = new Address("269 Jarvis St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Pepper Pots", address2);
        List<Product> products2 = new List<Product> { product1, product2 };
        Order order2 = new Order(products2, customer2);
        Console.WriteLine("\n" + order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
