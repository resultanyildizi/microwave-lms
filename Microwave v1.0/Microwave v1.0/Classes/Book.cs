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
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
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
            SQLiteConnection con = new SQLiteConnection(datasource);

            string que_author     = "Select Authors.NAME from Authors where Authors.AUTHOR_ID = " + author_id.ToString();
            string que_publisher  = "Select Publishers.NAME from Publishers where Publishers.PUBLISHER_ID = " + publisher_id.ToString();
            string que_category   = "Select Categories.NAME from Categories where Categories.CATEGORY_ID = " + category_id.ToString();
            string que_shelf      = "Select Shelves.NAME from Shelves where Shelves.SHELF_ID = " + shelf_id.ToString();
            string que_popularity = "Select Popularity.NAME from Popularity where Popularity.POPULARITY_ID = " + popularity_id.ToString();

            SQLiteCommand cmd = null;
            // take author name
            con.Open();
            cmd = new SQLiteCommand(que_author, con);
            author_name = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Connection.Close();
            // take publisher name
            con.Open();
            cmd = new SQLiteCommand(que_publisher, con);
            publisher_name = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Connection.Close();
            // take category name
            con.Open();
            cmd = new SQLiteCommand(que_category, con);
            category_name = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Connection.Close();
            // take shelf name
            con.Open();
            cmd = new SQLiteCommand(que_shelf, con);
            shelf_name = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Connection.Close();
            // take popularity name
            con.Open();
            cmd = new SQLiteCommand(que_popularity, con);
            popularity_name = cmd.ExecuteScalar().ToString();
            con.Close();
            cmd.Connection.Close();
        }
        public void Add_Book_To_Database()
        {
            string title;
            string values;

            if(main_page.Main_list.Is_List_Empty())
            {
                int starter_id = 05101900;
                title = "INSERT INTO Books (BOOK_ID,AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}','{12}')",
                                       starter_id, author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, 
                                       date,description, count, cover_path_file, popularity_score);
            }
            else
            {
                title = "INSERT INTO Books (AUTHOR_ID,PUBLISHER_ID, CATEGORY_ID, LIBRARIAN_ID, SHELF_ID, POPULARITY_ID, NAME, DATE, DESCRIPT, COUNT, COVER_PATH, POPULARITY_SCORE) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}', '{11}')", 
                                        author_id, publisher_id, category_id, librarian_id, shelf_id, popularity_id, name, date,
                                        description, count, cover_path_file, popularity_score);
            }

            string query = title + values;

            DataBaseEvents.ExecuteNonQuery(query, datasource);

            // Take book id which is given by database automatically
            Take_Id();
        }

        public void Take_Id()
        {
            // To take the id of new book.
            string title = "SELECT Books.BOOK_ID FROM Books ";
            string query = title + string.Format("Where NAME = '{0}' AND PUBLISHER_ID = '{1}';", name, publisher_id);

            int id = DataBaseEvents.ExecuteQuery_Int32(query, datasource);
            this.book_id = id;
            this.Info.Book_id = id; // IMPORTANT
        }

        public void Delete_Book_from_Database()
        {
            string title = "DELETE FROM Books ";
            string query = title + string.Format("Where BOOK_ID = '{0}';", book_id);

            DataBaseEvents.ExecuteNonQuery(query, datasource);
        }

        // Adds the cover picture of this book to the image list on the main form by giving its id as a key
        public void Add_Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.book_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.cover_path_file));
        }

        
    }
}
