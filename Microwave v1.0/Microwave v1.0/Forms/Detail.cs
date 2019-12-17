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
        BOOK = 0, USER, AUTHOR, PUBLISHER, EMPLOYEE, CATEGORY
    }
    public partial class Detail : Form
    {
        GiveBook give_book_form = null;
        GivePenalty give_penalty_form = null;
        User user = null;
        Publisher publisher = null;
        Employee employee = null;
        Book book = null;
        Author author = null;
        Category category = null;


        AddBook edit_book = null;
        AddAuthor edit_author = null;
        AddEmployee edit_employee = null;
        AddPublisher edit_publisher = null;
        AddUser edit_user = null;

        // For system manager
        private bool change_pass_clicked = false;
        private string password = "";
        private string password_confirm = "";
        private int pass_strength_score = 0;
        private bool show_pass_clicked = false;

        private Microwave main_page = (Microwave)Application.OpenForms["Microwave"];
        static private string datasource = System.Configuration.ConfigurationManager.AppSettings["data_source"];


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
            this.btn_change_pass.Hide();

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
            this.btn_change_pass.Hide();
            this.pnl_change_pass.Hide();
            this.btn_show_pass.Hide();

            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(book.Cover_path_file);

            choise = SELECTED.BOOK;
        }

        public Detail(User user)
        {
            InitializeComponent();
            this.btn_change_pass.Hide();

            this.user = user;


            DataTable dt = Book.Show_All_Books(user);
            int rows_count = dt.Rows.Count;

            int user_book_count = 0;
            for (int i = 0; i < rows_count; i++)
            {
                user_book_count += int.Parse(dt.Rows[i][9].ToString());
            }
            user.Book_count = user_book_count;

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
            this.tb_5.Text = user.Fee + "₺";
            this.tb_6.Text = user.Book_count.ToString();
            this.tb_7.Hide();
            this.btn_change_pass.Hide();
            this.pnl_change_pass.Hide();
            this.btn_show_pass.Hide();

            picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__1_1;

            choise = SELECTED.USER;
        }

        public Detail(Publisher publisher)
        {
            InitializeComponent();
            this.btn_change_pass.Hide();


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
            this.btn_change_pass.Hide();
            this.pnl_change_pass.Hide();
            this.btn_show_pass.Hide();

            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(publisher.Pub_cover_path_file);

            choise = SELECTED.PUBLISHER;
        }

        public Detail(Author author)
        {
            InitializeComponent();
            this.btn_change_pass.Hide();


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
            this.btn_change_pass.Hide();
            this.pnl_change_pass.Hide();
            this.btn_show_pass.Hide();


            picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(author.Author_cover_path_file);

            choise = SELECTED.AUTHOR;

        }

        public Detail(Employee employee, bool change_pass)
        {
            InitializeComponent();

            if (change_pass)
            {
                this.btn_change_pass.Show();
                this.btn_show_pass.Show();
            }
            else
            {
                this.btn_change_pass.Hide();
                this.btn_show_pass.Hide();
            }

            this.pnl_change_pass.Hide();

            this.pnl_pow1.Hide();
            this.pnl_pow2.Hide();
            this.pnl_pow3.Hide();
            this.lbl_power.Hide();
            this.lbl_matched.Hide();

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
            this.lbl_4.Text = "Birth Date:";
            this.lbl_3.Text = "Password:";
            this.lbl_2.Text = "Gender:";
            this.lbl_5.Text = "Department:";

            this.lbl_desc.Text = " ";

            this.tb_1.Text = employee.Email;
            this.tb_2.Text = employee.Gender;
            this.tb_3.Text = employee.Password;
            this.tb_4.Text = employee.Birth_date_dt.ToString().Substring(0,10);
            this.tb_5.Text = employee.Deparment_name;

            if (this.employee.Deparment_name == "System Manager")
                this.tb_3.UseSystemPasswordChar = true;

            this.tb_7.Hide();


            this.picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(employee.Cover_path_file);

            choise = SELECTED.EMPLOYEE;

        }
        public Detail(Category category)
        {
            InitializeComponent();
            this.btn_change_pass.Hide();

            this.category = category;

            DataTable dt = Book.Show_All_Books(category);
            dgw_users.DataSource = dt;

            this.btn_give_book.Hide();
            this.btn_give_penalty.Hide();
            this.btn_return_book.Hide();

            this.btn_id.Text = category.Category_id.ToString();
            this.lbl_date.Hide();

            this.lbl_name.Text = category.Category_name;

            this.lbl_1.Text = "";
            this.lbl_2.Text = "";
            this.lbl_3.Text = "";
            this.lbl_4.Text = "";
            this.lbl_5.Hide();
            this.lbl_6.Hide();

            this.lbl_desc.Text = "Books in " + category.Category_name + " category : ";

            this.tb_1.Hide();
            this.tb_2.Hide();
            this.tb_3.Hide();
            this.tb_4.Hide();
            this.tb_5.Hide();
            this.tb_6.Hide();
            this.tb_7.Hide();
            this.btn_show_pass.Hide();


            picture_box.Image = Picture_Events.Get_Copy_Image_Bitmap(category.Category_cover_path_file);

            choise = SELECTED.CATEGORY;

        }

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            string query = "Select Books.BOOK_ID, Books.AUTHOR_ID, Books.PUBLISHER_ID, Books.CATEGORY_ID, Books.LIBRARIAN_ID, " +
                           "Books.SHELF_ID, Books.POPULARITY_ID, Books.NAME, Books.DATE, Books.DESCRIPT, Book_User.COUNT, Books.COVER_PATH," +
                           " Books.POPULARITY_SCORE From Book_User Join Books On Book_User.BOOK_ID = Books.BOOK_ID Where Book_User.USER_ID = " + user.User_id;
            Create_New_Give_Book_Form(query);
        }

        private void btn_give_book_Click(object sender, EventArgs e)
        {
            string query = "Select * From Books";
            Create_New_Give_Book_Form(query);
        }

        public void Create_New_Give_Book_Form(string query)
        {

            if (give_book_form == null)
            {
                give_book_form = new GiveBook(this, user, query);
            }

            try
            {
                give_book_form.Show();
            }
            catch (Exception)
            {
                give_book_form = new GiveBook(this, user, query);
                give_book_form.Show();
            }

        }
        public void Create_New_Give_Penalty_Form(Book selected)
        {
            if (give_penalty_form == null)
            {
                give_penalty_form = new GivePenalty(main_page.Manager, this, selected, user);
            }

            try
            {
                give_penalty_form.Show();
            }
            catch (Exception)
            {
                give_penalty_form = new GivePenalty(main_page.Manager, this, selected, user);
                give_penalty_form.Show();
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

                picture_box.Image = global::Microwave_v1._0.Properties.Resources.man_user__1_;
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

                if (author.Author_info.Pic_path_file == System.Configuration.ConfigurationManager.AppSettings["def_aut_path"])
                {
                    delete_pic = false;
                }

                if (main_page.Warning_form.Result)
                    author.Author_info.Remove(delete_pic);

                main_page.Warning_form.Refresh_Form();

                main_page.Pnl_author_list.VerticalScroll.Value = 0;
                main_page.Author_search_list.Delete_All_List();
                main_page.Main_author_list.Hide_All_Author_Objects();
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
                if (publisher.Pub_info.Pub_pic_path_file == System.Configuration.ConfigurationManager.AppSettings["def_pb_path"])
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

        private void btn_give_penalty_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgw_users.SelectedRows[0].Cells[0].Value.ToString());

            Book selected = main_page.Main_book_list.Find_Book_By_ID(id);
            Create_New_Give_Penalty_Form(selected);
        }

        private void btn_change_pass_Click(object sender, EventArgs e)
        {
            if (change_pass_clicked)
                this.pnl_change_pass.Hide();
            else
                this.pnl_change_pass.Show();

            change_pass_clicked = !change_pass_clicked;
        }

        private void tb_new_pass_TextChanged(object sender, EventArgs e)
        {
            password = tb_new_pass.Text.Trim();
            pass_strength_score = Password_Events.GetPasswordStrength(password);

            

            if(pass_strength_score <= 1)
            {
                this.pnl_pow1.Show();
                this.pnl_pow1.BackColor = Color.FromArgb(211, 86, 86);
                this.pnl_pow2.Hide();
                this.pnl_pow3.Hide();
                this.lbl_power.Show();
                this.lbl_power.Text = "Weak";
                this.lbl_power.ForeColor = Color.FromArgb(211, 86, 86);
            }
            if (password == "")
            {
                this.lbl_power.Text = "";
                this.pnl_pow1.Hide();
                this.pnl_pow2.Hide();
                this.pnl_pow3.Hide();
            }
            else if(pass_strength_score > 1 && pass_strength_score <= 3)
            {
                this.pnl_pow1.Show();
                this.pnl_pow1.BackColor = Color.FromArgb(255, 215, 0);
                this.pnl_pow2.Show();
                this.pnl_pow2.BackColor = Color.FromArgb(255, 215, 0);
                this.pnl_pow3.Hide();
                this.lbl_power.Show();
                this.lbl_power.Text = "Fine";
                this.lbl_power.ForeColor = Color.FromArgb(255, 215, 0);
            }
            else if(pass_strength_score > 3)
            {
                this.pnl_pow1.Show();
                this.pnl_pow1.BackColor = Color.FromArgb(152, 251, 152);
                this.pnl_pow2.Show();
                this.pnl_pow2.BackColor = Color.FromArgb(152, 251, 152);
                this.pnl_pow3.Show();
                this.pnl_pow2.BackColor = Color.FromArgb(152, 251, 152);
                this.lbl_power.Show();
                this.lbl_power.Text = "Fine";
                this.lbl_power.ForeColor = Color.FromArgb(152, 251, 152);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.lbl_msg.Text = "";
            if(pass_strength_score == 0)
            {
                this.lbl_msg.Text = "*Password should have more than 5 characters.";
                this.lbl_msg.ForeColor = Color.FromArgb(211, 86, 86);
                this.tb_new_pass.Focus();
                return;
            }

            if(pass_strength_score == 1)
            {
                this.lbl_msg.Text = "*Password can't include only low letters.";
                this.lbl_msg.ForeColor = Color.FromArgb(211, 86, 86);
                this.tb_new_pass.Focus();
                return;
            }

            if(password != password_confirm)
            {
                this.lbl_msg.Text = "Password doesn't match";
                this.lbl_msg.ForeColor = Color.FromArgb(211, 86, 86);
                this.tb_pass_confirm.Focus();
                return;
            }

            this.employee.Change_Password(password);
            this.lbl_msg.Text = "Password changed successfully";
            this.lbl_msg.ForeColor = Color.FromArgb(152, 251, 152);
            this.lbl_msg.Show();

        }

        private void tb_pass_confirm_TextChanged(object sender, EventArgs e)
        {
            this.password_confirm = this.tb_pass_confirm.Text.Trim();
            if (pass_strength_score > 1 && password_confirm == password)
                lbl_matched.Show();
            else
                lbl_matched.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_pass_clicked = !show_pass_clicked;

            if (show_pass_clicked)
            {
                this.tb_3.UseSystemPasswordChar = false;
                this.btn_show_pass.Image = global::Microwave_v1._0.Properties.Resources.visibility_off;
            }
            else
            {
                this.tb_3.UseSystemPasswordChar = true;
                this.btn_show_pass.Image = global::Microwave_v1._0.Properties.Resources.visibility_on;
            }

        }
    }
}