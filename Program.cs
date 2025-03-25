using System;

namespace lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("MacBook", 1200, 4, 10);
            Product product2 = new Product("iPad", 500, 5, 21);
            Product product3 = new Product("iPhone 13", 150,6,32);
            Product product4 = new Product();

            Store store = new Store("Ali Mobile Store", "Faisalabad");

            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);
            store.AddProduct(product4);

            store.Display();

            Console.ReadKey();
        }
    }
}
