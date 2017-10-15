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
    public partial class UserListScreenAdmin : Form
    {
        UserHandler uh;
        public UserListScreenAdmin(UserHandler uh)
        {
            InitializeComponent();
            this.uh = uh;
            addListViewContent();
        }
        public void addListViewContent()
        {
            this.adminLabel.Text = uh.LoggedInUser.GetFullUserString();
            List<User> l = uh.retrieveAll();

            int i = 0;
            while (i < l.Count())
            {
                if (!uh.LoggedInUser.GetShortUserString().Equals(l[i].GetShortUserString()))
                {
                    ListViewItem item = new ListViewItem(l[i].GetFullUserString());
                    item.SubItems.Add(l[i].AverageRating.ToString());
                    item.SubItems.Add(l[i].RatingsCount.ToString());


                    this.listViewAdmin.Items.Add(item);
                }
                i++;
            }
        }

        public void reload()
        {
            this.listViewAdmin.Items.Clear();
            addListViewContent();
        }

        private void buttonAdminRating_click(object sender, EventArgs e)
        {
            List<ListViewItem> checkedUsers = new List<ListViewItem>();
            foreach (ListViewItem i in this.listViewAdmin.Items)
            {
                if (i.Checked) checkedUsers.Add(i);
            }
            new UserRatingDialog(uh, checkedUsers, this).Show();
        }

        private void makeAdmin_button_click(object sender, EventArgs e)
        {
            List<ListViewItem> checkedUsers = new List<ListViewItem>();
            foreach (ListViewItem i in this.listViewAdmin.Items)
            {
                if (i.Checked) checkedUsers.Add(i);
            }
            new MakeUserAdminDialog(uh, checkedUsers, this).Show();
        }
    }
}
