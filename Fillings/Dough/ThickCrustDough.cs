using System;

namespace PizzaPattern.Fillings.Dough
{
    class ThickCrustDough : IDough
    {
        public void Dough()
        {
            Console.WriteLine("Тесто с толстой корочкой");
        }
    }
}