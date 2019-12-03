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
        private Department department = null;
        private Employee_List main_employee_list = null;
        private AddEmployee addEmployee = null;
        private Book_Tag main_tag = null;
        private Warning Warning_form = null;


        private SQLiteConnection connection = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        private string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";

        public Employee_List Main_employee_list { get => main_employee_list; set => main_employee_list = value; }
        public AddEmployee AddEmployee { get => addEmployee; set => addEmployee = value; }
        public Book_Tag Main_tag { get => main_tag; set => main_tag = value; }
        public Warning Warning_form1 { get => Warning_form; set => Warning_form = value; }

        public ShowEmployee(Department department)
        {

            InitializeComponent();
            main_employee_list = new Employee_List();
            main_tag = this.emp_tag;
            this.department = department;
            main_tag.lbl_author.Text = " ";
            main_tag.lbl_description.Text = " ";
            main_tag.lbl_bookname.Text = " ";
           
            if(department==null)
            {
                lbl_dep_name.Text = "All Employees";
            }
            else
            {
                lbl_dep_name.Text = department.Name;
            }

        }


        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            this.pnl_employee_list.VerticalScroll.Value = 0;
            Employee.Show_All_Employees(department);

            main_employee_list.Draw_All_Employees();
            pnl_employee_list.BringToFront();

            pnl_emp_st.Hide();
            lb_emp_search.Hide();



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

        private void pnl_book_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_search_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_search_types_Click(object sender, EventArgs e)
        {

        }
        public void Create_Warning_Form(string message, Color color)
        {
            if (Warning_form == null)
            {
                Warning_form = new Warning();
            }
            try
            {
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
            catch (ObjectDisposedException)
            {
                Warning_form = new Warning();
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
        }
    }
}
