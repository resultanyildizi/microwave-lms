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
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string age;
        private string cover_path_file;

        public int Employee_id { get => employee_id; set => employee_id = value; }

        public Employee_Info()
        {
            InitializeComponent();
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            employee_list = main_page.Main_employee_list;

        } 

        public void Initialize_Employee_Info(int employee_id,string name,string surname,string email, string gender,string age,string cover_path_file)
        {

            this.name = name;
            this.surname = surname;
            this.email = email;
            this.gender = gender;
            this.age = age;
            this.employee_id = employee_id;
            this.cover_path_file = cover_path_file;
            

            this.lbl_name.Text = name;
            this.lbl_surname.Text = surname;
            this.lbl_gender.Text = gender;
            this.lbl_id.Text = employee_id.ToString();
            this.lbl_email.Text = email;
        }
        public void Draw_Employee_obj(ref int y)
        {
            main_page.Pnl_employee_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 55;
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


    }
}


