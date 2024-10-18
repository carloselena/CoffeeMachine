using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Cup
    {
        public int Quantity { get; set; }
        public int Size {  get; set; }
        public Cup(int cupQuantity, int cupSize)
        {
            Quantity = cupQuantity;
            Size = cupSize;
        }

        public bool HasCups(int cupQuantityNeeded)
        {
            return true;
        }

        public void GiveCups(int cupQuantity)
        {

        }
    }
}
