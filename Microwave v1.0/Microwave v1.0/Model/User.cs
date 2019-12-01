using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using System.Data;

namespace Microwave_v1._0
{
    public class User
    {

        private int user_id;
        private string name;
        private string surname;
        private string gender;
        private string password;
        private string email;
        private string date;
        private int age;
        private UserInfo info;

        public static int point_y = 5;
        static private Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        // Getters and setters
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Date { get => date; set => date = value; }
        public UserInfo Info { get => info; set => info = value; }
        public string Password { get => password; set => password = value; }

        // Constructors

        public User()
        {

        }

        public User(int user_id, string name, string surname, string gender, int age, string email, string password, string date)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.user_id = user_id;
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.email = email;
            this.password = password;
            this.date = date;
        }


        // Methods
        public void Add()
        {
            string title  = "Insert Into Users(NAME, SURNAME, GENDER, AGE, EMAIL, PASSWORD, DATE) ";
            string values = string.Format("Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", name, surname, gender, age, email, password, date);
            string query = string.Concat(title, values);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            
            if(result <= 0)
            {
                MessageBox.Show("Invalid insertion event");
                return;
            }

            info = new UserInfo();
            Take_Id_From_Database();
            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, INFO_COLOR_MODE.NORMAL);
            main_page.Main_user_list.Add_User_to_List(this);
            main_page.Pnl_user_list.VerticalScroll.Value = 0;
            info.Draw_User_Obj(ref User.point_y);
            info.Select_User_Info();

        }
        public void Edit()
        {
            string title = "Update Users ";
            string query = title + string.Format("Set NAME = '{0}', SURNAME = '{1}', GENDER = '{2}', " +
                "AGE = '{3}', EMAIL = '{4}' Where Users.USER_ID = '{5}'", name, surname, gender, age, email, user_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if(result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }

            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, INFO_COLOR_MODE.NORMAL);
            info.Select_User_Info();
        }
        public void Delete()
        {
            string query = "Delete From Users Where USER_ID = " + user_id;

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if(result <= 0)
            {
                MessageBox.Show("Invalid delete event");
                return;
            }

            return;
        }
        public static void Show_All_Users()
        {
            string query = "Select * From Users ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_page.Main_user_list.Fill_User_List(dt, INFO_COLOR_MODE.NORMAL);
            main_page.Main_user_list.Draw_All_Users();
        }
        public void Set_Book(INFO_COLOR_MODE color_mode)
        {
            info = new UserInfo();
            info.Initialize_User_Info(user_id, name, surname, gender, age, email, date, color_mode);
        }

        static public DataTable Search_User_By_Name(string name)
        {
            string query = string.Format("Select * From Users Where Users.NAME Like '{0}%'", name);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_User_By_Surname(string surname)
        {
            string query = string.Format("Select * From Users Where Users.SURNAME Like '{0}%'", surname);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_User_By_ID(string id)
        {
            string query = string.Format("Select * From Users Where Users.USER_ID Like '{0}%'", id);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_User_By_Email(string email)
        {
            string query = string.Format("Select * From Users Where Users.EMAIL Like '{0}%'", email);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;

        }
        static public DataTable Search_User_By_Age(string age)
        {
            string query = string.Format("Select * From Users Where Users.AGE Like '{0}%'", age);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }
        static public DataTable Search_User_By_Gender(string gender)
        {
            string query = string.Format("Select * From Users Where Users.GENDER Like '{0}%'", gender);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            return dt;
        }


        // Background Database Events
        private void Take_Id_From_Database()
        {
            string title = "Select Users.USER_ID from Users ";
            string query = title + string.Format("Where Users.NAME = '{0}' and Users.SURNAME = '{1}' and Users.EMAIL = '{2}'", name, surname, email);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.user_id = id;
            this.info.User_id = id;
        }
    }
}
