using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjPointOfSalesSystem
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            //check if the user want to exit 
            DialogResult result = MessageBox.Show("Do you want to submit?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result) {

                //it just temporary
                MessageBox.Show("Name:\n" + NameValue.Text + "Student Id:\n" + StudentId.Text +
                                "Year - Course:\n" + YrCrsValue.Text + "Address:\n" + AddressValue.Text + 
                                "Address:\n" + AddressValue.Text + "Nationality:\n" + NationalityValue.Text);

            }
                

        }
    }
}
