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
        private Microwave main_page;
        private User_List user_list;


        private string name;
        private string surname;
        private string email;
        private string gender;
        private int age;
        private string date;
        
        public UserInfo()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            user_list = main_page.user_list;
            this.btn_user_edit.Hide();
            this.btn_user_remove.Hide();
        }
    

        public void Initialize_User_Info(string name, string surname, string gender, int age, string email,string date)
        {
            this.lbl_user_name.Text = name;
            this.lbl_user_surname.Text = surname;
            this.lbl_user_gender.Text = gender;
            this.lbl_user_age.Text = age.ToString();
            this.lbl_user_email.Text = email;
            this.lbl_user_date.Text = date;

        }
        public void Draw_User_Obj(ref int y)
        {
            main_page.pnl_user_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }
        public void Select_User_Info()
        {
            Color back_color = Color.FromArgb(33, 37, 48);
            this.pnl_user_name.BackColor = back_color;
            this.pnl_user_surname.BackColor = back_color;
            this.pnl_user_gender.BackColor = back_color;
            this.pnl_user_age.BackColor = back_color;
            this.pnl_user_email.BackColor = back_color;
            this.pnl_user_date.BackColor = back_color;

            this.btn_user_edit.Show();
            this.btn_user_remove.Show();

        }

        public void Deselect_User_Info()
        {
            Color back_color = Color.FromArgb(55, 57, 68);
            this.pnl_user_name.BackColor = back_color;
            this.pnl_user_surname.BackColor = back_color;
            this.pnl_user_gender.BackColor = back_color;
            this.pnl_user_age.BackColor = back_color;
            this.pnl_user_email.BackColor = back_color;
            this.pnl_user_date.BackColor = back_color;

            this.btn_user_edit.Hide();
            this.btn_user_remove.Hide();

        }

    }
}

