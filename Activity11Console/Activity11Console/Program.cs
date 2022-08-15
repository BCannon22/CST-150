using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class program
{
    static void Main(string[] args)
    {
        var dice1 = new Dice(6, 0);
        var dice2 = new Dice(6, 0);

        int rolls = 0; //Keeps track of how many times it took to get snake eyes.

        while(true)    //Keeps rolling the dice untill both are equal to 1. 
        {
            rolls++;
            dice1.Roll();
            dice2.Roll();

            Console.WriteLine($"You roll: {dice1.Rolled} and {dice2.Rolled}");
            
            if (dice1.Rolled == 1)
            {
                if (dice2.Rolled == 1)
                {
                    Console.WriteLine($"Rolled: {dice1.Rolled} and {dice2.Rolled}");
                    Console.WriteLine("Snake Eyes!");
                    Console.WriteLine("You rolled " + rolls + " times");
                    break;
                }
            }
        }                 
    }
}
