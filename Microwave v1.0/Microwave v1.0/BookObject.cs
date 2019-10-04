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
    public partial class BookObject : UserControl
    {
        public Panel namePanel;
        public Panel authorPanel;
        public Panel publisherPanel;
        public Panel datePanel;
        public Panel countPanel;

        public Label nameLabel;
        public Label authorLabel;
        public Label publisherLabel;
        public Label dateLabel;
        public Label countLabel;

        public Books book;
        public bool chosen;
        private Microwave main_page;
        public BookObject()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BookObject_Load(object sender, EventArgs e)
        {
        }

        public void Draw_Book_Obj(ref int y)
        {
            main_page.pnl_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }

        public void BookObject_Clicked(object sender, EventArgs e)
        {
            main_page.book_list.Make_Chosen_False();
            chosen = true;
            main_page.book_list.Click_Book_Obj();
        }

        public void Chose_BookObject()
        {
            Color back_color;
            if (chosen)
            {
                back_color = Color.FromArgb(33, 37, 48);
                book.Edit_About_Book();
                book.get_about_book().Draw_About_Book();
            }else
            {
                back_color = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            }

            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
        }

        private void Panel3_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
