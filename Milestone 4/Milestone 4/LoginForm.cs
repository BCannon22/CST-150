using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_4
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public bool LoggedIn { get; set; }   //Creates boolean for login acception

        private void loginButton_Click(object sender, EventArgs e)    //Closes login form.
        {
            LoggedIn = true;
            this.Close();
        }
    }
}
