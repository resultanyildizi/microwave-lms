using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;


namespace Microwave_v1._0.Forms
{
    public partial class ShowEmployee : Form
    {
        private Employee_List main_employee_list = null;
        private AddEmployee addEmployee = null;

        public Employee_List Main_employee_list { get => main_employee_list; set => main_employee_list = value; }
        public AddEmployee AddEmployee { get => addEmployee; set => addEmployee = value; }

        public ShowEmployee()
        {
            InitializeComponent();
            main_employee_list = new Employee_List();
            
        }


        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            main_employee_list = new Employee_List();
            Employee.Show_All_Employees();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
   
            if(addEmployee == null)
            {
                addEmployee = new AddEmployee();
                
            }
            try
            {
                addEmployee.Show();
            }
            catch (Exception)
            {
                addEmployee = new AddEmployee();
                addEmployee.Show();
            }

        }
    }
}
