using System;

namespace PizzaPattern
{
    abstract class Pizza
    {
        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("\n2. Пицца готова");
        }

        public void Cut()
        {
            Console.WriteLine("\n3. Пицца разрезана");
        }

        public void Box()
        {
            Console.WriteLine("\n4. Пицца упакована");
        }
    }
}
