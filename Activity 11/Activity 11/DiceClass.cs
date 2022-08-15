using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_11
{
    class Dice
    {
        private int Sides { get; set; }    //Sets amount of sides.
        public int Rolled { get; set; }   //Random numbered used to see what dice lands on.

        public Dice(int Sides, int Rolled)    //Constructs dice object
        {
            this.Sides = Sides;
            this.Rolled = Rolled;
        }

        public int Roll()            //Roles between 1 and what the sides of the dice are set to.
        {
            Random random = new Random();
            int num = random.Next(1, Sides + 1);
            return Rolled = num;
        }
    }
}
