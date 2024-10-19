using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class MediumCup : Cup
    {
        public override int Size { get; set; } = 5;

        public MediumCup(int cupQuantity) : base(cupQuantity) { }
    }
}
