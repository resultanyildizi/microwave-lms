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
    public partial class AddDepartment : Form
    {
        private string name;
        Microwave main_page;

        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
        private string pic_dest_path = @"..\..\Resources\Department Covers\";
        private string pic_new_source_path = "";

        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private bool is_edit = false;
        private bool change_image = false;
        private Department department_to_edit = null;

        public AddDepartment()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_department);
            pic_new_source_path = picture_event.Pic_source_file;

            this.BringToFront();
            main_page.SendToBack();
        }
        public AddDepartment(Department department)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_department);

            department_to_edit = department;

            this.tb_department.Text = department.Name;
            this.tb_department.ForeColor = Color.LightGray;

            pic_new_source_path = picture_event.Pic_source_file = department.Cover_path_file1;
            pic_department.Image = main_page.Dep_cover_image_list.Images[department.Department_id.ToString()];

            is_edit = true;
        }
        private void Add_Click_Function(bool is_edit)
        {
            name = (tb_department.Text.Trim()).Replace('\'', ' ');
            pic_new_source_path = picture_event.Pic_source_file;

            lbl_message.Text = "";

            if (tb_department.Text.Trim() == "Department's Name" || tb_department.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter your department's name";
                lbl_message.ForeColor = Color.Red;
                tb_department.Focus();
                return;
            }
            if (pic_new_source_path == null || pic_new_source_path == pic_default_file)
            {
                lbl_message.Text = "* Please choose a picture.";
                lbl_message.ForeColor = Color.Red;
                picture_event.Choose_Image();
                return;
            }

            if (is_edit == false)
            {
                picture_event.Copy_The_Picture(name);
                pic_new_source_path = picture_event.Pic_source_file;
                Department department = new Department(name,pic_new_source_path);
                department.Add();

                tb_department.Text = "Department's Name";
            }
            else
            {
                if (change_image)
                {
                    Picture_Events.Delete_The_Picture(department_to_edit.Cover_path_file1);
                    picture_event.Copy_The_Picture(name);
                    main_page.Remove_Image_From_Cover_List(department_to_edit.Department_id);
                    department_to_edit.Cover_path_file1 = picture_event.Pic_source_file;
                    department_to_edit.Cover_Pic_to_Image_List();
                    change_image = false;
                }
                lbl_message.Text = "* Department changed succesfully";
                lbl_message.ForeColor = Color.LightGreen;

                department_to_edit.Name = name;

               
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

        private void AddDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void AddDepartment_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.tb_department.Select();

        }
    }
}

