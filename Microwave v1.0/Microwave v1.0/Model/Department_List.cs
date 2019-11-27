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

            for(int i = 1; i<rows_count; i++)
            {
                int department_id = int.Parse(dt.Rows[i][0].ToString());
                string department_name = dt.Rows[i][1].ToString();
                string cover_path = dt.Rows[i][2].ToString();

                Department department = new Department(department_name,  cover_path);
                department.Set_Department();
                this.Add_Department_to_List(department);
            }
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
        public void Show_All_Departments()
        {
            department_node iterator = root;
            while(iterator != null)
            {
                iterator.department.Info.Draw_Department_Obj(ref Department.point_x, ref Department.point_y);
                iterator = iterator.next;
            }
        }
        public void Deselect_All_Department_Infos()
        {
            department_node iterator = root;
            while (iterator != null)
            {
                iterator.department.Info.Deselect_Department_Info();
                iterator = iterator.next;
            }
        }
        public void Delete_Department_from_List(int department_id ,bool delete_picture)
        {

            department_node iterator = root;

            if( root == null)
            {
                return;
            }

            if (root.department.Department_id == department_id)
            {

                if (delete_picture == true)
                    Picture_Events.Delete_The_Picture(root.department.Cover_path_file);

                root.department.Delete();
                root.department = null;
                root = root.next;
                --department_count;
                return;
            }

            while (iterator.next.department.Department_id != department_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CAN'T FOUND");
                    return;

                }
            }

            if (delete_picture == true)
                Picture_Events.Delete_The_Picture(iterator.next.department.Cover_path_file);

            iterator.next.department.Delete();
            iterator.next.department = null;
            iterator.next = iterator.next.next;
            --department_count;
            return;
    }
        public Department Find_Department_By_ID(int department_id)
        {
            if(root == null)
            {
                return null;
            }

            department_node iterator = root;

            while(iterator.department.Department_id != department_id)
            {
                if(iterator.next== null)
                {
                    return null;
                }

                iterator = iterator.next;
            }

            return iterator.department;
        }

        public bool Is_Dep_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }
         
        public void Fill_Cover_Image_List()
        {
            department_node iterator = root;
            while (iterator != null)
            {
                iterator = iterator.next;
            }
        }
    }
}
