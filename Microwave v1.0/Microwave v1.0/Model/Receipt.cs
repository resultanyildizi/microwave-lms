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
    public abstract class Receipt 
    {
        public static int point_x = 25;
        public static int point_y = 5;
        
        static protected Microwave main_page = null;
        protected static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        
        protected int receipt_id;
        protected int book_id;
        protected int user_id;
        protected int librarian_id;
        protected string message;
        protected string name;
        protected string creation_date;
        protected string receiving_date;
        protected Receipt_Info info = null;
        protected MODE mode;
        protected Action msg_creator;
        protected string pt_name;
        protected int fee;


        public Receipt_Info Info { get => info; set => info = value; }
        public string Message { get => message; set => message = value; }
        public string Name { get => name; set => name = value; }
        public string Creation_date { get => creation_date; set => creation_date = value; }
        public string Receiving_date { get => receiving_date; set => receiving_date = value; }
        public int Receipt_id { get => receipt_id; set => receipt_id = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Librarian_id { get => librarian_id; set => librarian_id = value; }
        public string Pt_name { get => pt_name; set => pt_name = value; }
        public int Fee { get => fee; set => fee = value; }

        public void Add()
        {
            msg_creator.Invoke();
            string title = "Insert into Receipt(BOOK_ID, USER_ID, LIBRARIAN_ID, NAME, MESSAGE, CREATION_DATE, RECEIVING_DATE, PENALTY_NAME, FEE)";
            string values = string.Format(" Values('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}')", book_id, user_id, librarian_id, name, message, creation_date, receiving_date, pt_name, fee);
            
            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, data_source);

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
            int result = DataBaseEvents.ExecuteNonQuery(query, data_source);

            if(result <= 0)
            {
                MessageBox.Show("Invalid delete event");
                return;
            }

        }


        
        static public void Show_All_Receipts(Microwave main_page)
        {
            string query = "Select * From Receipt";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            main_page.Main_receipt_list.Fill_Receipt_List(dt);
            main_page.Main_receipt_list.Draw_All_Receipts();
        }
        public void Set_Receipt()
        {
            info = new Receipt_Info();
            info.Initialize_Receipt_Info(receipt_id, name);
        }

        public abstract void Revert_Changes(Book book, User user);


        static public DataTable Search_Receipt_By_Name(string name)
        {
            string query = string.Format("Select * From Receipt Where Receipt.NAME Like '{0}%'", name);
            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        static public DataTable Search_Receipt_By_ID(string receipt_id)
        {
            string query = string.Format("Select * From Receipt Where Receipt.RECEIPT_ID Like '{0}%'", receipt_id);
            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        static public DataTable Search_Receipt_By_User_Name(string u_name)
        {
            string query = string.Format("Select Receipt.RECEIPT_ID, Receipt.BOOK_ID, Receipt.USER_ID, Receipt.LIBRARIAN_ID, Receipt.NAME, Receipt.MESSAGE, Receipt.CREATION_DATE, Receipt.RECEIVING_DATE, Receipt.PENALTY_NAME, Receipt.FEE " +
                "from Receipt Join Users On Receipt.USER_ID = Users.USER_ID Where Users.NAME Like '{0}%'", u_name);
            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        static public DataTable Search_Receipt_By_Book_Name(string b_name)
        {
            string query = string.Format("Select Receipt.RECEIPT_ID, Receipt.BOOK_ID, Receipt.USER_ID, Receipt.LIBRARIAN_ID, Receipt.NAME, Receipt.MESSAGE, Receipt.CREATION_DATE, Receipt.RECEIVING_DATE, Receipt.PENALTY_NAME, Receipt.FEE " +
                   "from Receipt Join Books On Receipt.BOOK_ID = Books.BOOK_ID Where Books.NAME Like '{0}%'", b_name);
            return DataBaseEvents.ExecuteQuery(query, data_source);
        }
        static public DataTable Search_Receipt_By_Librarian_Name(string l_name)
        {
            string query = string.Format("Select Receipt.RECEIPT_ID, Receipt.BOOK_ID, Receipt.USER_ID, Receipt.LIBRARIAN_ID, Receipt.NAME, Receipt.MESSAGE, Receipt.CREATION_DATE, Receipt.RECEIVING_DATE, Receipt.PENALTY_NAME, Receipt.FEE " +
                   "from Receipt Join Books On Receipt.LIBRARIAN_ID = Employee.EMPLOYEE_ID Where Employee.NAME Like '{0}%'", l_name);
            return DataBaseEvents.ExecuteQuery(query, data_source);

        }
        static public DataTable Search_Receipt_By_Date(string date)
        {
            string query = string.Format("Select * From Receipt Where Receipt.CREATION_DATE Like '{0}%'", date);
            return DataBaseEvents.ExecuteQuery(query, data_source);
        }

        protected void Take_ID_From_Database()
        {
            string title = "Select Receipt.RECEIPT_ID From Receipt ";
            string query = title + string.Format("Where Receipt.MESSAGE = '{0}'", message);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);
            int id = int.Parse(dt.Rows[0][0].ToString());

            this.receipt_id = id;
            this.Info.Receipt_id = id;
        }

    }
}
