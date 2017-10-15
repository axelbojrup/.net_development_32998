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
    public partial class LoginScreen : Form
    {
        UserHandler uh;
        public LoginScreen(UserHandler uh)
        {
            this.uh = uh;
            InitializeComponent();
        }
        

        private void button1_click(object sender, EventArgs e)
        {
            new NewUserScreen(uh).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u;
            string username = textBox1.Text;
            string password = textBox2.Text;



            u = uh.login(username, password);
            if (u != null){
                uh.LoggedInUser = u;
                if(u is Guest) new UserListScreenGuest(uh).Show();
                if (u is Admin && ((Admin)u).adminType == Admin.AdminType.Moderator) new UserListScreenModerator(uh).Show();
                if (u is Admin && ((Admin)u).adminType == Admin.AdminType.SuperAdmin) new UserListScreenAdmin(uh).Show();
                this.label1.Text = "";
                this.textBox1.Text = "";
                this.textBox2.Text = "";

            }
            else
            {
                this.label1.Text = "Incorrect password or username.";
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }

            

            
        }


    }
}
