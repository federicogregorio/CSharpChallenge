using System;
using System.IO;
using Logger;
using InventoryManagement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Fede!");
        /*
        var logger =  new LogEvents();
        logger.log_message("User logged in", "INFO");
        */
        var _inventory = new Inventory();
        _inventory.addProduct("Product A", 100, 5);
        _inventory.addProduct("Product B", 200, 3);
        _inventory.addProduct("Product C", 50, 10);

        // Example usage: Sort by 'price' in descending order
        string key = "stock";
        bool ascending = true;

        var products = _inventory.Sort(key, ascending);

        // Print the sorted list
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }
}


