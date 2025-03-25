using System;

namespace lab_6
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int ID { get; set; }
        private int qInStock;

        public int QInStock
        {
            get { return qInStock; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    qInStock = value;
                }
                else
                {
                    Console.WriteLine("The quantity must be in range of 0 to 100.");
                    qInStock = 0;
                }
            }
        }

        public Product(string name, double price, int id, int qInStock)
        {
            Name = name;
            Price = price;
            ID = id;
            QInStock = qInStock;
        }

        public Product() : this("Unnamed", 0, 0, 0) { }
        public Product(string name) : this(name, 0, 0, 0) { }
        public Product(string name, double price) : this(name, price, 0, 0) { }
        public Product(string name, double price, int id) : this(name, price, id, 0) { }

        public void Display()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Quantity in Stock: {QInStock}");
        }

        ~Product()
        {
            Console.WriteLine($"Destructor called for Product ID: {ID}");
        }
    }
}
