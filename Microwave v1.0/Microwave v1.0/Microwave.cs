using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

/*
 NOT:
 -Microwave class'ı C#'ın Form Classından inherit edilmiş bir class'tır. Programımızın ana formu bu classtır.
 -Bu Class'ta Book List classından programda kullanılacak olan kitapların tutulduğu Main List object yaratılır.
 ve Program çalışırken liste üzerinde yapılacak bütün değişiklikler main listi etkiler.
 -diğer classlardan listeyi düzenlemek isteyen bütün fonksiyonlar bu forma ve formun main listine ulaşmak
 zorundadır.
 -Ayrıca, Listedeki kitaplar hakkında bilgilerin gösterildiği Book Tag classından main_tag isimli obje oluşturulup
 seçilen kitabın bilgilerine göre bu obje düzenlenmektedir.
 -Kitap ekleneceği zaman,Kitap bilgilerinin girileceği AddBook Form Classından add_book objesi de bu classın içersinde 
 tutulmaktadır 

   /* Microwave class is inherited from C# Form Class. The main form of program is formed from this class. 
    In this class, Main List object will be created from the books which will be going to use in program 
    from Book List class.
    when


 */
 
namespace Microwave_v1._0
{
    public partial class Microwave : Form
    {
        // Variables 
        private AddBook add_book = null;              
        public Book_List main_list = null;
        private Book_Tag main_tag = null;
        private SQLiteConnection connection = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");


        // Getters and Setters
        public Book_Tag Book_tag { get => main_tag; set => main_tag = value; }
        public SQLiteConnection Connection { get => connection; set => connection = value; }

        // Constructor
        public Microwave()
        {
            InitializeComponent();
            main_list = new Book_List(); 
            main_tag = new Book_Tag();   
        }

        private void Microwave_Load(object sender, EventArgs e)
        {
            string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
            main_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", path_file);
            main_tag.Draw_Book_Tag();

            Read_Database();

            main_list.Show_All_Books();
        }


        private void Read_Database()
        {
            connection.Open();
            string query = "SELECT * FROM Books ";
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                string name = reader.GetString(1);
                string author = reader.GetString(2);
                string publisher = reader.GetString(3);
                string date = reader.GetString(4);
                int count = reader.GetInt32(5);
                string description = reader.GetString(6);
                string cover_path = reader.GetString(7);

                Book book = new Book(name, author, publisher, date, description, count, cover_path);
                main_list.Add_Book_to_List(book);
            }
            connection.Close();
        }

        private void Btn_Add_Book_Click(object sender, EventArgs e)
        {
           
            if(add_book == null)
            {
                add_book = new AddBook();
            }
           
            try
            {
                add_book.Show();  
            }catch(ObjectDisposedException d)
            {
                add_book = new AddBook();
                add_book.Show();
            }
            
        }

        private void Tb_search_Click(object sender, EventArgs e)
        {
            tb_search.Focus();
        }

        private void Pnl_menu_Click(object sender, EventArgs e)
        {
            pnl_menu.Focus();
        }

        private void Pic_logo_Click(object sender, EventArgs e)
        {
            pic_logo.Focus();
        }

        private void Pnl_left_Click(object sender, EventArgs e)
        {
            pnl_left.Focus();
        }

        private void Panel9_Click(object sender, EventArgs e)
        {
            panel9.Focus();
        }

        private void Pnl_list_Click(object sender, EventArgs e)
        {
            pnl_list.Focus();
        }

        private void tb_search_Enter(object sender, EventArgs e)
        {
            if(tb_search.Text == "Search A Book...")
            {
                tb_search.Text = "";
                tb_search.ForeColor = Color.LightGray;
            }
        }

        private void tb_search_Leave(object sender, EventArgs e)
        {
            if (tb_search.Text == "")
            {
                tb_search.Text = "Search A Book...";
                tb_search.ForeColor = Color.DimGray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 51);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 91);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 130);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel5.Location = new Point(0, 13);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
