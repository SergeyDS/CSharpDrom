using System;

namespace ShopTube
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }


        public void Print()
        {
            Console.WriteLine($"{Name,-10} {Price,-10}");
        }

    }
}
