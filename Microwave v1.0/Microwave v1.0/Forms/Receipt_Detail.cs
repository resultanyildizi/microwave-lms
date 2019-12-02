using Microwave_v1._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    public partial class Receipt_Detail : Form
    {
        private Receipt receipt;
        private Book book;
        private User user;
        // private Employee librarian;

        public Receipt_Detail()
        {
            InitializeComponent();
        }

        public Receipt_Detail(Receipt receipt, Book book, User user)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.book = book;
            this.user = user;
        }

        private void Receipt_Detail_Load(object sender, EventArgs e)
        {
            this.pb_book.Image = Picture_Events.Get_Copy_Image_Bitmap(book.Cover_path_file);
            this.lbl_rcpt_name.Text = receipt.Name;
            this.lbl_book_name_val.Text = book.Name;
            this.lbl_book_id_val.Text = book.Book_id.ToString();

            this.lbl_user_name_val.Text = user.Name + " " + user.Surname;
            this.lbl_user_email_val.Text = user.Email;
            this.lbl_user_id_val.Text = user.User_id.ToString();

            this.lbl_lib_id_val.Text = "1";
            this.lbl_lib_name_val.Text = "Nurettin Resul Tanyıldızı";

            this.lbl_date.Text = receipt.Creation_date.Substring(0, 10);
            this.tb_message.Text = receipt.Message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
