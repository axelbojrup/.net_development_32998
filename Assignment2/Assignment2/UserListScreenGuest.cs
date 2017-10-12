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
    public partial class UserListScreenGuest : Form
    {
        UserHandler uh;
        public UserListScreenGuest(UserHandler uh)
        {
            this.uh = uh;
            InitializeComponent();
            this.label1.Text = uh.LoggedInUser.GetFullUserString();

        }

        private void UserListScreenGuest_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add();
            List<User> l = uh.retrieveGuests();

            l.ForEach((User u) => { listBox1.Items.Add(u.GetShortUserString()); });
            
        }
    }
}
