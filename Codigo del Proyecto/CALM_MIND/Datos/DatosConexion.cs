using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatosConexion
    {
        private string connectionString;
        private MySqlConnection connection;

        private string server = "localhost";
        private string port = "3306";
        private string user = "root";
        private string password = "Enrrique0606.";
        private string database = "calm_mind";

        public DatosConexion()
        {
            connectionString = $"Server = {server}; Port = {port}; Database = {database}; User = {user}; password = {password} ";
            connection = new MySqlConnection(connectionString);

        }

        public MySqlConnection GetSqlConnection()
        {
            return connection;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public bool ConnectionStatus()
        {
            return (connection.State == System.Data.ConnectionState.Open);
        }
    }
}
