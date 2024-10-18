using CoffeeMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CupTest
    {
        [TestMethod]
        public void ShouldReturnTrueIfThereAreEnoughCups()
        {
            Cup smallCup = new Cup(2, 10);

            bool result = smallCup.HasCups(1);

            Assert.IsTrue(result);
        }

        public void ShouldReturnFalseIfThereAreNotEnoughCups()
        {
            Cup smallCup = new Cup(1, 10);

            bool result = smallCup.HasCups(2);

            Assert.IsFalse(result);
        }

        public void ShouldSubtractCupQuantity()
        {
            Cup smallCup = new Cup(5, 10);

            smallCup.GiveCups(1);

            Assert.AreEqual(4, smallCup.Quantity);
        }
    }
}