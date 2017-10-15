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
            addListViewContent();


        }

        public void addListViewContent()
        {
            this.label1.Text = uh.LoggedInUser.GetFullUserString();
            List<User> l = uh.retrieveGuests();

            int i = 0;
            while (i < l.Count())
            {
                if (!uh.LoggedInUser.GetShortUserString().Equals(l[i].GetShortUserString()))
                {
                    ListViewItem item = new ListViewItem(l[i].GetShortUserString());
                    item.SubItems.Add(l[i].AverageRating.ToString());
                    item.SubItems.Add(l[i].RatingsCount.ToString());


                    this.listView1.Items.Add(item);
                }
                i++;
            }

            l.Clear();
        }

        public void reload()
        {
            this.listView1.Items.Clear();
            addListViewContent();
        }
        

        private void button1_click(object sender, EventArgs e)
        {
            List<ListViewItem> checkedUsers = new List<ListViewItem>();
            foreach (ListViewItem i in this.listView1.Items)
            {
                if (i.Checked) checkedUsers.Add(i);
            }
            new UserRatingDialog(uh, checkedUsers, this).Show();
        }


        //

        //

    }
}
