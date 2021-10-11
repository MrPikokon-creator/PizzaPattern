using PizzaPattern.Factories;
using System;

namespace PizzaPattern.BenderPizza
{
    class BenderVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nВегетарианская пицца");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new BenderPizzaIngredientFactory();
            factory.CreateDough(); // Тесто
            factory.CreateSauce(); // Соус
            factory.CreateCheese(); // Сыр
            factory.CreateVeggies(); // Овощи

            base.Bake();
            base.Cut();
            base.Box();
        }
    }
}