using System;
using OnlineOrdering;

class Program
{
    static void Main()
    {
        
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", addr1);

        
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS123", 49.99, 2));

        
        order1.DisplayOrderDetails();
    }
}
