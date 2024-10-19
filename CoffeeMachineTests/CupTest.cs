using CoffeeMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CupTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfThereAreEnoughCups()
        {
            Cup smallCup = new SmallCup(2);

            bool result = smallCup.HasEnoughCups(1);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseIfThereAreNotEnoughCups()
        {
            Cup smallCup = new SmallCup(1);

            bool result = smallCup.HasEnoughCups(2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldSubtractCupQuantity()
        {
            Cup smallCup = new SmallCup(5);

            smallCup.GiveCups(1);

            Assert.AreEqual(4, smallCup.Quantity);
        }
    }
}