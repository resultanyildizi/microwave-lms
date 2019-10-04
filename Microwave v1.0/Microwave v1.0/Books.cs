using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0
{
    public class Books
    {
        private string name;
        private string author;
        private string publisher;
        private string date;
        private string count;
        private string description;
        private BookObject obj;
        private BookDescription about;

        public Books(string name, string author, string publisher, string date, string count)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.count = count;
            this.description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.";
            about = new BookDescription();
            obj = new BookObject();
            obj.lbl_name.Text = name;
            obj.lbl_author.Text = author;
            obj.lbl_publisher.Text = publisher;
            obj.lbl_date.Text = date;
            obj.lbl_count.Text = count;
            obj.book = this;
        }

        public BookObject Get_Book_Object()
        {
            return this.obj;
        }
        public BookDescription get_about_book()
        {
            return this.about;
        }

        public void Edit_About_Book()
        { 
            about.lbl_bookname.Text = name;
            about.lbl_description.Text = description;
            about.lbl_author.Text = "- " + author;

        }
    }
}
