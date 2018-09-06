using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace inventory.DBClass
{
    class DBConnetion
    {
        public static SqlConnection getDBConnection()
        {
            try
            {
                string connString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|\InventoryDB.mdf;Integrated Security=True;User Instance=True";
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }
    }

}
