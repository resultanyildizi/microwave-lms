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

namespace Microwave_v1._0.Model
{
   public  class Employee
    {
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        public static int point_y = 5;
        
        
        private int department_id;
        private int employee_id;
   
        
        private string name;
        private string surname;
        private string age;
        private string deparment_name;
        private string cover_path_file;
        private string email;
        private string password;
        private string gender;
        static Microwave_v1._0.Forms.ShowEmployee main_page;
        private Employee_Info info;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Age { get => age; set => age = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public Employee_Info Info { get => info; set => info = value; }
        public string Deparment_name { get => deparment_name; set => deparment_name = value; }
        public int Department_id { get => department_id; set => department_id = value; }
        public Employee()
        {

        }

        public Employee(int employee_id,string name,string surname,
                         string age,string cover_path_file,string email,string gender)
        {
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];    
           
            
            this.employee_id = employee_id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.cover_path_file = cover_path_file;
            this.email = email;
            this.gender = gender;

        }
        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Employee (NAME,SURNAME,EMAIL,AGE,GENDER,DEPARTMENT)";
            values = string.Format("VALUES'{0}','{1}','{2}','{3}','{4}','{5}'",name,surname,email,age,gender,department_id);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            info = new Employee_Info();
            Take_Id_From_Database();

            Join_Tables();

            info.Initialize_Employee_Info(employee_id,name,surname,email,gender,age,cover_path_file);

            main_page.Main_employee_list.Add_Employee_to_List(this);
            main_page.Pnl_employee_list.VerticalScroll.Value = 0;
            info.Draw_Employee_obj(ref Employee.point_y);


        }
        public void Set_Employee()
        {
            info = new Employee_Info();
            info.Initialize_Employee_Info(employee_id, name, surname, email, gender, age, cover_path_file);
        }
        static public void Show_All_Employees()
        {
            string query = "SELECT * FROM Employee ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);


            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
           
            main_page.Main_employee_list.Fill_Employee_List(dt);
            main_page.Main_employee_list.Show_All_Employees();

        }
        private void Join_Tables()
        {
            DataTable dt = null;
            string query = string.Format("SELECT Department.name FROM Employee JOIN Department ON Department.DEPARTMENT_ID = Employee.DEPARTMENT_ID WHERE EMPLOYEE_ID = '{0}'", employee_id);

            dt = DataBaseEvents.ExecuteQuery(query, datasource);

            deparment_name = dt.Rows[0][0].ToString();
        }
        private void Take_Id_From_Database()
        {
            // To take the id of new book.
            string title = "SELECT Employee.EMPLOYEE_ID FROM Employee ";
            string query = title + string.Format("Where NAME = '{0}';", name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.employee_id = id;


            // For user inteface
            this.Info.Employee_id = id; // IMPORTANT
        }

    }
}
