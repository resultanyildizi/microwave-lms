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
        private Shelf shelf;

        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private string book_name;
        private int book_id;
        private string description;
        private string author;
        private int shelf_id;
        private string category;
        
        public Book_Info_For_Shelf(Shelf shelf)
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_shelf_list = main_page.Main_shelf_list;
            this.shelf = shelf;
            //Random random = new Random();
            //int pic_num = random.Next(0,60);
            
            //if(pic_num <= 10)
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b1;
            //else if(pic_num <= 20)
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b2;
            //else if(pic_num <= 30)
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b3;
            //else if(pic_num <= 40)
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b4;
            //else if(pic_num <= 50)
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b5;
            //else
            //    this.pictureBox1.Image = global::Microwave_v1._0.Properties.Resources.b6;

        }

        public void Initialize_Book_Info(int book_id, string name)
        {
            this.book_id = book_id;
            this.book_name = name;
        }

        public void Draw_Book_Obj(ref int x)
        {
            shelf.Shelf_ınfo.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, shelf.Shelf_ınfo.Pnl_shelf.Location.Y - this.Height);
            x += 20;
        }
    }
}
