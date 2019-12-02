using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0.Model
{
    public class Receipt
    {
        private int receipt_id;
        private Book book;
        private User user;
        // private Employee librarian;
        private string message;
        private string name;
        private string creation_date;
        private string receiving_date;




        public Receipt()
        {

        }

        public Receipt(Book book, User user /*,Employee librarian*/ )
        {
            this.book = book;
            this.user = user;
        }

        public void Add()
        {
            string message = Create_Message();

            string title = "Insert into Receipt(BOOK_ID, USER_ID, LIBRARIAN_ID, NAME, MESSAGE, CREATION_DATE, RECEIVING_DATE)";
            string values = string.Format(" Values('{0}','{1}','{2}','{3}','{4}', '{5}')", book.Book_id, user.User_id, 0, "BORROW", message, creation_date.ToString(), receiving_date.ToString());
            string quert = title + values;
        }

        public void Delete()
        {

        }

        private string Create_Message()
        {
            DateTime creation = DateTime.Now;
            DateTime receiving = DateTime.Now.AddDays(15.0);

            this.creation_date = creation.ToString();
            this.receiving_date = receiving.ToString();

            string msg = string.Format("\"{0}\" has been lended by \"{1}\" on \"{2}\". The book should be returned to the library in 15 days (\"{3}\"). Have a good time.", book.Name, user.Name, creation_date, receiving_date);
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



    }
}
