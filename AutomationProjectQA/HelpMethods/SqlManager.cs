using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProjectQA.HelpMethods
{
    public class SqlManager
    {
        private SqlConnection connection;
        private SqlCommand command;

        public SqlConnection OpenDBConnect()
        {
            connection = new SqlConnection();

            connection.ConnectionString =
                $@"Data Source={@"SQL_Server\DB_Name"};" + 
                $"Initial Catalog={"Server_Name"};" +
                $"User id={"UserId"};" +
                $"Password={"Password"};" +
                "Integrated Security=false;";

            connection.Open();

            return connection;
        }

        public SqlDataReader RunScript(string sqlScript)
        {
            OpenDBConnect();

            try
            {
                command = new SqlCommand(sqlScript, connection);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                connection.Close();
            }

            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }

        public void CloseConnection()
        {
            this.connection.Close();
        }
    }
}
