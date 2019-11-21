using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using System.Data;


namespace Microwave_v1._0.Classes
{
    public class Department
    {
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        public static int point_y = 5;

        private string name;
        private int department_ıd;
        private int staff_count;
        private string Cover_path_file;
        Microwave main_page = null;
        private Department_Info info;
        
       

        public string Name { get => name; set => name = value; }
        public int Department_ıd { get => department_ıd; set => department_ıd = value; }
        public int Staff_count { get => staff_count; set => staff_count = value; }
        public string Cover_path_file1 { get => Cover_path_file; set => Cover_path_file = value; }
        public Department_Info Info { get => info; set => info = value; }

        public Department(string name,string Cover_path_file)
        {
            this.name = name;
            this.Cover_path_file = Cover_path_file;
        }
        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Department (NAME, COVER_PATH)";
            values = string.Format("VALUES('{0}','{1}')", name, Cover_path_file);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            info = new Department_Info();
            
        }
        public void Set_Department()
        {
            info = new Department_Info();
            info.Initialize_Department_Info(name, Cover_path_file);
        }
        public void Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.Department_ıd.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.Cover_path_file));
        }
        private void Take_Id_From_Database()
        {
            // To take the id of new book.
            string title = "SELECT Department.DEPARTMENT_ID FROM Department ";
            string query = title + string.Format("Where NAME = '{0}';", name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.department_ıd = id;


            // For user inteface
            this.Info.Department_ıd = id; // IMPORTANT
        }

    }
}
    
