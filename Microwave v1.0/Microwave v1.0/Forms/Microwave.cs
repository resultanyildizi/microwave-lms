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
using System.Threading;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;

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
    public enum MENU_CHOSEN
    {
        BOOKS = 0,USERS,EMAIL, PUBLISHER,ABOUT_US
    }
    public partial class Microwave : Form
    {
        // Variables 
        private Warning warning_form = null;
        private AddBook add_book = null;              
        private Book_List main_book_list = null;
        private Book_Tag main_tag = null;
        private AddUser add_user = null;
        private AddPublisher add_publisher = null;
        private Publisher_List main_pub_list = null;
        private User_List main_user_list = null;
        private SQLiteConnection connection = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");
        private string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";

        MENU_CHOSEN chosen = MENU_CHOSEN.BOOKS;

        // Getters and Setters
        public AddBook Add_book { get => add_book; set => add_book = value; }
        public AddUser Add_user { get => add_user; set => add_user = value; }
        public AddPublisher Add_publisher { get => add_publisher; set => add_publisher = value; }
        public Warning Warning_form { get => warning_form; set => warning_form = value; }
        public SQLiteConnection Connection { get => connection; set => connection = value; }
        public Publisher_List Main_pub_list { get => main_pub_list; set => main_pub_list = value; }
        public Book_List Main_book_list { get => main_book_list; set => main_book_list = value; }
        public User_List Main_user_list { get => main_user_list; set => main_user_list = value; }
        public Book_Tag Book_tag { get => main_tag; set => main_tag = value; }
        public string Path_file { get => path_file; set => path_file = value; }

        // Constructor
        public Microwave()
        {
            InitializeComponent();
            Main_book_list = new Book_List(); 
            main_tag = new Book_Tag();
            main_user_list = new User_List();
            main_pub_list = new Publisher_List();

            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_book.Hide();
            pnl_stick.Hide();
            pnl_pub.Hide();
            pnl_menu.Hide();
            pnl_left.Hide();
            pnl_header.Hide();
        }

        private void Microwave_Load(object sender, EventArgs e)
        {
            main_book_list = new Book_List();
            main_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", "0");
            main_tag.Draw_Book_Tag();

            Book.Show_All_Books();

            
            Publisher.Show_All_Publishers();
            // It's need to change
            main_user_list.Show_All_Users();

        }

        private void Btn_Add_Book_Click(object sender, EventArgs e)
        {
            this.pic_logo.Focus();

            string message = null;
            Color color = Warning.Default_Color;

            if(chosen == MENU_CHOSEN.BOOKS)
            {
                message = "Do you want to add a book?";
                color = Color.DarkGreen;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Book_Form();
                warning_form.Refresh_Form();
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                message = "Do you want to add a user?";
                color = Color.DarkCyan;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_User_Form();

                warning_form.Refresh_Form();
            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                message = "Do you want to add a publisher?";
                color = Color.DarkCyan;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Publisher_Form();

                warning_form.Refresh_Form();
            }
        }

        public void Create_Add_User_Form()
        {
            if (add_user == null)
            {
                add_user = new AddUser();
            }

            try
            {
                add_user.Show();
            }
            catch (ObjectDisposedException d)
            {
                add_user = new AddUser();
                add_user.Show();
            }
            this.Btn_add.Enabled = false;
            pic_logo.Focus();
        }

        public void Create_Add_Book_Form()
        {
            if (Add_book == null)
            {
                Add_book = new AddBook();
            }

            try
            {
                Add_book.Show();
            }
            catch (ObjectDisposedException d)
            {
                Add_book = new AddBook();
                Add_book.Show();
            }
            this.Btn_add.Enabled = false;
            this.pic_logo.Focus();
            Add_book.Focus();
        }
        public void Create_Add_Publisher_Form()
        {
            if (Add_publisher == null)
            {
                Add_publisher = new AddPublisher();
            }

            try
            {
                Add_publisher.Show();
            }
            catch (ObjectDisposedException d)
            {
                Add_publisher = new AddPublisher();
                Add_publisher.Show();
            }
            this.Btn_add.Enabled = false;
            this.pic_logo.Focus();
            Add_publisher.Focus();
        }
        public void Create_Warning_Form(string message, Color color)
        {
            if (Warning_form == null)
            {
                Warning_form = new Warning();
            }
            try
            {
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
            catch (ObjectDisposedException d)
            {
                Warning_form = new Warning();
                Warning_form.Initialize_Warning(message, color);
                Warning_form.ShowDialog();
            }
        }


        private void btn_users_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.USERS;

            pnl_stick.Location = new Point(0, 51);
            pnl_stick.Show();
            pnl_user.Show();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_tag.Hide();

        }
        private void btn_email_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.EMAIL;
            pnl_stick.Location = new Point(0, 91);
            pnl_stick.Show();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.BOOKS;

            pnl_stick.Location = new Point(0, 13);
            pnl_stick.Show();
            pnl_book.Show();
            pnl_tag.Show();
            pnl_user.Hide();
            pnl_pub.Hide();
        }
        private void btn_publisher_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.PUBLISHER;

            pnl_stick.Location = new Point(0, 177);
            pnl_stick.Show();
            pnl_pub.Show();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
        }
        private void btn_about_us_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.ABOUT_US;
            pnl_stick.Location = new Point(0, 130);
            pnl_stick.Show();
        }



        private void General_Click(object sender, EventArgs e)
        {
            this.pic_logo.Focus();
            this.pic_logo.Select();
        }
        public void Remove_Image_From_Cover_List(int book_id)
        {
            Cover_image_list.Images[book_id.ToString()].Dispose();
            Cover_image_list.Images.RemoveByKey(book_id.ToString());
        }

        private void pnl_main_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnl_header.Show();
            pnl_left.Show();
            pnl_menu.Show();
            pnl_main_page.Hide();
        }
    }
}
