using System;

namespace ShopTube
{

    class Program
    {
        static void Main(string[] args)
        {
            Store onlineStore = new Store();

            Console.WriteLine("Добро пожаловать в магазин ");
            Console.WriteLine("1. Показать каталог продукта ");
            Console.WriteLine(" ");
            int numberAction = Convert.ToInt32(Console.ReadLine());

            switch (numberAction)
            {
                case 1:
                    onlineStore.ShowCatalog();

                    break;

                default:
                    Console.WriteLine("Вы не чего не выбрали...");
                    break;
            }

            bool yes;
            do
            {


                Console.WriteLine("Добавление продукта в корзину   (Да/Нет)");
                yes = IsYes(Console.ReadLine());

                if (yes)
                {
                    onlineStore.ShowCatalog();
                    Console.WriteLine("Выберите продукт");
                    int productNumber = Convert.ToInt32(Console.ReadLine());
                    onlineStore.AddToBasket(productNumber);
                }

            } while (yes);



            Console.WriteLine("Посмотреть корзину   (Да/Нет)");
            yes = IsYes(Console.ReadLine());

            if (yes)
            {
                onlineStore.ShowBasket();
            }

            Console.WriteLine("Оформить заказ :  (Да/Нет)");
            yes = IsYes(Console.ReadLine());

            if (yes)
            {
                onlineStore.CreateOrder();
            }
        }

        public static bool IsYes(string answer)
        {
            return answer.ToLower() == "да";
        }
    }  
}
