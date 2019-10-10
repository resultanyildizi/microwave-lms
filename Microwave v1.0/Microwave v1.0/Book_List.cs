using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Microwave_v1._0
{
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

        int point_y = 5;


        book_node root;
        public Book_List()
        {
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
            point_y = 5;
            book_node iterator = root;
            while(iterator != null)
            {
                iterator.book.Info.Draw_Book_Obj(ref point_y);
                iterator = iterator.next;
            }
        }

        public void Click_Book_Info_Objects()
        {
            book_node iterator = root;
            while(iterator != null)
            {
                iterator.book.Info.Chose_BookObject();
                iterator = iterator.next;
            }
        }

        public void Make_Infos_Chosen_False()
        {
            book_node iterator = root;
            while (iterator != null)
            {
                iterator.book.Info.chosen = false;
                iterator = iterator.next;
            }
        }

        void Add_To_DataBase()
        {

        }
    }
}
