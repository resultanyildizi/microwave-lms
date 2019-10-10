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
        public bool chosen;
        private Book_Tag book_tag;

        private Microwave main_page;
        private Book_List main_list;

        public Book_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_list = main_page.book_list;
        }

        public void Initialize_Book_Info(string name, string author, string publisher, string date, string count, Book_Tag bt)
        {
            this.lbl_name.Text = name;
            this.lbl_author.Text = author;
            this.lbl_publisher.Text = publisher;
            this.lbl_date.Text = date;
            this.lbl_count.Text = count;
            this.book_tag = bt;
        }

        public void Draw_Book_Obj(ref int y)
        {
            main_page.pnl_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }

        public void BookObject_Clicked(object sender, EventArgs e)
        {
            main_list.Make_Infos_Chosen_False();
            chosen = true;
            main_list.Click_Book_Info_Objects();
            this.Focus();
        }

        public void Chose_BookObject()
        {
            Color back_color;

            if (chosen)
            {
                back_color = Color.FromArgb(33, 37, 48);
                book_tag.Draw_Book_Tag();
            }else
            {
                back_color = System.Drawing.Color.FromArgb(55,57,68);
            }

            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
        }

    }
}
