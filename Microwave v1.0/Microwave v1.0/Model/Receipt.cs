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
        public Receipt(int rcpt_id, int book_id, int user_id, int librarian_id, string name)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = name;
        }

        public void Add()
        {
            this.message = Create_Message();

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
            info.Select_Receipt_Info();
        }


        public void Delete()
        {
            string query = "Delete From Receipt Where Receipt.RECEIPT_ID = " + receipt_id;
            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);

            if(result <= 0)
            {
                MessageBox.Show("Invalid delete event");
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

        private string Create_Message()
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

        static public DataTable Search_Receipt_By_Name(string name)
        {
            return null;
        }
        static public DataTable Search_Receipt_By_ID(int receipt_id)
        {
            return null;
        }
        static public DataTable Search_Receipt_By_User_Name(string u_name)
        {
            return null;

        }
        static public DataTable Search_Receipt_By_Book_Name(string b_name)
        {
            return null;

        }
        static public DataTable Search_Receipt_By_Librarian_Name(string l_name)
        {
            return null;

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
