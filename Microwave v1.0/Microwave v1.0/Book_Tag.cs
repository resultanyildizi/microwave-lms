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
    public partial class Book_Tag : UserControl
    {
        private string pic_path_file;

        public Book_Tag()
        {
            InitializeComponent();
        }

        public void Draw_Book_Tag()
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
            this.Location = new System.Drawing.Point(0,0);
            this.Size = new Size(main_page.Pnl_tag.Width, main_page.Pnl_tag.Height);
            main_page.Pnl_tag.Controls.Add(this);
            this.BringToFront();
        }

        public void Edit_Book_Tag(string name, string description, string author, string pic_path_file)
        {
            lbl_bookname.Text = name;
            lbl_description.Text = description;
            lbl_author.Text = "- " + author;
            this.pic_path_file = pic_path_file;
            this.pic_book.Load(pic_path_file);
        }

    }
}
