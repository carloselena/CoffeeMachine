using CoffeeMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class SugarSupplierTest
    {
        SugarSupplier sugarSupplier;

        [TestInitialize]
        public void SetUp()
        {
            sugarSupplier = new SugarSupplier(10);
        }

        [TestMethod]
        public void ShouldReturnTrueIfThereIsEnoughSugar()
        {
            bool result = sugarSupplier.HasEnoughSugar(5);

            Assert.IsTrue(result);

            result = sugarSupplier.HasEnoughSugar(10);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ShouldReturnFalseIfThereIsNotEnoughSugar()
        {
            bool result = sugarSupplier.HasEnoughSugar(15);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ShouldSubtractSugarFromSugarSupplier()
        {
            sugarSupplier.GiveSugar(5);

            Assert.AreEqual(5, sugarSupplier.SugarQuantity);

            sugarSupplier.GiveSugar(2);

            Assert.AreEqual(3, sugarSupplier.SugarQuantity);
        }
    }
}
