using System;

namespace lab_6
{
    public class Store
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Product[] Products { get; }
        public int ProductCount { get; private set; }

        public Store(string name, string location)
        {
            Name = name;
            Location = location;
            Products = new Product[10];
            ProductCount = 0;
        }

        public void AddProduct(Product product)
        {
            if (ProductCount < 10)
            {
                Products[ProductCount] = product;
                ProductCount++;
                Console.WriteLine($"Product {product.Name} added to store.");
            }
            else
            {
                Console.WriteLine("Product limit reached, cannot add more products.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Store: {Name} ({Location})");
            Console.WriteLine("Available Products:");
            for (int i = 0; i < ProductCount; i++)
            {
                Products[i].Display();
                Console.WriteLine("----------------------");
            }
        }
    }
}

