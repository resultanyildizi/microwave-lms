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
            this.rb_male.Checked = true;
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

            if (user.Gender == "Male")
                this.rb_male.Checked = true;
            else
                this.rb_female.Checked = true;

            this.is_edit = true;

            this.BringToFront();
        }

        private void Add_User_Click(bool is_edit)
        {

            name = (tb_user_name.Text.Trim());
            surname = (tb_user_surname.Text.Trim());
            email = (tb_user_email.Text.Trim());
            password = Generate_Auto_Password();
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

            if (!is_a_valid_email(email))
                return;

            if (rb_male.Checked)
            {
                gender = "Male";
            }
            else if (rb_female.Checked)
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
            rb_male.Checked = true;
            numUpDown_age.Value = 7;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_User_Click(is_edit); 
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
            lbl_user_message.ForeColor = Color.Red;
            int index_of_at = email.IndexOf('@');

            // Checking for '@'
            if (index_of_at == -1)
            {
                lbl_user_message.Text = message;
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
                    lbl_user_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid end
            if (head_email.EndsWith("."))
            {
                lbl_user_message.Text = message;
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
                    lbl_user_message.Text = message;
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
                lbl_user_message.Text = message;
                return false;
            }

            // Checking for invalid chars - tail email - after dot
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(tail_email.IndexOf(invalid_chars_all[i]) == -1))
                {
                    lbl_user_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid ends
            for (int i = 0; i < invalid_ends.Length; i++)
            {
                if (tail_email.EndsWith(invalid_ends[i]))
                {
                    lbl_user_message.Text = message;
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
