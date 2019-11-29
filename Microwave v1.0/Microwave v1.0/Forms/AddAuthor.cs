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

namespace Microwave_v1._0.Forms
{
    public partial class AddAuthor : Form
    {
        private string name;
        private string country;
        private string gender;
        private string year;
        private string biography;
   
        Microwave main_page;

        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Author Covers\DefaultAuthor.jpg";
        private string pic_dest_path = @"..\..\Resources\Author Covers\";
        private string pic_new_source_path = "";


        private bool is_edit = false;
        private bool change_image = false;
        private Author author_to_edit = null;

        public AddAuthor()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_author);
            pic_new_source_path = picture_event.Pic_source_file;

            this.rdo_male.Checked = true;
            this.BringToFront();
        }

        public AddAuthor(Author author)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_author);

            author_to_edit = author;

            this.tb_name.Text = author.Author_name;
            this.tb_name.ForeColor = Color.LightGray;
            this.tb_country.Text = author.Author_country;
            this.tb_country.ForeColor = Color.LightGray;
            this.gender = author.Author_gender;
            if (author.Author_gender == "Male")
            {
                rdo_male.Checked = true;
            }
            else
            {
                rdo_female.Checked = true;
            }
            this.year = author.Author_birthday;
            dtp_author.Value = new DateTime(int.Parse(year), 1, 1);

            pic_new_source_path = picture_event.Pic_source_file = author.Author_cover_path_file;
            pic_author.Image = Picture_Events.Get_Copy_Image_Bitmap(author.Author_cover_path_file);

            is_edit = true;
        }
        private void Add_Click_Func(bool is_edit)
        {
            
            name = (tb_name.Text.Trim()).Replace('\'', ' ');
            country = (tb_country.Text.Trim()).Replace('\'', ' ');
            year = dtp_author.Value.Year.ToString();
            biography = tb_biography.Text.Replace('\'', ' ');
            pic_new_source_path = picture_event.Pic_source_file;



            lbl_message.Text = "";

            if (tb_name.Text.Trim() == "Name" || tb_name.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter name.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }

            if (tb_country.Text.Trim() == "Country" || tb_country.Text.Trim() == "")
            {
                lbl_message.Text = "* Please country name.";
                lbl_message.ForeColor = Color.Red;
                tb_country.Focus();
                return;
            }

            if (dtp_author.Text.Trim() == "Year" || dtp_author.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter birth year.";
                lbl_message.ForeColor = Color.Red;
                dtp_author.Focus();
                return;
            }

            if (tb_biography.Text.Trim() == "Biography..." || tb_biography.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter biography.";
                lbl_message.ForeColor = Color.Red;
                tb_biography.Focus();
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
                /* IMPORTANT */
                if (picture_event.Pic_source_file != null && picture_event.Pic_source_file != pic_default_file)
                {
                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;
                }
                else
                    pic_new_source_path = pic_default_file;

                Author author = new Author(0, 1, name, country, gender, year, biography, pic_new_source_path);               
                author.Add();

                Clear();
            }
            else
            {
                if (change_image)
                {
                    /* IMPORTANT */
                    if(author_to_edit.Author_cover_path_file != pic_default_file)
                        Picture_Events.Delete_The_Picture(author_to_edit.Author_cover_path_file);
                    picture_event.Copy_The_Picture(name);
                    pic_new_source_path = picture_event.Pic_source_file;
                    change_image = false;
                }

                lbl_message.Text = "*Author changed successfully";
                lbl_message.ForeColor = Color.LightGreen;

                author_to_edit.Author_name = name;
                author_to_edit.Author_country = country;
                author_to_edit.Author_gender = gender;
                author_to_edit.Author_birthday = year;
                author_to_edit.Author_biography = biography;
                author_to_edit.Author_cover_path_file = pic_new_source_path;
                author_to_edit.Edit();
            }


        }

        private void Clear()
        {
            tb_name.Text = "Name";
            tb_name.ForeColor = Color.DimGray;
            tb_country.Text = "Country";
            tb_country.ForeColor = Color.DimGray;
            
            tb_biography.ForeColor = Color.DimGray;
            tb_biography.Text = "Biography...";
            tb_biography.ForeColor = Color.DimGray;
            rdo_male.Checked = true;
            
        }

     


        private void btn_add_Click(object sender, EventArgs e)
        {
            Add_Click_Func(is_edit);
        }
        private void AddAuthor_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void Change_Image_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();
        }

        private void AddAuthor_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
    }
}
