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
        private Microwave main_page = null;
        private Receipt_List main_receipt_list = null;
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
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_receipt_list = main_page.Main_receipt_list;
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

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Are you sure to delete that receipt?";
            main_page.Create_Warning_Form(message, Color.DarkRed);

            if (main_page.Warning_form.Result)
                Remove();

            main_page.Warning_form.Refresh_Form();

            main_page.Pnl_receipt_list.VerticalScroll.Value = 0;
            main_page.Receipt_search_list.Delete_All_List();
            main_page.Main_receipt_list.Draw_All_Receipts();
            main_page.Receipt_searched_already = false;

            this.Dispose();
        }

        private void Remove()
        {
            receipt.Revert_Changes(book, user);
            main_receipt_list.Delete_Receipt_from_List(receipt.Receipt_id);
            receipt.Info.Dispose();

            main_page.Pnl_receipt_list.VerticalScroll.Value = 0;
            Receipt.point_x = 25;
            Receipt.point_y = 25;
            main_receipt_list.Draw_All_Receipts();
        }
    }
}
