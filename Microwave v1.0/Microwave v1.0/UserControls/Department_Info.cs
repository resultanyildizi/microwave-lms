using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.UserControls
{
    public partial class Department_Info : UserControl
    {
        private Microwave main_page;
        private Department_List department_list;
        private AddDepartment edit_form = null;
        private ShowEmployee show_employee = null;

        private string name;
        private string pic_path_file;
        private int department_id;
        private bool chosen = false;
        public int Department_id { get => department_id; set => department_id = value; }

        public Department_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            department_list = main_page.Main_department_list;
            this.btn_dprt_edit.Hide();
            this.btn_dprt_remove.Hide();
        }
        public void Initialize_Department_Info(int department_id,string name, string pic_path_file)
        {
            this.department_id = department_id;
            this.name = name;
            this.pic_path_file = pic_path_file;
            //pb_department.Image = main_page.Dep_cover_image_list.Images[department_id.ToString()];
            pb_department.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_path_file);
            this.lbl_department_name.Text = name;
            this.btn_dep_id.Text = department_id.ToString();
        }
        public void Draw_Department_Obj(ref int x, ref int y)
        {
            main_page.Pnl_department_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);
            if (x > 500)
            {
                y += 240;
                x = 35;
            }
            else
                x += 180;
        }
        public void Select_Department_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            Color back_color2 = Color.FromArgb(48, 52, 64);
            this.pnl_name.BackColor = back_color2;
            this.BackColor = back_color;
            this.btn_dprt_edit.Show();
            this.btn_dprt_remove.Show();
        }
        public void Deselect_Department_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.BackColor = back_color;
            Color back_color2 = Color.FromArgb(55, 57, 68);
            this.pnl_name.BackColor = back_color2;
            btn_dprt_edit.Hide();
            btn_dprt_remove.Hide();
        }
        private void Department_Info_Click(object sender, EventArgs e)
        {
            department_list.Deselect_All_Department_Infos();
            this.Select_Department_Info();
        }


        private void btn_dprt_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this department";
            main_page.Create_Warning_Form(message, Color.Aqua);
            if (main_page.Warning_form.Result)
            {
                Remove();
            }
            main_page.Warning_form.Refresh_Form();

        }
        private void Remove(bool delete_picture = true)
        {
            department_list.Delete_Department_from_List(department_id, delete_picture);
            this.Dispose();

            main_page.Pnl_department_list.VerticalScroll.Value = 0;
            Department.point_x = 35;
            Department.point_y = 5;

            department_list.Draw_All_Dep_Infos();

        }

        private void btn_dprt_edit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to edit this department?";
            main_page.Create_Warning_Form(message, Color.Goldenrod);
            if (main_page.Warning_form.Result)
            {
                Edit();
            }
            main_page.Warning_form.Refresh_Form();
        }

        private void Edit()
        {
            Department current = department_list.Find_Department_By_ID(department_id);
            Create_Add_Department_Form_With_Department(current);

        }

        public void Create_Add_Department_Form_With_Department(Department department)
        {
            if (edit_form == null)
            {
                edit_form = new AddDepartment(department);
                edit_form.Show();
            }
            else
            {
                try
                {
                    edit_form.Show();
                }
                catch (Exception)
                {
                    edit_form = new AddDepartment(department);
                    edit_form.Show();
                }
            }
        }

        public void Dep_Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_name.BackColor = back_color2;
            }
        }
        public void Dep_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_name.BackColor = back_color2;
            }
        }

        private void Department_Info_MouseLeave(object sender, EventArgs e)
        {
            Dep_Mouse_Leave();
        }

        private void Department_Info_MouseEnter(object sender, EventArgs e)
        {
            Dep_Hover();
        }

        private void lbl_department_name_Click(object sender, EventArgs e)
        {
            department_list.Deselect_All_Department_Infos();
            this.Select_Department_Info();
        }
        private void pb_department_DoubleClick(object sender, EventArgs e)
        {
            Department current = department_list.Find_Department_By_ID(department_id);
            if (show_employee == null)
            {
                show_employee = new ShowEmployee(current);
            }

            try
            {
                show_employee.Show();
            }
            catch (ObjectDisposedException d)
            {
                show_employee = new ShowEmployee(current);
                show_employee.Show();
            }
        }
    }
}
