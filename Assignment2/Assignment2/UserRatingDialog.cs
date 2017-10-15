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
    public partial class UserRatingDialog : Form
    {

        List<ListViewItem> checkedUsers;
        UserHandler uh;
        UserListScreenGuest ulsg;
        UserListScreenModerator ulsm;

        int rating;
        public UserRatingDialog(UserHandler uh, List<ListViewItem> checkedUsers, UserListScreenGuest ulsg)
        {
            InitializeComponent();
            this.checkedUsers = checkedUsers;
            this.uh = uh;
            this.ulsg = ulsg;
        }

        public UserRatingDialog(UserHandler uh, List<ListViewItem> checkedUsers, UserListScreenModerator ulsm)
        {
            InitializeComponent();
            this.checkedUsers = checkedUsers;
            this.uh = uh;
            this.ulsm = ulsm;
        }


        private void cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void zero_click(object sender, EventArgs e)
        {
            rating = 0;

        }

        private void one_click(object sender, EventArgs e)
        {
            rating = 1;
        }

        private void two_click(object sender, EventArgs e)
        {
            rating = 2;
        }

        private void three_click(object sender, EventArgs e)
        {
            rating = 3;
        }

        private void four_click(object sender, EventArgs e)
        {
            rating = 4;
        }

        private void five_click(object sender, EventArgs e)
        {
            rating = 5;
        }

        private void submit_click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in checkedUsers)
            {
                User u = uh.retrieveAll().Find((User user) => { return lvi.SubItems[0].Text.Equals(user.GetFullUserString()); });
                if(u != null)
                {
                    u.AddRating(rating);
                    uh.SaveAllUsers();
                }
            }
            this.Close();
            if (ulsg != null) ulsg.reload();
            if (ulsm != null) ulsm.reload();

        }
    }
}
