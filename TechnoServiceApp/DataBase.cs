using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TechnoServiceApp
{
    internal class DataBase
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; password=2207; Database=TechnoServiceDB");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public int autoincriment(string tableName)
        {
            try
            {
                int id;

                NpgsqlCommand selectId = new NpgsqlCommand($"SELECT MAX(id) FROM {tableName}", connection);

                id = (int)selectId.ExecuteScalar() + 1;

                return id;
            }
            catch
            {
                return 1;
            }
        }
    }
}
