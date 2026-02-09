using System;
using System.Collections.Generic;
using System.Text;

namespace CST_150Dice
{
    internal class Dice
    {
        private Random rand = new Random();

        // Roll one die
        public int Roll()
        {
            // pick numbers 1 through 6 randomly
            return rand.Next(1, 7); 
        }
    }
}

