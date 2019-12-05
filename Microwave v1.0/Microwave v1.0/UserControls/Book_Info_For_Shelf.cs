using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;

namespace Microwave_v1._0.UserControls
{
    public partial class Book_Info_For_Shelf : UserControl
    {
        private Microwave main_page;
        private Shelf_List main_shelf_list;
        private Shelf shelf;


        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private string book_name;
        private int book_id;
        private string publisher;
        private string author;
        private int count;
        private string category;

        public Book_Info_For_Shelf(Shelf shelf)
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_shelf_list = main_page.Main_shelf_list;
            this.shelf = shelf;
            shelf.Shelf_ınfo.Pnl_book_detail.Hide();

        }

        public void Initialize_Book_Info(int book_id, string name, string author, string publisher, string category, int count)
        {
            this.book_id = book_id;
            this.book_name = name;
            this.author = author;
            this.publisher = publisher;
            this.category = category;
            this.count = count;

        }

        public void Draw_Book_Obj(ref int x)
        {
            shelf.Shelf_ınfo.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, shelf.Shelf_ınfo.Pnl_shelf.Location.Y - this.Height);
            x += 20;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            shelf.Shelf_ınfo.Lbl_book_name.Text = book_name;
            shelf.Shelf_ınfo.Lbl_author.Text = author;
            shelf.Shelf_ınfo.Lbl_publisher.Text = publisher;
            shelf.Shelf_ınfo.Lbl_category.Text = category;

            shelf.Shelf_ınfo.Pnl_book_detail.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            shelf.Shelf_ınfo.Pnl_book_detail.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            shelf.Shelf_ınfo.Pnl_book_detail.Hide();

        }
        public void Remove()
        {
            shelf.point_book_x = 65;
            shelf.Book_list.Delete_Book_from_List(book_id, false);
            this.Dispose();
            shelf.Book_list.Delete_All_Books_From_Shelf();
            shelf.Fill_Shelf();

        }

    }
}
