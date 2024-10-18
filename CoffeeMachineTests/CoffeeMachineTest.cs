using CoffeeMachine;
using System.Runtime.CompilerServices;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CoffeeMachineTest
    {
        CoffeeMaker coffeeMaker;
        Cup smallCup;
        Cup mediumCup;
        Cup largeCup;
        SugarSupplier sugarSupplier;
        CoffeeMachineClass coffeeMachine;

        [TestInitialize]
        public void SetUp()
        {
            coffeeMaker = new CoffeeMaker(50);
            smallCup = new Cup(5, 10);
            mediumCup = new Cup(5, 20);
            largeCup = new Cup(5, 30);
            sugarSupplier = new SugarSupplier(20);

            coffeeMachine = new CoffeeMachineClass();
            coffeeMachine.SetCoffeeMaker(coffeeMaker);
            coffeeMachine.SetSmallCups(smallCup);
            coffeeMachine.SetMediumCups(mediumCup);
            coffeeMachine.SetLargeCups(largeCup);
            coffeeMachine.SetSugarSupplier(sugarSupplier);
        }

        //[TestMethod]
        public void ShouldReturnASmallCup()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            Assert.AreEqual(coffeeMachine.SmallCup, cup);
        }

        //[TestMethod]
        public void ShouldReturnAMediumCup()
        {
            Cup cup = coffeeMachine.GetCupType("medium");

            Assert.AreEqual(coffeeMachine.MediumCup, cup);
        }

        //[TestMethod]
        public void ShouldReturnALargaCup()
        {
            Cup cup = coffeeMachine.GetCupType("large");

            Assert.AreEqual(coffeeMachine.LargeCup, cup);
        }

        //[TestMethod]
        public void ShouldReturnThereAreNoCups()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            string result = coffeeMachine.GetCoffeeCup(cup, 10, 2);

            Assert.AreEqual("No hay vasos", result);
        }

        //[TestMethod]
        public void ShouldReturnThereIsNoCoffee()
        {
            coffeeMaker = CoffeeMaker(5);
            coffeeMachine.SetCoffeeMaker(coffeeMaker);

            Cup cup = coffeeMachine.GetCupType("small");

            string result = coffeeMachine.GetCoffeeCup(cup, 1, 2);

            Assert.AreEqual("No hay café", result);
        }

        //[TestMethod]
        public void ShouldReturnThereIsNoSugar()
        {
            sugarSupplier = new SugarSupplier(2);
            coffeeMachine.SetSugarSupplier(sugarSupplier);

            Cup cup = coffeeMachine.GetCupType("small");

            string result = coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.AreEqual("No hay azúcar", result);
        }

        //[TestMethod]
        public void ShouldSubtractCoffee()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            coffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = coffeeMachine.GetCoffeeMaker().GetCoffeeQuantity();

            Assert.AreEqual(40, result);
        }

        //[TestMethod]
        public void ShouldSubtractCup()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            coffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = coffeeMachine.GetSmallCups().GetCupQuantity();

            Assert.AreEqual(4, result);
        }

        //[TestMethod]
        public void ShouldSubtractSugar()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            coffeeMachine.GetCoffeeCup(cup, 1, 3);

            int result = coffeeMachine.GetSugarSupplier().GetSugarQuantity();

            Assert.AreEqual(17, result);
        }

        //[TestMethod]
        public void ShouldReturnCongratulations()
        {
            Cup cup = coffeeMachine.GetCupType("small");

            string result = coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.AreEqual("¡Felicitaciones!", result);
        }
    }
}
