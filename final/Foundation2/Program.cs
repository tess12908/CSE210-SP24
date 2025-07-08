class Program
{
    static void Main()
    {
        Address address1 = new Address("649 S 2nd W", "Idaho", "ID", "USA");
        Customer customer1 = new Customer("Libby Lauer", address1);

        Product product1 = new Product("Candy", 106, 4.99, 3);
        Product product2 = new Product("Stuffed Animal", 102, 25.50, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(""); 
        Console.WriteLine("Packing Label:"); 
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(""); 
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(""); 
        Console.WriteLine("Total Cost: " + order1.GetTotalCost());
        Console.WriteLine($"Expected to be there on {order1.Arrival(15)}"); 
        Console.WriteLine("//////////////////////////////////////////////"); 

        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Moses Smith", address2);

        Product product3 = new Product("Shoe", 107, 150.00, 1);
        Product product4 = new Product("Laces", 104, 19.99, 1);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(""); 
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(""); 
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(""); 
        Console.WriteLine("Total Cost: " + order2.GetTotalCost());
        Console.WriteLine($"Expected to be there on {order2.Arrival(10)}"); 
        Console.WriteLine(""); 
        Console.WriteLine("//////////////////////////////////////////////"); 
    }
}
