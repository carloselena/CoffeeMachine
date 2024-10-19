using CoffeeMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CoffeeMakerTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfThereIsEnoughCoffee()
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(10);

            bool result = coffeeMaker.HasEnoughCoffee(5);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseIfThereIsNotEnoughCoffee()
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(10);

            bool result = coffeeMaker.HasEnoughCoffee(11);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldSubtractCoffeeFromCoffeeMaker()
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(10);

            coffeeMaker.GiveCoffee(7);

            Assert.AreEqual(3, coffeeMaker.CoffeeQuantity);
        }
    }
}
