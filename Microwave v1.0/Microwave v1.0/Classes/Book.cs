using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0
{   /* NOTE:
     * Book class includes all the information about books.
    */
    public class Book
    {
        // Global
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        Microwave main_page;
        // ID's
        private int book_id;
        private int author_id;
        private int publisher_id;
        private int category_id;
        private int shelf_id;
        private int popularity_id;
        private int librarian_id;
        // Variables
        private int popularity_score;
        private int count;
        private string name;
        private string date;           
        private string description; 
        private string cover_path_file; 
        private Book_Info info;
        // From database
        private string author_name;
        private string publisher_name;
        private string category_name;
        private string shelf_name;
        private string popularity_name;

        private SQLiteConnection con = null;
        // Getters and Setters 
        public string Date { get => date; set => date = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public Book_Info Info { get => info; set => info = value; }
        public int Author_id { get => author_id; set => author_id = value; }
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public int Category_id { get => category_id; set => category_id = value; }
        public int Shelf_id { get => shelf_id; set => shelf_id = value; }
        public int Popularity_id { get => popularity_id; set => popularity_id = value; }
        public int Popularity_score { get => popularity_score; set => popularity_score = value; }
        public string Name { get => name; set => name = value; }

        public Book(int book_id, int author_id, int publisher_id, int category_id, int librarian_id, int shelf_id, string name, int count, string date, string description, string pic_path_file, int popularity_id, int popularity_score)
        {
            con = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.book_id = book_id;
            this.author_id = author_id;
            this.publisher_id = publisher_id;
            this.category_id = category_id;
            this.librarian_id = librarian_id;
            this.shelf_id = shelf_id;
            this.name = name;
            this.date = date;
            this.count = count;
            this.description = description;
            this.cover_path_file = pic_path_file;
            this.popularity_score = popularity_score;
            this.popularity_id = popularity_id;

            // Take infos from database by matching with ID's
            Join_Tables();

            info = new Book_Info();
            info.Initialize_Book_Info(book_id, name, author_name, publisher_name, date, count, description, cover_path_file);

        }

        public void Join_Tables()
        {
            string que_author     = "Select Authors.NAME from Authors where Authors.AUTHOR_ID = " + author_id.ToString();
            string que_publisher  = "Select Publishers.NAME from Publishers where Publishers.PUBLISHER_ID = " + publisher_id.ToString();
            string que_category   = "Select Categories.NAME from Categories where Categories.CATEGORY_ID = " + category_id.ToString();
            string que_shelf      = "Select Shelves.NAME from Shelves where Shelves.SHELF_ID = " + shelf_id.ToString();
            string que_popularity = "Select Popularity.NAME from Popularity where Popularity.POPULARITY_ID = " + popularity_id.ToString();

            SQLiteDataReader reader = null;

            // take author name
            reader = DataBaseEvents.ExecuteQuery(con, que_author);
            author_name = reader.GetString(0);
            con.Close();
            // take publisher name
            reader = DataBaseEvents.ExecuteQuery(con, que_publisher);
            publisher_name = reader.GetString(0);
            con.Close();
            // take category name
            reader = DataBaseEvents.ExecuteQuery(con, que_category);
            category_name = reader.GetString(0);
            con.Close();
            // take shelf name
            reader = DataBaseEvents.ExecuteQuery(con, que_shelf);
            shelf_name = reader.GetString(0);
            con.Close();
            // take popularity name
            reader = DataBaseEvents.ExecuteQuery(con, que_popularity);
            popularity_name = reader.GetString(0);
            con.Close();

        }
        public void Add_Book_To_Database()
        {
            string title;
            string values;

            if(main_page.Main_list.Is_List_Empty())
            {
                int starter_id = 05101900;
                title = "INSERT INTO Books (BOOK_ID,AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}','{12}')",starter_id, author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, date,description, count, cover_path_file, popularity_score);
            }
            else
            {
                title = "INSERT INTO Books (AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}')", author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, date, description, count, cover_path_file, popularity_score);
            }

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(con, query);
            Take_Id();
        }

        public void Take_Id()
        {
            // To take the id of new book.
            string title = "SELECT * FROM Books ";
            string query = title + string.Format("Where NAME = '{0}' AND AUTHOR = '{1}' AND PUBLISHER = '{2}' AND COVER_PATH = '{3}';", name, author_name, publisher_name, cover_path_file);

            SQLiteDataReader reader = DataBaseEvents.ExecuteQuery(con, query);

            int id = reader.GetInt32(0);
            this.book_id = id;
            this.Info.Book_id = id; // IMPORTANT
            con.Close();
        }

        public void Delete_Book_from_Database()
        {
            string title = "DELETE FROM Books ";
            string query = title + string.Format("Where BOOK_ID = '{0}';", book_id);

            DataBaseEvents.ExecuteNonQuery(con, query);
        }

        public void Add_Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.book_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.cover_path_file));
        }

        
    }
}
