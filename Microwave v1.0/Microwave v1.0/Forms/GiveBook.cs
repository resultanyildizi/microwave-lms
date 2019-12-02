using Microwave_v1._0.Classes;
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
    public partial class GiveBook : Form
    {
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        Book_List book_list = null;
        Book_List search_list = null;
        User user;
        Detail dt_form = null;

        public GiveBook(Detail detail, User user)
        {
            InitializeComponent();
            dt_form = detail;
            this.lbl_message.Text = "";

            book_list = new Book_List();
            search_list = new Book_List();
            this.user = user;

            string query = "Select * From Books";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            

            SizeF scale = new Size();
            scale.Width = (float)0.80;
            scale.Height = (float)0.80;

            book_list.Fill_Book_List(dt,book_list, search_list, null, pnl_book_list, INFO_COLOR_MODE.NORMAL, false);
            book_list.Draw_All_Books();
            
        }

        private void btn_give_book_Click(object sender, EventArgs e)
        {
            Book current = book_list.Find_Book_By_Chosen();

            if (current == null)
            {
                lbl_message.Text = "*Please choose a book to lend";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            if (user.Book_count < 5)
            {

                if(current.Count <= 0)
                {
                    lbl_message.Text = "*That book doesn't exist right now";
                    lbl_message.ForeColor = Color.Red;
                    return;
                }



                current.Give_Book_To_User(user);
                current.Change_Count();
                DataTable dt = Book.Show_All_Books(user);
                user.Book_count = dt.Rows.Count;

                dt_form.Tb_6.Text = user.Book_count.ToString();
                dt_form.Dgw_users.DataSource = dt;

                this.lbl_message.Text = "*Book has been lended successfully";
                this.lbl_message.ForeColor = Color.LightGreen;
            }
            else
            {
                lbl_message.Text = "*A user can only have at most 5 books at the same time ";
                lbl_message.ForeColor = Color.Red;
                return;
            }
            
        }
    }
}
