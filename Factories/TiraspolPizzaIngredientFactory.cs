using PizzaPattern.Fillings.Dough;
using PizzaPattern.Fillings.Sauce;
using PizzaPattern.Fillings.Cheese;
using PizzaPattern.Fillings.Pepperoni;
using PizzaPattern.Fillings.Clams;
using PizzaPattern.Fillings.Veggies;

namespace PizzaPattern.Factories
{
    class TiraspolPizzaIngredientFactory : PizzaIngredientFactory
    {
        // Тесто
        public override void CreateDough()
        {
            IDough dough = new ThickCrustDough();
            dough.Dough();
        }

        // Соус
        public override void CreateSauce()
        {
            ISauce sauce = new PlumTomatoSauce();
            sauce.Sauce();
        }

        // Сыр
        public override void CreateCheese()
        {
            ICheese cheese = new MozzarellaCheese();
            cheese.Cheese();
        }

        // Овощи
        public override void CreateVeggies()
        {
            IVeggies veggies = new Tomatoes();
            veggies.Veggies();
        }

        // Пепперони
        public override void CreatePepperoni()
        {
            IPepperoni pepperoni = new SpicyPepperoni();
            pepperoni.Pepperoni();
        }

        // Креветки
        public override void CreateClam()
        {
            IClams clams = new FrozenClams();
            clams.Clams();
        }
    }
}