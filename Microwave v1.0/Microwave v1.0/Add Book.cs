using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    public partial class AddBook : Form
    {
        private string name;
        private string author;
        private string publisher;
        private string date;
        private string count;
        private string pic_path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
        Microwave main_page;
       

        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.BringToFront();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add_Book();
        }

        private void Add_Book()
        {
            name = tb_name.Text;
            author = tb_author.Text;
            publisher = tb_publisher.Text;
            date = tb_date.Text;
            count = tb_count.Text;

            Book book = new Book(name, author, publisher, date, count, pic_path_file);
            main_page.book_list.Add_Book_to_List(book);
            main_page.pnl_list.VerticalScroll.Value = 0;
            book.Info.Draw_Book_Obj(ref Book.point_y);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose_pic = new OpenFileDialog();
            choose_pic.ShowDialog();
            choose_pic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            pic_path_file = choose_pic.FileName;
            this.pic_book.Load(pic_path_file);
           
        }
    }
}
