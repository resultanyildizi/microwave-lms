using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
using Microwave_v1._0.Classes;
using System.Data;

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
        int point_y = Book.point_y;
        static int book_count = 0;
        book_node root;

        public Book_List()
        {
           
            root = null;
        }

        public void Fill_Book_List(DataTable dt, INFO_COLOR_MODE color_mode)
        {
            int rows_count = book_count = dt.Rows.Count;
            
            // IMPORTANT
            if(rows_count == 0)
                return;
            
            for(int i = 0; i < rows_count; i++)
            {
                int book_id = int.Parse(dt.Rows[i][0].ToString());
                int author_id = int.Parse(dt.Rows[i][1].ToString());
                int publisher_id = int.Parse(dt.Rows[i][2].ToString());
                int category_id = int.Parse(dt.Rows[i][3].ToString());
                int librarian_id = int.Parse(dt.Rows[i][4].ToString());
                int shelf_id = int.Parse(dt.Rows[i][5].ToString());
                int popularity_id = int.Parse(dt.Rows[i][6].ToString());
                string name = dt.Rows[i][7].ToString();
                string date = dt.Rows[i][8].ToString();
                string description = dt.Rows[i][9].ToString();
                int count = int.Parse(dt.Rows[i][10].ToString());
                string cover_path = dt.Rows[i][11].ToString();
                int popularity_score = int.Parse(dt.Rows[i][12].ToString());

                Book book = new Book(book_id, author_id, publisher_id, category_id, librarian_id, shelf_id, name, count, date, description, cover_path, popularity_id, popularity_score);
                book.Set_Book(color_mode);
                this.Add_Book_to_List(book);
            }

            Fill_Cover_Image_List();
        }
        public void Delete_All_List()
        {
            book_node iterator = root;
            book_node current;
            
            while(iterator != null)
            {
                current = iterator.next;
                iterator.book.Info.Dispose();
                iterator.book = null;
                iterator = current;
            }
            root = null;
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
            Book.point_y = 5;

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
        public void Hide_All_Book_Objects()
        {
            book_node iterator = root;
            while (iterator != null)
            {
                iterator.book.Info.Hide_Info();
                iterator = iterator.next;
            }
        }
        public void Delete_Book_from_List(int book_id, bool delete_picture)
        {

            book_node iterator = root;

            if (root == null)
            {
                return;
            }

            if (root.book.Book_id == book_id)
            {
                root.book.Delete();
                if(delete_picture == true)
                    Picture_Events.Delete_The_Picture(root.book.Cover_path_file);
                root.book = null;
                root = root.next;
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

            iterator.next.book.Delete();
            if(delete_picture == true)
                Picture_Events.Delete_The_Picture(iterator.next.book.Cover_path_file);
            iterator.next.book = null;
            iterator.next = iterator.next.next;
            return;
        }
        public Book Find_Book_By_ID(int book_id)
        {
            if (root == null)
                return null;

            book_node iterator = root;
            
            while(iterator.book.Book_id != book_id)
            {
                if (iterator.next == null)
                    return null;

                iterator = iterator.next;
            }

            return iterator.book;
        }
        public bool Is_List_Empty()
        {
            if (root == null)
                return true;
            else
                return false;
        }
        public void Fill_Cover_Image_List()
        {
            book_node iterator = root;
            while(iterator != null)
            {
                iterator.book.Cover_Pic_to_Image_List();
                iterator = iterator.next;
            }
        }
       
    }
}
