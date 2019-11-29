using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;
using Microwave_v1._0.Forms;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Properties;

namespace Microwave_v1._0.Forms
{
    public partial class AddEmployee : Form
    {
        private string name;
        private string surname;
        private string email;
        private string birth_date;
        private string gender;
        private string department;
        
        private int employee_id;
        private int department_id;
        Microwave_v1._0.Forms.ShowEmployee main_page;

        Picture_Events picture_event;
        private string picture_default_file = @"..\..\Resources\Employee Covers\Employee.png";
        private string pic_dest_path = @"..\..\Resources\Employee\";
        private string pic_new_source_path = "";

        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private bool is_edit = false;
        private bool change_image = false;
        private Employee employee_to_edit = null;

        public AddEmployee()
        {
            InitializeComponent();

            rdo_female.Checked = true;
            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, picture_default_file, ref this.pic_employee);
            pic_new_source_path = picture_event.Pic_source_file;

            Fill_Comboboxes();

            this.cb_department.SelectedIndex = 0;

            this.BringToFront();
        }
        public AddEmployee(Employee employee)
        {
            InitializeComponent();
           

            main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, picture_default_file, ref this.pic_employee);

            employee_to_edit = employee;

            Fill_Comboboxes();

            this.cb_department.SelectedIndex = this.cb_department.Items.IndexOf(employee.Name);

            this.tb_name.Text = employee.Name;
            this.tb_name.ForeColor = Color.LightGray;
            this.tb_surname.Text = employee.Surname;
            this.tb_surname.ForeColor = Color.LightGray;
            this.tb_email.Text = employee.Email;
            this.tb_email.ForeColor = Color.LightGray;
            



            pic_new_source_path = picture_event.Pic_source_file = employee.Cover_path_file;
            pic_employee.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_dest_path);

            is_edit = true;

            this.BringToFront();



        }
        private void Add_Click_Func(bool is_edit)
        {
            name = tb_name.Text.Replace('\'',' ');
            surname = tb_surname.Text;
            email = tb_email.Text;
            birth_date = dtp_time.Value.ToString();
            department = cb_department.SelectedIndex.ToString();

            lbl_message.Text = "";


            if (tb_name.Text.Trim() == "Employee's Name" || tb_name.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter name.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }
            if (tb_surname.Text.Trim() == "Employee's Surname" || tb_surname.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter surname.";
                lbl_message.ForeColor = Color.Red;
                tb_surname.Focus();
                return;
            }
            if (tb_email.Text.Trim() == "Employee's E-mail" || tb_email.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter e-mail.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }
            if (rdo_male.Checked)
            {
                gender = "Male";
            }
            else if (rdo_female.Checked)
            {
                gender = "Female";
            }
            else
            {
                lbl_message.Text = "* Please select gender";
                lbl_message.ForeColor = Color.Red;
                return;
            }


            if (is_edit == false)
            {
                if (picture_event.Pic_source_file != null && picture_event.Pic_source_file != picture_default_file)
                {
                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;

                    Employee employee_1 = new Employee(employee_id, name, surname, birth_date, pic_new_source_path, email, gender);
                }
                else
                {
                    pic_new_source_path = picture_default_file;

                }
                Employee employee = new Employee(employee_id, name, surname, birth_date, pic_new_source_path, email, gender);
                employee.Add();

            }
        }

        private void Fill_Comboboxes()
        {
            SQLiteConnection con = new SQLiteConnection(datasource);
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
            string query = "";

            con.Open();
            query = string.Format("SELECT Department.NAME FROM Department");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_department.Items.Add(reader.GetString(0));
            }
            cmd.Dispose();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Click_Func(is_edit);
        }

        private void btn_add_pic_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();
        }
    }
}
