using CoffeeMachine.Common;

namespace CoffeeMachine.Entities
{
    public class LargeCup : Cup
    {
        public override int Size { get; set; } = 7;

        public LargeCup(int cupQuantity) : base(cupQuantity) { }
    }
}
