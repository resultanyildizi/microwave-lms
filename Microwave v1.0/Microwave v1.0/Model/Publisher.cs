using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Forms;
using System.Data;

namespace Microwave_v1._0.Classes
{
    public class Publisher
    {
        public static int pub_point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        public static int pub_point_x = 35;
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int publisher_id;
        private string pub_name;
        private string pub_date_of_est;
        private string pub_cover_path_file;
        private string pub_description;
        private Publisher_Info pub_info;
        public Publisher(int publisher_id, string pub_name, string pub_date_of_est, string pub_pic_path_file)
        {

            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.Publisher_id = publisher_id;
            this.pub_name = pub_name;
            this.pub_date_of_est = pub_date_of_est;
            this.Pub_cover_path_file = pub_pic_path_file;

        }

        public Publisher_Info Pub_info { get => pub_info; set => pub_info = value; }
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public string Pub_cover_path_file { get => pub_cover_path_file; set => pub_cover_path_file = value; }
        public string Pub_name { get => pub_name; set => pub_name = value; }
        public string Pub_date_of_est { get => pub_date_of_est; set => pub_date_of_est = value; }
        public string Pub_description { get => pub_description; set => pub_description = value; }

        public void Add()
        {
            string title;
            string values;

            if (main_page.Main_pub_list.Is_Pub_List_Empty())
            {
                int pub_starter_id = 0;
                title = "INSERT INTO Publishers(PUBLISHER_ID,NAME,DATE_OF_EST,PICTURE_PATH) ";

                values = string.Format("VALUES ('{0}','{1}','{2}','{3}')", pub_starter_id, pub_name, pub_date_of_est, pub_cover_path_file);
            }
            else
            {
                title = "INSERT INTO Publishers(NAME,DATE_OF_EST,PICTURE_PATH) ";
                values = string.Format("VALUES ('{0}','{1}','{2}')", pub_name, pub_date_of_est, pub_cover_path_file);

            }
            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            pub_info = new Publisher_Info();
            Take_Pub_Id_From_Database();

            pub_info.Initialize_Publisher_Info(publisher_id, pub_name, pub_date_of_est, pub_cover_path_file);
            main_page.Main_pub_list.Add_Publisher_to_List(this);
            main_page.Pnl_pub_list.VerticalScroll.Value = 0;

            Pub_info.Draw_Publisher_Obj(ref Publisher.pub_point_x, ref Publisher.pub_point_y);

            main_page.Main_pub_list.Deselect_All_Publisher_Infos();
            Pub_info.Select_Publisher_Info();

        }

        public void Edit()
        {
            string title = "UPDATE Publishers";
            string query = title + string.Format(" SET ,NAME = '{0}',DATE_OF_EST = '{1}',PICTURE_PATH = '{2}'" +
            "Where PUBLISHER_ID = '{3}'", pub_name, pub_date_of_est, pub_cover_path_file, publisher_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }


            Pub_info.Initialize_Publisher_Info(publisher_id, pub_name, pub_date_of_est, pub_cover_path_file);
            Pub_info.Select_Publisher_Info();
        }

        public void Delete()
        {
            string title = "DELETE FROM Publishers ";
            string query = title + string.Format("Where PUBLISHER_ID = '{0}'", publisher_id);

            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            if (result <= 0)
                MessageBox.Show("Delete is not valid");
            return;
        }

        static public void Show_All_Publishers()
        {
            string query = "SELECT * FROM Publishers";
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            main_page = (Microwave)Application.OpenForms["Microwave"];

            main_page.Main_pub_list.Fill_Pub_List(dt);
            main_page.Main_pub_list.Show_All_Publishers();

        }

        public void Set_Publisher()
        {
            pub_info = new Publisher_Info();
            pub_info.Initialize_Publisher_Info(publisher_id, pub_name, pub_date_of_est, pub_cover_path_file);

        }

        static public DataTable Search_Publisher_By_ID() { return null; }
        static public DataTable Search_Publisher_By_Name() { return null; }

        private void Take_Pub_Id_From_Database()
        {
            string title = "SELECT Publishers.PUBLISHER_ID FROM Publishers ";
            string query = title + string.Format("Where NAME = '{0}'", Pub_name); ;

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int id = int.Parse(dt.Rows[0][0].ToString());
            this.publisher_id = id;

            this.Pub_info.Publisher_id = id;

        }

        /*public void Cover_Pic_to_Image_List()
        {
            main_page.Pub_cover_image_list.Images.Add(this.Publisher_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.Pub_cover_path_file));
        }*/
    }

}