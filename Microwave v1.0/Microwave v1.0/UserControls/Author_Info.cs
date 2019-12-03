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

namespace Microwave_v1._0.UserControls
{
    public partial class Author_Info : UserControl
    {
        private Microwave main_page;
        private Author_List author_list;
        private AddAuthor edit_form;
        private Detail detail_form;

        public System.Windows.CornerRadius CornerRadius { get; set; }

        private string name;
        private string pic_path_file;
        private int author_id;
        private bool chosen = false;

        public int Author_id { get => author_id; set => author_id = value; }
        public string Pic_path_file { get => pic_path_file; set => pic_path_file = value; }

        public Author_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            author_list = main_page.Main_author_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

        public void Initialize_Author_Info(int author_id, string name, string pic_path_file)
        {
            this.author_id = author_id;
            this.name = name;
            this.pic_path_file = pic_path_file;
            this.lbl_author.Text = name;
            this.btn_author_id.Text = author_id.ToString();
            this.pb_author.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_path_file);
        }

        public void Hide_Info()
        {
            main_page.Pnl_author_list.Controls.Remove(this);
        }

        public void Draw_Author_Obj(ref int x, ref int y)
        {
            main_page.Pnl_author_list.Controls.Add(this);
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
            pb_author.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_path_file);

        }

        public void Select_Author_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            Color back_color2 = Color.FromArgb(48, 52, 64);
            this.pnl_name.BackColor = back_color2;
            this.BackColor = back_color;
            this.btn_edit.Show();
            this.btn_remove.Show();

        }

        public void Deselect_Author_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.BackColor = back_color;
            Color back_color2 = Color.FromArgb(55, 57, 68);
            this.pnl_name.BackColor = back_color2;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

        public void Author_Info_Click(object sender, EventArgs e)
        { 
            main_page.Main_author_list.Deselect_All_Infos();
            main_page.Author_search_list.Deselect_All_Infos();
            this.Select_Author_Info();

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this author?";
            main_page.Create_Warning_Form(message, Color.DarkRed);
            bool delete_pic = true;

            if (pic_path_file == @"..\..\Resources\Author Covers\DefaultAuthor.jpg")
            {
                delete_pic = false;
            }

            if (main_page.Warning_form.Result)
                Remove(delete_pic);

            main_page.Warning_form.Refresh_Form();

            main_page.Pnl_author_list.VerticalScroll.Value = 0;
            main_page.Author_search_list.Delete_All_List();
            main_page.Main_author_list.Draw_All_Authors();
            main_page.Author_searched_already = false;
        }


        public void Remove(bool delete_picture = true)
        {

            author_list.Delete_Author_from_List(author_id, delete_picture);
            this.Dispose();
            main_page.Pnl_author_list.VerticalScroll.Value = 0;
            Author.author_point_y = 5;
            Author.author_point_x = 35;
            author_list.Draw_All_Authors();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string message = "Do you want to edit this author?";
            main_page.Create_Warning_Form(message, Color.DarkBlue);
            if (main_page.Warning_form.Result)
                Edit();

            main_page.Warning_form.Refresh_Form();
        }

        private void Edit()
        {
            Author current = author_list.Find_Author_By_ID(author_id);
            // Don't delete the picture from file
            Create_Add_Author_Form_With_Author(current);
        }

        private void Create_Add_Author_Form_With_Author(Author author)
        {

            if (edit_form == null)
            {
                edit_form = new AddAuthor(author);
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
                    edit_form = new AddAuthor(author);
                    edit_form.Show();
                }
            }
        }
        private void Create_Author_Detail_Form(Author author)
        {

            if (detail_form == null)
            {
                detail_form = new Detail(author);
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
                    detail_form = new Detail(author);
                    detail_form.Show();
                }
            }
        }

        public void Author_Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_name.BackColor = back_color2;
            }
        }

        public void Author_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.BackColor = back_color;
                Color back_color2 = Color.FromArgb(55, 57, 68);
                this.pnl_name.BackColor = back_color2;
            }
        }

        private void lbl_name_MouseLeave(object sender, EventArgs e)
        {
            Author_Mouse_Leave();
        }

        private void lbl_name_MouseEnter(object sender, EventArgs e)
        {
            Author_Hover();
        }
        private void Author_Info_DoubleClick(object sender, EventArgs e)
        {
            Author current = author_list.Find_Author_By_ID(author_id);
            Create_Author_Detail_Form(current);

        }

    }
}
