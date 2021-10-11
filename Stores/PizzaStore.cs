using System;

namespace PizzaPattern.Stores
{
    abstract class PizzaStore
    {
        public string OrderPizza()
        {
            Console.WriteLine("\nВыберите пиццу:");
            Console.WriteLine("1. Сырная");
            Console.WriteLine("2. Пепперони");
            Console.WriteLine("3. С креветками");
            Console.WriteLine("4. Вегетарианская");
            Console.Write("Выбор (цифра): ");
            string pizza = Console.ReadLine();
            return pizza;
        }

        public abstract void CreatePizza();
    }
}
