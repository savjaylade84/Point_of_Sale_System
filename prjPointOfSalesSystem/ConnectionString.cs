using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPointOfSalesSystem
{
    internal class ConnectionString
    {
        internal static string Info { get {

                //get the connection string in the app.config file then send to 
                //sql connection in any form needed it 
                var connection = ConfigurationManager.ConnectionStrings["accountConnectionString"];

                //return empty string if its empty
                if (connection == null)
                    return "";

                return connection.ConnectionString;

            } }

    }
}
