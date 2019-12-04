using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;
using Microwave_v1._0.UserControls;
using Microwave_v1._0.Forms;

namespace Microwave_v1._0.Forms
{
    public enum SELECTED
    {
        BOOK = 0, USER, AUTHOR, PUBLISHER, EMPLOYEE
    }
    public partial class Detail : Form
    {
        GiveBook give_book_form = null;

        User user = null;
        Publisher publisher = null;
        Employee employee = null;
        Book book = null;
        Author author = null;

        AddBook edit_book = null;
        AddAuthor edit_author = null;
        AddEmployee edit_employee = null;
        AddPublisher edit_publisher = null;
        AddUser edit_user = null;

        private Microwave main_page = (Microwave)Application.OpenForms["Microwave"];

        static private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";

        private SELECTED choise;

        public SELECTED Choise { get => choise; set => choise = value; }

        public Detail()
        {
            InitializeComponent();
        }

        public Detail(Book book)
        {
            InitializeComponent();

            this.book = book;

            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();

            DataTable dt = User.Show_All_Users(book);
            dgw_users.DataSource = dt;

            DataGridViewButtonColumn detail_dgw_btn = new DataGridViewButtonColumn();
            detail_dgw_btn.HeaderText = "Detail";
            detail_dgw_btn.Text = "Show";
            detail_dgw_btn.Name = "detail_dgw_btn";
            detail_dgw_btn.UseColumnTextForButtonValue = true;
            detail_dgw_btn.DefaultCellStyle.BackColor = Color.FromArgb(32, 33, 38);
            detail_dgw_btn.DefaultCellStyle.ForeColor = Color.White;

            dgw_users.Columns.Add(detail_dgw_btn);

            this.btn_id.Text = book.Book_id.ToString();
            this.lbl_date.Text = book.Date.Substring(0, 10);

            this.lbl_name.Text = book.Name; // Label for name

            this.lbl_1.Text = "Author:";
            this.lbl_2.Text = "Publisher:";
            this.lbl_3.Text = "Category:";
            this.lbl_4.Text = "Shelf:";
            this.lbl_5.Text = "Popularity:";
            this.lbl_6.Text = "Count:";
            this.lbl_desc.Text = "Users which have that book currently:";

            this.tb_1.Text = book.Author_name;
            this.tb_2.Text = book.Publisher_name;
            this.tb_3.Text = book.Category_name;
            this.tb_4.Text = "#" + book.Shelf_name;
            this.tb_5.Text = book.Popularity_name + " ( " + book.Popularity_score + " )";
            this.tb_6.Text = book.Count.ToString();
            this.tb_7.Hide();

            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(book.Cover_path_file);

            choise = SELECTED.BOOK;
        }

        public Detail(User user)
        {
            InitializeComponent();

            this.user = user;


            DataTable dt = Book.Show_All_Books(user);
            user.Book_count = dt.Rows.Count;
            dgw_users.DataSource = dt;


            this.btn_give_book.Show();
            this.btn_give_penalty.Show();
            this.btn_return_book.Show();

            this.btn_id.Text = user.User_id.ToString();


            this.lbl_name.Text = user.Name + " " + user.Surname;

            this.lbl_1.Text = "Email:";
            this.lbl_2.Text = "Gender:";
            this.lbl_3.Text = "Password:";
            this.lbl_4.Text = "Age:";
            this.lbl_5.Text = "Total Fee:";
            this.lbl_6.Text = "Book Count:";

            this.lbl_desc.Text = "Books that " + user.Name + " currently has:"; 

            this.tb_1.Text = user.Email;
            this.tb_2.Text = user.Gender;
            this.tb_3.Text = user.Password;
            this.tb_4.Text = user.Age.ToString();
            this.tb_5.Text = "15₺";
            this.tb_6.Text = user.Book_count.ToString();
            this.tb_7.Hide();

            picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__2_;

            choise = SELECTED.USER;
        }

        public Detail(Publisher publisher)
        {
            InitializeComponent();

            this.publisher = publisher;

            DataTable dt = Book.Show_All_Books(publisher);
            dgw_users.DataSource = dt;

            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();

            this.btn_id.Text = publisher.Publisher_id.ToString();
            this.lbl_date.Hide();

            this.lbl_name.Text = publisher.Pub_name; // Label for name

            this.lbl_1.Text = "Name:";
            this.lbl_2.Text = "Email:";

            this.lbl_3.Text = "Phone:";
            this.lbl_4.Text = "Date:";
            this.lbl_5.Hide();
            this.lbl_6.Hide();
            this.lbl_desc.Text = "Books which " + publisher.Pub_name + " has:";

            this.tb_1.Text = publisher.Pub_name;
            this.tb_2.Text = publisher.Pub_email;
            this.tb_3.Text = publisher.Pub_phone_num;
            this.tb_4.Text = publisher.Pub_date_of_est;
            this.tb_5.Hide();
            this.tb_6.Hide();
            this.tb_7.Hide();

            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(publisher.Pub_cover_path_file);

            choise = SELECTED.PUBLISHER;
        }

        public Detail(Author author)
        {
            InitializeComponent();

            this.author = author;

            DataTable dt = Book.Show_All_Books(author);
            dgw_users.DataSource = dt;

            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();

            this.btn_id.Text = author.Author_id.ToString();
            this.lbl_date.Hide();

            this.lbl_name.Text = author.Author_name;

            this.lbl_1.Text = "Country:";
            this.lbl_2.Text = "Gender:";
            this.lbl_3.Text = "Birth Year:";
            this.lbl_4.Text = "Biography:";
            this.lbl_5.Hide();
            this.lbl_6.Hide();

            this.lbl_desc.Text = "Books of " + author.Author_name + ": ";

            this.tb_1.Text = author.Author_country;
            this.tb_2.Text = author.Author_gender;
            this.tb_3.Text = author.Author_birthday;
            this.tb_4.Hide();
            this.tb_5.Hide();
            this.tb_6.Hide();
            this.tb_7.Text = author.Author_biography;

            picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(author.Author_cover_path_file);

            choise = SELECTED.AUTHOR;

        }

        public Detail(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;


            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();
            this.lbl_6.Hide();
            this.tb_6.Hide();
            this.dgw_users.Hide();

            this.btn_id.Text = employee.Employee_id.ToString();


            this.lbl_name.Text = employee.Name + " " + employee.Surname;

            this.lbl_1.Text = "Email:";
            this.lbl_2.Text = "Birth Date:";
            this.lbl_3.Text = "Password:";
            this.lbl_4.Text = "Gender:";
            this.lbl_5.Text = "Department:";

            this.lbl_desc.Text = " ";

            this.tb_1.Text = employee.Email;
            this.tb_2.Text = employee.Gender;
            this.tb_3.Text = employee.Password;
            this.tb_4.Text = employee.Birth_date_dt.ToString().Substring(0,10);
            this.tb_5.Text = employee.Deparment_name;
            this.tb_7.Hide();


            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(employee.Cover_path_file);

            choise = SELECTED.EMPLOYEE;

        }

        private void btn_give_book_Click(object sender, EventArgs e)
        {
            Create_New_Give_Book_Form();
        }

        public void Create_New_Give_Book_Form()
        {

            if (give_book_form == null)
            {
                give_book_form = new GiveBook(this, user);
            }

            try
            {
                give_book_form.Show();
            }
            catch (Exception)
            {
                give_book_form = new GiveBook(this, user);
                give_book_form.Show();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (choise == SELECTED.BOOK)
            {
                string message = "Do you want to edit this book?";
                main_page.Create_Warning_Form(message, Color.DarkSeaGreen);
                if (main_page.Warning_form.Result)
                {

                    if (edit_book == null)
                    {
                        edit_book = new AddBook(book);
                        edit_book.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            edit_book.ShowDialog();
                        }
                        catch (Exception)
                        {
                            edit_book = new AddBook(book);
                            edit_book.ShowDialog();
                        }

                    }
                   
                    main_page.Warning_form.Refresh_Form();

                    this.lbl_name.Text = book.Name;
                    this.tb_1.Text = book.Author_name;
                    this.tb_2.Text = book.Publisher_name;
                    this.tb_3.Text = book.Category_name;
                    this.tb_4.Text = "#" + book.Shelf_name;
                    this.tb_5.Text = book.Popularity_name + " ( " + book.Popularity_score + " )";
                    this.tb_6.Text = book.Count.ToString();

                    this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(book.Cover_path_file);
                }
            }
            else if (choise == SELECTED.AUTHOR)
            {
                string message = "Do you want to edit this author?";
                main_page.Create_Warning_Form(message, Color.DarkSeaGreen);
                if (main_page.Warning_form.Result)
                {
                    if (edit_author == null)
                    {
                        edit_author = new AddAuthor(author);
                        edit_author.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            edit_author.ShowDialog();
                        }
                        catch (Exception)
                        {
                            edit_author = new AddAuthor(author);
                            edit_author.ShowDialog();
                        }
                    }
                  
                }

                main_page.Warning_form.Refresh_Form();

                this.lbl_name.Text = author.Author_name;
                this.tb_1.Text = author.Author_country;
                this.tb_2.Text = author.Author_gender;
                this.tb_3.Text = author.Author_birthday;
                picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(author.Author_cover_path_file);
        
            }
            else if (choise == SELECTED.EMPLOYEE)
            {
                string message = "Do you want to edit this employee?";
                main_page.Create_Warning_Form(message, Color.DarkSeaGreen);
                if (main_page.Warning_form.Result)
                {
                    if (edit_employee == null)
                    {
                        edit_employee = new AddEmployee(employee);
                        edit_employee.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            edit_employee.ShowDialog();
                        }
                        catch (Exception)
                        {

                            edit_employee = new AddEmployee(employee);
                            edit_employee.ShowDialog();
                        }
                    }
                }
                main_page.Warning_form.Refresh_Form();

                this.lbl_name.Text = employee.Name;
                this.tb_1.Text = employee.Email;
                this.tb_2.Text = employee.Gender;
                this.tb_3.Text = employee.Password;
                this.tb_4.Text = employee.Birth_date_dt.ToString().Substring(0,10);
                this.tb_5.Text = employee.Deparment_name;


                this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(employee.Cover_path_file);
            }
            else if (choise == SELECTED.PUBLISHER)
            {
                string message = "Do you want to edit this publisher?";
                main_page.Create_Warning_Form(message, Color.DarkSeaGreen);
                if (main_page.Warning_form.Result)
                {
                    if (edit_publisher == null)
                    {
                        edit_publisher = new AddPublisher(publisher);
                        edit_publisher.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            edit_publisher.ShowDialog();
                        }
                        catch (Exception)
                        {

                            edit_publisher = new AddPublisher(publisher);
                            edit_publisher.ShowDialog();
                        }
                    }
                }
                main_page.Warning_form.Refresh_Form();

                this.lbl_name.Text = publisher.Pub_name;
                this.tb_1.Text = publisher.Pub_name;
                this.tb_2.Text = publisher.Pub_email;
                this.tb_3.Text = publisher.Pub_phone_num;
                this.tb_4.Text = publisher.Pub_date_of_est;

                this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(publisher.Pub_cover_path_file);
            }
            else if (choise == SELECTED.USER)
            {
                string message = "Do you want to edit this user?";
                main_page.Create_Warning_Form(message, Color.DarkSeaGreen);
                if (main_page.Warning_form.Result)
                {
                    if (edit_user == null)
                    {
                        edit_user = new AddUser(user);
                        edit_user.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            edit_user.ShowDialog();
                        }
                        catch (Exception)
                        {
                            edit_user = new AddUser(user);
                            edit_user.ShowDialog();
                        }
                    }
                }

                main_page.Warning_form.Refresh_Form();

                this.lbl_name.Text = user.Name;
                this.tb_1.Text = user.Email;
                this.tb_2.Text = user.Gender;
                this.tb_3.Text = user.Password;
                this.tb_4.Text = user.Age.ToString();
                this.tb_5.Text = "15₺";
                this.tb_6.Text = user.Book_count.ToString();

                picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__2_;
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (choise == SELECTED.BOOK)
            {
                Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
                string message = "Do you want to delete this book?";
                main_page.Create_Warning_Form(message, Color.DarkRed);
                if (main_page.Warning_form.Result)
                    book.Info.Remove();

                main_page.Warning_form.Refresh_Form();

                main_page.Pnl_book_list.VerticalScroll.Value = 0;
                main_page.Book_search_list.Delete_All_List();
                main_page.Main_book_list.Draw_All_Books();
                main_page.Book_searched_already = false;

                this.Close();
            }
            else if (choise == SELECTED.AUTHOR)
            {
               
                string message = "Do you want to delete this author?";
                main_page.Create_Warning_Form(message, Color.DarkRed);
                bool delete_pic = true;

                if (author.Author_info.Pic_path_file == @"..\..\Resources\Author Covers\DefaultAuthor.jpg")
                {
                    delete_pic = false;
                }

                if (main_page.Warning_form.Result)
                    author.Author_info.Remove(delete_pic);

                main_page.Warning_form.Refresh_Form();

                main_page.Pnl_author_list.VerticalScroll.Value = 0;
                main_page.Author_search_list.Delete_All_List();
                main_page.Main_author_list.Draw_All_Authors();
                main_page.Author_searched_already = false;

                this.Close();
            }
            else if (choise == SELECTED.EMPLOYEE)
            {
                ShowEmployee main_page = (Microwave_v1._0.Forms.ShowEmployee)Application.OpenForms["ShowEmployee"];
                string message = "Do you want to delete this Employee";
                main_page.Create_Warning_Form(message, Color.LimeGreen);
                bool delete_pic = true;
                if (main_page.Warning_form1.Result)
                {
                    employee.Info.Remove(delete_pic);
                }
                main_page.Warning_form1.Refresh_Form();
                main_page.Pnl_employee_list.VerticalScroll.Value = 0;
                main_page.Main_employee_list.Draw_All_Employees();

                this.Close();
            }
            else if (choise == SELECTED.PUBLISHER)
            {
                string message = "Do you want to delete this publisher?";
                main_page.Create_Warning_Form(message, Color.DarkRed);
                bool delete_pic = true;
                if (publisher.Pub_info.Pub_pic_path_file == @"..\..\Resources\Publisher Covers\DefaultPublisher.jpg")
                {
                    delete_pic = false;
                }

                string query = "UPDATE Books SET PUBLISHER_ID = 0 WHERE Books.PUBLISHER_ID = " + publisher.Publisher_id;
                DataBaseEvents.ExecuteNonQuery(query, datasource);

                if (main_page.Warning_form.Result)
                    publisher.pub_info.Remove(delete_pic);

                main_page.Warning_form.Refresh_Form();

                main_page.Pnl_pub_list.VerticalScroll.Value = 0;
                main_page.Publisher_search_list.Delete_All_List();
                main_page.Main_pub_list.Draw_All_Publishers();
                main_page.Publisher_searched_already = false;
                this.Close();
            }
            else if (choise == SELECTED.USER)
            {
                string message = "Do you want to delete that user?";
                main_page.Create_Warning_Form(message, Color.DarkRed);
                if (main_page.Warning_form.Result)
                {
                    user.Info.Remove();
                }
                main_page.Warning_form.Refresh_Form();

                main_page.Pnl_user_list.VerticalScroll.Value = 0;
                main_page.User_search_list.Delete_All_List();
                main_page.Main_user_list.Draw_All_Users();
                main_page.User_searched_already = false;
                this.Close();
            }
        }

        private void dgw_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(choise == SELECTED.BOOK)
            {
                if(e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    int user_id = int.Parse(dgw_users.Rows[e.RowIndex].Cells[1].Value.ToString());
                    User user = main_page.Main_user_list.Find_User_By_ID(user_id);

                    user.Info.Create_User_Detail_Form(user);
                }

            }

        }

    }
}