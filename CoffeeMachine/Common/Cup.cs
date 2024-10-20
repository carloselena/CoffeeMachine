namespace CoffeeMachine.Common
{
    public abstract class Cup
    {
        public int Quantity { get; set; }
        public virtual int Size { get; set; }
        public Cup(int cupQuantity)
        {
            Quantity = cupQuantity;
        }

        public bool HasEnoughCups(int cupQuantityNeeded)
        {
            if (Quantity < cupQuantityNeeded)
            {
                return false;
            }
            return true;
        }

        public void GiveCups(int cupQuantity)
        {
            Quantity -= cupQuantity;
        }
    }
}
