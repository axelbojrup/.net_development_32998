using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class NewUserScreen : Form
    {
        UserHandler uh;
        public NewUserScreen(UserHandler uh)
        {
            this.uh = uh;
            InitializeComponent();
        }
        private bool onFormat(string s)
        {
            if (Regex.IsMatch(s, "^[a-zA-Z0-9]{2,}$")) return true;
            return false;
        }

        private bool nameOnFormat(string s)
        {
            if (Regex.IsMatch(s, "^[A-Z]{1}[A-Za-z]{1,}$")) return true;
            return false;
        }

        private void displayError(string msg)
        {
            this.label6.Text = msg;
        }
        private void submit_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 ) {
                if (!onFormat(textBox1.Text)) displayError("username in incorrect format.");
                else if (!onFormat(textBox2.Text)) displayError("password in incorrect format.");
                else if (!nameOnFormat(textBox3.Text)) displayError("first name in incorrect format.");
                else if (!nameOnFormat(textBox4.Text)) displayError("last name in incorrect format.");
                else
                {
                    uh.addGuest(new Guest(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, 0, 0.0, dateTimePicker1.Value));
                    uh.SaveAllUsers();
                    this.Close();
                }
            }

            

        }

        private void Cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
