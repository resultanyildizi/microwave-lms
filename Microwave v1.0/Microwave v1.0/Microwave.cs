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
        BOOKS = 0,USERS,EMAİL,ABOUT_US
    }
    public partial class Microwave : Form
    {
        // Variables 
        private Warning warning_form = null;
        private AddBook add_book = null;              
        private Book_List main_list = null;
        private Book_Tag main_tag = null;
        private AddUser add_user = null;
        public User_List user_list = null;
        private SQLiteConnection connection = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");
        private string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";

        MENU_CHOSEN chosen = MENU_CHOSEN.BOOKS;

        // Getters and Setters
        public Book_Tag Book_tag { get => main_tag; set => main_tag = value; }
        public SQLiteConnection Connection { get => connection; set => connection = value; }
        public Warning Warning_form { get => warning_form; set => warning_form = value; }
        public AddBook Add_book { get => add_book; set => add_book = value; }
        public Book_List Main_list { get => main_list; set => main_list = value; }
        public string Path_file { get => path_file; set => path_file = value; }

        // Constructor
        public Microwave()
        {
            InitializeComponent();
            Main_list = new Book_List(); 
            main_tag = new Book_Tag();
            user_list = new User_List();

            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_book.Hide();
            pnl_stick.Hide();
        }

        private void Microwave_Load(object sender, EventArgs e)
        {
            
            main_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", path_file);
            main_tag.Draw_Book_Tag();

            Book_List.Read_Database();
            Main_list.Show_All_Books();
            user_list.Show_All_Users();

        }

        private void Btn_Add_Book_Click(object sender, EventArgs e)
        {
            Action method = null;
            string message = null;
            Color color = Warning.Default_Color;

            if(chosen == MENU_CHOSEN.BOOKS)
            {
                method = Create_Add_Book_Form;
                message = "Do you want to add a book?";
                color = Color.DarkGreen;
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                method = Create_Add_User_Form;
                message = "Do you want to add a user?";
                color = Color.DarkCyan;
            }

            Create_Warning_Form(message, method, color);
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
            pic_logo.Focus();
        }

        public void Create_Warning_Form(string message, Action method, Color color)
        {
            if (Warning_form == null)
            {
                Warning_form = new Warning();
                Warning_form.Initialize_Warning(message, method, color);
            }
            try
            {
                Warning_form.Show();
            }
            catch (ObjectDisposedException d)
            {
                Warning_form = new Warning();
                Warning_form.Initialize_Warning(message, method, color);
                Warning_form.Show();
            }
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
            chosen = MENU_CHOSEN.USERS;

            pnl_stick.Location = new Point(0, 51);
            pnl_stick.Show();
            pnl_user.Show();
            pnl_book.Hide();
            pnl_tag.Hide();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.EMAİL;
            pnl_stick.Location = new Point(0, 91);
            pnl_stick.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.ABOUT_US;
            pnl_stick.Location = new Point(0, 130);
            pnl_stick.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.BOOKS;

            pnl_stick.Location = new Point(0, 13);
            pnl_stick.Show();
            pnl_book.Show();
            pnl_tag.Show();
            pnl_user.Hide();
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
            pnl_book.Focus();
        }

        private void Pnl_list_Click(object sender, EventArgs e)
        {
            pnl_book_list.Focus();
        }
     

        private void pnl_user_list_Click(object sender, EventArgs e)
        {
            pnl_user.Focus();
        }

        private void pnl_user_Click(object sender, EventArgs e)
        {
            pnl_user.Focus();
        }

        private void Pnl_header_Click(object sender, EventArgs e)
        {
            pnl_header.Focus();
        }

        private void Microwave_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
    }
}
