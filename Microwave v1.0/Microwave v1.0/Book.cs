using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0
{
    public class Book
    {

        public static int point_y = 5;
        private string name;
        private string author;
        private string publisher;
        private string date;
        private string count;
        private string description;
        private string cover_path_file;
        private Book_Info info;

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Date { get => date; set => date = value; }
        public string Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public Book_Info Info { get => info; set => info = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }

        public Book(string name, string author, string publisher, string date, string description, string count, string pic_path_file)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.count = count;
            this.description = description;
            this.cover_path_file = pic_path_file;
                
            /*"Lorem Ipsum is simply dummy text of the printing and typesetting industry." +
            "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, " +
            "when an unknown printer took a galley of type and scrambled it to make a type " +
            "specimen book. It has survived not only five centuries, but also the leap into " +
            "electronic typesetting, remaining essentially unchanged.";*/

           

            info = new Book_Info();
            info.Initialize_Book_Info(name, author, publisher, date, count, description, cover_path_file);
           
        }
    }
}
