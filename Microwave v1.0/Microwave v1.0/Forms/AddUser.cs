using System;
using System.Drawing;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    public partial class AddUser : Form
    {
        private string name;
        private string surname;
        private string gender = "Male";
        private int age;
        private string email;
        private string password;
        private string date;
        private User user_to_edit = null;
        Microwave main_page;

        private bool is_edit = false;

        public AddUser()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.rdo_male.Checked = true;
            this.BringToFront();
        }

        public AddUser(User user)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            user_to_edit = user;

            this.tb_user_name.Text = user.Name;
            this.tb_user_surname.Text = user.Surname;
            this.tb_user_email.Text = user.Email;
            this.numUpDown_age.Value = user.Age;

            this.tb_user_name.ForeColor = Color.LightGray;
            this.tb_user_surname.ForeColor = Color.LightGray;
            this.tb_user_email.ForeColor = Color.LightGray;

            this.is_edit = true;

            this.rdo_male.Checked = true;

            this.BringToFront();
        }

        private void Add_User_Click(bool is_edit)
        {

            name = (tb_user_name.Text.Trim());
            surname = (tb_user_surname.Text.Trim());
            email = (tb_user_email.Text.Trim());
            date = DateTime.Now.ToString();
            age = (int)numUpDown_age.Value;
            


            lbl_user_message.Text = "";

            if (tb_user_name.Text.Trim() == "Name" || tb_user_name.Text.Trim() == "")
            {
                lbl_user_message.Text = "* Please enter name.";
                lbl_user_message.ForeColor = Color.Red;
                tb_user_name.Focus();
                return;
            }

            if (tb_user_surname.Text.Trim() == "Surname" || tb_user_surname.Text.Trim() == "")
            {
                lbl_user_message.Text = "* Please enter surname.";
                lbl_user_message.ForeColor = Color.Red;
                tb_user_surname.Focus();
                return;
            }

            if (tb_user_email.Text.Trim() == "Email" || tb_user_email.Text.Trim() == "")
            {
                lbl_user_message.Text = "* Please enter email.";
                lbl_user_message.ForeColor = Color.Red;
                tb_user_email.Focus();
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
                lbl_user_message.Text = "* Please select gender";
                lbl_user_message.ForeColor = Color.Red;
                return;
            }

            if(is_edit == false)
            {
                User user = new User(0, name, surname, gender, age, email, password, date);
                user.Add();
                Clear();
            }
            else
            {
                lbl_user_message.Text = "*User changed successfully";
                lbl_user_message.ForeColor = Color.LightGreen;

                user_to_edit.Name = name;
                user_to_edit.Surname = surname;
                user_to_edit.Email = email;
                user_to_edit.Gender = gender;
                user_to_edit.Age = age;

                user_to_edit.Edit();

                main_page.Pnl_user_list.VerticalScroll.Value = 0;
                main_page.User_search_list.Delete_All_List();
                main_page.Main_user_list.Draw_All_Users();
                main_page.User_searched_already = false;
            }
        }
        private void Clear()
        {
            tb_user_name.Text = "Name";
            tb_user_name.ForeColor = Color.DimGray;
            tb_user_surname.Text = "Surname";
            tb_user_surname.ForeColor = Color.DimGray;
            tb_user_email.Text = "Email";
            tb_user_email.ForeColor = Color.DimGray;
            rdo_male.Checked = true;
            numUpDown_age.Value = 7;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_User_Click(is_edit); 
        }



        private void Tb_user_name_Enter(object sender, EventArgs e)
        {
            if(tb_user_name.Text == "Name")
            {
                tb_user_name.Text = "";
                tb_user_name.ForeColor = Color.LightGray;
            }
        }
        private void Tb_user_email_Enter(object sender, EventArgs e)
        {
            if (tb_user_email.Text == "Email")
            {
                tb_user_email.Text = "";
                tb_user_email.ForeColor = Color.LightGray;
            }
        }
        private void Tb_user_surname_Enter(object sender, EventArgs e)
        {
            if(tb_user_surname.Text == "Surname")
            {
                tb_user_surname.Text = "";
                tb_user_surname.ForeColor = Color.LightGray;
            }
        }


        private void Tb_user_name_Leave(object sender, EventArgs e)
        {
            if(tb_user_name.Text == "")
            {
                tb_user_name.Text = "Name";
                tb_user_name.ForeColor = Color.Gray;
            }
        }
        private void Tb_user_surname_Leave(object sender, EventArgs e)
        {
            if(tb_user_surname.Text == "")
            {
                tb_user_surname.Text = "Surname";
                tb_user_surname.ForeColor = Color.Gray;
            }
        }
        private void Tb_user_email_Leave(object sender, EventArgs e)
        {
            if(tb_user_email.Text == "")
            {
                tb_user_email.Text = "Email";
                tb_user_email.ForeColor = Color.Gray;
            }
        }


        private void Tb_user_name_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if(e.KeyChar == (char)Keys.Enter)
            {
                Add_User_Click(is_edit);
            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void NumUpDown_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Add_User_Click(is_edit);
            }
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tb_user_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_User_Click(is_edit);
            }
        }
    }
}
