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
            PasswordValue.UseSystemPasswordChar = true;
            ConfirmPasswordValue.UseSystemPasswordChar = true;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            UserStorage userStorage = new UserStorage();
            //check if the user want to exit 
            DialogResult result = MessageBox.Show("Do you want to submit?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result) {

                userStorage.user_id = UserIdValue.Text;
                userStorage.username = UsernameValue.Text;
                userStorage.password = PasswordValue.Text;
                //it just temporary
                MessageBox.Show("Name:\n" + userStorage.username);

            }
                

        }

        //modify
        private void FocusTextbox(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { UserIdValue, UsernameValue, PasswordValue, ConfirmPasswordValue };

            foreach (TextBox textBox in textBoxes) {

                if ((TextBox)sender == textBox)
                {

                    textBox.Focus();
                    textBox.Clear();

                }

            }

        }

        //modify
        private void UnFocusTextBox(Object sender, EventArgs e) {

            TextBox[] textBoxes = { UserIdValue, UsernameValue, PasswordValue, ConfirmPasswordValue };

            foreach (TextBox textBox in textBoxes)
            {

                if ((TextBox)sender == textBox)
                {

                    textBox.Text = textBox.Tag.ToString();

                }

            }

        }

        public void ShowHidePassword(bool YesNo) {


            PasswordValue.UseSystemPasswordChar = YesNo;
            ConfirmPasswordValue.UseSystemPasswordChar = YesNo;

        }

        private void ShowHidePassword(object sender, EventArgs e)
        {
            if (ShowPasswordChckBx.Checked)
            {

                ShowHidePassword(false);
                ShowPasswordChckBx.Text = "Hide";

            }
            else {

                ShowHidePassword(true);
                ShowPasswordChckBx.Text = "Show";

            }

        }
    }
}
