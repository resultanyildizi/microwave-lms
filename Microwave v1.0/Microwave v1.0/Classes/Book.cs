using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
namespace Microwave_v1._0
{   /* NOTE:
     * Book class includes all the information about books.
    */
    public class Book
    {
        // Global
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset.
        Microwave main_page;
        // Variables
        private string name;
        private string author;
        private string publisher;
        private string date;           
        private string description; 
        private string cover_path_file; 
        private Book_Info info;
        private int book_id;
        private int count;
        private SQLiteConnection con = null;
        // Getters and Setters 
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Date { get => date; set => date = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public Book_Info Info { get => info; set => info = value; }

        public Book(int book_id, string name, string author, string publisher, string date, string description, int count, string pic_path_file)
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.book_id = book_id;
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.count = count;
            this.description = description;
            this.cover_path_file = pic_path_file;
            info = new Book_Info();
            info.Initialize_Book_Info(book_id, name, author, publisher, date, count, description, cover_path_file);
            con = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");

        }
        public void Add_Book_To_Database()
        {
            string title;

            string values;

            if(main_page.Main_list.Is_List_Empty())
            {
                title = "INSERT INTO Books (BOOK_ID,NAME,AUTHOR,PUBLISHER,DATE,COUNT,DESCRIPT,COVER_PATH) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}');",05101900, name, author, publisher, date, count, description, cover_path_file);
            }
            else
            {
                title = "INSERT INTO Books (NAME,AUTHOR,PUBLISHER,DATE,COUNT,DESCRIPT,COVER_PATH) ";
                values = string.Format("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", name, author, publisher, date, count, description, cover_path_file);
            }

            string query = title + values;
            con.Open();
            var cmd_insert = con.CreateCommand();
            
            cmd_insert.CommandText = query;
            cmd_insert.ExecuteNonQuery();
            
            con.Close();
            Take_Id();
        }

        public void Take_Id()
        {
            // To take the id of new book.
            string title = "SELECT * FROM Books ";
            string query = title + string.Format("Where NAME = '{0}' AND AUTHOR = '{1}' AND PUBLISHER = '{2}' AND COVER_PATH = '{3}';", name, author, publisher, cover_path_file);

            con.Open();
            var cmd_take_id = con.CreateCommand();
            cmd_take_id.CommandText = query;
            cmd_take_id.ExecuteNonQuery();

            int id = int.Parse(cmd_take_id.ExecuteScalar().ToString());
            this.book_id = id;
            this.Info.Book_id = id; // IMPORTANT
            con.Close();
        }

        public void Delete_Book_from_Database()
        {
            string title = "DELETE FROM Books ";
            string query = title + string.Format("Where BOOK_ID = '{0}';", book_id);

            con.Open();
            var cmd_delete = con.CreateCommand();
            cmd_delete.CommandText = query;
            cmd_delete.ExecuteNonQuery();
            con.Close();
        }

        public void Add_Cover_Pic_to_Image_List()
        {
            main_page.Cover_image_list.Images.Add(this.book_id.ToString(), Picture_Events.Get_Copy_Image_Bitmap(this.cover_path_file));
        }

        
    }
}
