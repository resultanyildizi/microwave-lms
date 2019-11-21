using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microwave_v1._0.Classes;


namespace Microwave_v1._0.UserControls
{
    public partial class Department_Info : UserControl
    {
        private Microwave main_page;
        private Department_List department_list;

        private string name;
        private string pic_path_file;
        private int department_ıd;
        public int Department_ıd { get => department_ıd; set => department_ıd = value; }

        public Department_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            department_list = main_page.Main_department_list;
        }
        public void Initialize_Department_Info(string name,string pic_path_file)
        {
            this.name = name;
            this.pic_path_file = pic_path_file;
        }
        public void Draw_Department_Obj(int y = 5)
        {
            main_page.Pnl_department_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 90;
        }

        private void Department_Info_Load(object sender, EventArgs e)
        {

        }

        /*
private void btn_edit_dep_Click(object sender, EventArgs e)
{
   {
       string message = "Do you want to edit this book?";
       main_page.Create_Warning_Form(message, Color.DarkBlue);
       if (main_page.Warning_form.Result)
           Edit();

       main_page.Warning_form.Refresh_Form();
   }
}
*/
    }
}
