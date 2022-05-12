using System.Collections.Generic;
using System;

namespace ShopTube
{
    public  class Order
    {
        public List<Product> Products;
        public decimal FullPrice;

        public Order(List<Product> products)
        {
            Products = products;
           

            foreach (var product in Products)
            {
                FullPrice += product.Price;
            }
        }
    }
}
