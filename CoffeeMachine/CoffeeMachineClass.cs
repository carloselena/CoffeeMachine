﻿namespace CoffeeMachine
{
    public class CoffeeMachineClass
    {
        public CoffeeMaker CoffeeMaker { get; set; }
        public SugarSupplier SugarSupplier { get; set; }
        public SmallCup SmallCups { get; set; }
        public MediumCup MediumCups { get; set; }
        public LargeCup LargeCups { get; set; }

        public Cup? GetCupType(string cupType)
        {
            switch (cupType)
            {
                case "small":
                    return SmallCups;
                case "medium":
                    return MediumCups;
                case "large":
                    return LargeCups;
                default:
                    return null;
            }
        }

        public string GetCoffeeCup(Cup cup, int cupQuantity, int sugarQuantity)
        {
            if (cup == SmallCups && SmallCups.Quantity < cupQuantity)
            {
                return "No hay suficientes vasos";
            }

            if (cup == MediumCups && MediumCups.Quantity < cupQuantity)
            {
                return "No hay suficientes vasos";
            }

            if (cup == LargeCups && LargeCups.Quantity < cupQuantity)
            {
                return "No hay suficientes vasos";
            }

            if (SugarSupplier.SugarQuantity < sugarQuantity * cupQuantity)
            {
                return "No hay suficiente azúcar";
            }

            if (CoffeeMaker.CoffeeQuantity < cupQuantity * cup.Size)
            {
                return "No hay suficiente café";
            }

            if (cup == SmallCups) SmallCups.Quantity -= cupQuantity;
            if (cup == MediumCups) MediumCups.Quantity -= cupQuantity;
            if (cup == LargeCups) LargeCups.Quantity -= cupQuantity;

            SugarSupplier.SugarQuantity -= sugarQuantity * cupQuantity;
            CoffeeMaker.CoffeeQuantity -= cup.Size * cupQuantity;

            return "¡Felicidades!";

        }
    }
}
