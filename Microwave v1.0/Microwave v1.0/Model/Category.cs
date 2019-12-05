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
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

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

            DataBaseEvents.ExecuteNonQuery(query, datasource);

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

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.category_id = this.info.Category_id = id;
        }

        public void Edit()
        {
            string title = "UPDATE Categories ";
            string query = title + string.Format("SET NAME = '{0}', COVER_PATH_FILE = '{1}' WHERE CATEGORY_ID = '{2}'", category_name, category_cover_path_file, category_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
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
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        public void Delete()
        {
            string title = "DELETE FROM Categories ";
            string query = title + string.Format("Where CATEGORY_ID = '{0}' ;", category_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            if (result <= 0)
            {
                MessageBox.Show("Delete is not valid");
                return;
            }
        }
        
        static public void Show_All_Categories(Microwave main_page)
        {
            string query = "SELECT * FROM Categories";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            main_page.Main_category_list.Fill_Category_List(dt);
            main_page.Main_category_list.Draw_All_Categories();
        }
    }
}
