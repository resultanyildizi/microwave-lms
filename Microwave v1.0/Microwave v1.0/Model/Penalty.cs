using Microwave_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Model
{
    public class Penalty : Receipt
    {

        public Penalty() { }

        public Penalty(int rcpt_id, int book_id, int user_id, int librarian_id, string message, string creation_date, string receiving_date, string pt_name, int fee)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = "PENALTY";
            this.message = message;
            this.creation_date = creation_date;
            this.receiving_date = receiving_date;
            this.pt_name = pt_name;
            this.fee = fee;
        }
        public Penalty(int rcpt_id, int book_id, int user_id, int librarian_id, string pt_name, int fee)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.receipt_id = rcpt_id;
            this.book_id = book_id;
            this.user_id = user_id;
            this.librarian_id = librarian_id;
            this.name = "PENALTY";
            this.pt_name = pt_name;
            this.fee = fee;
            msg_creator = Generate_Penalty_Message;
        }

        public override void Revert_Changes(Book book, User user)
        {
            user.Fee -= this.Fee;
            user.Change_Fee();
        }

        private void Generate_Penalty_Message()
        {
            DateTime creation = DateTime.Now;
            DateTime receiving = DateTime.Now.AddDays(15.0);

            this.creation_date = creation.ToString();
            this.receiving_date = receiving.ToString();

            string book_name = DataBaseEvents.ExecuteQuery(("Select Books.NAME From Books Where Books.BOOK_ID = " + book_id), data_source).Rows[0][0].ToString();
            string user_name = DataBaseEvents.ExecuteQuery(("Select Users.NAME From Users Where Users.USER_ID = " + user_id), data_source).Rows[0][0].ToString();
            string gender = DataBaseEvents.ExecuteQuery(("Select Users.GENDER From Users Where Users.USER_ID = " + user_id), data_source).Rows[0][0].ToString();
            int user_total_fee = int.Parse(DataBaseEvents.ExecuteQuery(("Select Users.FEE From Users Where Users.USER_ID = " + user_id), data_source).Rows[0][0].ToString()) + this.fee;
            string title = "";

            if (gender == "Male")
                title = "Mr.";
            else
                title = "Mrs.";

            string msg = string.Format("{0} \"{1}\", you have been fined due to penalty of \"{2}\". Your fee is \"{3}\" and you cannot take another book until you pay all your fees (\"{4}\").",title, user_name, pt_name, fee, user_total_fee);

            this.message = msg;
        }

       
    }
}
