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
        Book_List book_list = null;
        Book_List search_list = null;

        public GiveBook()
        {
            InitializeComponent();
            book_list = new Book_List();
            search_list = new Book_List();

            string query = "Select * From Books";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            

            SizeF scale = new Size();
            scale.Width = (float)0.80;
            scale.Height = (float)0.80;

            book_list.Fill_Book_List(dt,book_list, search_list, null, pnl_book_list, INFO_COLOR_MODE.NORMAL, false);
            book_list.Draw_All_Books();
            
        }

        private void btn_give_book_Click(object sender, EventArgs e)
        {
            Book current = book_list.Find_Book_By_Chosen();
            current.Count--;
            current.Info.Initialize_Book_Info(current.Book_id, current.Name, current.Author_name,
                current.Publisher_name, current.Category_name, current.Shelf_name, current.Date, 
                current.Count, current.Description, current.Cover_path_file, INFO_COLOR_MODE.NORMAL);
        }
    }
}
