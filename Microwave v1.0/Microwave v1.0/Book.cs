using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0
{
    public class Book
    {
        private string name;
        private string author;
        private string publisher;
        private string date;
        private string count;
        private string description;
        private Book_Info info;
        private Book_Tag book_tag;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Date { get => date; set => date = value; }
        public string Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public Book_Info Info { get => info; set => info = value; }
        public Book_Tag Book_tag { get => book_tag; set => book_tag = value; }

        public Book(string name, string author, string publisher, string date, string count)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.count = count;
            this.description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
                "when an unknown printer took a galley of type and scrambled it to make a type " +
                "specimen book. It has survived not only five centuries, but also the leap into " +
                "electronic typesetting, remaining essentially unchanged.";

            book_tag = new Book_Tag();
            book_tag.Edit_Book_Tag(name, description, author);

            info = new Book_Info();
            info.Edit_Book_Info(name, author, publisher, date, count, book_tag);
           
        }
    }
}
