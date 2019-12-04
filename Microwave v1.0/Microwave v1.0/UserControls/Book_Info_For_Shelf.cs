using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;

namespace Microwave_v1._0.UserControls
{
    public partial class Book_Info_For_Shelf : UserControl
    {
        private Microwave main_page;
        private Shelf_List main_shelf_list;

        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private string book_name;
        private int book_id;
        private string description;
        private string author;
        private string pic_path_file;
        private string shelf;
        private string category;
        
        public Book_Info_For_Shelf()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_shelf_list = main_page.Main_shelf_list;
        }

        public void Initialize_Book_Info(int book_id, string name, string author, string publisher, string category, string shelf, string date, int count, string description)
        {
            this.book_id = book_id;
            this.description = description;
            this.author = author;
            this.book_name = name;
            this.shelf = shelf;
            this.category = category;
            this.btn_book_name.Text = name;
        }
    }
}
