using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace prjPointOfSalesSystem
{
    public partial class frmUser : Form
    {

        public frmUser()
        {
            InitializeComponent();

            //fill the datagridview  with data from the database 
            //when the form loaded
            connect.SelectData(userDGV);

        }
        private DatabaseConnect connect = new DatabaseConnect();
        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            //check if none of this is equal to the default value
            bool isNotEmpty = (UserIdValue.Text != "[user id:]") && 
                              (UsernameValue.Text != "[username:]") && 
                              (PasswordValue.Text != "[password:]") && 
                              (FirstNameValue.Text != "[first name:]") && 
                              (LastNameValue.Text != "[last name:]") && 
                              (EmailValue.Text != "[email:]") && 
                              (ContactValue.Text != "[contact no.:]");


            //check if the user want to exit 
            DialogResult result = MessageBox.Show("Do you want to create?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == result)
            {

                if (isNotEmpty)

                    try
                    {
                        // inserted value user raw data
                        connect.EnterData(new Account()
                        {

                            userid = Convert.ToInt32(UserIdValue.Text),
                            username = UsernameValue.Text,
                            password = PasswordValue.Text,
                            firstname = FirstNameValue.Text,
                            lastname = LastNameValue.Text,
                            email = EmailValue.Text,
                            contact = ContactValue.Text

                        });

                        //show the data inserted in the datagridview
                        connect.SelectData(userDGV);
                        //show the user that is it success
                        MessageBox.Show("Created Complete");

                        //clear the value
                        ClearControl.Clear(new TextBox[] { 
                        
                            UsernameValue,UserIdValue,PasswordValue
                            ,FirstNameValue,LastNameValue,EmailValue
                            ,ContactValue

                        });

                        //reset to the default value
                        ClearControl.ResetValue(new TextBox[] {

                             UsernameValue,UserIdValue,PasswordValue
                            ,FirstNameValue,LastNameValue,EmailValue
                            ,ContactValue

                        });

                    }
                    catch (SqlException)
                    {

                        //show the user that it is failed
                        MessageBox.Show("Failed to connec");

                    }

                else
                    //show the user that it is empty
                    MessageBox.Show("Empty Value");
            }


        }


        //to let password have asterisk or dot value show    
        private void FocusAndClearTextbox(TextBox change) {

            change.Focus();
            change.Clear();
        
        }

        public void GeneratePasswordTxtBox(object sender,EventArgs e) => PasswordValue.Text = Generate.Password(12);

        //to point the active texbox control and
        //clear the value of it
        private void FocusTextbox(object sender, EventArgs e)
        {
            //capture the active texbox control 
            TextBox a = (TextBox)sender;

            //check if the not password or confirm password
            if (a != PasswordValue)
                FocusAndClearTextbox(a);

            //check if it is a userid then generate id number for it
            if (a == UserIdValue) UserIdValue.Text = Generate.UserId(7);

            PasswordValue.UseSystemPasswordChar = true;
            
        }

        //modify
        private void UnFocusTextBox(Object sender, EventArgs e) {

            PasswordValue.Text = Generate.Password(12);

        }

        //support validating format of the username 
        private bool isValid(string username,string expression)
        {

            if (Regex.IsMatch(username, expression))
            {

                return true;

            }

            return false;
        }


        //check the regular expression of those textbox 
        private void ValidateDataFormat(object sender, EventArgs e) {

            TextBox textBox = (TextBox)sender; 
            
            //validate username format
            if (textBox == UsernameValue) {
                if (!isValid(textBox.Text, @"^[a-zA-Z][a-zA-Z0-9_-]{5,30}$"))
                    UsernameError.SetError(textBox, "Not Valid Format For Username");
                else
                    UsernameError.Clear();
            }
            //validate firstname format
            if (textBox == FirstNameValue) {
                if (!isValid(textBox.Text, @"^[a-zA-z]{5,50}$"))
                    FIrstnameError.SetError(textBox, "Not Valid Format For Firstname");
                else
                    FIrstnameError.Clear();
            }
            //validate firstname format
            if (textBox == LastNameValue)
            {
                if (!isValid(textBox.Text, @"^[a-zA-z]{5,50}$"))
                    LastnameError.SetError(textBox, "Not Valid Format For Lastname");
                else
                    LastnameError.Clear();
            }
            //validate email format
            if (textBox == EmailValue) {
                if (!isValid(textBox.Text, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    EmailError.SetError(textBox, "Not Valid Format For Email Address");
                else
                    EmailError.Clear();
            }
            //validate contact format
            if (textBox == ContactValue) {
                if (!isValid(textBox.Text, @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"))
                    ContactError.SetError(textBox, "Not Valid Format For Contact Number");
                else
                    ContactError.Clear();
            }

        }

        //support in changing the appearance of the value
        //in the password
        public void ShowHidePassword(bool YesNo) => PasswordValue.UseSystemPasswordChar = YesNo;

        //show or not the password
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
