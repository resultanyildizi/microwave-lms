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
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.Forms
{
    public partial class AddPublisher : Form
    {
        private string pub_name;
        private string pub_email;
        private string pub_phone_number;
        private string pub_date_of_est;
        
        Microwave main_page;

        Picture_Events picture_event;
        private string pic_default_file = System.Configuration.ConfigurationManager.AppSettings["def_pb_path"];
        private string pic_dest_path = System.Configuration.ConfigurationManager.AppSettings["pb_dest_path"];
        private string pic_new_source_path = "";


        private bool is_edit = false;
        private bool change_image = false;
        private Publisher publisher_to_edit = null;

        public AddPublisher()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_publisher);
            pic_new_source_path = picture_event.Pic_source_file;
            this.lbl_pub_message.Text = "";

        }

        public AddPublisher(Publisher pub)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_publisher);

            publisher_to_edit = pub;
            this.lbl_pub_message.Text = "";


            // Make other properties default
            this.tb_pub_name.Text = pub.Pub_name;
            this.tb_pub_name.ForeColor = Color.LightGray;
            this.tb_pub_email.Text = pub.Pub_email;
            this.tb_pub_email.ForeColor = Color.LightGray;
            this.tb_pub_phone_num.Text = pub.Pub_phone_num;
            this.tb_pub_phone_num.ForeColor = Color.LightGray;
            this.pub_date_of_est = pub.Pub_date_of_est;
            dtp_publisher.Value = new DateTime(int.Parse(pub_date_of_est),1,1);


            pic_new_source_path = picture_event.Pic_source_file = pub.Pub_cover_path_file;
            pic_publisher.Image = Picture_Events.Get_Copy_Image_Bitmap(pub.Pub_cover_path_file);

            is_edit = true;
        }

        private void Pub_Add_Click_Func(bool is_edit)
        {
            pub_name = tb_pub_name.Text.Replace('\'', ' ');
            pub_email = tb_pub_email.Text.Replace('\'', ' ');
            pub_phone_number = tb_pub_phone_num.Text.Replace('\'', ' ');
            pic_new_source_path = picture_event.Pic_source_file;
            pub_date_of_est = dtp_publisher.Value.ToString("yyyy");

            lbl_pub_message.Text = "";

            // Validations
            if (tb_pub_name.Text.Trim() == "Publisher's Name" || tb_pub_name.Text.Trim() == "")
            {
                lbl_pub_message.Text = "* Please enter publisher's name.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_name.Focus();
                return;
            }
            if (tb_pub_email.Text.Trim() == "Publisher's Email" || tb_pub_email.Text.Trim() == "")
            {
                lbl_pub_message.Text = "* Please enter publisher's email.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_email.Focus();
                return;
            }
            if (!is_a_valid_email(pub_email))
                return;
            
            if (tb_pub_phone_num.Text.Trim() == "Publisher's Phone Number" || tb_pub_phone_num.Text.Trim() == "")
            {
                lbl_pub_message.Text = "* Please enter publisher's phone number.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_phone_num.Focus();
                return;
            }

            
            if (is_edit == false)
            {
                if (picture_event.Pic_source_file != null && picture_event.Pic_source_file != pic_default_file)
                {
                    picture_event.Copy_The_Picture(pub_name);
                    pic_new_source_path = picture_event.Pic_source_file;
                }
                else
                    pic_new_source_path = pic_default_file;
                
                Publisher publisher= new Publisher(0,pub_name,pub_email,pub_phone_number, pub_date_of_est,pic_new_source_path);
                publisher.Add();
                
                   

                Clear();
            }
            else
            {
                if (change_image)
                {
                    if(publisher_to_edit.Pub_cover_path_file != pic_default_file)
                        Picture_Events.Delete_The_Picture(publisher_to_edit.Pub_cover_path_file);
                    picture_event.Copy_The_Picture(pub_name);
                    pic_new_source_path = picture_event.Pic_source_file;
                    change_image = false;
                }

                lbl_pub_message.Text = "*Publisher changed successfully";
                lbl_pub_message.ForeColor = Color.LightGreen;

                publisher_to_edit.Pub_name= pub_name;
                publisher_to_edit.Pub_email = pub_email;
                publisher_to_edit.Pub_phone_num = pub_phone_number;
                publisher_to_edit.Pub_date_of_est = pub_date_of_est;
                publisher_to_edit.Pub_cover_path_file= picture_event.Pic_source_file;
                
                publisher_to_edit.Edit();

                main_page.Pnl_pub_list.VerticalScroll.Value = 0;
                main_page.Publisher_search_list.Delete_All_List();
                main_page.Main_pub_list.Draw_All_Publishers();
                main_page.Publisher_searched_already = false;

                main_page.Main_book_list.Delete_All_List();
                Book.Show_All_Books(main_page);
            }
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
            lbl_pub_message.ForeColor = Color.Red;
            int index_of_at = email.IndexOf('@');

            // Checking for '@'
            if (index_of_at == -1)
            {
                lbl_pub_message.Text = message;
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
                    lbl_pub_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid end
            if (head_email.EndsWith("."))
            {
                lbl_pub_message.Text = message;
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
                    lbl_pub_message.Text = message;
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
                lbl_pub_message.Text = message;
                return false;
            }

            // Checking for invalid chars - tail email - after dot
            for (int i = 0; i < invalid_chars.Length; i++)
            {
                if (!(tail_email.IndexOf(invalid_chars_all[i]) == -1))
                {
                    lbl_pub_message.Text = message;
                    return false;
                }
            }
            // Checking for invalid ends
            for (int i = 0; i < invalid_ends.Length; i++)
            {
                if (tail_email.EndsWith(invalid_ends[i]))
                {
                    lbl_pub_message.Text = message;
                    return false;
                }
            }

            return true;

        }

        private void Clear()
        {
            tb_pub_name.Text = "Publisher's Name";
            tb_pub_name.ForeColor = Color.DimGray;
            tb_pub_email.Text = "Publisher's Email";
            tb_pub_email.ForeColor = Color.DimGray;
            tb_pub_phone_num.Text = "Publisher's Phone Number";
            tb_pub_phone_num.ForeColor = Color.DimGray;
            dtp_publisher.Value = DateTime.Today;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Pub_Add_Click_Func(is_edit);
        }
        private void btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Pub_Add_Click_Func(is_edit);
            }
        }

        private void Change_Image_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();
        }


        private void tb_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_pub_name_Enter(object sender, EventArgs e)
        {
            if (tb_pub_name.Text == "Publisher's Name")
            {
                tb_pub_name.Text = "";
                tb_pub_name.ForeColor = Color.LightGray;
            }
        }
        private void tb_pub_name_Leave(object sender, EventArgs e)
        {
            if (tb_pub_name.Text == "")
            {
                tb_pub_name.Text = "Publisher's Name";
                tb_pub_name.ForeColor = Color.DimGray;
            }
        }
        
        private void tb_pub_email_Enter(object sender, EventArgs e)
        {
            if (tb_pub_email.Text == "Publisher's Email")
            {
                tb_pub_email.Text = "";
                tb_pub_email.ForeColor = Color.LightGray;
            }
        }

        private void tb_pub_email_Leave(object sender, EventArgs e)
        {
            if (tb_pub_email.Text == "")
            {
                tb_pub_email.Text = "Publisher's Email";
                tb_pub_email.ForeColor = Color.DimGray;
            }
        }

        private void tb_pub_phone_num_Enter(object sender, EventArgs e)
        {
            if (tb_pub_phone_num.Text == "Publisher's Phone Number")
            {
                tb_pub_phone_num.Text = "";
                tb_pub_phone_num.ForeColor = Color.LightGray;
            }
        }

        private void tb_pub_phone_num_Leave(object sender, EventArgs e)
        {
            if (tb_pub_phone_num.Text == "")
            {
                tb_pub_phone_num.Text = "Publisher's Phone Number";
                tb_pub_phone_num.ForeColor = Color.DimGray;
            }
        }



        // Form closed - closing
        private void AddPublisher_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddPublisher_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddPublisher_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.tb_pub_name.Select();
        }

        private void tb_pub_phone_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pub_Add_Click_Func(is_edit);
            }
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
