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
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        public static int point_x = 22; // Book infoları ekrana çizdirirken kullanılan offset
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int shelf_id;
        private string shelf_name;
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

        public void Add_Form()
        {
            string title;
            string values;
            title = "INSERT INTO Shelf (SHELF_ID,SHELF_NAME) ";
            values = string.Format("VALUES ('{0}','{1}')",
                                    shelf_id, shelf_name);

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);
        }
        static public void Show_All_Shelf(Microwave main_page)
        {
            string query = "Select * From Shelf ";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page.Main_shelf_list.Fill_Shelf_List(dt);
            main_page.Main_shelf_list.Draw_All_Shelf();

        }

        public void Set_Shelf()
        {
            shelf_ınfo = new Shelf_Info();
            shelf_ınfo.Initialize_Shelf_Info(shelf_id,shelf_name);
        }

    }
}
