﻿using System;
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
        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";
        private string path_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";

        MENU_CHOSEN chosen = MENU_CHOSEN.BOOKS;

        // Searching stuff
        private Book_List book_search_list = null;
        private bool book_searched_already = false;
        private User_List user_search_list = null;
        private bool user_searched_already = false;
        public Publisher_List publisher_searchinf_list = null;
        string pub_last_search_text;

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
        public Book_List Book_search_list { get => book_search_list; set => book_search_list = value; }


        public bool Book_searched_already { get => book_searched_already; set => book_searched_already = value; }
        public User_List User_search_list { get => user_search_list; set => user_search_list = value; }
        public bool User_searched_already { get => user_searched_already; set => user_searched_already = value; }

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
            main_book_list = new Book_List();
            main_department_list = new Department_List();
            main_user_list = new User_List();
            main_pub_list = new Publisher_List();
            main_author_list = new Author_List();

            // Searching
            book_search_list = new Book_List();
            user_search_list = new User_List();
            publisher_searchinf_list = new Publisher_List();


            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
            tb_search_book.Hide();
            tb_search_publisher.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();    
            btn_show_search_types.Hide();


            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            btn_show_search_types.Hide();
            
            // Book search
            pnl_book_st.Hide();
            lb_book_search.Hide();
            rb_book_name.Checked = true;

            // User search
            pnl_user_st.Hide();
            lb_user_search.Hide();
            rb_user_name.Checked = true;
            
            pnl_publisher_st.Hide();
            rb_pub_name.Checked = true;


            pnl_author_st.Hide();

            pnl_department_st.Hide();
            
        }

        private void Microwave_Load(object sender, EventArgs e)
        {
            main_tag.Edit_Book_Tag("Select A Book To Show", "Select A Book To Show", "", "0");
            main_tag.Draw_Book_Tag();

            this.pnl_book_list.VerticalScroll.Value = 0;
            this.pnl_author_list.VerticalScroll.Value = 0;
            this.pnl_user_list.VerticalScroll.Value = 0;
            this.pnl_pub_list.VerticalScroll.Value = 0;
            this.pnl_department_list.VerticalScroll.Value = 0;

            Book.Show_All_Books();
            User.Show_All_Users();
            Department.Show_All_Departments();
            Publisher.Show_All_Publishers();
            Author.Show_All_Authors();
            // It's need to change
            main_user_list.Draw_All_Users();

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            this.pic_logo.Focus();

            string message = null;
            Color color = Warning.Default_Color;

            if(chosen == MENU_CHOSEN.BOOKS)
            {
                pnl_book_list.VerticalScroll.Value = 0;
                book_search_list.Delete_All_List();
                main_book_list.Draw_All_Books();
                book_searched_already = false;

                message = "Do you want to add a book?";
                color = Color.DarkGreen;
                Create_Warning_Form(message, color);
                if (warning_form.Result == true)
                    Create_Add_Book_Form();
                warning_form.Refresh_Form();
            }
            else if(chosen == MENU_CHOSEN.USERS)
            {
                pnl_user_list.VerticalScroll.Value = 0;
                user_search_list.Delete_All_List();
                main_user_list.Draw_All_Users();
                user_searched_already = false;

                message = "Do you want to add a user?";
                color = Color.Bisque;
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
            catch (ObjectDisposedException)
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
            catch (ObjectDisposedException)
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
            catch (ObjectDisposedException)
            {
                add_user = new AddUser();
                add_user.Show();
            }
            this.Btn_add.Enabled = false;
            pic_logo.Focus();
            Add_user.Focus();
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
            catch (ObjectDisposedException)
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
            catch (ObjectDisposedException)
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
            catch (ObjectDisposedException)
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

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_book.Location.Y);
            pnl_stick.Show();
            pnl_book.Show();
            pnl_tag.Show();
            pnl_user.Hide();
            pnl_pub.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            btn_show_search_types.Show();
            tb_search_book.Show();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
            
        }
        private void btn_users_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.USERS;

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_user.Location.Y);
            pnl_stick.Show();
            pnl_user.Show();
            pnl_book.Hide();
            pnl_pub.Hide();
            pnl_tag.Hide();
            pnl_authors.Hide();
            pnl_department.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Show();
            tb_search_author.Hide();
            tb_search_publisher.Hide();
        }
        private void btn_author_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.AUTHOR;

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_author.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_authors.Show();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Show();
            tb_search_publisher.Hide();


        }
        private void btn_publisher_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.PUBLISHER;

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_publisher.Location.Y);
            pnl_stick.Show();
            pnl_pub.Show();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_department.Hide();
            pnl_authors.Hide();
            btn_show_search_types.Show();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Show();
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            chosen = MENU_CHOSEN.DEPARTMENT;

            pnl_stick.Location = new Point(pnl_stick.Location.X, btn_department.Location.Y);
            pnl_stick.Show();
            pnl_pub.Hide();
            pnl_book.Hide();
            pnl_tag.Hide();
            pnl_user.Hide();
            pnl_authors.Hide();
            pnl_department.Show();
            btn_show_search_types.Hide();
            tb_search_book.Hide();
            tb_search_user.Hide();
            tb_search_author.Hide();
            tb_search_publisher.Hide();

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
            this.lb_book_search.Hide();
            this.pic_logo.Focus();
            this.pic_logo.Select();
        }

        public void Remove_Image_From_Cover_List(int book_id)
        {
            Cover_image_list.Images[book_id.ToString()].Dispose();
            Cover_image_list.Images.RemoveByKey(book_id.ToString());
        }





        private void Btn_show_search_types_Click(object sender, EventArgs e)
        {
            if (chosen == MENU_CHOSEN.BOOKS)
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
            else if (chosen == MENU_CHOSEN.USERS)
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
            else if (chosen == MENU_CHOSEN.AUTHOR)
            {
                if (show_pnl_author_st == false)
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
        // Searching events for books
        private void RadioButtonBook_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_book_st.Hide();
            this.show_pnl_book_st = false;
        }
        private void Tb_search_book_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_book.Text.Trim();
            book_searched_already = false;
            if (chosen == MENU_CHOSEN.BOOKS)
            {
                if (text == "")
                {
                    lb_book_search.Hide();
                    lb_book_search.Items.Clear();

                    book_search_list.Delete_All_List();
                    main_book_list.Draw_All_Books();
                    return;
                }
                if(text == "Search a book")
                {
                    book_search_list.Delete_All_List();
                    main_book_list.Draw_All_Books();
                    return;
                }
                else
                {
                    this.pnl_book_list.VerticalScroll.Value = 0;
                    if (rb_book_name.Checked)
                    {
                        string query = string.Format("Select Books.NAME from Books Where Books.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_id.Checked)
                    {
                        string query = string.Format("Select Books.BOOK_ID From Books Where Books.BOOK_ID Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_author.Checked)
                    {
                        string query = string.Format("Select Authors.NAME From Authors Where Authors.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_publis.Checked)
                    {
                        string query = string.Format("Select Publishers.NAME From Publishers Where Publishers.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_category.Checked)
                    {
                        string query = string.Format("Select Categories.NAME From Categories Where Categories.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_shelf.Checked)
                    {
                        string query = string.Format("Select Shelves.NAME From Shelves Where Shelves.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            lb_book_search.Show();
                        return;
                    }
                    if (rb_book_pop.Checked)
                    {
                        string query = string.Format("Select Popularity.NAME From Popularity Where Popularity.NAME Like '{0}%'", text);
                        Fill_Book_Search_List_Box(query);
                        if (lb_book_search.Items.Count > 0)
                            this.lb_book_search.Show();
                        return;
                    }
                    
                }

            }
        }
        private void Tb_search_book_KeyPress(object sender, KeyPressEventArgs e)
        {
            string text = tb_search_book.Text;

            if(e.KeyChar == (char)Keys.Enter && !book_searched_already)
            {
                lb_book_search.Hide();
                if(tb_search_book.Text == "")
                {
                    return;
                }
                main_book_list.Hide_All_Book_Objects();
                book_search_list.Delete_All_List();
                this.pnl_book_list.VerticalScroll.Value = 0;

                if (rb_book_name.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Name(text), INFO_COLOR_MODE.NAME);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_id.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_ID(text), INFO_COLOR_MODE.ID);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_author.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Author(text), INFO_COLOR_MODE.AUTHOR);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_publis.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Publisher(text), INFO_COLOR_MODE.PUBLISHER);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_category.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Category(text), INFO_COLOR_MODE.CATEGORY);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_shelf.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Shelf(text), INFO_COLOR_MODE.SHELF);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
                if (rb_book_pop.Checked)
                {
                    book_search_list.Fill_Book_List(Book.Search_Book_By_Popularity(text), INFO_COLOR_MODE.NORMAL);
                    book_search_list.Draw_All_Books();
                    book_searched_already = true;
                    return;
                }
            }

        }
        private void Tb_search_book_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                if (lb_book_search.Items.Count != 0)
                {
                    lb_book_search.Select();
                    lb_book_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_book_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' '|| e.KeyChar == (char)Keys.Back)
            {
                if (e.KeyChar == (char)Keys.Back)
                    tb_search_book.Text = tb_search_book.Text.Remove(tb_search_book.Text.Length - 1, 1);
                else
                    tb_search_book.Text += e.KeyChar;
                tb_search_book.Focus();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }
            else if(e.KeyChar == (char)Keys.Enter)
            {
                tb_search_book.Focus();
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
                tb_search_book.Select(tb_search_book.Text.Length, 0);
            }


        }
        private void Fill_Book_Search_List_Box(string query)
        {

            lb_book_search.Items.Clear();
            
            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int rows_count = dt.Rows.Count;

            if (rows_count <= 0)
            {
                return;
            }

            for(int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                lb_book_search.Items.Add(item);
            }

        }
        private void Tb_search_Leave(object sender, EventArgs e)
        {

            if (chosen == MENU_CHOSEN.BOOKS)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a book";
                    tb_search_book.ForeColor = Color.Gray;
                    
                }
            }
            else if (chosen == MENU_CHOSEN.USERS)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a user";
                    tb_search_book.ForeColor = Color.Gray;
                }

            }
            else if (chosen == MENU_CHOSEN.DEPARTMENT)
            {
                if (tb_search_book.Text == "")
                {
                    tb_search_book.Text = "Search a department";
                    tb_search_book.ForeColor = Color.Gray;
                }

            }
            else if (chosen == MENU_CHOSEN.PUBLISHER)
            {
                if (tb_search_publisher.Text == "")
                {
                    tb_search_publisher.Text = "Search a publisher";
                    tb_search_publisher.ForeColor = Color.Gray;
                }
            }

        }
        private void Tb_search_Enter(object sender, EventArgs e)
        {    
            if (tb_search_book.Text == "Search a book")
            {
                tb_search_book.Text = "";
            }

            if (lb_book_search.Items.Count > 0)
                lb_book_search.Show();
           
            tb_search_book.ForeColor = Color.LightGray;
        }
        private void Lb_book_search_Leave(object sender, EventArgs e)
        {
            lb_book_search.Hide();
        }
        private void Lb_book_search_DoubleClick(object sender, EventArgs e)
        {
            tb_search_book.Focus();
            if(lb_book_search.SelectedItem != null)
                tb_search_book.Text = lb_book_search.SelectedItem.ToString();
            tb_search_book.Select(tb_search_book.Text.Length, 0);
        }


        private void tb_search_publisher_Enter(object sender, EventArgs e)
        {
            pub_last_search_text = tb_search_publisher.Text;
            if(tb_search_publisher.Text == "Search a publisher")
            {
                tb_search_publisher.Text = "";
            }

            tb_search_publisher.ForeColor = Color.LightGray;
        }
        private void tb_search_publisher_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_publisher.Text.Trim();

            if(chosen == MENU_CHOSEN.PUBLISHER)
            {
                if(text == "")
                {
                    publisher_searchinf_list.Delete_All_List();
                    main_pub_list.Show_All_Publishers();
                    return;
                }
                if(text == "Search a publisher")
                {
                    publisher_searchinf_list.Delete_All_List();
                    main_pub_list.Show_All_Publishers();
                    return;
                }

                this.pnl_pub_list.VerticalScroll.Value = 0;
                main_pub_list.Hide_All_Publisher_Objects();
                publisher_searchinf_list.Delete_All_List();

                if (rb_pub_name.Checked)
                {
                    publisher_searchinf_list.Fill_Pub_List(Publisher.Search_Publisher_By_Name(text));
                    publisher_searchinf_list.Show_All_Publishers();
                    return;
                }
                if (rb_pub_id.Checked)
                {
                    publisher_searchinf_list.Fill_Pub_List(Publisher.Search_Publisher_By_ID(text));
                    publisher_searchinf_list.Show_All_Publishers();
                    return;
                }
            }
        }
        private void rb_pub_name_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_publisher_st.Hide();
            this.show_pnl_pub_st = false;
        }


        private void RadioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            this.pnl_user_st.Hide();
            this.show_pnl_user_st = false;
        }
        private void Tb_search_user_TextChanged(object sender, EventArgs e)
        {
            string text = tb_search_user.Text.Trim();
            user_searched_already = false;

            if(chosen == MENU_CHOSEN.USERS)
            {
                if(text == "")
                {
                    lb_user_search.Hide();
                    lb_user_search.Items.Clear();

                    user_search_list.Delete_All_List();
                    main_user_list.Draw_All_Users();
                    return;
                }
                if(text == "Search a user")
                {
                    user_search_list.Delete_All_List();
                    main_user_list.Draw_All_Users();
                    return;
                }
                else
                {
                    this.pnl_user_list.VerticalScroll.Value = 0;

                    if(rb_user_name.Checked)
                    {
                        string query = string.Format("Select Users.NAME From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if(rb_user_surname.Checked)
                    {
                        string query = string.Format("Select Users.SURNAME From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if(rb_user_id.Checked)
                    {
                        string query = string.Format("Select Users.USER_ID From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if(rb_user_email.Checked)
                    {
                        string query = string.Format("Select Users.EMAIL From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if(rb_user_age.Checked)
                    {
                        string query = string.Format("Select Users.AGE From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                    if(rb_user_gender.Checked)
                    {
                        string query = string.Format("Select Users.GENDER From Users Where Users.NAME Like '{0}%'", text);
                        Fill_User_Search_List_Box(query);
                        if (lb_user_search.Items.Count > 0)
                            lb_user_search.Show();
                        return;
                    }
                }

            }
            
        }
        private void Tb_search_user_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Tb_search_user_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                if(lb_user_search.Items.Count > 0)
                {
                    lb_user_search.Select();
                    lb_user_search.SelectedIndex = 0;
                }
            }
        }
        private void Lb_user_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Lb_user_search_Leave(object sender, EventArgs e)
        {

        }
        private void Lb_user_search_DoubleClick(object sender, EventArgs e)
        {

        }
        private void Tb_search_user_Enter(object sender, EventArgs e)
        {

        }
        private void Tb_search_user_Leave(object sender, EventArgs e)
        {

        }
        private void Fill_User_Search_List_Box(string query)
        {
            lb_user_search.Items.Clear();

            DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);

            int rows_count = dt.Rows.Count;

            if(rows_count <= 0)
                return;

            for (int i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                lb_user_search.Items.Add(item);
            }
        }

    }
}
