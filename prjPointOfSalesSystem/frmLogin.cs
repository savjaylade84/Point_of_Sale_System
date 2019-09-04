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
            Thread thread = new Thread(new ThreadStart(CallScreenSplash));
            thread.Start();
            Thread.Sleep(5000);
            thread.Abort();
            this.Focus();

        }


        private void Cancel_Click(object sender, EventArgs e) {

            DialogResult result = MessageBox.Show("Do you want to Cancel","Alert",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);

            if(DialogResult.OK == result)
            this.Close();

        }

        private void CallScreenSplash() {

            Application.Run(new frmSplashScreen());
        
        }

        private void CallDashboard(){

            Application.Run(new Dashboard());
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username = "Jayson";
            String Password = "deleon";
            bool CorrectLogin = ((usernameValue.Text == "jayson") && (passwordValue.Text == "deleon"));
            bool IsEmpty = ((usernameValue.Text == String.Empty) || (passwordValue.Text == String.Empty ));


            if (IsEmpty){

                warning.Text = "Empty";
                errorProvider1.SetError(warning,"Empty Value");
                

            } else {


                if (CorrectLogin)
                {

                    Thread thread = new Thread(new ThreadStart(CallDashboard));
                    thread.Start();
                    this.Close();

                }
                else {

                    MessageBox.Show("Incorrect Username or Password","Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                    usernameValue.Clear();
                    passwordValue.Clear();
                    usernameValue.Focus();

                }


            }




        }
    }
}
