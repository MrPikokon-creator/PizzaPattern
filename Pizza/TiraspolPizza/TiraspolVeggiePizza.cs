using PizzaPattern.Factories;
using System;

namespace PizzaPattern.TiraspolPizza
{
    class TiraspolVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("\n\nВегетарианская пицца");
            Console.WriteLine("\n1. Ингредиенты:");
            PizzaIngredientFactory factory = new TiraspolPizzaIngredientFactory();
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