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

namespace Microwave_v1._0
{
    public partial class Book_Tag : UserControl
    {
        Microwave main_page;
        ShowEmployee show_employee;
        public Book_Tag()
        {
            InitializeComponent();
        }

        public void Draw_Book_Tag()
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.Location = new System.Drawing.Point(0,0);
            this.Size = new Size(main_page.Pnl_tag.Width, main_page.Pnl_tag.Height);
            main_page.Pnl_tag.Controls.Add(this);
            this.BringToFront();
        }

        public void Edit_Book_Tag(string name, string description, string author, string book_id)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            lbl_bookname.Text = name;
            lbl_description.Text = description;
            lbl_author.Text = "- " + author;
            this.pic_book.Image = main_page.Cover_image_list.Images[book_id];
        }
        public void Edit_Book_Tag_for_emp(string name, string description, string author, string cover_path_file)
        {
            show_employee = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
            lbl_bookname.Text = name;
            lbl_description.Text = description;
            lbl_author.Text = "- " + author;
            this.pic_book.Image = Picture_Events.Get_Copy_Image_Bitmap(cover_path_file);
        }

    }
}
