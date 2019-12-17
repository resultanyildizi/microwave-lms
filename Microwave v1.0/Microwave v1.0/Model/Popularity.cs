using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microwave_v1._0.Classes;
using System.Windows;

namespace Microwave_v1._0.Model
{
    public class Popularity
    {

        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        private int pop_id;
        private string name;
        private int base_score;

        public int Pop_id { get => pop_id; set => pop_id = value; }
        public string Name { get => name; set => name = value; }
        public int Base_score { get => base_score; set => base_score = value; }

        public Popularity(int id, string name, int score)
        {
            this.pop_id = id;
            this.name = name;
            this.base_score = score;
        }

        public void Add()
        {
            string query = string.Format("Insert into Popularity(NAME,SCORE) Values('{0}', '{1}')", name, base_score);
            DataBaseEvents.ExecuteNonQuery(query, data_source);

            Take_ID_From_DataBase();
        }

        public void Edit()
        {
            string query = string.Format("Update Popularity Set NAME = '{0}',  SCORE = '{1}' Where POPULARITY_ID = '{2}'", name, base_score, pop_id);
            DataBaseEvents.ExecuteNonQuery(query, data_source);
        }

        public void Delete()
        {
            string query1 = string.Format("Update Books Set POPULARITY_ID = 0 Where POPULARITY_ID = '{0}'", this.pop_id);
            string query2 = string.Format("Update Authors Set POPULARITY_ID = 0 Where POPULARITY_ID = '{0}'", this.pop_id);
            string query3 = string.Format("Update Categories Set POPULARITY_ID = 0 Where POPULARITY_ID = '{0}'", this.pop_id);

            DataBaseEvents.ExecuteNonQuery(query1, data_source);

            string query = string.Format("Delete From Popularity Where Popularity.POPULARITY_ID = '{0}'", pop_id);
            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);

            if(result <= 0)
            {
                MessageBox.Show("Invalid delete operation");
                return;
            }
        }
        public static DataTable Show_All_Popularities()
        {
            string query = "Select * From Popularity";

            return DataBaseEvents.ExecuteQuery(query, data_source);
        }

        private void Take_ID_From_DataBase()
        {
            string query = string.Format("Select POPULARITY_ID From Popularity Where NAME = '{0}'", name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.pop_id = id;
        }

        public static int Contains_Name(string val)
        {
            string query = string.Format("Select POPULARITY_ID From Popularity Where NAME = '{0}'", val);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            if (dt.Rows.Count <= 0)
                return -1;

            return int.Parse(dt.Rows[0][0].ToString());
        }

        public static int Contains_Score(int score)
        {
            string query = string.Format("Select POPULARITY_ID From Popularity Where SCORE = '{0}'", score);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            if (dt.Rows.Count <= 0)
                return -1;

            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
