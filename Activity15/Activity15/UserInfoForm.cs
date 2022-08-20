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
    public partial class UserInfoForm : Form
    {
        public UserInfoForm()
        {
            InitializeComponent();
        }

        private void FillDate()           //Fills the date combobox once a month is selected.
        {
            for(int day = 1; day <= 30; day++)
            {
                dateBox.Items.Add(day.ToString());
            }
        }

        private void monthBox_SelectedIndexChanged(object sender, EventArgs e)   //Checks to see if a month is selected in the month combobox
        {
            if (monthBox.SelectedIndex != -1)
            {
                FillDate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)       //Generates a set amount of years from 1950 to current year.
        {
            for (int year = 1950; year <= DateTime.Today.Year; year++)
            {
                yearBox.Items.Add(year.ToString());
            }
        }

        private void NumFormButton_Click(object sender, EventArgs e)     //Shows the lucky number form once the button is clicked.
        {
            LuckyNumberForm luckyNumber = new LuckyNumberForm();

            luckyNumber.ShowDialog();
        }
    }
}
