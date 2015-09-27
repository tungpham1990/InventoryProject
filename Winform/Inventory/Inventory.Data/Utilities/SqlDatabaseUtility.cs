using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Utilities
{
    public class SqlDatabaseUtility
    {
        public static SqlConnection GetConnection()
        {
            string cnstr = ConfigurationManager.ConnectionStrings["connectionConfig"].ConnectionString;
            SqlConnection cn = new SqlConnection(cnstr);
            cn.Open();
            return cn;
        }
        public static SqlDataReader ExecuteQuery(
            string commandText,
            Dictionary<string, SqlParameter> commandParameters = null, CommandType commandType = CommandType.Text
        )
        {
            // open a database connection
            SqlConnection cn = GetConnection();
            // create a SQL command to execute the stored procedure
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = commandType;
            cmd.CommandText = commandText;
            if (commandParameters != null)
            {
                // assign parameters passed in to the command
                foreach (var procParameter in commandParameters)
                {
                    cmd.Parameters.Add(procParameter.Value);
                }
            }
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public static int ExecuteCommand(
            string storedProcName,
            Dictionary<string, SqlParameter> procParameters )
        {
            int rc;
            using (SqlConnection cn = GetConnection())
            {
                // create a SQL command to execute the stored procedure
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storedProcName;
                // assign parameters passed in to the command
                foreach (var procParameter in procParameters)
                {
                    cmd.Parameters.Add(procParameter.Value);
                }
                rc = cmd.ExecuteNonQuery();
                cn.Close();
            }
            return rc;
        }
    }
}
