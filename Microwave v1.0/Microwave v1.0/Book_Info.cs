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
    public partial class Book_Info : UserControl
    {
        private Microwave main_page;
        private Book_List main_list;
        string description;
        string name;
        string author;
        string pic_path_file;

        public Book_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_list = main_page.book_list;
        }

        public void Initialize_Book_Info(string name, string author, string publisher, string date, string count, string description, string pic_path_file)
        {
            this.lbl_name.Text = name;
            this.lbl_author.Text = author;
            this.lbl_publisher.Text = publisher;
            this.lbl_date.Text = date;
            this.lbl_count.Text = count;
            this.description = description;
            this.author = author;
            this.name = name;
            this.pic_path_file = pic_path_file;
        }

        public void Draw_Book_Obj(ref int y)
        {
            main_page.pnl_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }

        public void BookObject_Clicked(object sender, EventArgs e)
        {
            main_list.Deselect_All_Book_Infos();
            this.Select_Book_Info();
            this.Focus();
        }

        public void Select_Book_Info()
        {
            Book_Tag main_book_tag = main_page.Book_tag;
            Color back_color;
            back_color = Color.FromArgb(33, 37, 48);
            main_book_tag.Edit_Book_Tag(name, description, author, pic_path_file);
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;

        }

        public void Deselect_Book_Info()
        {
            Color back_color;
            back_color = System.Drawing.Color.FromArgb(55, 57, 68);
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
        }

    }
}
