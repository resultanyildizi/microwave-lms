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
        public int point_book_x = 65;
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int shelf_id;
        private string shelf_name;
        private Book_List book_list;
        private Shelf_Info shelf_ınfo;


        public int Shelf_id { get => shelf_id; set => shelf_id = value; }
        public string Shelf_name { get => shelf_name; set => shelf_name = value; }
        public Shelf_Info Shelf_ınfo { get => shelf_ınfo; set => shelf_ınfo = value; }
        public Book_List Book_list { get => book_list; set => book_list = value; }

        public Shelf()
        {

        }

        public Shelf(int shelf_id, string shelf_name)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.shelf_id = shelf_id;
            this.shelf_name = shelf_name;
        }

        public void Add()
        {
            string title;
            string values;

            title = "INSERT INTO Shelves(NAME) ";
            values = string.Format("VALUES ('{0}')", shelf_name);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            shelf_ınfo = new Shelf_Info();
            Take_Pub_Id_From_Database();

            shelf_ınfo.Initialize_Shelf_Info(shelf_id, shelf_name);
            main_page.Main_shelf_list.Add_Shelf_to_List(this);
            main_page.Pnl_shelf_list.VerticalScroll.Value = 0;

            shelf_ınfo.Draw_Shelf_Obj(ref Shelf.point_y);

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
            shelf_ınfo.Initialize_Shelf_Info(shelf_id, shelf_name);
            Fill_Shelf();
        }

        public void Fill_Shelf()
        {
            string query = "Select * From Books Where Books.SHELF_ID = " + shelf_id;
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            book_list = new Book_List();
            book_list.Fill_Book_List(dt, this);
            book_list.Draw_All_Books_For_Shelf(ref point_book_x);
        }

        public static string Generate_Shelf_Name()
        {
            string query = "SELECT Shelves.NAME From Shelves ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            if (dt.Rows.Count <= 0)
            {
                return "A01";
            }
            string name = dt.Rows[dt.Rows.Count - 1][0].ToString();

            int number = int.Parse(name.Substring(1, 2));
            char letter = Convert.ToChar(name.Substring(0, 1));

            if (number < 3)
            {
                number++;

            }
            else
            {
                letter++;
                number = 1;
            }
            return letter.ToString() + "0" + number;
        }

        private void Take_Pub_Id_From_Database()
        {
            string title = "SELECT Shelves.SHELF_ID FROM Shelves ";
            string query = title + string.Format("Where NAME = '{0}'", shelf_name);

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.shelf_id = id;

            this.shelf_ınfo.Shelf_id = id;

        }
    }
}
