using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FIOTask
{
    internal class Database
    {

        private SqlConnection sqlConnection;

        public Database(string dataSource, string initCatalog)
        {
            sqlConnection = new SqlConnection($"Data Source={dataSource}; Initial Catalog={initCatalog}; " +
                $"Integrated Security=True; Connection Timeout=1");
        }

        public bool OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (SqlException)
                {
                    return false;
                }
            }
            return true;
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
