using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using System.Data;

namespace Microwave_v1._0.Model
{
    public class Category
    {
        public static int category_point_y = 5; // Category infoları ekrana çizdirirken kullanılan offset.
        public static int category_point_x = 35;

        static Microwave main_page = null;
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];


        private int category_id;
        private int popularity_id;
        private int popularity_score;
        private string category_name;
        private string category_cover_path_file;
        private Category_Info info;

        public int Category_id { get => category_id; set => category_id = value; }
        public string Category_name { get => category_name; set => category_name = value; }
        public string Category_cover_path_file { get => category_cover_path_file; set => category_cover_path_file = value; }
        public int Popularity_id { get => popularity_id; set => popularity_id = value; }
        public int Popularity_score { get => popularity_score; set => popularity_score = value; }
        public Category_Info Info { get => info; set => info = value; }

        public Category(int category_id, string category_name, int popularity_id, int popularity_score, string category_cover_path_file)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.category_id = category_id;
            this.popularity_id = popularity_id;
            this.popularity_score = popularity_score;
            this.category_name = category_name;
            this.category_cover_path_file = category_cover_path_file;
        }

        public Category()
        {
        }

        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Categories (NAME, POPULARITY_ID, POPULARITY_SCORE, COVER_PATH_FILE) ";
            values = string.Format("VALUES('{0}','{1}','{2}','{3}')", category_name, popularity_id, popularity_score, category_cover_path_file);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, data_source);

            info = new Category_Info();
            Take_Id_From_Database();

            Info.Initialize_Category_Info(category_id, category_name, category_cover_path_file);

            main_page.Main_category_list.Add_Category_to_List(this);
            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            info.Draw_Category_Obj(ref Category.category_point_x, ref Category.category_point_y);

        }


        private void Take_Id_From_Database()
        {
            string title = "SELECT Categories.CATEGORY_ID FROM Categories ";
            string query = title + string.Format("Where NAME = '{0}';", category_name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.category_id = this.info.Category_id = id;
        }

        public void Edit()
        {
            string title = "UPDATE Categories ";
            string query = title + string.Format("SET NAME = '{0}', COVER_PATH_FILE = '{1}' WHERE CATEGORY_ID = '{2}'", category_name, category_cover_path_file, category_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }

            info.Initialize_Category_Info(category_id, category_name, category_cover_path_file);
            info.Select_Category_Info();
        }
        public void Set_Categories()
        {
            info = new Category_Info();
            info.Initialize_Category_Info(category_id, category_name, category_cover_path_file);
        }

        //Search Method
        static public DataTable Search_Category_By_Name(string category_name)
        {
            string query = string.Format("Select * From Categories Where Categories.NAME Like '{0}%'", category_name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        public void Delete()
        {
            string title1 = "Update Books ";
            string query1 = title1 + string.Format("Set CATEGORY_ID = 0 Where Books.CATEGORY_ID = '{0}'", this.category_id);

            DataBaseEvents.ExecuteNonQuery(query1, data_source);

            string title = "DELETE FROM Categories ";
            string query = title + string.Format("Where CATEGORY_ID = '{0}' ;", category_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            if (result <= 0)
            {
                MessageBox.Show("Delete is not valid");
                return;
            }
        }

        public void Change_Popularity_Score()
        {
            string query = string.Format("Update Categories Set POPULARITY_SCORE = '{0}' Where CATEGORY_ID = '{1}'", popularity_score, category_id);
            DataBaseEvents.ExecuteNonQuery(query, data_source);

            Change_Popularity_Stat();

        }
        private void Change_Popularity_Stat()
        {
            string query = string.Format("Select * From Popularity Order By SCORE");
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            List<Popularity> pop_list = new List<Popularity>();

            int rows_count = dt.Rows.Count;

            if (rows_count <= 1)
                this.popularity_id = 0;
            else
            {
                for (int i = 0; i < rows_count; i++)
                {
                    int id = int.Parse(dt.Rows[i][0].ToString());
                    string name = dt.Rows[i][1].ToString();
                    int score = int.Parse(dt.Rows[i][2].ToString());
                    Popularity curr_pop = new Popularity(id, name, score);

                    pop_list.Add(curr_pop);
                }
            }

            for (int i = 0; i < pop_list.Count; i++)
            {
                if (this.popularity_score >= pop_list[i].Base_score)
                    this.popularity_id = pop_list[i].Pop_id;
            }


            string query_edit = string.Format("Update Categories Set POPULARITY_ID = '{0}' where CATEGORY_ID = '{1}'", this.popularity_id, this.category_id);
            DataBaseEvents.ExecuteNonQuery(query_edit, data_source);
        }

        static public void Show_All_Categories(Microwave main_page)
        {
            string query = "SELECT * FROM Categories";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            main_page.Main_category_list.Fill_Category_List(dt);
            main_page.Main_category_list.Draw_All_Categories();
        }
    }
}
