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

        public Book_Tag()
        {
            InitializeComponent();
        }

        public void Draw_Book_Tag()
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new Size(main_page.pnl_tag.Width, main_page.pnl_tag.Height);
            main_page.pnl_tag.Controls.Add(this);
            this.BringToFront();
        }

        public void Initialize_Book_Tag(string name, string description, string author)
        {
            lbl_bookname.Text = name;
            lbl_description.Text = description;
            lbl_author.Text = "- " + author;
        }

    }
}
