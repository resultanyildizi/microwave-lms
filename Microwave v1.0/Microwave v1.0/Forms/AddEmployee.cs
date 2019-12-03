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
        private string password;
        
        private int employee_id;
        private int department_id;
        Employee employee;
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
            department_id = int.Parse(cb_department.SelectedIndex.ToString());
            password = Generate_Auto_Password();


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
            if (!is_a_valid_email(email))
                return;

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
                }
                else
                    pic_new_source_path = picture_default_file;

                Employee employee = new Employee(employee_id, department_id, name, surname, birth_date, email, password, gender, pic_new_source_path);
                employee.Add();



                Clear();
            }
            else
            {
                if (change_image)
                {
                    if (employee_to_edit.Cover_path_file != picture_default_file)
                        Picture_Events.Delete_The_Picture(employee_to_edit.Cover_path_file);
                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;
                    change_image = false;
                }

                lbl_message.Text = "*Employee changed successfully";
                lbl_message.ForeColor = Color.LightGreen;

                employee_to_edit.Name = name;
                employee_to_edit.Surname = surname;
                employee_to_edit.Gender = gender;
                employee_to_edit.Email = email;
                employee_to_edit.Age = birth_date;
                employee_to_edit.Department_id = department_id;

                employee_to_edit.Edit();

                main_page.Pnl_employee_list.VerticalScroll.Value = 0;
                main_page.Main_employee_list.Draw_All_Employees();
               
            }
        }

        public void Clear()
        {
            this.cb_department.SelectedIndex = 0;
            this.cb_department.ForeColor = Color.Gray;
            tb_name.Text = "Employee's Name";
            tb_surname.Text = "Employee's Surname";
            tb_email.Text = "Employee's E-mail";
            tb_name.ForeColor = Color.Gray;
            tb_surname.ForeColor = Color.Gray;
            tb_email.ForeColor = Color.Gray;
            
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
        private bool is_a_valid_email(string email)
        {
            string[] invalid_ends = { ".", "_", "-", "!", "\"", "é", "'", "^", "+", "%",
                                       "&", "/", "(", ")",  "=", "?", ",", ";", ":", "<",
                                       ">", "|", "`", "#",  "$", "½", "{", "}", "[", "]",
                                       "\\", "ç", "Ç", "~", "ş", "Ş", "ğ", "Ğ", "İ", "ü",
                                       "Ü" , "ö", "Ö", "ı", "æ", "ß", "´", "₺", "€", "@",
                                        " "};

            string[] invalid_chars = { "!", "\"", "é","^", "+", "%","&", "/", "(", ")",
                                       "=", "?", ",", ";", ":", "<",">", "|", "`", "#",
                                       "$", "½", "{", "}", "[", "]","\\","ç", "Ç", "~",
                                       "ş", "Ş", "ğ", "Ğ", "İ", "ü","Ü" ,"ö", "Ö", "ı",
                                       "æ", "ß", "´", "₺", "€", "@", " "};

            string[] invalid_chars_all = {"_", "-", "!", "\"", "é", "'", "^", "+", "%",
                                            "&", "/", "(", ")",  "=", "?", ",", ";", ":", "<",
                                         ">", "|", "`", "#",  "$", "½", "{", "}", "[", "]",
                                         "\\", "ç", "Ç", "~", "ş", "Ş", "ğ", "Ğ", "İ", "ü",
                                         "Ü" , "ö", "Ö", "ı", "æ", "ß", "´", "₺", "€", "@",
                                        " "};

            string message = "Please enter a valid email.";
            lbl_message.ForeColor = Color.Red;
            int index_of_at = email.IndexOf('@');

            // Checking for '@'
            if (index_of_at == -1)
            {
                lbl_message.Text = message;
                return false;
            }

            // Substringing email
            string head_email = email.Substring(0, index_of_at);
            string tail_email = email.Substring(index_of_at + 1, email.Length - index_of_at - 1);

            // Checking for invalid chars
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(head_email.IndexOf(invalid_chars[i]) == -1))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid end
            if (head_email.EndsWith("."))
            {
                lbl_message.Text = message;
                return false;
            }


            // Checking for '.' after '@'
            bool contains_dot = false;
            int[] indexes_of_dots = new int[20];

            int j = 0;
            for (int i = 0; i < tail_email.Length; i++)
            {
                if (tail_email[i] == '.')
                {
                    indexes_of_dots[j] = i;
                    j++;
                }
            }


            // Checking for if the dots are next to each other
            for (int i = 1; i < indexes_of_dots.Length; i++)
            {
                int a = indexes_of_dots[i - 1];
                int b = indexes_of_dots[i];

                if (b - a == 1)
                {
                    lbl_message.Text = message;
                    return false;
                }
            }

            // Checking for if there is a dot or starts with dot
            if (indexes_of_dots[0] == 0)
            {
                contains_dot = false;
            }
            else
                contains_dot = true;

            if (!contains_dot)
            {
                lbl_message.Text = message;
                return false;
            }

            // Checking for invalid chars - tail email - after dot
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(tail_email.IndexOf(invalid_chars_all[i]) == -1))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid ends
            for (int i = 0; i < invalid_ends.Length; i++)
            {
                if (tail_email.EndsWith(invalid_ends[i]))
                {
                    lbl_message.Text = message;
                    return false;
                }
            }

            return true;

        }
        private string Generate_Auto_Password()
            {
                Random r = new Random();

                string pass = "";
                pass += (char)r.Next(65, 90);
                pass += (char)r.Next(97, 122);
                pass += (char)r.Next(65, 90);
                pass += (char)r.Next(97, 122);
                pass += r.Next(1001, 9998);


                return pass;
            }
    }
}
