using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity15
{
    public partial class LuckyNumberForm : Form
    {
        public LuckyNumberForm()
        {
            InitializeComponent();
        }

        private void LuckyNumberForm_Load(object sender, EventArgs e)       //Generates a random number
        {
            Random rn = new Random();

            LuckyNumLabel.Text = rn.Next(1, 31).ToString();
        }
    }
}
