using System;

namespace PizzaPattern.Fillings.Pepperoni
{
    class NotSpicyPepperoni : IPepperoni
    {
        public void Pepperoni()
        {
            Console.WriteLine("Неострая пепперони");
        }
    }
}