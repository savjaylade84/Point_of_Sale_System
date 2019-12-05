using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjPointOfSalesSystem;
using System.Data.SqlClient;
namespace prjPointOfSalesSystem
{
    class DatabaseConnect
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        internal string connstring;
        public DatabaseConnect() {

        }

        public void EnterData(IAccount account) {


            connstring = @"EXECUTE addAccount @uid = @UID,@uname = @UNAME,@pword = @PWORD " +
            @",@fname = @FNAME,@lname = @LNAME,@email = @EMAIL,@contact = @CONTACT";


            using (connection = new SqlConnection(ConnectionString.Info))
            using (command = new SqlCommand(connstring, connection))
            {

                connection.Open();

                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.AddWithValue("@UID", account.userid);
                command.Parameters.AddWithValue("@UNAME", account.username);
                command.Parameters.AddWithValue("@PWORD", account.password);
                command.Parameters.AddWithValue("@FNAME", account.firstname);
                command.Parameters.AddWithValue("@LNAME", account.lastname);
                command.Parameters.AddWithValue("@EMAIL", account.email);
                command.Parameters.AddWithValue("@CONTACT", account.contact);

                command.ExecuteNonQuery();

                connection.Close();

            }



        }                                                                  

        public void SelectData(System.Windows.Forms.DataGridView view) {

            connstring = @"EXEC selectAccount";
            var tempDset = new System.Data.DataSet();
            using (connection = new SqlConnection(ConnectionString.Info))
            using (command = new SqlCommand(connstring,connection))
            using (adapter = new SqlDataAdapter(command)) {

                connection.Open();

                builder = new SqlCommandBuilder(adapter);
                adapter.Fill(tempDset);
                view.ReadOnly = true;
                view.DataSource = tempDset.Tables[0];

                connection.Close();

            }

        }

    }
}
