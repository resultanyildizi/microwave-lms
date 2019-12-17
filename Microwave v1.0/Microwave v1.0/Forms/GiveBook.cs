using Microwave_v1._0.Classes;
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
    public partial class GiveBook : Form
    {
        private string datasource = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        Book_List book_list = null;
        Book_List search_list = null;
        User user;
        Detail dt_form = null;
        private bool searched_already = false;

        public GiveBook(Detail detail, User user, string query)
        {
            InitializeComponent();
            dt_form = detail;
            this.lbl_message.Text = "";

            if (query == "Select * From Books")
            {
                this.btn_return_book.Hide();
                this.btn_give_book.Show();
                this.tb_search_book.Enabled = true;
            }
            else
            {
                this.btn_give_book.Hide();
                this.btn_return_book.Show();
                this.tb_search_book.Enabled = false;
            }

            book_list = new Book_List();
            search_list = new Book_List();
            this.user = user;

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            

            SizeF scale = new Size();
            scale.Width = (float)0.80;
            scale.Height = (float)0.80;

            book_list.Fill_Book_List(dt,book_list, search_list, null, pnl_book_list, INFO_COLOR_MODE.NORMAL, false);
            book_list.Draw_All_Books();
            
        }

        private void btn_give_book_Click(object sender, EventArgs e)
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];

            Book current = book_list.Find_Book_By_Chosen();

            if (current == null)
                current = search_list.Find_Book_By_Chosen();

            if (current == null)
            {
                lbl_message.Text = "*Please choose a book to lend";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            if(user.Fee > 0)
            {
                lbl_message.Text = "*Should pay all fees before";
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



                Author curr_aut = main_page.Main_author_list.Find_Author_By_ID(current.Author_id);
                Category curr_ctg = main_page.Main_category_list.Find_Category_By_ID(current.Category_id);

                current.Popularity_score += 5;
                curr_aut.Popularity_score += 5;
                curr_ctg.Popularity_score += 5;
                
                current.Change_Popularity_Score();
                curr_aut.Change_Popularity_Score();
                curr_ctg.Change_Popularity_Score();


                DataTable dt = Book.Show_All_Books(user);

                int rows_count = dt.Rows.Count;
                if (rows_count <= 0)
                    user.Book_count = 0;
                else
                {
                    int user_book_count = 0;
                    for (int i = 0; i < rows_count; i++)
                    {
                        user_book_count += int.Parse(dt.Rows[i][9].ToString());
                    }
                    user.Book_count = user_book_count;
                }

                

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

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            Book current = book_list.Find_Book_By_Chosen();

            if (current == null)
            {
                lbl_message.Text = "*Please choose a book to lend";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            user.Give_Book_Back(current);
            current.Change_Count();
            DataTable dt = Book.Show_All_Books(user);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
                user.Book_count = 0;
            else
            {
                int user_book_count = 0;
                for (int i = 0; i < rows_count; i++)
                {
                    user_book_count += int.Parse(dt.Rows[i][9].ToString());
                }
                user.Book_count = user_book_count;
            }

            dt_form.Tb_6.Text = user.Book_count.ToString();
            dt_form.Dgw_users.DataSource = dt;

            this.lbl_message.Text = "*Book has been returned successfully";
            this.lbl_message.ForeColor = Color.LightGreen;
        }

        private void Tb_search_book_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_book.Text.Trim();
            searched_already = false;

                if (text == "")
                {
                    lb_book_search.Hide();
                    lb_book_search.Items.Clear();

                    search_list.Delete_All_List();
                    book_list.Draw_All_Books();
                    return;
                }
                if (text == "Search a book")
                {
                    search_list.Delete_All_List();
                    book_list.Draw_All_Books();
                    return;
                }
                else
                {
                    this.pnl_book_list.VerticalScroll.Value = 0;

                    string query = string.Format("Select Books.NAME from Books Where Books.NAME Like '{0}%'", text);
                    Fill_Book_Search_List_Box(query);
                    if (lb_book_search.Items.Count > 0)
                        lb_book_search.Show();
                    return;
                }
        }
        private void Tb_search_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_book.Text;

            if (e.KeyChar == (char)Keys.Enter && !searched_already)
            {
                lb_book_search.Hide();
                if (tb_search_book.Text == "")
                {
                    return;
                }
                book_list.Hide_All_Book_Objects();
                search_list.Delete_All_List();
                this.pnl_book_list.VerticalScroll.Value = 0;

             
                search_list.Fill_Book_List(Book.Search_Book_By_Name(text), book_list, search_list, null, pnl_book_list, INFO_COLOR_MODE.NAME);
                search_list.Draw_All_Books();
                searched_already = true;
                return;
            }

        }
        private void Tb_search_book_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_book_search.Items.Count != 0)
                {
                    lb_book_search.Select();
                    lb_book_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_book_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_book.Text = tb_search_book.Text.Remove(tb_search_book.Text.Length - 1, 1);
                else
                    tb_search_book.Text += e.KeyChar;
                tb_search_book.Focus();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_book.Focus();
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }


        }
        private void Fill_Book_Search_List_Box(string query)
        {

            lb_book_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
            {
                return;
            }

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_book_search.Items.Contains(item))
                    continue;
                lb_book_search.Items.Add(item);
            }

        }
        private void Tb_search_Leave(object sender, EventArgs e)
        {

            if (tb_search_book.Text == "")
            {
                tb_search_book.Text = "Search a book";
                tb_search_book.ForeColor = Color.Gray;
            }
        }
        private void Tb_search_Enter(object sender, EventArgs e)
        {
            if (tb_search_book.Text == "Search a book")
            {
                tb_search_book.Text = "";
            }

            if (lb_book_search.Items.Count > 0)
                lb_book_search.Show();

            tb_search_book.ForeColor = Color.LightGray;
        }
        private void Lb_book_search_Leave(object sender, EventArgs e)
        {
            lb_book_search.Hide();
        }
        private void Lb_book_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_book.Focus();
            if (lb_book_search.SelectedItem != null)
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
            tb_search_book.Select(tb_search_book.Text.Length, 0);
        }
    }
}
