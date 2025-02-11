using System;
using MySql.Data.MySqlClient;

namespace PerfumeriaPOS.DB_manager
{
    public static class DatabaseHelper
    {
        private static string connectionString = "Server=localhost;Database=perfumeria;User ID=root;Password=tu_contraseña;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
