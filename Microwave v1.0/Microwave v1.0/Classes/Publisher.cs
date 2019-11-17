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

namespace Microwave_v1._0.Classes
{
    public class Publisher
    {
        public static int pub_point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int publisher_id;
        private string pub_name;
        private string pub_date_of_est;
        private string pub_cover_path_file;
        private string pub_description;
        private Publisher_Info pub_info;
        public Publisher(int publisher_id, string pub_name, string pub_date_of_est, string pub_description, string pub_pic_path_file)
        {

            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.Publisher_id = publisher_id;
            this.pub_name = pub_name;
            this.pub_date_of_est = pub_date_of_est;
            this.pub_description = pub_description;
            this.Pub_cover_path_file = pub_pic_path_file;

        }

        public Publisher_Info Pub_info { get => pub_info; set => pub_info = value; }
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public string Pub_cover_path_file { get => pub_cover_path_file; set => pub_cover_path_file = value; }
        public string Pub_name { get => pub_name; set => pub_name = value; }
        public string Pub_date_of_est { get => pub_date_of_est; set => pub_date_of_est = value; }
        public string Pub_description { get => pub_description; set => pub_description = value; }

        public void Add_Publisher()
        {
            pub_info = new Publisher_Info();

            pub_info.Initialize_Publisher_Info(publisher_id, pub_name, pub_description, pub_date_of_est, pub_cover_path_file);
            Cover_Pic_to_Image_List();
            main_page.Main_pub_list.Add_Publisher_to_List(this);

            main_page.Pnl_pub_list.VerticalScroll.Value = 0;

            Pub_info.Draw_Publisher_Obj(ref Publisher.pub_point_y);

            main_page.Main_pub_list.Deselect_All_Publisher_Infos();
            Pub_info.Select_Publisher_Info();

        }

        public void Edit_Publisher()
        {

            Pub_info.Initialize_Publisher_Info(publisher_id, pub_name,pub_description,pub_date_of_est,pub_cover_path_file);
            Pub_info.Select_Publisher_Info();
        }

        public void Cover_Pic_to_Image_List()
        {
            main_page.Pub_cover_image_list.Images.Add(this.Publisher_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.Pub_cover_path_file));
        }
    }

}
