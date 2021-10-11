using PizzaPattern.TiraspolPizza;

namespace PizzaPattern.Stores
{
    class TiraspolPizzaStore : PizzaStore
    {
        public override void CreatePizza()
        {
            string pizza = base.OrderPizza();

            if (pizza == "1") // Сырная
            {
                (new TiraspolCheesePizza()).Prepare();
            }
            else if (pizza == "2") // Пепперони
            {
                (new TiraspolPepperoniPizza()).Prepare();
            }
            else if (pizza == "3") // С креветками
            {
                (new TiraspolClamPizza()).Prepare();
            }
            else if (pizza == "4") // Вегетарианская
            {
                (new TiraspolVeggiePizza()).Prepare();
            }
        }
    }
}
