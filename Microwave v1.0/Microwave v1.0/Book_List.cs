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

        int point_y = Book.point_y;


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

        void Add_To_DataBase()
        {

        }
    }
}
