using PizzaPattern.BenderPizza;

namespace PizzaPattern.Stores
{
    class BenderPizzaStore : PizzaStore
    {
        public override void CreatePizza()
        {
            string pizza = base.OrderPizza();

            if (pizza == "1") // Сырная
            {
                (new BenderCheesePizza()).Prepare();
            }
            else if (pizza == "2") // Пепперони
            {
                (new BenderPepperoniPizza()).Prepare();
            }
            else if (pizza == "3") // С креветками
            {
                (new BenderClamPizza()).Prepare();
            }
            else if (pizza == "4") // Вегетарианская
            {
                (new BenderVeggiePizza()).Prepare();
            }
        }
    }
}
