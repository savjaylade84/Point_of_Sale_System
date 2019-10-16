using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPointOfSalesSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            //add username to the menulogout
            menuLogout.Text += " " + DashboardStorage.name;

        }


        private void EditAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //call the user account
            frmUser user = new frmUser();
            user.MdiParent = this;
            user.Show();

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //check if the user want to exit 
            DialogResult result = MessageBox.Show("Do you want to logout", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
                this.Close();
        }
    }
}
