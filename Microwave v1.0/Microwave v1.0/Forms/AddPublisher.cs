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
        private string pub_date_of_est;
        private string pub_description;
        private int publisher_id;


        Microwave main_page;


        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Publisher Covers\DefaultPublisher.jpg";
        private string pic_dest_path = @"..\..\Resources\Publisher Covers\";
        private string pic_new_source_path = "";


        private bool is_edit = false;
        private bool change_image = false;
        private Publisher publisher_to_edit = null;

        public AddPublisher()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);
            pic_new_source_path = picture_event.Pic_source_file;
        }

        public AddPublisher(Publisher pub)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);

            publisher_to_edit = pub;

            pic_new_source_path = picture_event.Pic_source_file = pub.Pub_cover_path_file;
            pic_book.Image = main_page.Cover_image_list.Images[pub.Publisher_id.ToString()];

            is_edit = true;
        }

        private void Pub_Add_Click_Func(bool is_edit)
        {
            pub_description = tb_pub_description.Text.Replace('\'', ' ');
            pub_name = (tb_pub_name.Text.Trim()).Replace('\'', ' ');
            pic_new_source_path = picture_event.Pic_source_file;
            pub_date_of_est = dtp_publisher.Value.ToString();

            lbl_pub_message.Text = "";

            // Validations
            if (tb_pub_name.Text.Trim() == "Publisher's Name" || tb_pub_name.Text.Trim() == "")
            {
                lbl_pub_message.Text = "* Please enter publisher's name.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_name.Focus();
                return;
            }
            if (tb_pub_description.Text == "Description..." || tb_pub_description.Text == "")
            {
                lbl_pub_message.Text = "* Please enter description.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_description.Focus();
                return;
            }
            if (pic_new_source_path == null || pic_new_source_path == pic_default_file)
            {
                lbl_pub_message.Text = "* Please choose a picture.";
                lbl_pub_message.ForeColor = Color.Red;
                tb_pub_description.Focus();
                picture_event.Choose_Image();
                return;
            }

            if (is_edit == false)
            {
                picture_event.Copy_The_Picture(pub_name);
                pic_new_source_path = picture_event.Pic_source_file;
                /* ONEMLI */
                int publisher_id = 0;
                Publisher publisher= new Publisher(0,pub_name,pub_date_of_est,pub_description,pic_new_source_path);
                publisher.Add_Publisher();

                Clear();
            }
            else
            {
                if (change_image)
                {
                    Picture_Events.Delete_The_Picture(publisher_to_edit.Pub_cover_path_file);
                    picture_event.Copy_The_Picture(pub_name);
                    main_page.Remove_Image_From_Cover_List(publisher_to_edit.Publisher_id);
                    publisher_to_edit.Cover_Pic_to_Image_List();
                    change_image = false;
                }

                lbl_pub_message.Text = "*Publisher changed successfully";
                lbl_pub_message.ForeColor = Color.LightGreen;

                publisher_to_edit.Pub_name= pub_name;
                publisher_to_edit.Pub_description= pub_description;
                publisher_to_edit.Pub_date_of_est = pub_date_of_est;
                publisher_to_edit.Pub_cover_path_file= picture_event.Pic_source_file;
                publisher_to_edit.Edit_Publisher();
            }
        }

        private void Clear()
        {
            tb_pub_name.Text = "Publisher's Name";
            tb_pub_name.ForeColor = Color.DimGray;
            tb_pub_description.Text = "Description...";
            tb_pub_description.ForeColor = Color.DimGray;
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
        private void tb_pub_description_Enter(object sender, EventArgs e)
        {
            if (tb_pub_description.Text == "Description...")
            {
                tb_pub_description.Text = "";
                tb_pub_description.ForeColor = Color.LightGray;
            }
        }
        private void tb_pub_description_Leave(object sender, EventArgs e)
        {
            if (tb_pub_description.Text == "")
            {
                tb_pub_description.Text = "Description...";
                tb_pub_description.ForeColor = Color.Gray;
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


    }
}
