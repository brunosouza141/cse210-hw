using System;

class Program
{
    static void Main(string[] args)
    {
        //First order
        List<Product> firstOrderProducts = new List<Product>();
        Address address1 = new Address("742 Oakridge Avenue", "Portland", "OR", "USA");
        Customer customer1 = new Customer("Alice", address1);
        firstOrderProducts.Add(new Product(
            "Bluetooth Headphones",
            101,
            10,
            1));

        firstOrderProducts.Add(new Product(
            "Stainless Steel Water Bottle",
            202,
            15,
            2));

        Order firstOrder = new Order(customer1, firstOrderProducts);
        Console.WriteLine("\nFirst order: \n");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(firstOrder.PackingLabel());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(firstOrder.ShippingLabel());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Order total price: " + firstOrder.OrderPrice());
        Console.WriteLine("--------------------------------------");


        //Second order
        List<Product> secondOrderProducts = new List<Product>();
        Address address2 = new Address("Rua 25 de Março, 25", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Marcos", address2);
        secondOrderProducts.Add(new Product(
            "Wireless Mouse",
            404,
            20,
            1));

        secondOrderProducts.Add(new Product(
            "USB-C Charging Cable",
            505,
            5,
            3));

        Order secondOrder = new Order(customer2, secondOrderProducts);
        Console.WriteLine("\nSecond order: \n");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(secondOrder.PackingLabel());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(secondOrder.ShippingLabel());
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Order total price: " + secondOrder.OrderPrice());
        Console.WriteLine("--------------------------------------");
    }
}