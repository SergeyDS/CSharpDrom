using System;
using System.Collections.Generic;

namespace ShopTube
{
    public class Store
    {
        public List<Product> Products;
        public List<Product> Basket;
        public List<Order> Orders;

        public Store()
        {
            Products = new List<Product>
            {
                new Product("Хлеб", 25),
                new Product("Молоко", 35),
                new Product("Колбоса", 45),
                new Product("Сыр", 76),
                new Product("Сахар", 15),
                new Product("Рыба", 20),
                new Product("Помидоры", 10),
                new Product("Масло", 100),
                new Product("Снежок", 75)
            };

            Basket = new List<Product>();
            Orders = new List<Order>();
        }

        public void ShowCatalog()
        {
            Console.WriteLine("Каталог протуктов :");
            Console.WriteLine();
            ShowProducts(Products);
        }

        private void ShowProducts(List<Product> products)
        {
            int number = 1;
            
            Console.WriteLine($"{"Продукт",-12 }{"Цена",-10}");
            Console.WriteLine();
            foreach (Product product in products)
            {
                Console.Write(number + ".");
                product.Print();
                number++;
            }

        }

        public void AddToBasket(int numberProduct)
        {
            Basket.Add(Products[numberProduct-1]);
            Console.WriteLine($"Продукт {Products[numberProduct-1].Name} добавлен в корзину");
            Console.WriteLine($"В корзине {Basket.Count} продуктов");
        }

        public void ShowBasket()
        { 

            Console.WriteLine("содержимое корзины :");
            ShowProducts(Basket);
        }

        public void CreateOrder()
        {

            // передать в отдет доставки
            Order order = new Order(Basket);
            Orders.Add(order);
            
            Basket.Clear();
        }
    }
}
