using CoffeeMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CoffeeMachineTest
    {
        CoffeeMaker CoffeeMaker;
        SmallCup SmallCup;
        MediumCup MediumCup;
        LargeCup LargeCup;
        SugarSupplier SugarSupplier;
        CoffeeMachineClass CoffeeMachine;

        [TestInitialize]
        public void SetUp()
        {
            CoffeeMaker = new CoffeeMaker(50);
            SmallCup = new SmallCup(5);
            MediumCup = new MediumCup(5);
            LargeCup = new LargeCup(5);
            SugarSupplier = new SugarSupplier(20);

            CoffeeMachine = new CoffeeMachineClass();
            CoffeeMachine.CoffeeMaker = CoffeeMaker;
            CoffeeMachine.SmallCups = SmallCup;
            CoffeeMachine.MediumCups = MediumCup;
            CoffeeMachine.LargeCups = LargeCup;
            CoffeeMachine.SugarSupplier = SugarSupplier;
        }

        [TestMethod]
        public void ShouldReturnASmallCup()
        {
            Cup? cup = CoffeeMachine.GetCupType("small");

            Assert.AreEqual(CoffeeMachine.SmallCups, cup);
        }

        [TestMethod]
        public void ShouldReturnAMediumCup()
        {
            Cup? cup = CoffeeMachine.GetCupType("medium");

            Assert.AreEqual(CoffeeMachine.MediumCups, cup);
        }

        [TestMethod]
        public void ShouldReturnALargaCup()
        {
            Cup? cup = CoffeeMachine.GetCupType("large");

            Assert.AreEqual(CoffeeMachine.LargeCups, cup);
        }

        [TestMethod]
        public void ShouldReturnThereAreNotEnoughCups()
        {
            Cup? cup = CoffeeMachine.GetCupType("medium");

            string result = CoffeeMachine.GetCoffeeCup(cup, 6, 2);

            Assert.AreEqual("No hay suficientes vasos", result);
        }

        [TestMethod]
        public void ShouldReturnThereIsNotEnoughSugar()
        {
            SugarSupplier sugarSupplier = new SugarSupplier(4);
            CoffeeMachine.SugarSupplier = sugarSupplier;

            Cup? cup = CoffeeMachine.GetCupType("small");

            string result = CoffeeMachine.GetCoffeeCup(cup, 2, 3);

            Assert.AreEqual("No hay suficiente azúcar", result);
        }

        [TestMethod]
        public void ShouldReturnThereIsNotEnoughCoffee()
        {
            CoffeeMaker coffeeMaker = new CoffeeMaker(5);
            CoffeeMachine.CoffeeMaker = coffeeMaker;

            Cup? cup = CoffeeMachine.GetCupType("small");

            string result = CoffeeMachine.GetCoffeeCup(cup, 2, 2);

            Assert.AreEqual("No hay suficiente café", result);
        }

        [TestMethod]
        public void ShouldSubtractCoffee()
        {
            Cup? cup = CoffeeMachine.GetCupType("small");

            CoffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = CoffeeMachine.CoffeeMaker.CoffeeQuantity;

            Assert.AreEqual(47, result);
        }

        [TestMethod]
        public void ShouldSubtractCup()
        {
            Cup? cup = CoffeeMachine.GetCupType("small");

            CoffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = CoffeeMachine.SmallCups.Quantity;

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ShouldSubtractSugar()
        {
            Cup? cup = CoffeeMachine.GetCupType("small");

            CoffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = CoffeeMachine.SugarSupplier.SugarQuantity;

            Assert.AreEqual(17, result);
        }

        [TestMethod]
        public void ShouldReturnCongratulations()
        {
            Cup? cup = CoffeeMachine.GetCupType("small");

            string result = CoffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.AreEqual("¡Felicidades!", result);
        }
    }
}
