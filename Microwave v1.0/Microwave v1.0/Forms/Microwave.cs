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
        BOOKS = 0,USERS,AUTHOR, PUBLISHER, DEPARTMENT, EMAIL, ABOUT_US
    }
    public partial class Microwave : Form
    {
        // Variables 
        private Warning warning_form = null;
        private AddBook add_book = null;
        private AddUser add_user = null;
        private AddAuthor add_author = null;
        private AddPublisher add_publisher = null;
        private AddDepartment add_department = null;
        
        private Book_List main_book_list = null;
        private User_List main_user_list = null;
        private Author_List main_author_list = null;
        private Publisher_List main_pub_list = null;
        private Department_List main_department_list = null;

        private Book_Tag main_tag = null;

        private SQLiteConnection connection = new SQLiteConnection(@"data source = ..\..\Resources\Databases\LMS_Database.db");
        private string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";

        MENU_CHOSEN chosen = MENU_CHOSEN.BOOKS;

        // Getters and Setters

        public Warning Warning_form { get => warning_form; set => warning_form = value; }
        public AddBook Add_book { get => add_book; set => add_book = value; }
        public AddUser Add_user { get => add_user; set => add_user = value; }
        public AddAuthor Add_author { get => add_author; set => add_author = value; }
        public AddPublisher Add_publisher { get => add_publisher; set => add_publisher = value; }
        public AddDepartment Add_department { get => add_department; set => add_department = value; }

        
        public Book_List Main_book_list { get => main_book_list; set => main_book_list = value; }
        public User_List Main_user_list { get => main_user_list; set => main_user_list = value; }
        public Author_List Main_author_list { get => main_author_list; set => main_author_list = value; }
        public Publisher_List Main_pub_list { get => main_pub_list; set => main_pub_list = value; }
        public Department_List Main_department_list { get => main_department_list; set => main_department_list = value; }
        
        public Book_Tag Book_tag { get => main_tag; set => main_tag = value; }
        public string Path_file { get => path_file; set => path_file = value; }
        public SQLiteConnection Connection { get => connection; set => connection = value; }
        // Booleans
        private bool show_pnl_book_st   = false;
        private bool show_pnl_user_st   = false;
        private bool show_pnl_author_st = false;
        private bool show_pnl_pub_st    = false;
        private bool show_pnl_depart_st = false;

        // Constructor
        public Microwave()
        {
            InitializeComponent();
            main_tag = new Book_Tag();
            Main_book_list = new Book_List();
            main_department_list = new Department_List();
            main_user_list = new User_List();
            main_pub_list = new Publisher_List();
            main_author_list = new Author_List();

            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
            tb_search.Hide();
            btn_show_search_types.Hide();

            // Book search category
            // Search category
            pnl_book_st.Hide();
            rb_book_name.Checked = true;

            pnl_user_st.Hide();
            pnl_author_st.Hide();
            pnl_publisher_st.Hide();
            pnl_department_st.Hide();
            

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
            else if (chosen == MENU_CHOSEN.AUTHOR)
            {
                message = "Do you want to add a author?";
                color = Color.BlueViolet;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Author_Form();

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
            else if (chosen == MENU_CHOSEN.DEPARTMENT)
            {
                message = "Do you want to add a Department?";
                color = Color.Chocolate;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Department_Form();

                warning_form.Refresh_Form();
            }
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
        public void Create_Add_Author_Form()
        {
            if (Add_author == null)
            {
                Add_author = new AddAuthor();
            }

            try
            {
                Add_author.Show();
            }
            catch (ObjectDisposedException d)
            {
                Add_author = new AddAuthor();
                Add_author.Show();
            }
            this.Btn_add.Enabled = false;
            this.pic_logo.Focus();
            Add_author.Focus();
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
        public void Create_Add_Department_Form()
        {
            if (add_department == null)
            {
                add_department = new AddDepartment();
            }
            try
            {
                add_department.Show();
            }
            catch (ObjectDisposedException d)
            {
                add_department = new AddDepartment();
                add_department.Show();
            }
            this.Btn_add.Enabled = false;
            pic_logo.Focus();
            add_department.Focus();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.BOOKS;
            tb_search.Text = "Search a book";

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_book.Location.Y);
            pnl_stick.Show();
            pnl_book.Show();
            pnl_tag.Show();
            tb_search.Show();
            btn_show_search_types.Show();
            pnl_user.Hide();
            pnl_pub.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.USERS;
            tb_search.Text = "Search a user";

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_user.Location.Y);
            pnl_stick.Show();
            pnl_user.Show();
            tb_search.Show();
            btn_show_search_types.Show();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_tag.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
        }
        private void btn_author_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.AUTHOR;

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_author.Location.Y);
            pnl_stick.Show();
            tb_search.Show();
            btn_show_search_types.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_authors.Show();

        }
        private void btn_publisher_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.PUBLISHER;
            tb_search.Text = "Search a publisher";

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_publisher.Location.Y);
            pnl_stick.Show();
            pnl_pub.Show();
            tb_search.Show();
            btn_show_search_types.Show();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.DEPARTMENT;
            tb_search.Text = "Search a department";

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_department.Location.Y);
            pnl_stick.Show();
            tb_search.Show();
            btn_show_search_types.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_department.Show();
        }
        private void btn_email_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.EMAIL;
            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_email.Location.Y);
            pnl_stick.Show();
        }
        private void btn_about_us_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.ABOUT_US;
            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_about.Location.Y);
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

        /* public void Remove_Image_From_Aut_Cover_List(int aut_id)
        {
            Author_cover_image_list.Images[aut_id.ToString()].Dispose();
            Author_cove
        }
        public void Remove_Image_From_Pub_Cover_List(int pub_id)
        {
            Dep_cover_image_list.Images[pub_id.ToString()].Dispose();
            Dep_cover_image_list.Images.RemoveByKey(pub_id.ToString());
        }
        public void Remove_Image_From_Dep_Cover_List(int dep_id)
        {
            Dep_cover_image_list.Images[dep_id.ToString()].Dispose();
            Dep_cover_image_list.Images.RemoveByKey(dep_id.ToString());
        }*/

        private void Btn_show_search_types_Click(object sender, EventArgs e)
        {
            if(chosen == MENU_CHOSEN.BOOKS)
            {
                if (show_pnl_book_st == false)
                {
                    this.pnl_book_st.Show();
                    show_pnl_book_st = true;
                }
                else
                {
                    this.pnl_book_st.Hide();
                    show_pnl_book_st = false;
                }
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                if (show_pnl_user_st == false)
                {
                    this.pnl_user_st.Show();
                    show_pnl_user_st = true;
                }
                else
                {
                    this.pnl_user_st.Hide();
                    show_pnl_user_st = false;
                }
            }
            else if(chosen == MENU_CHOSEN.AUTHOR)
            {
                if(show_pnl_author_st == false)
                {
                    this.pnl_author_st.Show();
                    show_pnl_author_st = true;
                }
                else
                {
                    this.pnl_author_st.Hide();
                    show_pnl_author_st = false;
                }
            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (show_pnl_pub_st == false)
                {
                    this.pnl_publisher_st.Show();
                    show_pnl_pub_st = true;
                }
                else
                {
                    this.pnl_publisher_st.Hide();
                    show_pnl_pub_st = false;
                }
            }
            else if (chosen == MENU_CHOSEN.DEPARTMENT)
            {
                if (show_pnl_depart_st == false)
                {
                    this.pnl_department_st.Show();
                    show_pnl_depart_st = true;
                }
                else
                {
                    this.pnl_department_st.Hide();
                    show_pnl_depart_st = false;
                }
            }

        }
        private void Tb_search_Leave(object sender, EventArgs e)
        {
            if(chosen == MENU_CHOSEN.BOOKS)
            {
                if(tb_search.Text == "")
                {
                    tb_search.Text = "Search a book";
                    tb_search.ForeColor = Color.Gray;
                }
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                if (tb_search.Text == "")
                {
                    tb_search.Text = "Search a user";
                    tb_search.ForeColor = Color.Gray;
                }

            }
            else if(chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (tb_search.Text == "")
                {
                    tb_search.Text = "Search a publisher";
                    tb_search.ForeColor = Color.Gray;
                }

            }
            else if(chosen == MENU_CHOSEN.DEPARTMENT)
            {
                if (tb_search.Text == "")
                {
                    tb_search.Text = "Search a department";
                    tb_search.ForeColor = Color.Gray;
                }

            }
            else
            {
                if (tb_search.Text == "")
                {
                    tb_search.Text = "Search a book";
                    tb_search.ForeColor = Color.DimGray;
                }

            }
        }
        private void Tb_search_Enter(object sender, EventArgs e)
        {
            if(tb_search.Text == "Search a book" || tb_search.Text == "Search a user" || tb_search.Text == "Search a publisher" || tb_search.Text == "Search a department")
            {
                tb_search.Text = "";
            }

            tb_search.ForeColor = Color.LightGray;
        }
    }
}
