using Microwave_v1._0.UserControls;
using System.Data;
using System.Windows.Forms;

namespace Microwave_v1._0.Classes
{
    public class Author
    {
        public static int author_point_y = 5; // Author infoları ekrana çizdirirken kullanılan offset.
        public static int author_point_x = 5;
        static Microwave main_page = null;
        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private int author_id;
        private int popularity_id;
        private int popularity_score;
        private string author_name;
        private string author_country;
        private string author_gender;
        private string author_birthday;
        private string author_biography;
        private string author_cover_path_file;
        private string author_popularity_name;
        private Author_Info author_info;
        
        
        public Author(int author_id, int popularity_id, string author_name, string author_country, string author_gender, string author_birthday, string author_biography, string author_cover_path_file)
        {

            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.author_id = author_id;
            this.popularity_id = popularity_id;
            this.author_name = author_name;
            this.author_country = author_country;
            this.author_gender = author_gender;
            this.author_birthday = author_birthday;
            this.author_biography = author_biography;
            this.author_cover_path_file = author_cover_path_file;
            
            

        }

        public Author()
        {

        }

        public int Author_id { get => author_id; set => author_id = value; }
        public string Author_name { get => author_name; set => author_name = value; }
        public string Author_country { get => author_country; set => author_country = value; }
        public string Author_gender { get => author_gender; set => author_gender = value; }
        public string Author_birthday { get => author_birthday; set => author_birthday = value; }
        public string Author_biography { get => author_biography; set => author_biography = value; }
        public string Author_cover_path_file { get => author_cover_path_file; set => author_cover_path_file = value; }
        public Author_Info Author_info { get => author_info; set => author_info = value; }
        public string Cover_path_file { get; internal set; }
        public int Popularity_score { get => popularity_score; set => popularity_score = value; }
        public int Popularity_id { get => popularity_id; set => popularity_id = value; }
        public string Author_popularity_name { get => author_popularity_name; set => author_popularity_name = value; }

        public void Add()
        {
            string title;
            string values;

            title = "INSERT INTO Authors ( POPULARITY_ID, NAME, COUNTRY, GENDER, BIRTHDAY, BIOGRAPHY, PICTURE_PATH, POPULARITY_SCORE) ";
            values = string.Format("VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}') ",
                     popularity_id, author_name, author_country, author_gender, author_birthday, author_biography,
                     author_cover_path_file, popularity_score);

            string query = title + values;
            DataBaseEvents.ExecuteNonQuery(query, datasource);
            author_info = new Author_Info();
            author_info.Initialize_Author_Info(author_name, author_cover_path_file);
            Take_ID_From_Database();
            Join_Tables();
            //Cover_Pic_to_Image_List();
            main_page.Main_author_list.Add_Author_to_List(this);
            main_page.Pnl_author_list.VerticalScroll.Value = 0;
            author_info.Draw_Author_Obj(ref Author.author_point_x, ref Author.author_point_y);
        }

        public void Edit()
        {
            Join_Tables();
            string query = string.Format("UPDATE AUTHORS SET AUTHOR_ID = '{0}', POPULARITY_ID = '{1}', NAME = '{2}', COUNTRY = '{3}' , GENDER ='{4}', BIRTHDAY ='{5}'," +
                " BIOGRAPHY = '{6}', PICTURE_PATH = '{7}'", author_id, popularity_id, author_name, author_country, author_gender, author_biography, author_cover_path_file);
            int result = DataBaseEvents.ExecuteNonQuery(query, datasource);
            
            if(result <= 0)
            {
                MessageBox.Show("Invalid update event");
                return;
            }

            author_info.Initialize_Author_Info(author_name, author_cover_path_file); 

        }

        private void Take_ID_From_Database()
        {
            string title = "SELECT AUTHORS.AUTHOR_ID FROM AUTHORS ";
            string query = title + string.Format(" WHERE Authors.NAME = '{0}' and Authors.COUNTRY = '{1}'", author_name, author_country);
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
            this.author_id = this.author_info.Author_id = int.Parse(dt.Rows[0][0].ToString());
            
        }

        private void Join_Tables()
        {
            string query = "SELECT Popularity.name FROM Authors JOIN POPULARITY ON AUTHORS.POPULARITY_ID = POPULARITY.POPULARITY_ID WHERE AUTHORS.AUTHOR_ID = " + author_id;
            DataTable db = DataBaseEvents.ExecuteQuery(query, datasource);
            author_popularity_name = db.Rows[0][0].ToString();
        }
        
        /*public void Cover_Pic_to_Image_List()
        {
            main_page.Author_cover_image_list.Images.Add(this.Author_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.Author_cover_path_file));
        }*/


    }
}
