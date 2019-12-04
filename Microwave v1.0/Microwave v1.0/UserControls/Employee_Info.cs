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
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;

namespace Microwave_v1._0.UserControls
{
    public enum COLOR
    {
        NORMAL, ID, NAME, GENDER, EMAIL,BIRTH_DATE
    }
    public partial class Employee_Info : UserControl
    {
        private Microwave_v1._0.Forms.ShowEmployee main_page;
        private Employee_List employee_list;
        private Employee_List search_list;
        private AddEmployee edit_form = null;
        private Detail detail_form = null;
        private Panel main_panel = null;
        private Book_Tag main_tag = null;

        private int employee_id;
        private string department_name;
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string birth_date;
        private string cover_path_file;
        private bool chosen = false;
        private COLOR color_mode;

        public int Employee_id { get => employee_id; set => employee_id = value; }

        public Employee_Info(Employee_List main_list,Employee_List search_list, Book_Tag main_tag, Panel pnl)
        {
            InitializeComponent();
            this.employee_list = main_list;
            this.search_list = search_list;
            this.main_panel = pnl;
            this.main_tag = main_tag;

            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            employee_list = main_page.Main_employee_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();

        } 

        public void Initialize_Employee_Info(int employee_id,string department_name,string name,string surname,string email, string birth_date,string gender,string cover_path_file,COLOR mode)
        {

            this.employee_id = employee_id;
            this.department_name = department_name;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.birth_date = birth_date;
            this.gender = gender;
            this.cover_path_file = cover_path_file;
            this.color_mode = mode;

            this.lbl_id.Text = employee_id.ToString();
            this.lbl_department.Text = department_name;
            this.lbl_name.Text = name;
            this.lbl_surname.Text = surname;
            this.lbl_gender.Text = gender;
            this.lbl_email.Text = email;
            this.lbl_birthdate.Text = birth_date;

            Color new_color = Color.FromArgb(59, 180, 193);

            if (mode == COLOR.ID)
                this.pnl_id.BackColor = new_color;
            else if (mode == COLOR.NAME)
                this.pnl_name.BackColor = new_color;
            else if (mode == COLOR.EMAIL)
                this.pnl_email.BackColor = new_color;
            else if (mode == COLOR.GENDER)
                this.pnl_birthdate.BackColor = new_color;
            else if (mode == COLOR.BIRTH_DATE)
                this.pnl_gender.BackColor = new_color;


        }
        public void Hide_Info()
        {
            main_page.Pnl_employee_list.Controls.Remove(this);
        }  
        public void Draw_Employee_obj(ref int y)
        {
            main_page.Pnl_employee_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            this.SendToBack();
            y += 50;
        }
        public void Select_Employee_Info()
        {
            chosen = true;
            Book_Tag main_employee_tag = main_page.Main_tag;
            Color back_color = Color.FromArgb(33, 37, 48);

            main_employee_tag.Edit_Book_Tag_for_emp(name +" "+ surname , "\n" + gender + "\n" + birth_date + "\n" + email + "\n",cover_path_file);
            main_page.Main_tag.pic_book.Visible = true;
            this.pnl_surname.BackColor = back_color;
            this.pnl_birthdate.BackColor = back_color;
            this.pnl_id.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_email.BackColor = back_color;
            this.pnl_gender.BackColor = back_color;
            this.pnl_department.BackColor = back_color;

            Color new_color = Color.FromArgb(4, 137, 152);

            if (color_mode == COLOR.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == COLOR.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == COLOR.EMAIL)
                this.pnl_email.BackColor = new_color;
            else if (color_mode == COLOR.GENDER)
                this.pnl_birthdate.BackColor = new_color;
            else if (color_mode == COLOR.BIRTH_DATE)
                this.pnl_gender.BackColor = new_color;

            this.btn_edit.Show();
            this.btn_remove.Show();
        }
        public void Deselect_Employee_Info()
        {
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
           
            this.pnl_name.BackColor = back_color;
            this.pnl_surname.BackColor = back_color;
            this.pnl_birthdate.BackColor = back_color;
            this.pnl_id.BackColor = back_color;
            this.pnl_email.BackColor = back_color;
            this.pnl_gender.BackColor = back_color;
            this.pnl_department.BackColor = back_color;

            Color new_color = Color.FromArgb(59, 180, 193);

            if (color_mode == COLOR.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == COLOR.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == COLOR.EMAIL)
                this.pnl_email.BackColor = new_color;
            else if (color_mode == COLOR.GENDER)
                this.pnl_birthdate.BackColor = new_color;
            else if (color_mode == COLOR.BIRTH_DATE)
                this.pnl_gender.BackColor = new_color;

            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }
        private void btn_remove_Click(object sender, EventArgs e)
        {
            ShowEmployee main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            string message = "Do you want to delete this Employee";
            main_page.Create_Warning_Form(message, Color.LimeGreen);
            bool delete_pic = true;
            if (main_page.Warning_form1.Result)
            {
                Remove(delete_pic);
            }
            main_page.Warning_form1.Refresh_Form();
            main_page.Pnl_employee_list.VerticalScroll.Value = 0;
            main_page.Main_employee_list.Draw_All_Employees();
        }
        public void Remove(bool delete_picture = true)
        {
            main_page.Main_employee_list.Delete_Employee_from_List(employee_id, delete_picture);
            this.Dispose();
            main_page.Pnl_employee_list.VerticalScroll.Value = 0;
            main_page.Main_employee_list.Draw_All_Employees();
            main_page.Main_tag.lbl_author.Text = " ";
            main_page.Main_tag.lbl_description.Text = " ";
            main_page.Main_tag.lbl_bookname.Text = " ";
            main_page.Main_tag.pic_book.Visible = false;

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            ShowEmployee main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            string message = "Do you want to edit this Employee";
            main_page.Create_Warning_Form(message, Color.MidnightBlue);
            if(main_page.Warning_form1.Result)
            {
                Edit();
            }
            main_page.Warning_form1.Refresh_Form();
            
        }
        private void Edit()
        {
            Employee current = main_page.Main_employee_list.Find_Employee_By_ID(Employee_id);
            Create_Add_Employee_Form_With_Employee(current);
        }
        private void Create_Add_Employee_Form_With_Employee(Employee employee)
        {
            if(edit_form== null)
            {
                edit_form = new AddEmployee(employee);
                edit_form.Show();
            }
            else
            {
                try
                {
                    edit_form.Show();
                }
                catch (Exception d)
                {

                    edit_form = new AddEmployee(employee);
                    edit_form.Show();
                }
            }
        }
        public void Employee_Hover()
        {
          if (!chosen)
          {
            Color back_color2 = Color.FromArgb(43, 47, 58);
            this.pnl_id.BackColor = back_color2;
            this.pnl_name.BackColor = back_color2;
            this.pnl_email.BackColor = back_color2;
            this.pnl_birthdate.BackColor = back_color2;
            this.pnl_department.BackColor = back_color2;
            this.pnl_surname.BackColor = back_color2;
            this.pnl_gender.BackColor = back_color2;

                Color new_color = Color.FromArgb(49, 170, 183);


                if (color_mode == COLOR.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == COLOR.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == COLOR.EMAIL)
                    this.pnl_email.BackColor = new_color;
                else if (color_mode == COLOR.GENDER)
                    this.pnl_birthdate.BackColor = new_color;
                else if (color_mode == COLOR.BIRTH_DATE)
                    this.pnl_gender.BackColor = new_color;
            }
        }
        public void Employee_Mouse_Leave()
        {
            if (!chosen)
            {
               
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_id.BackColor = back_color2;
                this.pnl_name.BackColor = back_color2;
                this.pnl_email.BackColor = back_color2;
                this.pnl_birthdate.BackColor = back_color2;
                this.pnl_department.BackColor = back_color2;
                this.pnl_surname.BackColor = back_color2;
                this.pnl_gender.BackColor = back_color2;

                Color new_color = Color.FromArgb(59, 180, 193);

                if (color_mode == COLOR.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == COLOR.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == COLOR.EMAIL)
                    this.pnl_email.BackColor = new_color;
                else if (color_mode == COLOR.GENDER)
                    this.pnl_birthdate.BackColor = new_color;
                else if (color_mode == COLOR.BIRTH_DATE)
                    this.pnl_gender.BackColor = new_color;
            }
        }
        private void Employee_Info_Click(object sender, EventArgs e)
        {
            main_page.Main_employee_list.Deselect_All_Infos();
            employee_list.Deselect_All_Infos();
            search_list.Deselect_All_Infos();
            this.Select_Employee_Info();
        }
        private void Employee_Info_MouseLeave(object sender, EventArgs e)
        {
            Employee_Mouse_Leave();
        }
        private void Employee_Info_MouseEnter(object sender, EventArgs e)
        {
            Employee_Hover();
        }
        private void Employee_Info_DoubleClick(object sender, EventArgs e)
        {
            Employee current = employee_list.Find_Employee_By_ID(employee_id);
            Create_Book_Detail_Form(current);


        }
        private void Create_Book_Detail_Form(Employee employee)
        {

            if (detail_form == null)
            {
                detail_form = new Detail(employee);
                detail_form.Show();
            }
            else
            {
                try
                {
                    detail_form.Show();
                }
                catch (Exception)
                {
                    detail_form = new Detail(employee);
                    detail_form.Show();
                }
            }
        }
    }
}


