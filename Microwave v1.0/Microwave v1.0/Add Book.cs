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

        Microwave main_page;
       

        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.BringToFront();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            name = tb_name.Text;
            author = tb_author.Text;
            publisher = tb_publisher.Text;
            date = tb_date.Text;
            count = tb_count.Text;
            
            Books book = new Books(name, author, publisher, date, count);
            main_page.book_list.Add_Book_To_List(book);
            main_page.pnl_list.VerticalScroll.Value = 0;
            main_page.book_list.Print_Book_List();
        }
    }
}
