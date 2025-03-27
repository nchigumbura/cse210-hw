using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address instances
        var address1 = new Address("123 Main St", "New York", "NY", "USA");
        var address2 = new Address("456 Elm St", "London", "England", "UK");

        // Create Customer instances
        var customer1 = new Customer("Alice Johnson", address1);
        var customer2 = new Customer("Bob Smith", address2);

        // Create Order instances and add Products
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 1200m, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25m, 2));

        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "C789", 800m, 1));
        order2.AddProduct(new Product("Charger", "D012", 20m, 3));

        // Display Order Details for Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        // Display Order Details for Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
    }
}
