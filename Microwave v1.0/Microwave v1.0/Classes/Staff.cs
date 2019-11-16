using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.Classes
{
   public class Staff
    {
        //Global
        Microwave main_page;
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        //Variables
        private string name;
        private string surname;
        private string email;
        private string gender;
        private string department;
        private int working_hour;
        private int age;
        private int starting_date;
        private Staff info;
        //Getters and Setters
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Department { get => department; set => department = value; }
        public int Working_hour { get => working_hour; set => working_hour = value; }
        public Staff Info { get => info; set => info = value; }
        public int Age { get => age; set => age = value; }

        public Staff(string name,string email,string gender,string department,int working_hour ,int age)
        {
            main_page = (Microwave)Application.OpenForms["ShowStaff"];

            
 
        }

    }

}
