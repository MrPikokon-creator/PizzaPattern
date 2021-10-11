using System;

namespace PizzaPattern.Fillings.Dough
{
    class ThinCrustDough : IDough
    {
        public void Dough()
        {
            Console.WriteLine("Тесто с тонкой корочкой");
        }
    }
}