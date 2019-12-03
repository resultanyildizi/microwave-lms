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

        private Employee_List emp_search_list = null;
        private bool emp_searched_already = false;

        public Employee_List Main_employee_list { get => main_employee_list; set => main_employee_list = value; }
        public AddEmployee AddEmployee { get => addEmployee; set => addEmployee = value; }
        public Book_Tag Main_tag { get => main_tag; set => main_tag = value; }
        public Warning Warning_form1 { get => Warning_form; set => Warning_form = value; }
        public Employee_List Emp_search_list { get => emp_search_list; set => emp_search_list = value; }
        public bool Emp_searched_already { get => emp_searched_already; set => emp_searched_already = value; }

        private bool show_pnl_emp_st = false;
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

            emp_search_list = new Employee_List();
            pnl_emp_st.Hide();
            lb_emp_search.Hide();

        }


        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            this.pnl_employee_list.VerticalScroll.Value = 0;
            Employee.Show_All_Employees(department);

            main_employee_list.Draw_All_Employees();

            rb_emp_name.Checked = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            pnl_employee_list.VerticalScroll.Value = 0;
            emp_search_list.Delete_All_List();
            main_employee_list.Draw_All_Employees();
            emp_searched_already = false;
            string message = "Do you want to add an employee?";
            Color color = Color.SpringGreen;
            Create_Warning_Form(message, color);
            if (Warning_form.Result == true)
            {
                if (addEmployee == null)
                {
                    addEmployee = new AddEmployee(department);

                }
                try
                {
                    addEmployee.Show();
                }
                catch (Exception)
                {
                    addEmployee = new AddEmployee(department);
                    addEmployee.Show();
                }
            }
            Warning_form.Refresh_Form();
        }

        private void btn_show_search_types_Click(object sender, EventArgs e)
        {
            if(show_pnl_emp_st == false)
            {
                this.pnl_emp_st.Show();
                show_pnl_emp_st = true;
            }
            else
            {
                this.pnl_emp_st.Hide();
                show_pnl_emp_st = false;
            }
            lb_emp_search.Hide();
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

        private void rb_emp_name_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_emp_st.Hide();
            this.tb_search_emp.Text = "";
            this.tb_search_emp.Focus();
            this.show_pnl_emp_st = false;
        }

        private void rb_emp_id_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_emp_st.Hide();
            this.tb_search_emp.Text = "";
            this.tb_search_emp.Focus();
            this.show_pnl_emp_st = false;
        }

        private void rb_gender_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_emp_st.Hide();
            this.tb_search_emp.Text = "";
            this.tb_search_emp.Focus();
            this.show_pnl_emp_st = false;
        }

        private void rb_email_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_emp_st.Hide();
            this.tb_search_emp.Text = "";
            this.tb_search_emp.Focus();
            this.show_pnl_emp_st = false;
        }

        private void rb_department_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_emp_st.Hide();
            this.tb_search_emp.Text = "";
            this.tb_search_emp.Focus();
            this.show_pnl_emp_st = false;
        }

        private void tb_search_emp_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_emp.Text.Trim();
            emp_searched_already = false;
            if (text == "")
            {
                lb_emp_search.Hide();
                lb_emp_search.Items.Clear();

                emp_search_list.Delete_All_List();
                main_employee_list.Draw_All_Employees();
                return;
            }
            if(text == "Search an Employee")
            {
                emp_search_list.Delete_All_List();
                main_employee_list.Draw_All_Employees();
                return;
            }
            else
            {
                if (rb_emp_name.Checked)
                {
                    this.pnl_employee_list.VerticalScroll.Value = 0;
                    string query = string.Format("Select Employee.NAME from Employee Where Employee.NAME Like '{0}%'", text);
                    Fill_Employee_Search_List_Box(query);
                    if (lb_emp_search.Items.Count > 0)
                        lb_emp_search.Show();
                    return;
                }
                if (rb_emp_id.Checked)
                {
                    this.pnl_employee_list.VerticalScroll.Value = 0;
                    string query = string.Format("Select Employee.EMPLOYEE_ID from Employee Where Employee.EMPLOYEE_ID Like '{0}%'", text);
                    Fill_Employee_Search_List_Box(query);
                    if (lb_emp_search.Items.Count > 0)
                        lb_emp_search.Show();
                    return;
                }
                if (rb_gender.Checked)
                {
                    this.pnl_employee_list.VerticalScroll.Value = 0;
                    string query = string.Format("Select Employee.GENDER from Employee Where Employee.GENDER Like '{0}%'", text);
                    Fill_Employee_Search_List_Box(query);
                    if (lb_emp_search.Items.Count > 0)
                        lb_emp_search.Show();
                    return;
                }
                if (rb_email.Checked)
                {
                    this.pnl_employee_list.VerticalScroll.Value = 0;
                    string query = string.Format("Select Employee.EMAIL from Employee Where Employee.EMAIL Like '{0}%'", text);
                    Fill_Employee_Search_List_Box(query);
                    if (lb_emp_search.Items.Count > 0)
                        lb_emp_search.Show();
                    return;
                }
                if (rb_department.Checked)
                { 
                    
                    this.pnl_employee_list.VerticalScroll.Value = 0;
                    string query = string.Format("Select Employee.DEPARTMENT_ID from Employee Where Employee.DEPARTMENT_ID Like '{0}%'", text);
                    Fill_Employee_Search_List_Box(query);
                    if (lb_emp_search.Items.Count > 0)
                        lb_emp_search.Show();
                    return;
                }
            }
        }

        private void tb_search_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_emp.Text;

            if (e.KeyChar == (char)Keys.Enter && !emp_searched_already)
            {
                lb_emp_search.Hide();
                if (tb_search_emp.Text == "")
                {
                    return;
                }
                main_employee_list.Hide_All_Employee_Objects();
                emp_search_list.Delete_All_List();
                this.pnl_employee_list.VerticalScroll.Value = 0;

                if (rb_emp_name.Checked)
                {
                    emp_search_list.Fill_Employee_List(Employee.Search_Employee_By_Name(text), main_employee_list, emp_search_list, main_tag, pnl_employee_list);
                    emp_search_list.Draw_All_Employees();
                    emp_searched_already = true;
                    return;
                }
                if (rb_emp_id.Checked)
                {
                    emp_search_list.Fill_Employee_List(Employee.Search_Employee_By_ID(text), main_employee_list, emp_search_list, main_tag, pnl_employee_list);
                    emp_search_list.Draw_All_Employees();
                    emp_searched_already = true;
                    return;
                }
                if (rb_gender.Checked)
                {
                    emp_search_list.Fill_Employee_List(Employee.Search_Employee_By_Gender(text), main_employee_list, emp_search_list, main_tag, pnl_employee_list);
                    emp_search_list.Draw_All_Employees();
                    emp_searched_already = true;
                    return;
                }
                if (rb_email.Checked)
                {
                    emp_search_list.Fill_Employee_List(Employee.Search_Employee_By_Email(text), main_employee_list, emp_search_list, main_tag, pnl_employee_list);
                    emp_search_list.Draw_All_Employees();
                    emp_searched_already = true;
                    return;
                }
                if (rb_department.Checked)
                {
                    emp_search_list.Fill_Employee_List(Employee.Search_Employee_By_Department(text), main_employee_list, emp_search_list, main_tag, pnl_employee_list);
                    emp_search_list.Draw_All_Employees();
                    emp_searched_already = true;
                    return;
                }
            }
        }

        private void tb_search_emp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lb_emp_search.Items.Count != 0)
                {
                    lb_emp_search.Select();
                    lb_emp_search.SelectedIndex = 0;
                }
            }
        }

        private void lb_emp_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_emp.Text = tb_search_emp.Text.Remove(tb_search_emp.Text.Length - 1, 1);
                else
                    tb_search_emp.Text += e.KeyChar;
                tb_search_emp.Focus();
                tb_search_emp.Select(tb_search_emp.Text.Length, 0);
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                tb_search_emp.Focus();
                tb_search_emp.Text = lb_emp_search.SelectedItem.ToString();
                tb_search_emp.Select(tb_search_emp.Text.Length, 0);
            }
        }
        private void Fill_Employee_Search_List_Box(string query)
        {
            lb_emp_search.Items.Clear();  

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
            {
                return;
            }
            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                if (lb_emp_search.Items.Contains(item))
                    continue;
                lb_emp_search.Items.Add(item);
                
            }
        }

        private void tb_search_emp_Leave(object sender, EventArgs e)
        {
            if (tb_search_emp.Text == "")
            {
            tb_search_emp.Text = "Search an Employee";
            tb_search_emp.ForeColor = Color.Gray;
            }
        }

        private void tb_search_emp_Enter(object sender, EventArgs e)
        {
            if (tb_search_emp.Text == "Search an Employee")
            {
                tb_search_emp.Text = "";
            }
            if (lb_emp_search.Items.Count > 0)
                lb_emp_search.Show();

            tb_search_emp.ForeColor = Color.LightGray;
        }

        private void lb_emp_search_Leave(object sender, EventArgs e)
        {
            lb_emp_search.Hide();
        }

        private void lb_emp_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_emp.Focus();
            if (lb_emp_search.SelectedItem != null)
                tb_search_emp.Text = lb_emp_search.SelectedItem.ToString();
            tb_search_emp.Select(tb_search_emp.Text.Length, 0); 
        }
    }
}
