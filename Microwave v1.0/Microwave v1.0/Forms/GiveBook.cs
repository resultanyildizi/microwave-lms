using Microwave_v1._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    public partial class GiveBook : Form
    {
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        public GiveBook()
        {
            InitializeComponent();

            string query = "Select * From Books";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            Book_List book_list = new Book_List();

            SizeF scale = new Size();
            scale.Width = (float)0.80;
            scale.Height = (float)0.80;

            book_list.Fill_Book_List(dt, INFO_COLOR_MODE.NORMAL, false);
            book_list.Draw_All_Books(scale, this);
            
        }
    }
}
