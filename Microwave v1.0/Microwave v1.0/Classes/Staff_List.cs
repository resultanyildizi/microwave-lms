using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.Classes
{ 
    class staff_node
    {
        public staff_node next;
        public Staff staff;

        public staff_node(Staff b)
        {
            this.staff = b;
            this.next = null;
        }
    }
    class Staff_List
    {
        private static string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        static Microwave show_page;

        staff_node root;

        public Staff_List()
        {
            root = null;
        }

        public static void Read_Database()
        {
            show_page = (Microwave)Application.OpenForms["ShowStaff"];
            string query = "SELECT Staff.Name || ' ' ||Staff.Surname AS name,Staff.Age,Staff.Gender,staff.Email,Department.DepartmentName,Staff.Working_Hour,Staff.Starting_Date FROM Staff , Department WHERE staff.Department_ID = Department.DepartmentID ";
            SQLiteConnection con = new SQLiteConnection();
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            SQLiteDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString(0);
                int age = reader.GetInt32(1);
                string gender = reader.GetString(2);
                string email = reader.GetString(3);
                string department = reader.GetString(4);
                int working_hour = reader.GetInt32(5);
                int starting_date = reader.GetInt32(6);

                Staff staff = new Staff(name, email, gender, department, working_hour, starting_date);
            }
            con.Close();
        }
        public void Add_Staff_to_List(Staff staff)
        {
            if(root == null)
            {
                root = new staff_node(staff);
                return;
            }
            staff_node iterator = root;
            while (iterator.next != null)
            {
                iterator = iterator.next;
            }
            iterator.next = new staff_node(staff);
        }

        
    }
}
