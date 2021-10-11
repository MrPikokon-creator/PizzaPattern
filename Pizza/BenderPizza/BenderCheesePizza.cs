using PizzaPattern.Factories;
using System;

namespace PizzaPattern.BenderPizza
{
    class BenderCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nСырная пицца");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new BenderPizzaIngredientFactory();
            factory.CreateDough(); // Тесто
            factory.CreateSauce(); // Соус
            factory.CreateCheese(); // Сыр

            base.Bake();
            base.Cut();
            base.Box();
        }
    }
}