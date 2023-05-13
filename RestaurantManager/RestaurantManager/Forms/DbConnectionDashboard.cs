using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace RestaurantManager.Forms
{
    public abstract class DbConnectionDashboard
    {
        private readonly string connectionString;

        public DbConnectionDashboard()
        {
            connectionString = "Server=localhost;Database=restaurant_manager;Uid=root;Pwd=;";
        }

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
