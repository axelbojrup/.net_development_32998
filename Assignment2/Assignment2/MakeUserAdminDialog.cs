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
    public partial class MakeUserAdminDialog : Form
    {

        UserHandler uh;
        List<ListViewItem> checkedUsers;
        UserListScreenAdmin ulsa;
        Admin.AdminType selectedEnum;

        public MakeUserAdminDialog(UserHandler uh, List<ListViewItem> checkedUsers, UserListScreenAdmin ulsa)
        {
            InitializeComponent();
            this.checkedUsers = checkedUsers;
            this.uh = uh;
            this.ulsa = ulsa;
        }


        private void makeUserAdminComboBox_click(object sender, EventArgs e)
        {
            if (makeUserAdminComboBox.Text.Equals("Moderator")) selectedEnum = Admin.AdminType.Moderator;
            else selectedEnum = Admin.AdminType.SuperAdmin;
        }

        private void MakeUserAdmin_Submit_click(object sender, EventArgs e)
        {
            List<User> tmp = uh.retrieveAll();
            foreach (ListViewItem lvi in checkedUsers)
            {
                User u = tmp.Find((User user) => { return lvi.SubItems[0].Text.Equals(user.GetFullUserString()); });
                if (u != null)
                {
                    if (u is Guest)
                    {
                        Admin a = ((Guest)u).makeAdmin();
                        a.adminType = selectedEnum;
                        uh.addAdmin(a);
                        uh.remove(u);
                    }
                    else ((Admin)u).adminType = selectedEnum;
                    
                    uh.SaveAllUsers();
                    ulsa.reload();
                }
            }
            this.Close();
        }

        private void MakeUserAdmin_Cancel_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
