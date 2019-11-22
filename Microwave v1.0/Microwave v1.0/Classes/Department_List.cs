using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Classes;
using System.Data;


namespace Microwave_v1._0.Classes
{
    class department_node
    {
        public department_node next;
        public Department department;
        
        public  department_node(Department a)
        {
            this.department = a;
            this.next = null;
        }
    }
   public class Department_List
    {
        int point_y = Department.point_y;
        private int department_count;
        department_node root;

        public int Department_count { get => department_count; set => department_count = value; }

        public Department_List()
        {
            root = null;
        }

        public void Fill_Department_list(DataTable dt)
        {
            int rows_count = dt.Rows.Count;

            for(int i = 0; i<rows_count; i++)
            {
                int department_id = int.Parse(dt.Rows[i][0].ToString());
                string department_name = dt.Rows[i][1].ToString();
                int staff_count = int.Parse(dt.Rows[i][2].ToString());
                string cover_path = dt.Rows[i][3].ToString();

                Department department = new Department(department_name,  cover_path);
                department.Set_Department();
                this.Add_Department_to_List(department);
            }
                Fill_Cover_Image_List();
        }

        public void Add_Department_to_List(Department department)
        {
            if(root == null)
            {
                root = new department_node(department);
                department_count++;
                return;
            }
            department_node iterator = root;
            while (iterator.next != null)
            {
                iterator = iterator.next;
            }
            iterator.next = new department_node(department);
            department_count++;
        }
        public void Fill_Cover_Image_List()
        {
            department_node iterator = root;
            while (iterator != null)
            {
                //iterator.department.Cover_Pic_to_Image_List();
                iterator = iterator.next;
            }
        }

        // SİLERKEN COUNT AZALTILACAK!!!!
    }
}
