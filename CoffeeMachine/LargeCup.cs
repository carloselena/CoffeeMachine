using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class LargeCup : Cup
    {
        public override int Size { get; set; } = 7;

        public LargeCup(int cupQuantity) : base(cupQuantity) { }
    }
}
