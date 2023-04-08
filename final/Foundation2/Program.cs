using System;
using System.Collections.Generic;

namespace ProductOrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
        Customer customer1 = new Customer("John Doe", new Address("123 Main St", "Campton", "NY", "USA"));
        Customer customer2 = new Customer("Jane Smith", new Address("456 Elm St", "Millenial", "CA", "USA"));
        Customer customer3 = new Customer("Racheal Leitz", new Address("2 Hope St", "Bridget", "EG", "EU"));
        Customer customer4 = new Customer("Alex Kim", new Address("789 Oak St", "Apt. 4B", "Seoul", "South Korea"));
        Customer customer5 = new Customer("Maria Garcia", new Address("555 Maple Ave", "Ciudad de Mexico", "Mexico City", "Mexico"));

        // Create products
        Product product1 = new Product("Stain Free Markers", "WID001", 2.50, 3);
        Product product2 = new Product("iPhone14", "GIZ001", 5.00, 2);
        Product product3 = new Product("PlayStation", "THG001", 10.00, 1);
        Product product4 = new Product("Laptop Bag", "ACC001", 20.00, 2);
        Product product5 = new Product("Wireless Headphones", "ACC002", 30.00, 1);
        Product product6 = new Product("Waterproof Camera", "CAM001", 40.00, 1);
        Product product7 = new Product("Drone", "GIZ002", 50.00, 1);
        Product product8 = new Product("Smart Watch", "ACC003", 60.00, 1);
        Product product9 = new Product("Gaming Mouse", "THG002", 70.00, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Order order3 = new Order(customer3);
        order3.AddProduct(product3);
        order3.AddProduct(product4);
        order3.AddProduct(product5);

        Order order4 = new Order(customer4);
        order4.AddProduct(product4);
        order4.AddProduct(product5);
        order4.AddProduct(product6);

        Order order5 = new Order(customer5);
        order5.AddProduct(product5);
        order5.AddProduct(product6);
        order5.AddProduct(product7);

        // Display the packing and shipping labels and total price for each order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price " + order1.CalculateTotalPrice());
        Console.WriteLine("----------");
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price " + order2.CalculateTotalPrice());
        Console.WriteLine("----------");
        Console.WriteLine();

        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total price " + order3.CalculateTotalPrice());
        Console.WriteLine("----------");
        Console.WriteLine();

        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine("Total price " + order4.CalculateTotalPrice());
        Console.WriteLine();
        }
    }
}
