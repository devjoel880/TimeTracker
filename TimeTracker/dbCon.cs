using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace TimeTracker
{
    public class dbCon
    {
        public string dbPath = @"DataSource=TimeTracker.db";

        public void OpenConnetion()
        {
            using(var connection = new SqliteConnection(dbPath))
            {
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connection Sucessful"); // for debugging purposes
                }
                else
                {
                    Console.WriteLine("Connection Failed"); // for debugging purposes
                }
            }
        }
        public void CloseConnetion()
        {
            using (var connection = new SqliteConnection(dbPath))
            {
                connection.Close();
                if(connection.State == System.Data.ConnectionState.Closed)
                {
                    Console.WriteLine("Conenction Closed!"); // for debugging purposes
                }
                else
                {
                    Console.WriteLine("Connection Failed to close!"); // for debugging purposes
                }
            }
        }
        public void SaveMode(string mode, int duration)
        {
            using (var connection = new SqliteConnection(dbPath))
            {
                connection.Open();
                string query = "INSERT INTO Mode (modeName, durationInMinutes) VALUES (@modename, @duration)";
                var command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@modename", mode);
                command.Parameters.AddWithValue("@duration", duration);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Mode has been saved Successfuly!");
                }
                else
                {
                    MessageBox.Show("Failed to save Mode");
                }
            }
        }

        public void DeleteMode(string mode)
        {
            using(var connection  = new SqliteConnection(dbPath))
            {
                connection.Open();
                string query = $"DELETE FROM Mode WHERE modeName = {mode}";
                var cmd = new SqliteCommand(query, connection);

            }
        }

    }
}
