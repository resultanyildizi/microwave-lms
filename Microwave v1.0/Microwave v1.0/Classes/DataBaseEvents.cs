using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Microwave_v1._0.Classes
{
    class DataBaseEvents
    {
        // Reads the first coloumn of the first row
        public static DataTable ExecuteQuery(string query, string datasource)
        {
            SQLiteConnection con = new SQLiteConnection(datasource);
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            DataTable data_table = new DataTable();
            adapter.Fill(data_table);
            con.Close();
            return data_table;
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
