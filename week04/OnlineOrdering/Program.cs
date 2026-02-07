using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER 1 (USA)
        Address a1 = new Address("123 Main St", "Miami", "FL", "USA");
        Customer c1 = new Customer("William Brown", a1);

        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Coloring Book", "P100", 2.50, 4));
        o1.AddProduct(new Product("Colored pencils", "P200", 5.00, 1));

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${o1.GetTotalCost()}");
        Console.WriteLine("\n-----------------\n");

        // ORDER 2 (Non-USA)
        Address a2 = new Address("Av. Hidalgo 45", "Tampico", "TAM", "Mexico");
        Customer c2 = new Customer("Rosa Posadas", a2);

        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Keychain", "K300", 3.00, 3));
        o2.AddProduct(new Product("Sticker Set", "S400", 1.25, 10));

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"TOTAL: ${o2.GetTotalCost()}");
    }
}
