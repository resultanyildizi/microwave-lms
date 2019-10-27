using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace Microwave_v1._0
{
    /* NOTE:
     * Book List class is a linked list data structure which keeps all the books in 
     * the database and information about them. 
     * When the application started to running, all the books are transferred from 
     * the database to the main book list in the main form. When a book is editted, 
     * deleted and added, first, it effects the book list then the database.
     */

    class book_node
    {
        public book_node next;
        public Book book;

        
        public book_node(Book b)
        {
            this.book = b;
            this.next = null;
        }
    }

    public class Book_List
    {

        private static Microwave main_page;
        private int point_y = Book.point_y;
        book_node root;


        public Book_List()
        {
           
            root = null;
        }

        public static void Read_Database()
        {
            main_page = (Microwave)Application.OpenForms["Microwave"];
            SQLiteConnection connection = main_page.Connection;
            connection.Open();
            string query = "SELECT * FROM Books ";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int book_id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string author = reader.GetString(2);
                string publisher = reader.GetString(3);
                string date = reader.GetString(4);
                int count = reader.GetInt32(5);
                string description = reader.GetString(6);
                string cover_path = reader.GetString(7);

                Book book = new Book(book_id, name, author, publisher, date, description, count, cover_path);
                main_page.Main_list.Add_Book_to_List(book);
            }
            connection.Close();
        }

        public void Add_Book_to_List(Book book)
        {
            if (root == null)
            {
                root = new book_node(book);
                return;
            }

            book_node iterator = root;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new book_node(book);
        }

        public void Show_All_Books()
        {
            book_node iterator = root;
            while(iterator != null)
            {
                iterator.book.Info.Draw_Book_Obj(ref Book.point_y);
                iterator = iterator.next;
            }
        }

        public void Deselect_All_Book_Infos()
        {
            book_node iterator = root;
            while (iterator != null)
            {
                iterator.book.Info.Deselect_Book_Info();
                iterator = iterator.next;
            }
        }

        public void Delete_Book_from_List(int book_id)
        {

            book_node iterator = root;
            if (root.book.Book_id == book_id)
            {
                root = root.next; 
                return;
            }

            if (root == null)
            {
                return;
            }

            while (iterator.next.book.Book_id != book_id)
            {
                iterator = iterator.next;
                if (iterator.next == null)
                {
                    MessageBox.Show("CANT FOUND");
                    return;
                }
            }

            iterator.next.book.Delete_Book_from_Database();
            Picture_Events.Delete_The_Picture(iterator.next.book.Cover_path_file);

            iterator.next.book = null;
            iterator.next = iterator.next.next;
            return;
        }
        public void Fill_Image_List_for_Book_Covers()
        {
            book_node iterator = root;
            while (iterator != null)
            {
                iterator.book.Add_Picture_to_ImageList();
                iterator = iterator.next;
            }
        }
        public bool Is_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }
       

    }
}
