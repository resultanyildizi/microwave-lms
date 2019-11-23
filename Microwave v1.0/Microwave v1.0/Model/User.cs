using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    public class User
    {
        public static int point_y = 5;
        Microwave main_page;

        private string name;
        private string surname;
        private string gender;
        private int age;
        private string email;
        private string date;
        private int user_id;
        private UserInfo info;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Email { get => email; set => email = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public UserInfo Info { get => info; set => info = value; }
        public string Date { get => date; set => date = value; }

        public User(string name, string surname, string gender, int age, string email,string date)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            this.email = email;
            this.date = date;
            info = new UserInfo();
            info.Initialize_User_Info(name, surname, gender, age, email, date);
        }
    }
}
