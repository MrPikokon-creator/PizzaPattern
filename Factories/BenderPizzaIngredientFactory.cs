using PizzaPattern.Fillings.Dough;
using PizzaPattern.Fillings.Sauce;
using PizzaPattern.Fillings.Cheese;
using PizzaPattern.Fillings.Pepperoni;
using PizzaPattern.Fillings.Clams;
using PizzaPattern.Fillings.Veggies;

namespace PizzaPattern.Factories
{
    class BenderPizzaIngredientFactory : PizzaIngredientFactory
    {
        // Тесто
        public override void CreateDough()
        {
            IDough dough = new ThinCrustDough();
            dough.Dough();
        }

        // Соус
        public override void CreateSauce()
        {
            ISauce sauce = new MarinaraSauce();
            sauce.Sauce();
        }

        // Сыр
        public override void CreateCheese()
        {
            ICheese cheese = new ReggianoCheese();
            cheese.Cheese();
        }

        // Овощи
        public override void CreateVeggies()
        {
            IVeggies veggies = new Olives();
            veggies.Veggies();
        }

        // Пепперони
        public override void CreatePepperoni()
        {
            IPepperoni pepperoni = new NotSpicyPepperoni();
            pepperoni.Pepperoni();
        }

        // Креветки
        public override void CreateClam()
        {
            IClams clams = new FreshClams();
            clams.Clams();
        }
    }
}