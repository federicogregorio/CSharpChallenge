using System;
using System.Collections.Generic;
using System.Linq;

namespace InventoryManagement{

    public class Product 
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

        public Product (string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

    }

    public class Inventory
    {
        private List<Product> products = new List<Product>();

        public void addProduct(string name, double price, int stock)
        {
            Product product = new Product(name, price, stock);
            products.Add(product);
        }
        public List<Product> Sort(string key, bool ascending)
        {
            // Using LINQ to sort based on the sortKey
            switch (key.ToLower())
            {
                case "name":
                    return ascending
                        ? this.products.OrderBy(p => p.Name).ToList()
                        : this.products.OrderByDescending(p => p.Name).ToList();
                case "price":
                    return ascending
                        ? this.products.OrderBy(p => p.Price).ToList()
                        : this.products.OrderByDescending(p => p.Price).ToList();
                case "stock":
                    return ascending
                        ? this.products.OrderBy(p => p.Stock).ToList()
                        : this.products.OrderByDescending(p => p.Stock).ToList();
                default:
                    throw new ArgumentException("Invalid key");
            }
        }
    }

}
