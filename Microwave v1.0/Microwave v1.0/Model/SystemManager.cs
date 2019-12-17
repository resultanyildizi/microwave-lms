using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0.Model
{
    public class SystemManager : Employee
    {
        private static string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];


        public SystemManager(int employee_id, int department_id, string name, string surname, string password, string email, string gender, DateTime birth_date, string cover_path_file)
        {
            this.Employee_id = employee_id;
            this.Department_id = department_id;
            this.Name = name;
            this.Surname = surname;
            this.Password = password;
            this.Email = email;
            this.Gender = gender;
            this.Birth_date_dt = birth_date;
            this.Cover_path_file = cover_path_file;

            this.Join_Tables();
        }

        public static SystemManager Login(string email, string password)
        {
            string query = string.Format("Select * From Employee Where " +
                "Employee.DEPARTMENT_ID = 5 and Employee.EMAIL = '{0}' and Employee.PASSWORD = '{1}'",email, password);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, data_source);

            if (dt.Rows.Count <= 0)
                return null;

            int employee_id = int.Parse(dt.Rows[0][0].ToString());
            int department_id = int.Parse(dt.Rows[0][1].ToString());
            string employee_name = dt.Rows[0][2].ToString();
            string employee_surname = dt.Rows[0][3].ToString();
            string employee_email = dt.Rows[0][4].ToString();
            string employee_password = dt.Rows[0][5].ToString();
            string employee_gender = dt.Rows[0][6].ToString();
            string birth_date = dt.Rows[0][7].ToString();
            string pic_path_file = dt.Rows[0][8].ToString();

            DateTime b_date = Convert.ToDateTime(birth_date);

            SystemManager manager = new SystemManager(employee_id, department_id, employee_name, employee_surname, employee_password, employee_email, employee_gender, b_date, pic_path_file);
            return manager;
            
        }

        public void Give_Penalty_To_User(User user, Book book, Receipt penalty, Detail detail)
        {
            penalty.Add();
            user.Fee += penalty.Fee;
            user.Change_Fee();
            detail.Tb_5.Text = user.Fee + "₺";



            if(penalty.Pt_name == "LOST" || penalty.Pt_name == "DAMAGED")
            {
                user.Book_count--;
                string query_select = string.Format("Select Book_User.COUNT From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, user.User_id);
                DataTable dt = DataBaseEvents.ExecuteQuery(query_select, data_source);

                if (dt.Rows.Count <= 0)
                    return;

                int current_count = int.Parse(dt.Rows[0][0].ToString());
                if (current_count > 1)
                {
                    current_count--;
                    string query_update = string.Format("Update Book_User Set COUNT = {0} Where Book_User.BOOK_ID = {1} and Book_User.USER_ID = {2}", current_count, book.Book_id, user.User_id);
                    DataBaseEvents.ExecuteNonQuery(query_update, data_source);
                }
                else
                {
                    string query_delete = string.Format("Delete From Book_User Where Book_User.BOOK_ID = {0} and Book_User.USER_ID = {1}", book.Book_id, user.User_id);
                    DataBaseEvents.ExecuteNonQuery(query_delete, data_source);
                }

                detail.Dgw_users.DataSource = Book.Show_All_Books(user);
                detail.Tb_6.Text = user.Book_count.ToString();
            }
           
        }
    }
}
