namespace CoffeeMachine
{
    public class CoffeeMaker
    {
        public int CoffeeQuantity { get; set; }

        public CoffeeMaker(int coffeeQuantity)
        {
            CoffeeQuantity = coffeeQuantity;
        }

        public bool HasEnoughCoffee(int coffeeQuantityNeeded)
        {
            if (CoffeeQuantity < coffeeQuantityNeeded)
            {
                return false;
            }
            return true;
        }

        public void GiveCoffee(int coffeeQuantity)
        {
            CoffeeQuantity -= coffeeQuantity;
        }
    }
}
