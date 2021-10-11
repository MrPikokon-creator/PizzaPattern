using PizzaPattern.Stores;
using System;

namespace PizzaPattern
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите город:");
            Console.WriteLine("1. Тирасполь");
            Console.WriteLine("2. Бендеры");
            Console.Write("Выбор (цифра): ");
            var city = Console.ReadLine();
            PizzaStore store = null;

            if (city == "1") // Тирасполь
            {
                store = new TiraspolPizzaStore();
            }
            else if (city == "2") // Бендеры
            {
                store = new BenderPizzaStore();
            }

            if (store != null)
            {
                store.CreatePizza();
            }
            Console.ReadKey();
        }
    }
}