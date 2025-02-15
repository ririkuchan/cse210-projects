using System;

namespace OnlineOrdering
{
    public class Product
    {
        public string Name { get; set; }
        public string ProductID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, string productId, double price, int quantity)
        {
            Name = name;
            ProductID = productId;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }
    }
}
