using System;
using System.Windows.Forms;

namespace Time_Calculator
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void ConvertedTime_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating my variable for seconds.
                double Seconds;
                Seconds = double.Parse(secondsText.Text);

                if (Seconds >= 60 && Seconds <= 3599)    // Sees if the number of seconds is in the range of minutes
                {
                    //Converts seconds into minutes
                    double Minutes;       
                    Minutes = Seconds / 60;

                    //Sends the amount of mintues to the ConvertedTime textbox
                    ConvertedTime.Text = Minutes.ToString("n2") + " minutes.";

                }
                else if (Seconds >= 3600 && Seconds <= 86399) //Sees if the seconds are with the range of hours
                {
                    //Converts seconds into hours
                    double Hours;
                    Hours = Seconds / 3600;

                    //Sends the amount of hours to the ConvertedTIme textbox
                    ConvertedTime.Text = Hours.ToString("n2") + " hours.";
                }
                else if (Seconds >= 86400) //Sees if the number of seconds is in the range of days
                {
                    //Converts seconds into days
                    double Days;
                    Days = Seconds / 86400;

                    //Sends the amount of days to the converted number to the convertedTime textbox.
                    ConvertedTime.Text = Days.ToString("n2") + " days.";
                }
                else if (Seconds >= 0 && Seconds <= 59) //Sees if the range is still within seconds
                {
                    //Shows the amount of seconds in ConvertedTime textbox
                    ConvertedTime.Text = Seconds.ToString("n2") + " seconds";
                }
                else //catches negative number
                {
                    //Lets the user known negative numbers are not allowed.
                    ConvertedTime.Text = "Incorrect Number";
                }
            }
            catch (Exception ex)
            {
                //Displays error message
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearText_Click(object sender, EventArgs e)
        {
            //Clears the text of the textboxes
            secondsText.Text = "";
            ConvertedTime.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
    }
}
