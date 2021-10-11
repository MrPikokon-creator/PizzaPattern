using PizzaPattern.Factories;
using System;

namespace PizzaPattern.TiraspolPizza
{
    class TiraspolPepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nПицца Пепперони");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new TiraspolPizzaIngredientFactory();
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