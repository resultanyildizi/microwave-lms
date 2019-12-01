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

namespace Microwave_v1._0.UserControls
{
    public partial class Employee_Info : UserControl
    {
        private Microwave_v1._0.Forms.ShowEmployee main_page;
        private Employee_List employee_list;
        private AddEmployee edit_form = null;

        private int employee_id;
        private int department_id;
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string birth_date;
        private string cover_path_file;

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public int Department_id { get => department_id; set => department_id = value; }

        public Employee_Info()
        {
            InitializeComponent();
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            employee_list = main_page.Main_employee_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();

        } 

        public void Initialize_Employee_Info(int employee_id,int department_id,string name,string surname,string email, string gender,string birth_date,string cover_path_file)
        {

            this.employee_id = employee_id;
            this.department_id = department_id;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.gender = gender;
            this.birth_date = birth_date;
            this.cover_path_file = cover_path_file;

            this.lbl_id.Text = employee_id.ToString();
            this.lbl_department.Text = department_id.ToString();
            this.lbl_name.Text = name;
            this.lbl_surname.Text = surname;
            this.lbl_gender.Text = gender;
            this.lbl_email.Text = email;
            this.lbl_birthdate.Text = birth_date;
        }
        public void Draw_Employee_obj(ref int y)
        {
            main_page.Pnl_employee_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 50;
        }

        public void Hide_Info()
        {
            main_page.Pnl_employee_list.Controls.Remove(this);
        }

        public void Select_Employee_Info()
        {
            Book_Tag main_employee_tag = main_page.Main_tag;
            Color back_color = Color.FromArgb(33, 37, 48);

            main_employee_tag.Edit_Book_Tag_for_emp(name, surname + "/n" + gender + "/n" + birth_date + "/n" + email + "/n" ," ",cover_path_file);

            this.pnl_surname.BackColor = back_color;
            this.pnl_gender.BackColor = back_color;
            this.pnl_id.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_email.BackColor = back_color;

            this.btn_edit.Show();
            this.btn_remove.Show();
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

        private void Employee_Info_Click(object sender, EventArgs e)
        {
            this.Select_Employee_Info();
        }
    }
}


