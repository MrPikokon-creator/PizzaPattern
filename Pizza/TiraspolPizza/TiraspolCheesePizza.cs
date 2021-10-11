using PizzaPattern.Factories;
using System;

namespace PizzaPattern.TiraspolPizza
{
    class TiraspolCheesePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nСырная пицца");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new TiraspolPizzaIngredientFactory();
            factory.CreateDough(); // Тесто
            factory.CreateSauce(); // Соус
            factory.CreateCheese(); // Сыр

            base.Bake();
            base.Cut();
            base.Box();
        }
    }
}