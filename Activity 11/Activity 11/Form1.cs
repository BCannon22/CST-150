using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class diceRoller : Form
    {
        public diceRoller()
        {
            InitializeComponent();
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            var dice1 = new Dice(6, 0);
            var dice2 = new Dice(6, 0);

            int rolls = 0;
            
            while (true)
            {
                rolls++;
                
                dice1.Roll();
                dice2.Roll();

                dice1Rolls.AppendText($"You rolled: {dice1.Rolled}");
                dice2Rolls.AppendText($"You rolled: {dice2.Rolled}");

                if (dice1.Rolled == 1)
                {
                    if (dice2.Rolled == 1)
                    {
                        dice1Rolls.AppendText($"You rolled: {dice1.Rolled}");
                        dice2Rolls.AppendText($"You rolled: {dice2.Rolled}");
                        MessageBox.Show("Snake Eyes!");
                        MessageBox.Show("You rolled " + rolls + " times");
                        break;
                    }
                }
            }
        }
    }
}
