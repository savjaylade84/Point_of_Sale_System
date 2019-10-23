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

            UserStorage userStorage = new UserStorage();
            //check if the user want to exit 
            DialogResult result = MessageBox.Show("Do you want to create?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result) {

                //inserted the value to user storage
                userStorage.user_id = UserIdValue.Text;
                userStorage.username = UsernameValue.Text;
                userStorage.password = PasswordValue.Text;
                userStorage.firstname = FirstNameValue.Text;
                userStorage.lastname = LastNameValue.Text;
                userStorage.email = EmailValue.Text;
                userStorage.contactNO = ContactValue.Text;

                //show the user inserted value
                InfoAlert.Text = "\nUsername   : " + userStorage.username +
                                 "\nUser ID    : " + userStorage.user_id +
                                 "\nPassword   : " + userStorage.password +
                                 "\nFirst Name : " + userStorage.firstname +
                                 "\nLast Name  : " + userStorage.lastname +
                                 "\nEmail      : " + userStorage.email +
                                 "\nContact No : " + userStorage.contactNO;
            }
                

        }

        //to let password have asterisk or dot value show    
        private void FocusAndClearTextbox(TextBox change) {

            change.Focus();
            change.Clear();
        
        }

        //to point the active texbox control and
        //clear the value of it
        private void FocusTextbox(object sender, EventArgs e)
        {
            //capture the active texbox control 
            TextBox a = (TextBox)sender;

            //check if the not password or confirm password
            if (a != PasswordValue || a != ConfirmPasswordValue)
                FocusAndClearTextbox(a);

            FocusAndClearTextbox(a);
            PasswordValue.UseSystemPasswordChar = true;
            ConfirmPasswordValue.UseSystemPasswordChar = true;

        }

        //modify
        private void UnFocusTextBox(Object sender, EventArgs e) {

            //TextBox[] textBoxes = { UserIdValue, UsernameValue, PasswordValue, ConfirmPasswordValue };

            //foreach (TextBox textBox in textBoxes)
            //{

            //    if ((TextBox)sender == textBox)
            //    {

            //        textBox.Text = textBox.Tag.ToString();

            //    }

            //}

        }

        //support in changing the appearance of the value
        //in the password
        public void ShowHidePassword(bool YesNo) {


            PasswordValue.UseSystemPasswordChar = YesNo;
            ConfirmPasswordValue.UseSystemPasswordChar = YesNo;

        }

        private void ShowHidePassword(object sender, EventArgs e)
        {
             //show or not the password real value
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

        //exit this form
        private void ExitForm(object sender, EventArgs e) => this.Close();
 
    }
}
