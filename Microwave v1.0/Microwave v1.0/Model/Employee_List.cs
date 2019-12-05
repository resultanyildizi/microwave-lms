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
using System.Drawing;

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
        public void Fill_Employee_List(DataTable dt, Employee_List main_list, Employee_List search_list, Book_Tag main_tag, Panel main_panel, COLOR color_mode)
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
                string employee_gender = dt.Rows[i][6].ToString();
                string birth_date = dt.Rows[i][7].ToString();
                string pic_path_file = dt.Rows[i][8].ToString();

                DateTime bd = Convert.ToDateTime(birth_date);
                Employee employee = new Employee(employee_id, department_id, employee_name, employee_surname, employee_password, employee_email, employee_gender, bd, pic_path_file);
                employee.Set_Employee(main_list, search_list, main_tag, main_panel, color_mode);
                this.Add_Employee_to_List(employee);

            }
        }

        public void Add_Employee_to_List(Employee employee)
        {
            if (root == null)
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
        public void Delete_Employee_from_List(int employee_id, bool delete_picture)
        {
            employee_node iterator = root;

            if (root == null)
            {
                return;
            }

            if (root.employee.Employee_id == employee_id)
            {
                root.employee.Delete();
                if (delete_picture == true)
                    Picture_Events.Delete_The_Picture(root.employee.Cover_path_file);
                root.employee = null;
                root = root.next;
                return;
            }

            while (iterator.next.employee.Employee_id != employee_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CANT FOUND");
                    return;
                }
            }

            iterator.next.employee.Delete();
            if (delete_picture == true)
                Picture_Events.Delete_The_Picture(iterator.next.employee.Cover_path_file);
            iterator.next.employee = null;
            iterator.next = iterator.next.next;
            return;
        }

        public void Deselect_All_Infos()
        {
            employee_node iterator = root;
            while (iterator != null)
            {
                iterator.employee.Info.Deselect_Employee_Info();
                iterator = iterator.next;
            }
        }
        public void Delete_All_List()
        {
            employee_node iterator = root;
            employee_node current;
            while (iterator != null)
            {
                current = iterator.next;
                iterator.employee.Info.Dispose();
                iterator.employee = null;
                iterator = current;
            }
            root = null;
        }
        public void Hide_All_Employee_Objects()
        {
            employee_node iterator = root;
            while (iterator != null)
            {
                iterator.employee.Info.Hide_Info();
                iterator = iterator.next;
            }
        }

        public void Draw_All_Employees()
        {
            Employee.point_y = 5;
            employee_node iterator = root;

            while (iterator != null)
            {
                iterator.employee.Info.Draw_Employee_obj(ref Employee.point_y);
                iterator.employee.Info.Show();
                iterator = iterator.next;
            }
        }
        public Employee Find_Employee_By_ID(int employee_id)
        {
            if (root == null)
                return null;

            employee_node iterator = root;

            while (iterator.employee.Employee_id != employee_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.employee;
        }


    }
}

