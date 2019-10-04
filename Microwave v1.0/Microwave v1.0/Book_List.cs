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
        public Books book;

        
        public book_node(Books book)
        {
            this.book = book;
            this.next = null;
        }
    }

    public class Book_List
    {

        int point_y = 5;


        book_node head;
        public Book_List()
        {
            head = null;
        }

        public void Add_Book_To_List(Books book)
        {
            if (head == null)
            {
                head = new book_node(book);
                return;
            }

            book_node iterator = head;
            while (iterator.next != null)
                iterator = iterator.next;

            iterator.next = new book_node(book);
        }

        public void Print_Book_List()
        {
            point_y = 5;
            book_node iterator = head;
            while(iterator != null)
            {
                iterator.book.Get_Book_Object().Draw_Book_Obj(ref point_y);
                iterator = iterator.next;
            }
        }

        public void Click_Book_Obj()
        {
            book_node iterator = head;
            while(iterator != null)
            {
                iterator.book.Get_Book_Object().Chose_BookObject();
                iterator = iterator.next;
            }
        }

        public void Make_Chosen_False()
        {
            book_node iterator = head;
            while (iterator != null)
            {
                iterator.book.Get_Book_Object().chosen = false;
                iterator = iterator.next;
            }
        }

        void Add_To_DataBase()
        {

        }
    }
}
