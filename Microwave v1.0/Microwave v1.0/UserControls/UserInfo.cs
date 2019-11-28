using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    public partial class UserInfo : UserControl
    {
        private Microwave main_page = null;
        private User_List main_list = null;
        private AddUser edit_form = null;

        private string name;
        private string surname;
        private string gender;
        private int age;
        private string email;
        private string date;
        private int user_id;

        private bool chosen = false;
        private INFO_COLOR_MODE color_mode;

        public int User_id { get => user_id; set => user_id = value; }

        public UserInfo()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_list = main_page.Main_user_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }
        public void Initialize_User_Info(int user_id, string name, string surname, string gender, int age, string email,string date, INFO_COLOR_MODE mode)
        {
            this.user_id = user_id;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.email = email;
            this.date = date;
            this.lbl_id.Text = user_id.ToString();
            this.lbl_name.Text = name;
            this.lbl_surname.Text = surname;
            this.lbl_gender.Text = gender;
            this.lbl_age.Text = age.ToString();
            this.lbl_email.Text = email;
            this.lbl_date.Text = date;
            this.color_mode = mode;

            Color new_color = Color.FromArgb(59, 180, 193);

            if (mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.SURNAME)
                this.pnl_surname.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.GENDER)
                this.pnl_gender.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.AGE)
                this.pnl_age.BackColor = new_color;
            else if (mode == INFO_COLOR_MODE.EMAIL)
                this.pnl_email.BackColor = new_color;

        }
        public void Draw_User_Obj(ref int y)
        {
            main_page.Pnl_user_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }
        public void Hide_Info()
        {
            main_page.Pnl_user_list.Controls.Remove(this);
        }
        private void UserInfo_Click(object sender, EventArgs e)
        {
            main_list.Deselect_All_User_Infos();
            this.Select_User_Info();
            this.Select();
        }
        public void Select_User_Info()
        {
            chosen = true;
            Color back_color = Color.FromArgb(33, 37, 48);
            this.pnl_name.BackColor = back_color;
            this.pnl_surname.BackColor = back_color;
            this.pnl_gender.BackColor = back_color;
            this.pnl_age.BackColor = back_color;
            this.pnl_email.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_id.BackColor = back_color;

            this.btn_edit.Show();
            this.btn_remove.Show();

            Color new_color = Color.FromArgb(4, 137, 152);

            if (color_mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.SURNAME)
                this.pnl_surname.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.GENDER)
                this.pnl_gender.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.AGE)
                this.pnl_age.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.EMAIL)
                this.pnl_email.BackColor = new_color;

        }
        public void Deselect_User_Info()
        {
            Color back_color = Color.FromArgb(55, 57, 68);
            this.pnl_name.BackColor = back_color;
            this.pnl_surname.BackColor = back_color;
            this.pnl_gender.BackColor = back_color;
            this.pnl_age.BackColor = back_color;
            this.pnl_email.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_id.BackColor = back_color;

            this.btn_edit.Hide();
            this.btn_remove.Hide();

            Color new_color = Color.FromArgb(59, 180, 193);

            if (color_mode == INFO_COLOR_MODE.ID)
                this.pnl_id.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.NAME)
                this.pnl_name.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.SURNAME)
                this.pnl_surname.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.GENDER)
                this.pnl_gender.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.AGE)
                this.pnl_age.BackColor = new_color;
            else if (color_mode == INFO_COLOR_MODE.EMAIL)
                this.pnl_email.BackColor = new_color;

        }
        private void Btn_edit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to edit that user?";
            main_page.Create_Warning_Form(message, Color.DarkBlue);
            if (main_page.Warning_form.Result)
                Edit();

            main_page.Warning_form.Refresh_Form();
        }
        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete that user?";
            main_page.Create_Warning_Form(message, Color.DarkRed);
            if (main_page.Warning_form.Result)
            {
                Remove();
            }
            main_page.Warning_form.Refresh_Form();
        }
        private void Edit()
        {
            User current = main_list.Find_User_By_ID(user_id);
            Create_Add_User_Form_With_User(current);
        }
        private void Remove()
        {
            main_list.Delete_User_From_List(user_id);
            this.Dispose();

            main_page.Pnl_user_list.VerticalScroll.Value = 0;
            User.point_y = 5;
            main_list.Draw_All_Users();
        }

        private void Create_Add_User_Form_With_User(User user)
        {

            if (edit_form == null)
            {
                edit_form = new AddUser(user);
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
                    edit_form = new AddUser(user);
                    edit_form.Show();
                }
            }
        }
        public void Hover()
        {
            if(!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);

                this.pnl_id.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_surname.BackColor = back_color;
                this.pnl_gender.BackColor = back_color;
                this.pnl_age.BackColor = back_color;
                this.pnl_email.BackColor = back_color;
                this.pnl_date.BackColor = back_color;

                Color new_color = Color.FromArgb(49, 170, 183);
                if (color_mode == INFO_COLOR_MODE.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.SURNAME)
                    this.pnl_surname.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.GENDER)
                    this.pnl_gender.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.AGE)
                    this.pnl_age.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.EMAIL)
                    this.pnl_email.BackColor = new_color;

            }
        }
        public void Mouse_Leave()
        {
            if(!chosen)
            {
                Color back_color = Color.FromArgb(55, 57, 68);

                this.pnl_id.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_surname.BackColor = back_color;
                this.pnl_gender.BackColor = back_color;
                this.pnl_age.BackColor = back_color;
                this.pnl_email.BackColor = back_color;
                this.pnl_date.BackColor = back_color;

                Color new_color = Color.FromArgb(59, 180, 193);
                if (color_mode == INFO_COLOR_MODE.ID)
                    this.pnl_id.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.NAME)
                    this.pnl_name.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.SURNAME)
                    this.pnl_surname.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.GENDER)
                    this.pnl_gender.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.AGE)
                    this.pnl_age.BackColor = new_color;
                else if (color_mode == INFO_COLOR_MODE.EMAIL)
                    this.pnl_email.BackColor = new_color;
            }
        }
        private void UserInfo_MouseEnter(object sender, EventArgs e)
        {
            Hover();
        }
        private void UserInfo_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave();
        }

        private void UserInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                string message = "Do you want to delete that user?";
                main_page.Create_Warning_Form(message, Color.DarkRed);
                if(main_page.Warning_form.Result)
                {
                    Remove();
                }
                main_page.Warning_form.Refresh_Form();
            }
        }
    }
}

