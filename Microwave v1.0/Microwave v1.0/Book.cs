using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microwave_v1._0
{   /* NOTE:
     * Book class includes all the information about books.
    */
    public class Book
    {
        // Global
        public static int point_y = 5; // Book infoları ekrana çizdirirken kullanılan offset 
        private static int id = 05101900;
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
        // Getters and Setters 
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Date { get => date; set => date = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public string Cover_path_file { get => cover_path_file; set => cover_path_file = value; }
        public static int Id { get => id; set => id = value; }
        public int Book_id { get => book_id; set => book_id = value; }
        public Book_Info Info { get => info; set => info = value; }

        public Book(string name, string author, string publisher, string date, string description, int count, string pic_path_file)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.date = date;
            this.count = count;
            this.description = description;
            this.cover_path_file = pic_path_file;
            this.book_id = Book.Id;
            info = new Book_Info();
            info.Initialize_Book_Info(name, author, publisher, date, count, description, cover_path_file);
           
        }
    }
}
