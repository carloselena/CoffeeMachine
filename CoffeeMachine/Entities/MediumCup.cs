using CoffeeMachine.Common;

namespace CoffeeMachine.Entities
{
    public class MediumCup : Cup
    {
        public override int Size { get; set; } = 5;

        public MediumCup(int cupQuantity) : base(cupQuantity) { }
    }
}
