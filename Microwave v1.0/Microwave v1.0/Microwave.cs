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
    public partial class Microwave : Form
    {
        private AddBook add_book = null;
        public Book_List book_list = new Book_List();
        private Book_Tag book_tag;

        public Book_Tag Book_tag { get => book_tag; set => book_tag = value; }

        public Microwave()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
            book_tag = new Book_Tag();
            book_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", path_file);
            book_tag.Draw_Book_Tag();

            
            book_list.Add_Book_to_List(new Book("Oyunbaz", "Wulf Dorn", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Fareler ve İnsanlar", "John Steinbeck", "YapiKredi Yayınevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Oyunbaz", "Wulf Dorn", "YapiKredi Yayınevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Fareler ve İnsanlar", "John Steinbeck", "YapiKredi Yayinevi", "12/4/1998","", "45",path_file));
            book_list.Add_Book_to_List(new Book("Kurk Mantolu Madonna", "Sabahattin Ali", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Marsli", "Andy Weir", "İthaki Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Uçurtma Avcisi", "Khalid Hosseini", "Everest Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Türkiyenin Yakin Tarihi", "İlber Ortayli", "Timas Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Siyah Lale", "Alexandre Dumas", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Denemeler", "Montaigne", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Mesnevi", "Mevlana", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Oyunbaz", "Wulf Dorn", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Fareler ve İnsanlar", "John Steinbeck", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Kurk Mantolu Madonna", "Sabahattin Ali", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Marsli", "Andy Weir", "İthaki Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Uçurtma Avcisi", "Khalid Hosseini", "Everest Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Türkiyenin Yakin Tarihi", "İlber Ortayli", "Timas Yayinlari", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Siyah Lale", "Alexandre Dumas", "YapiKredi Yayinevi", "12/4/1998", "","45", path_file));
            book_list.Add_Book_to_List(new Book("Denemeler", "Montaigne", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
            book_list.Add_Book_to_List(new Book("Mesnevi", "Mevlana", "YapiKredi Yayinevi", "12/4/1998","", "45", path_file));
          
            book_list.Show_All_Books();

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            
            if(add_book == null)
            {
                add_book = new AddBook();
            }
            // IMPORTANT
            try
            {
                add_book.Show();
            }catch(ObjectDisposedException d)
            {
                add_book = new AddBook();
                add_book.Show();
            }
            
        }

        private void Tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void Pnl_menu_Click(object sender, EventArgs e)
        {
            pnl_menu.Focus();
        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {
            pic_logo.Focus();
        }

        private void Pnl_left_Click(object sender, EventArgs e)
        {
            pnl_left.Focus();
        }

        private void Panel9_Click(object sender, EventArgs e)
        {
            panel9.Focus();
        }

        private void Pnl_list_Click(object sender, EventArgs e)
        {
            pnl_list.Focus();
        }

        private void tb_search_Enter(object sender, EventArgs e)
        {
            if(tb_search.Text == "Search A Book...")
            {
                tb_search.Text = "";
                tb_search.ForeColor = Color.LightGray;
            }
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                tb_search.Text = "Search A Book...";
                tb_search.ForeColor = Color.DimGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 51);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 91);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 130);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 13);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
