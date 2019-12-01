using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Forms;
using System.Data;
using System.Data.SQLite;
using System.Threading;

namespace Microwave_v1._0.Model
{
    class employee_node
    {
        public employee_node next;
        public Employee employee;

        public employee_node(Employee a)
        {
            this.employee = a;
            this.next = null;
        }
    }

   public class Employee_List
    {
        private int employee_count;
        employee_node root;

        public int Employee_Count { get => employee_count; set => employee_count = value; }

        public Employee_List()
        {
            root = null;
        }
        public void Fill_Employee_List(DataTable dt)
        {
            int rows_count = dt.Rows.Count;

            if (rows_count == 0) return;

            for (int i = 0; i < rows_count; i++)
            {
                int employee_id = int.Parse(dt.Rows[i][0].ToString());
                int department_id = int.Parse(dt.Rows[i][1].ToString());
                string employee_name = dt.Rows[i][2].ToString();
                string employee_surname = dt.Rows[i][3].ToString();
                string employee_email = dt.Rows[i][4].ToString();
                string employee_password = dt.Rows[i][5].ToString();
                string birth_date = dt.Rows[i][6].ToString();
                string employee_gender = dt.Rows[i][7].ToString();
                string pic_path_file = dt.Rows[i][8].ToString();

                Employee employee = new Employee(employee_id, department_id, employee_name, employee_surname, birth_date, employee_email, employee_password, employee_gender, pic_path_file);
                employee.Set_Employee();
                this.Add_Employee_to_List(employee);
                
            }
        }

        public void Add_Employee_to_List(Employee employee)
        {
            if(root==null)
            {
                root = new employee_node(employee);
                employee_count++;
                return;
            }

            employee_node iterator = root;
            while (iterator.next != null)
            {
                iterator = iterator.next;
            }
            iterator.next = new employee_node(employee);
            employee_count++;
        }
        public void Draw_All_Employees() 
        {
            Employee.point_y = 5;
            employee_node iterator = root;

            while(iterator != null)
            {
                iterator.employee.Info.Draw_Employee_obj(ref Employee.point_y);
                iterator.employee.Info.Show();
                iterator = iterator.next;
            }
        }

    }
}

