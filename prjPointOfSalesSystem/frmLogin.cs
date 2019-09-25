using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
namespace prjPointOfSalesSystem
{
    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();

            //this will call the splash screen after cal that
            //this form will apppear
            Thread thread = new Thread(new ThreadStart(CallScreenSplash));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
            this.Focus();

        }


        private void Cancel_Click(object sender, EventArgs e) {

            //prompt the user if its want to exit
            DialogResult result = MessageBox.Show("Do you want to Cancel","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if(DialogResult.OK == result)
              this.Close();

        }

        //run the splash screen ui 
        private void CallScreenSplash() => Application.Run(new frmSplashScreen());


        //run the dashboard ui
        private void CallDashboard() => Application.Run(new Dashboard());


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {



            //check the if the username and password are correct
            bool CorrectLogin = ((usernameValue.Text == "jayson") && (passwordValue.Text == "deleon"));

            //check if the texbox is empty
            bool IsEmpty = ((usernameValue.Text == String.Empty) || (passwordValue.Text == String.Empty ));

            //check if the condition meet for logging in if not
            //handle the error
            if (IsEmpty){

                warning.Text = "Empty";
                errorProvider1.SetError(warning,"Empty Value");
                

            } else {


                if (CorrectLogin)
                {

                    //run the dashboard ui
                    Thread thread = new Thread(new ThreadStart(CallDashboard));
                    thread.Start();

                    //close this form
                    this.Close();

                }
                else {

                    //prompt the user of a incorrect crediential then clear textbox
                    MessageBox.Show("Incorrect Username or Password","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    usernameValue.Clear();
                    passwordValue.Clear();
                    usernameValue.Focus();

                }


            }




        }
    }
}
