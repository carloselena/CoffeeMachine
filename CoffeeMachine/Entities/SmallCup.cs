using CoffeeMachine.Common;

namespace CoffeeMachine.Entities
{
    public class SmallCup : Cup
    {
        public override int Size { get; set; } = 3;

        public SmallCup(int cupQuantity) : base(cupQuantity) { }
    }
}
