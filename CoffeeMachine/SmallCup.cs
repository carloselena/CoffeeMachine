using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class SmallCup : Cup
    {
        public override int Size { get; set; } = 3;

        public SmallCup(int cupQuantity) : base(cupQuantity) { }
    }
}
