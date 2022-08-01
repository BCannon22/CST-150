using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class PiCalc : Form
    {
        public PiCalc()
        {
            InitializeComponent();
        }
        private void CalcButton_Click(object sender, EventArgs e)
        {
            //variables 
            double Terms;    
            Terms = double.Parse(TermsTextBox.Text);
            int s = 1;
            double Pi = 0;
            double Divisor = 1;

            //Loop that starts at one and ends once it reaches terms
            while (Divisor <= Terms)              // While loop works but is a little bit off.
            {
                Pi += s * 4.0 / Divisor;  //Formula for approximating pi
                Divisor += 2;  
                s *= -1;
            }
            
            Results.Text = Pi.ToString(); //Shows results
            
            
            //for (n = 1; n <= Terms; n++)       Testing for Loop
            //{               
                //Pi = 4 / (2 * n - 1);
                    //if(n < Terms)
                //{
                    //Pi = Pi + Pi2;
                //}

                //Results.Text = Pi.ToString();
            //}
        }
    }
}
