using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Model;
using Microwave_v1._0.Forms;
using System.Data;
using System.Drawing;

namespace Microwave_v1._0.Model
{
    public class Employee
    {
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];

        public static int point_y = 5;


        private int department_id;
        private int employee_id;

        DateTime birth_date_dt;
        private string name;
        private string surname;
        private string birth_date;
        private string department_name;
        private string cover_path_file;
        private string email;
        private string password;
        private string gender;

        static Microwave_v1._0.Forms.ShowEmployee main_page = null;
        private Employee_Info info;


        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public Employee_Info Info { get => info; set => info = value; }
        public int Department_id { get => department_id; set => department_id = value; }
        public string Deparment_name { get => department_name; set => department_name = value; }
        public DateTime Birth_date_dt { get => birth_date_dt; set => birth_date_dt = value; }

        public Employee()
        {

        }

        public Employee(int employee_id, int department_id, string name, string surname, string password, string email, string gender, DateTime birth_date, string cover_path_file)
        {
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];


            this.employee_id = employee_id;
            this.department_id = department_id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.birth_date_dt = birth_date;
            this.birth_date = birth_date_dt.Date.ToString();
            this.gender = gender;
            this.password = password;
            this.cover_path_file = cover_path_file;
        }

        public void Add()
        {
            string title;
            string values;

            title = " INSERT INTO Employee (DEPARTMENT_ID , NAME, SURNAME, EMAIL, PASSWORD, GENDER, BIRTH_DATE,COVER_PATH)";
            values = string.Format(" VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", department_id, name, surname, email, password, gender, birth_date, cover_path_file);

            string query = string.Concat(title, values);


            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);

            if (result <= 0)
            {
                MessageBox.Show("Invalid insertion event");
                return;
            }

            info = new Employee_Info(main_page.Main_employee_list, main_page.Emp_search_list, main_page.Main_tag, main_page.Pnl_employee_list);
            Take_Id_From_Database();
            Join_Tables();

            info.Initialize_Employee_Info(employee_id, department_name, name, surname, email, birth_date.Substring(0, 10), gender, cover_path_file, COLOR.NORMAL);

            main_page.Main_employee_list.Add_Employee_to_List(this);
            main_page.Pnl_employee_list.VerticalScroll.Value = 0;
            info.Draw_Employee_obj(ref Employee.point_y);


        }
        public void Edit()
        {
            birth_date = birth_date_dt.ToString();
            string title = "UPDATE Employee ";
            string query = title + string.Format(" SET DEPARTMENT_ID = '{0}', NAME = '{1}', SURNAME = '{2}', EMAIL = '{3}', GENDER = '{4}', " +
                " BIRTH_DATE = '{5}', COVER_PATH = '{6}' Where Employee.EMPLOYEE_ID = '{7}'", department_id, name, surname, email, gender, birth_date, cover_path_file, employee_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }

            Join_Tables();

            info.Initialize_Employee_Info(employee_id, department_name, name, surname, email, birth_date.Substring(0, 10), gender, cover_path_file, COLOR.NORMAL);
            info.Select_Employee_Info();

        }

        public void Delete()
        {
            string title = "DELETE FROM Employee ";
            string query = title + string.Format("Where EMPLOYEE_ID = '{0}'", employee_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);
            if (result <= 0)
                MessageBox.Show("Delete is not valid");
            return;
        }
        public void Set_Employee(Employee_List main_list, Employee_List search_list, Book_Tag main_tag, Panel main_panel, COLOR color_mode)
        {
            Join_Tables();
            info = new Employee_Info(main_page.Main_employee_list, main_page.Emp_search_list, main_page.Main_tag, main_page.Pnl_employee_list);
            info.Initialize_Employee_Info(employee_id, department_name, name, surname, email, birth_date.Substring(0, 10), gender, cover_path_file, color_mode);
        }
        static public void Show_All_Employees(Department department)
        {
            int dep_id;
            string query;

            if (department != null)
            {
                dep_id = department.Department_id;
                query = "SELECT * FROM Employee WHERE Employee.DEPARTMENT_ID = " + dep_id;
            }
            else
            {
                query = "SELECT * FROM Employee";
            }


            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);


            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];

            main_page.Main_employee_list.Fill_Employee_List(dt, main_page.Main_employee_list, main_page.Emp_search_list, main_page.Main_tag, main_page.Pnl_employee_list, COLOR.NORMAL);
            main_page.Main_employee_list.Draw_All_Employees();

        }

        protected void Join_Tables()
        {
            DataTable dt = null;
            string query = string.Format("SELECT Department.name FROM Employee JOIN Department ON Department.DEPARTMENT_ID = Employee.DEPARTMENT_ID WHERE EMPLOYEE_ID = '{0}'", employee_id);

            dt = DataBaseEvents.ExecuteQuery(query, data_source);

            department_name = dt.Rows[0][0].ToString();
        }
        private void Take_Id_From_Database()
        {
            // To take the id of new book.
            string title = "SELECT Employee.EMPLOYEE_ID FROM Employee ";
            string query = title + string.Format("Where NAME = '{0}';", name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.employee_id = id;
            this.Info.Employee_id = id;
        }
        static public DataTable Search_Employee_By_Name(string name, string dep_id)
        {
            string query;
            if(dep_id == "-1")
                query = string.Format("Select * From Employee Where Employee.NAME Like '{0}%'", name);
            else
                query = string.Format("Select * From Employee Where Employee.NAME Like '{0}%' and DEPARTMENT_ID = '{1}'", name, dep_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Employee_By_ID(string id, string dep_id)
        {
            string query;
            if(dep_id == "-1")
                query = string.Format("Select * From Employee Where Employee.EMPLOYEE_ID Like '{0}%'", id);
            else
                query = string.Format("Select * From Employee Where Employee.EMPLOYEE_ID Like '{0}%' and DEPARTMENT_ID = '{1}'", id, dep_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }
        static public DataTable Search_Employee_By_Email(string email, string dep_id)
        {
            string query;
            if (dep_id == "-1")
                query = string.Format("Select * From Employee Where Employee.EMAIL Like '{0}%'", email);
            else
                query = string.Format("Select * From Employee Where Employee.EMAIL Like '{0}%' and DEPARTMENT_ID = '{1}'", email, dep_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;

        }
        static public DataTable Search_Employee_By_Gender(string gender, string dep_id)
        {
            string query;
            if(dep_id == "-1")
                query = string.Format("Select * From Employee Where Employee.GENDER Like '{0}%'", gender);
            else
                query = string.Format("Select * From Employee Where Employee.GENDER Like '{0}%' and DEPARTMENT_ID = '{1}'", gender, dep_id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            return dt;
        }

        static public int Contains_Email(string email)
        {
            string query = string.Format("Select Employee.EMPLOYEE_ID From Employee Where Employee.EMAIL = '{0}'", email);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            if (dt.Rows.Count <= 0)
                return -1;

            int id = int.Parse(dt.Rows[0][0].ToString());
            return id;
        }

        public void Change_Password(string password)
        {
            this.password = password;

            string query = string.Format("Update Employee Set PASSWORD = '{0}' Where Employee.EMPLOYEE_ID = '{1}'", password, this.employee_id);
            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);

            if(result > 0)
            {
                MessageBox.Show("Program neeeds to restart", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Microwave app= (Microwave)Application.OpenForms["Microwave"];
                app.Close();
                return;
            }
            else
            {
                MessageBox.Show("Invalid change operation", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
