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
        public static int point_x = 35;
        private string name;
        private int department_id;
        private int staff_count;
        private string cover_path_file;
        static Microwave main_page = null;
        private Department_Info info;
        
       

        public string Name { get => name; set => name = value; }
        public int Department_id { get => department_id; set => department_id = value; }
        public int Staff_count { get => staff_count; set => staff_count = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public Department_Info Info { get => info; set => info = value; }

        public Department(string name,string Cover_path_file)
        {
            this.name = name;
            this.cover_path_file = Cover_path_file;
            main_page = (Microwave)Application.OpenForms["Microwave"];
        }
        public Department()
        {

        }
        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Department (NAME, COVER_PATH)";
            values = string.Format("VALUES('{0}','{1}')", name, cover_path_file);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            info = new Department_Info();
            Take_Id_From_Database();
            

            info.Initialize_Department_Info(name, cover_path_file);

           
            main_page.Main_department_list.Add_Department_to_List(this);
            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            info.Draw_Department_Obj(ref Department.point_x, ref Department.point_y);

        }
        public void Set_Department()
        {
            info = new Department_Info();
            info.Initialize_Department_Info(name, cover_path_file);
        }
      public void Delete()
        {
            string title = "DELETE FROM Department ";
            string query = title + string.Format("Where DEPARTMENT_ID = '{0}' ;", department_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            if ( result <= 0)
            {
                MessageBox.Show("Delete is not valid");
                return;
            }
        }
        private void Take_Id_From_Database()
        {
            // To take the id of new book.
            string title = "SELECT Department.DEPARTMENT_ID FROM Department ";
            string query = title + string.Format("Where NAME = '{0}';", name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.department_id = id;


            // For user inteface
            this.Info.Department_id = id; // IMPORTANT
        }
       static public void Show_All_Departments()
        {
            string query = "SELECT * FROM Department";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            main_page.Main_department_list.Fill_Department_list(dt);
            main_page.Main_department_list.Show_All_Departments();

        }
    }
}
    
