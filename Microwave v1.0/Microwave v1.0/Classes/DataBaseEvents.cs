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
        // Reads the first coloumn of the first row
        public static string ExecuteQuery_String(string query, string datasource)
        {
            string result = null;
            SQLiteConnection con = new SQLiteConnection(datasource);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            result = reader.GetString(0);
            reader.Close();
            cmd.Dispose();
            con.Close();
            return result;
        }

        public static int ExecuteQuery_Int32(string query, string datasource)
        {
            int result = -1;
            SQLiteConnection con = new SQLiteConnection(datasource);
                con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            result = reader.GetInt32(0);
            reader.Close();
            cmd.Dispose();
            con.Close();
            return result;
        }

        // Insert, Delete, Update
        public static int ExecuteNonQuery(string query, string datasource)
        {
            SQLiteConnection connect = new SQLiteConnection(datasource);
            connect.Open();
            SQLiteCommand cmd = connect.CreateCommand();
            cmd.CommandText = query;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            connect.Close();
            cmd.Connection.Close();
            return 1;
        }
    }
}
