using Microwave_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Model
{
    public class Informer : Receipt
    {
        public Informer()
        {

        }


        public Informer(int rcpt_id, int book_id, int user_id, int librarian_id, string name, string message, string creation_date, string receiving_date)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = name;
            this.message = message;
            this.creation_date = creation_date;
            this.receiving_date = receiving_date;
            this.pt_name = "NONE";
            this.fee = 0;
            
        }
        public Informer(int rcpt_id, int book_id, int user_id, int librarian_id, string name, MODE mode)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = name;
            this.mode = mode;
            this.pt_name = "NONE";
            this.fee = 0;
            if (mode == MODE.GIVE)
                msg_creator = Generate_Give_Message;
            else if (mode == MODE.RETURN)
                msg_creator = Generate_Return_Message;
        }
        public override void Revert_Changes(Book book, User user)
        {
            if (this.mode == MODE.GIVE)
            {
                book.Count++;
                book.Change_Count();

                string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.User_id);
                DataTable dt = DataBaseEvents.ExecuteQuery(query_select, data_source);

                if (dt.Rows.Count <= 0)
                    return;

                int current_count = int.Parse(dt.Rows[0][0].ToString());
                if (current_count > 1)
                {
                    current_count--;
                    string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, this.user_id);
                    DataBaseEvents.ExecuteNonQuery(query_update, data_source);
                }
                else
                {
                    string query_delete = string.Format("Delete From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.user_id);
                    DataBaseEvents.ExecuteNonQuery(query_delete, data_source);
                }



                // Popularity
                Author aut = main_page.Main_author_list.Find_Author_By_ID(book.Author_id);
                Category ctg = main_page.Main_category_list.Find_Category_By_ID(book.Category_id);

                book.Popularity_score -= 5;
                aut.Popularity_score -= 5;
                ctg.Popularity_score -= 5;

                book.Change_Popularity_Score();
                aut.Change_Popularity_Score();
                ctg.Change_Popularity_Score();
            }
            else
            {

                book.Count--;
                book.Change_Count();

                string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.User_id);
                DataTable dt = DataBaseEvents.ExecuteQuery(query_select, data_source);

                if (dt.Rows.Count <= 0)
                {

                    string query_delete = string.Format("Insert Into Book_User(BOOK_ID, USER_ID, COUNT) Values({0},{1},{2})", book.Book_id, this.user_id, 1);
                    DataBaseEvents.ExecuteNonQuery(query_delete, data_source);
                }
                else
                {
                    int current_count = int.Parse(dt.Rows[0][0].ToString());
                    if (current_count > 0)
                    {
                        current_count++;
                        string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, this.user_id);
                        DataBaseEvents.ExecuteNonQuery(query_update, data_source);
                    }
                }
            }

        }

        private void Generate_Give_Message()
        {
            DateTime creation = DateTime.Now;
            DateTime receiving = DateTime.Now.AddDays(15.0);

            this.creation_date = creation.ToString();
            this.receiving_date = receiving.ToString();

            string book_name = DataBaseEvents.ExecuteQuery(("Select Books.NAME From Books Where Books.BOOK_ID = " + book_id), data_source).Rows[0][0].ToString();
            string user_name = DataBaseEvents.ExecuteQuery(("Select Users.NAME From Users Where Users.USER_ID = " + user_id), data_source).Rows[0][0].ToString();

            string msg = string.Format("\"{0}\" has been borrowed by \"{1}\" on \"{2}\". " +
                "The book should be returned to the library in 15 days (\"{3}\"). Have a good time."
                , book_name, user_name, creation_date, receiving_date);

            this.message = msg;
        }

        private void Generate_Return_Message()
        {
            DateTime now = DateTime.Now;

            this.creation_date = now.ToString();
            this.receiving_date = now.ToString();

            string book_name = DataBaseEvents.ExecuteQuery(("Select Books.NAME From Books Where Books.BOOK_ID = " + book_id), data_source).Rows[0][0].ToString();
            string user_name = DataBaseEvents.ExecuteQuery(("Select Users.NAME From Users Where Users.USER_ID = " + user_id), data_source).Rows[0][0].ToString();

            string msg = string.Format("\"{0}\" has been returned to the library by \"{1}\" on \"{2}\". " +
                "Thanks for your common sense."
                , book_name, user_name, creation_date); ;

            this.message = msg;
        }
    }
}
