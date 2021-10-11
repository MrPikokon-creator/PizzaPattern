using PizzaPattern.Factories;
using System;

namespace PizzaPattern.BenderPizza
{
    class BenderClamPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nПицца с креветками");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new BenderPizzaIngredientFactory();
            factory.CreateDough(); // Тесто
            factory.CreateSauce(); // Соус
            factory.CreateCheese(); // Сыр
            factory.CreateClam(); // Креветки

            base.Bake();
            base.Cut();
            base.Box();
        }
    }
}