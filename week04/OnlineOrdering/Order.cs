using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> products;
        public Customer Customer { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetTotalCost()
        {
            double total = 0;
            foreach (var product in products)
            {
                total += product.GetTotalPrice();
            }
            total += Customer.LivesInUSA() ? 5 : 35; // Shipping cost
            return total;
        }

        public void DisplayOrderDetails()
        {
            Console.WriteLine($"Customer: {Customer.Name}");
            Console.WriteLine($"Shipping Address: {Customer.Address.GetFullAddress()}");
            Console.WriteLine("Products:");
            foreach (var product in products)
            {
                Console.WriteLine($" - {product.Name} (x{product.Quantity}): ${product.GetTotalPrice():0.00}");
            }
            Console.WriteLine($"Total Cost: ${GetTotalCost():0.00}\n");
        }
    }
}
