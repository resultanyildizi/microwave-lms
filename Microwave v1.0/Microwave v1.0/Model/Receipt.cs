using Microwave_v1._0.Classes;
using Microwave_v1._0.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Model
{
    public enum MODE
    {
        GIVE, RETURN
    }
    public class Receipt
    {
        public static int point_x = 25;
        public static int point_y = 5;

        static private Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int receipt_id;
        private int book_id;
        private int user_id;
        private int librarian_id;
        private string message;
        private string name;
        private string creation_date;
        private string receiving_date;
        private Receipt_Info info = null;
        private MODE mode;

        public Receipt_Info Info { get => info; set => info = value; }
        public string Message { get => message; set => message = value; }
        public string Name { get => name; set => name = value; }
        public string Creation_date { get => creation_date; set => creation_date = value; }
        public string Receiving_date { get => receiving_date; set => receiving_date = value; }
        public int Receipt_id { get => receipt_id; set => receipt_id = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Librarian_id { get => librarian_id; set => librarian_id = value; }

        public Receipt()
        {

        }

        public Receipt(int rcpt_id, int book_id, int user_id, int librarian_id, string name, string message, string creation_date, string receiving_date)
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

        }
        public Receipt(int rcpt_id, int book_id, int user_id, int librarian_id, string name, MODE mode)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = name;
            this.mode = mode;
        }

        public void Add()
        {
            if (mode == MODE.GIVE)
                this.message = Generate_Give_Message();
            else
                this.message = Generate_Return_Message();

            string title = "Insert into Receipt(BOOK_ID, USER_ID, LIBRARIAN_ID, NAME, MESSAGE, CREATION_DATE, RECEIVING_DATE)";
            string values = string.Format(" Values('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}')", book_id, user_id, librarian_id, name, message, creation_date, receiving_date);
            
            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            info = new Receipt_Info();
            Take_ID_From_Database();

            info.Initialize_Receipt_Info(receipt_id, name);
            main_page.Main_receipt_list.Add_Receipt_to_List(this);
            main_page.Pnl_receipt_list.VerticalScroll.Value = 0;

            info.Draw_Receipt_Obj(ref Receipt.point_x, ref Receipt.point_y);
            main_page.Main_receipt_list.Deselect_All_Infos();
            info.Select_Receipt_Info();
        }


        public void Delete()
        {

            string query = "Delete From Receipt Where Receipt.RECEIPT_ID = " + receipt_id;
            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);

            if(result <= 0)
            {
                MessageBox.Show("Invalid delete event");
                return;
            }

        }


        public void Revert_Changes(Book book, User user)
        {
            if (this.mode == MODE.GIVE)
            {
                book.Count++;
                book.Change_Count();

                string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.User_id);
                DataTable dt = DataBaseEvents.ExecuteQuery(query_select, datasource);

                if (dt.Rows.Count <= 0)
                    return;

                int current_count = int.Parse(dt.Rows[0][0].ToString());
                if (current_count > 1)
                {
                    current_count--;
                    string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, this.user_id);
                    DataBaseEvents.ExecuteNonQuery(query_update, datasource);
                }
                else
                {
                    string query_delete = string.Format("Delete From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.user_id);
                    DataBaseEvents.ExecuteNonQuery(query_delete, datasource);
                }
            }
            else
            {

                book.Count--;
                book.Change_Count();

                string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, this.User_id);
                DataTable dt = DataBaseEvents.ExecuteQuery(query_select, datasource);

                if (dt.Rows.Count <= 0)
                {

                    string query_delete = string.Format("Insert Into Book_User(BOOK_ID, USER_ID, COUNT) Values({0},{1},{2})", book.Book_id, this.user_id, 1);
                    DataBaseEvents.ExecuteNonQuery(query_delete, datasource);
                }
                else
                {
                    int current_count = int.Parse(dt.Rows[0][0].ToString());
                    if (current_count > 0)
                    {
                        current_count++;
                        string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, this.user_id);
                        DataBaseEvents.ExecuteNonQuery(query_update, datasource);
                    }
                }
            }
            
        }
        static public void Show_All_Receipts(Microwave main_page)
        {
            string query = "Select * From Receipt";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page.Main_receipt_list.Fill_Receipt_List(dt);
            main_page.Main_receipt_list.Draw_All_Receipts();
        }
        public void Set_Receipt()
        {
            info = new Receipt_Info();
            info.Initialize_Receipt_Info(receipt_id, name);
        }

        private string Generate_Give_Message()
        {
            DateTime creation = DateTime.Now;
            DateTime receiving = DateTime.Now.AddDays(15.0);

            this.creation_date = creation.ToString();
            this.receiving_date = receiving.ToString();

            string book_name = DataBaseEvents.ExecuteQuery(("Select Books.NAME From Books Where Books.BOOK_ID = " + book_id), datasource).Rows[0][0].ToString();
            string user_name = DataBaseEvents.ExecuteQuery(("Select Users.NAME From Users Where Users.USER_ID = " + user_id), datasource).Rows[0][0].ToString();

            string msg = string.Format("\"{0}\" has been borrowed by \"{1}\" on \"{2}\". " +
                "The book should be returned to the library in 15 days (\"{3}\"). Have a good time."
                ,book_name, user_name, creation_date, receiving_date);

            return msg;
        }

        private string Generate_Return_Message()
        {
            DateTime now = DateTime.Now;

            this.creation_date = now.ToString();
            this.receiving_date = now.ToString();

            string book_name = DataBaseEvents.ExecuteQuery(("Select Books.NAME From Books Where Books.BOOK_ID = " + book_id), datasource).Rows[0][0].ToString();
            string user_name = DataBaseEvents.ExecuteQuery(("Select Users.NAME From Users Where Users.USER_ID = " + user_id), datasource).Rows[0][0].ToString();

            string msg = string.Format("\"{0}\" has been returned to the library by \"{1}\" on \"{2}\". " +
                "Thanks for your common sense."
                , book_name, user_name, creation_date); ;

            return msg;
        }

        static public DataTable Search_Receipt_By_Name(string name)
        {
            string query = string.Format("Select * From Receipt Where Receipt.NAME Like '{0}%'", name);
            return DataBaseEvents.ExecuteQuery(query, datasource);
        }
        static public DataTable Search_Receipt_By_ID(string receipt_id)
        {
            string query = string.Format("Select * From Receipt Where Receipt.RECEIPT_ID Like '{0}%'", receipt_id);
            return DataBaseEvents.ExecuteQuery(query, datasource);
        }
        static public DataTable Search_Receipt_By_User_Name(string u_name)
        {
            string query = string.Format("Select Receipt.RECEIPT_ID, Receipt.BOOK_ID, Receipt.USER_ID, Receipt.LIBRARIAN_ID, Receipt.NAME, Receipt.MESSAGE, Receipt.CREATION_DATE, Receipt.RECEIVING_DATE " +
                "from Receipt Join Users On Receipt.USER_ID = Users.USER_ID Where Users.NAME Like '{0}%'", u_name);
            return DataBaseEvents.ExecuteQuery(query, datasource);
        }
        static public DataTable Search_Receipt_By_Book_Name(string b_name)
        {
            string query = string.Format("Select Receipt.RECEIPT_ID, Receipt.BOOK_ID, Receipt.USER_ID, Receipt.LIBRARIAN_ID, Receipt.NAME, Receipt.MESSAGE, Receipt.CREATION_DATE, Receipt.RECEIVING_DATE " +
                   "from Receipt Join Books On Receipt.BOOK_ID = Books.BOOK_ID Where Books.NAME Like '{0}%'", b_name);
            return DataBaseEvents.ExecuteQuery(query, datasource);
        }
        static public DataTable Search_Receipt_By_Librarian_Name(string l_name)
        {
            return null;

        }
        static public DataTable Search_Receipt_By_Date(string date)
        {
            string query = string.Format("Select * From Receipt Where Receipt.CREATION_DATE Like '{0}%'", date);
            return DataBaseEvents.ExecuteQuery(query, datasource);
        }

        private void Take_ID_From_Database()
        {
            string title = "Select Receipt.RECEIPT_ID From Receipt ";
            string query = title + string.Format("Where Receipt.MESSAGE = '{0}'", message);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            int id = int.Parse(dt.Rows[0][0].ToString());

            this.receipt_id = id;
            this.Info.Receipt_id = id;
        }

    }
}
