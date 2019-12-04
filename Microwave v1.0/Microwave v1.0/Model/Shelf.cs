using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using System.Data;
using System.Drawing;
using Microwave_v1._0.Model;
using Microwave_v1._0.Forms;
using Microwave_v1._0.UserControls;


namespace Microwave_v1._0.Model
{
    public class Shelf
    {
        public static int point_y = 5; 
        public static int point_x = 22; 
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int shelf_id;
        private string shelf_name;
        private Book_List book_list;
        private Shelf_Info shelf_ınfo;


        public int Shelf_id { get => shelf_id; set => shelf_id = value; }
        public string Shelf_name { get => shelf_name; set => shelf_name = value; }
        public Shelf_Info Shelf_ınfo { get => shelf_ınfo; set => shelf_ınfo = value; }

        public Shelf()
        {

        }

        public Shelf(int shelf_id, string shelf_name)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.shelf_id = shelf_id;
            this.shelf_name = shelf_name;
        }

     
        static public void Show_All_Shelf(Microwave main_page)
        {
            string query = "Select * From Shelves ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);


            main_page.Main_shelf_list.Fill_Shelf_List(dt);
            main_page.Main_shelf_list.Draw_All_Shelf();
        }

        public void Set_Shelf()
        {
            shelf_ınfo = new Shelf_Info();
            shelf_ınfo.Initialize_Shelf_Info(shelf_id,shelf_name);
            Fill_Shelf();
        }

        public void Fill_Shelf()
        {
            string query = "Select * From Books Where Books.SHELF_ID = " + shelf_id;
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            book_list = new Book_List();
            book_list.Fill_Book_List(dt, this);
            book_list.Draw_All_Books_For_Shelf();
        }

        public static string Generate_Shelf_Name() {
            return "";
        }
    }
}
