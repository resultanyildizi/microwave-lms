using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;

namespace Microwave_v1._0.UserControls
{
    public partial class Category_Info : UserControl
    {
        private Microwave main_page;
        private Category_List category_list;
        private AddCategory edit_form;
        private Detail detail_form;

        public System.Windows.CornerRadius CornerRadius { get; set; }
       
        private string category_name;
        private string category_cover_path_file;
        private int category_id;
        private bool chosen = false;

        public string Category_name { get => category_name; set => category_name = value; }
        public string Category_cover_path_file { get => category_cover_path_file; set => category_cover_path_file = value; }
        public int Category_id { get => category_id; set => category_id = value; }


        public Category_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            category_list = main_page.Main_category_list;
            this.btn_category_edit.Hide();
            this.btn_category_remove.Hide();
        }

        public void Initialize_Category_Info(int category_id, string category_name, string category_cover_path_file)
        {
            this.category_id = category_id;
            this.category_name = category_name;
            this.category_cover_path_file = category_cover_path_file;
            this.lbl_category.Text = category_name;
            this.btn_category_id.Text = category_id.ToString();
            this.pb_category.Image = Picture_Events.Get_Copy_Image_Bitmap(category_cover_path_file);
        }

        public void Hide_Info()
        {
            main_page.Pnl_categories_list.Controls.Remove(this);
        }

        public void Draw_Category_Obj(ref int x, ref int y)
        {
            main_page.Pnl_categories_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);

            if (x > 500)
            {
                y += 240;
                x = 35;
            }
            else
            {
                x += 180;
            }
            pb_category.Image = Picture_Events.Get_Copy_Image_Bitmap(category_cover_path_file);

        }

        public void Select_Category_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            Color back_color2 = Color.FromArgb(48, 52, 64);
            this.pnl_category_name.BackColor = back_color2;
            this.BackColor = back_color;
            this.btn_category_edit.Show();
            this.btn_category_remove.Show();

        }

        public void Deselect_Category_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.BackColor = back_color;
            Color back_color2 = Color.FromArgb(55, 57, 68);
            this.pnl_category_name.BackColor = back_color2;
            this.btn_category_edit.Hide();
            this.btn_category_remove.Hide();
        }

        public void Category_Info_Click(object sender, EventArgs e)
        {
            main_page.Main_category_list.Deselect_All_Infos();
            main_page.Category_search_list.Deselect_All_Infos();
            this.Select_Category_Info();

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this category?";
            main_page.Create_Warning_Form(message, Color.DarkRed);
            bool delete_pic = true;

            if (category_cover_path_file == @"..\..\Resources\Category Covers\DefaultCategory.jpg")
            {
                delete_pic = false;
            }

            if (main_page.Warning_form.Result)
                Remove(delete_pic);

            main_page.Warning_form.Refresh_Form();

            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            main_page.Category_search_list.Delete_All_List();
            main_page.Main_category_list.Draw_All_Categories();
            main_page.Category_searched_already = false;
        }


        public void Remove(bool delete_picture = true)
        {

            category_list.Delete_Category_from_List(category_id, delete_picture);
            this.Dispose();
            main_page.Pnl_categories_list.VerticalScroll.Value = 0;
            Category.category_point_y = 5;
            Category.category_point_x = 35;
            category_list.Draw_All_Categories();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to edit this category?";
            main_page.Create_Warning_Form(message, Color.DarkBlue);
            if (main_page.Warning_form.Result)
                Edit();

            main_page.Warning_form.Refresh_Form();
        }

        private void Edit()
        {
            Category current = category_list.Find_Category_By_ID(category_id);
            // Don't delete the picture from file
            Create_Add_Category_Form_With_Category(current);
        }

        private void Create_Add_Category_Form_With_Category(Category category)
        {

            if (edit_form == null)
            {
                edit_form = new AddCategory(category);
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
                    edit_form = new AddCategory(category);
                    edit_form.Show();
                }
            }
        }
        private void Create_Category_Detail_Form(Category category)
        {

            if (detail_form == null)
            {
                detail_form = new Detail(category);
                detail_form.Show();
            }
            else
            {
                try
                {
                    detail_form.Show();
                }
                catch (Exception)
                {
                    detail_form = new Detail(category);
                    detail_form.Show();
                }
            }
        }

        public void Category_Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_category_name.BackColor = back_color2;
            }
        }

        public void Category_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_category_name.BackColor = back_color2;
            }
        }
        private void lbl_category_name_MouseLeave(object sender, EventArgs e)
        {
            Category_Mouse_Leave();
        }
        private void lbl_category_name_MouseEnter(object sender, EventArgs e)
        {
            Category_Hover();
        }
        private void Category_Info_DoubleClick(object sender, EventArgs e)
        {
            Category current = category_list.Find_Category_By_ID(category_id);
            Create_Category_Detail_Form(current);

        }
    }
}
