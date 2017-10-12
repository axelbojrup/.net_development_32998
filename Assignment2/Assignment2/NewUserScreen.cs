using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void submit_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 ) {
                uh.addGuest(new Guest(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, 0, 0.0, dateTimePicker1.Value));
                this.Close();
            }

            

        }

        private void Cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
