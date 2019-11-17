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
        private string date;
        Microwave main_page;


        public AddUser()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.rdo_male.Checked = true;
            this.BringToFront();
        }

        private void Add_User()
        {

            name = (tb_user_name.Text.Trim());
            email = (tb_user_surname.Text.Trim());
            email = DateTime.Now.ToString();
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

            Create_New_User_And_Set();
            Clear();
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

        private void Create_New_User_And_Set()
        {
            User user = new User(name, surname, gender, age, email, date);

            main_page.Main_user_list.Add_User_to_List(user);
            main_page.Pnl_user_list.VerticalScroll.Value = 0;

            user.Info.Draw_User_Obj(ref Book.point_y);

            main_page.Main_user_list.Deselect_All_User_Infos();
            user.Info.Select_User_Info();
            //user.Add_User_To_Database();
        }



        private void lbl_count_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_User(); 
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
    }
}
