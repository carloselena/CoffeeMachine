namespace CoffeeMachine.Entities
{
    public class SugarSupplier
    {
        public int SugarQuantity { get; set; }

        public SugarSupplier(int sugarQuantity)
        {
            SugarQuantity = sugarQuantity;
        }

        public bool HasEnoughSugar(int sugarQuantityNeeded)
        {
            if (SugarQuantity < sugarQuantityNeeded)
            {
                return false;
            }
            return true;
        }

        public void GiveSugar(int sugarQuantity)
        {
            SugarQuantity -= sugarQuantity;
        }
    }
}
