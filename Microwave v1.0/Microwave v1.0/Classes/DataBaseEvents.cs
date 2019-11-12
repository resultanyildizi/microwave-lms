using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace Microwave_v1._0.Classes
{
    class DataBaseEvents
    {
        // Reading data from database
        public static SQLiteDataReader ExecuteQuery(SQLiteConnection con, string query)
        {
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            return reader;
        }

        // Insert, Delete, Update
        public static int ExecuteNonQuery(SQLiteConnection con, string query)
        {
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText = query;
            // Returns the number of rows which is affected
            int count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
    }
}
