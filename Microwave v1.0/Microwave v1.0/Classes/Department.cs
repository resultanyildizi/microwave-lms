using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.Classes
{
    public class Department
    {
        Microwave main_page;
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private string name;
        private int department_ıd;
        private int staff_count;

        public string Name { get => name; set => name = value; }
        public int Department_ıd { get => department_ıd; set => department_ıd = value; }
        public int Staff_count { get => staff_count; set => staff_count = value; }

        public Department(string name, int department_ıd, int staff_count)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.name = name;
            this.department_ıd = department_ıd;
            this.staff_count = staff_count; 

         
        }
    }
}
    
