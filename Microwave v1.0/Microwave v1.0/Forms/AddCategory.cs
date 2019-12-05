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
using Microwave_v1._0.Model;

namespace Microwave_v1._0.Forms
{
    public partial class AddCategory : Form
    {
        private string category_name;
        private string category_description;
        private int popularity_id;
        private int popularity_score;

        Microwave main_page;
        private Category_List main_category_list;

        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Category Covers\DefaultCategory.jpg";
        private string pic_dest_path = @"..\..\Resources\Category Covers\";
        private string pic_new_source_path = "";

        private bool is_edit = false;
        private bool change_image = false;
        private Category category_to_edit = null;
        public AddCategory()
        {
            InitializeComponent();

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_category);
            pic_new_source_path = picture_event.Pic_source_file;
            this.lbl_category_message.Text = "";

            this.BringToFront();
            main_page.SendToBack();
        }

        public AddCategory(Category category)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_category);
            this.lbl_category_message.Text = "";

            category_to_edit = category;

            this.tb_category_name.Text = category.Category_name;
            this.tb_category_name.ForeColor = Color.LightGray;
            //this.tb_category_description.Text = category.Category_description ;
            //this.tb_category_name.ForeColor = Color.LightGray;

            pic_new_source_path = picture_event.Pic_source_file = category.Category_cover_path_file;
            pic_category.Image = Picture_Events.Get_Copy_Image_Bitmap(category.Category_cover_path_file);

            is_edit = true;
        }
        private void Add_Click_Function(bool is_edit)
        {
            category_name = (tb_category_name.Text.Trim()).Replace('\'', ' ');
            pic_new_source_path = picture_event.Pic_source_file;

            lbl_category_message.Text = "";

            if (tb_category_name.Text.Trim() == "Category's Name" || tb_category_name.Text.Trim() == "")
            {
                lbl_category_message.Text = "* Please enter your category's name";
                lbl_category_message.ForeColor = Color.Red;
                lbl_category_message.Focus();
                return;
            }
            if (pic_new_source_path == null || pic_new_source_path == pic_default_file)
            {
                lbl_category_message.Text = "* Please choose a picture.";
                lbl_category_message.ForeColor = Color.Red;
                picture_event.Choose_Image();
                return;
            }

            if (is_edit == false)
            {
                picture_event.Copy_The_Picture(category_name);
                pic_new_source_path = picture_event.Pic_source_file;
                Category category = new Category(0, category_name, popularity_id, popularity_score, pic_new_source_path);
                category.Add();

                tb_category_name.Text = "Category's Name";
            }
            else
            {
                if (change_image)
                {
                    if (category_to_edit.Category_cover_path_file != pic_default_file)
                        Picture_Events.Delete_The_Picture(category_to_edit.Category_cover_path_file);

                    picture_event.Copy_The_Picture(category_name);
                    pic_new_source_path = picture_event.Pic_source_file;
                    change_image = false;
                }
                lbl_category_message.Text = "* Category changed succesfully";
                lbl_category_message.ForeColor = Color.LightGreen;

                category_to_edit.Category_name = category_name;
                category_to_edit.Category_cover_path_file = picture_event.Pic_source_file;

                category_to_edit.Edit();

            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Click_Function(is_edit);
        }
        private void btn_add_pic_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();

        }
        private void AddCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddCategory_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.tb_category_name.Select();

        }
        private void tb_category_name_Enter(object sender, EventArgs e)
        {
            if (tb_category_name.Text == "Category's Name")
            {
                tb_category_name.Text = "";
                tb_category_name.ForeColor = Color.LightGray;
            }
        }
        private void tb_category_name_Leave(object sender, EventArgs e)
        {
            if (tb_category_name.Text == "")
            {
                tb_category_name.Text = "Category's Name";
                tb_category_name.ForeColor = Color.Gray;
            }
        }
        private void btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_Click_Function(is_edit);
            }
        }
    }
}
