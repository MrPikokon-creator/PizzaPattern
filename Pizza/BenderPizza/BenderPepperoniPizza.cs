using PizzaPattern.Factories;
using System;

namespace PizzaPattern.BenderPizza
{
    class BenderPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nПицца Пепперони");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new BenderPizzaIngredientFactory();
            factory.CreateDough(); // Тесто
            factory.CreateSauce(); // Соус
            factory.CreateCheese(); // Сыр
            factory.CreatePepperoni(); // Пепперони

            base.Bake();
            base.Cut();
            base.Box();
        }
    }
}