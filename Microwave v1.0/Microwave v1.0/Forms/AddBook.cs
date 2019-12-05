using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using Microwave_v1._0.Classes;
using Microwave_v1._0.Model;

namespace Microwave_v1._0
{
    /* NOTE:
     * AddBook is a form which is used for adding a new book to 
     * the system by taking their information and cover pictures.
     */ 
    public partial class AddBook : Form
    {
        private string name;
        private string author;
        private string publisher;
        private string category;
        private string shelf;
        private string date;
        private string description;
        private int count;


        private int author_id;
        private int publisher_id;
        private int category_id;
        private int shelf_id;
        Microwave main_page;


        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
        private string pic_dest_path = @"..\..\Resources\Book Covers\";
        private string pic_new_source_path = "";


        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";


        private bool is_edit = false;
        private bool change_image = false;
        private Book book_to_edit = null;
        private Publisher_List pub_list = null;



        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);
            pic_new_source_path = picture_event.Pic_source_file;
            this.lbl_message.Text = "";


            // Read Authors, Publishers, Categories, Shelves from Database
            Fill_Comboboxes();

            // Make comboboxes default
            this.cb_author.SelectedIndex = 0;
            this.cb_publisher.SelectedIndex = 0;
            this.cb_category.SelectedIndex = 0;
            this.cb_shelf.SelectedIndex = 0;

           


            this.BringToFront();
        }

        public AddBook(Book book)
        {
            InitializeComponent();
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_;

            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);
            this.lbl_message.Text = "";

            book_to_edit = book;

            // Read Authors, Publishers, Categories, Shelves from Database
            Fill_Comboboxes();

            // Make comboboxes default
            this.cb_author.SelectedIndex = this.cb_author.Items.IndexOf(book.Author_name);
            this.cb_publisher.SelectedIndex = this.cb_publisher.Items.IndexOf(book.Publisher_name);
            this.cb_category.SelectedIndex = this.cb_category.Items.IndexOf(book.Category_name);
            this.cb_shelf.SelectedIndex = this.cb_shelf.Items.IndexOf(book.Shelf_name);
            this.cb_author.ForeColor = Color.LightGray;
            this.cb_publisher.ForeColor = Color.LightGray;
            this.cb_category.ForeColor = Color.LightGray;
            this.cb_shelf.ForeColor = Color.LightGray;

            // Make other properties default
            this.tb_name.Text = book.Name;
            this.tb_name.ForeColor = Color.LightGray;
            this.tb_description.Text = book.Description;
            this.tb_description.ForeColor = Color.LightGray;
            this.numUpDown_count.Value = book.Count;

            pic_new_source_path = picture_event.Pic_source_file = book.Cover_path_file;
            pic_book.Image = main_page.Cover_image_list.Images[book.Book_id.ToString()];

            is_edit = true;

            this.BringToFront();
        }

        private void Add_Click_Func(bool is_edit)
        {
            description = tb_description.Text.Replace('\'', ' ');
            name        = (tb_name.Text.Trim()).Replace('\'', ' ');
            author      = cb_author.SelectedItem.ToString();
            publisher   = cb_publisher.SelectedItem.ToString();
            category    = cb_category.SelectedItem.ToString();
            shelf       = cb_shelf.SelectedItem.ToString();
            count       = (int)numUpDown_count.Value;
            date        =  DateTime.Now.ToString();
            pic_new_source_path = picture_event.Pic_source_file;

            lbl_message.Text = "";

            // Validations
            if (tb_name.Text.Trim() == "Book's Name" || tb_name.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter book's name.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }
            if(cb_author.SelectedIndex == 0)
            {
                lbl_message.Text = "* Please choose an author.";
                lbl_message.ForeColor = Color.Red;
                cb_author.Focus();
                return;
            }
            if (cb_publisher.SelectedIndex == 0)
            {
                lbl_message.Text = "* Please choose a publisher.";
                lbl_message.ForeColor = Color.Red;
                cb_publisher.Focus();
                return;
            }
            if (cb_category.SelectedIndex == 0)
            {
                lbl_message.Text = "* Please choose a category.";
                lbl_message.ForeColor = Color.Red;
                cb_category.Focus();
                return;
            }
            if (tb_description.Text == "Description..." || tb_description.Text == "")
            {
                lbl_message.Text = "* Please enter description.";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                return;
            }
            if (cb_shelf.SelectedIndex == 0)
            {
                lbl_message.Text = "* Please choose a shelf.";
                lbl_message.ForeColor = Color.Red;
                cb_shelf.Focus();
                return;
            }
            if (pic_new_source_path == null || pic_new_source_path == pic_default_file)
            {
                lbl_message.Text = "* Please choose a picture.";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                picture_event.Choose_Image();
                return;
            }
                Join_Tables();


            if(is_edit == false)
            {
                picture_event.Copy_The_Picture(name);
                pic_new_source_path = picture_event.Pic_source_file;
                /* ONEMLI */
                int librarian_id = 0;
                Book book = new Book(0, author_id, publisher_id, category_id, librarian_id, shelf_id, name, count, date, description, pic_new_source_path, 1, 0);
                book.Add();

                Clear();
            }
            else
            {
                if(change_image)
                {
                    Picture_Events.Delete_The_Picture(book_to_edit.Cover_path_file);
                    picture_event.Copy_The_Picture(name);
                    main_page.Remove_Image_From_Cover_List(book_to_edit.Book_id);
                    book_to_edit.Cover_path_file = picture_event.Pic_source_file;
                    book_to_edit.Cover_Pic_to_Image_List();
                    change_image = false;
                }

                lbl_message.Text = "*Book changed successfully";
                lbl_message.ForeColor = Color.LightGreen;

                book_to_edit.Author_id = author_id;
                book_to_edit.Publisher_id = publisher_id;
                book_to_edit.Category_id = category_id;
                book_to_edit.Shelf_id = shelf_id;
                book_to_edit.Count = count;
                book_to_edit.Name = name;
                book_to_edit.Description = description;
                
                book_to_edit.Edit();

                main_page.Pnl_book_list.VerticalScroll.Value = 0;
                main_page.Book_search_list.Delete_All_List();
                main_page.Main_book_list.Draw_All_Books();
                main_page.Book_searched_already = false;

                main_page.Main_shelf_list.Delete_All_List();
                Shelf.Show_All_Shelf(main_page);

            }

           

        }

        // Reads ID's from database
        private void Join_Tables()
        {
            DataTable dt = null;
            string que_author = string.Format("Select Authors.AUTHOR_ID from Authors where Authors.NAME = '{0}'", author);
            string que_publisher = string.Format("Select Publishers.PUBLISHER_ID from Publishers where Publishers.NAME = '{0}'", publisher);
            string que_category = string.Format("Select Categories.CATEGORY_ID from Categories where Categories.NAME = '{0}'", category);
            string que_shelf = string.Format("Select Shelves.SHELF_ID from Shelves where Shelves.NAME= '{0}'", shelf);


            dt = DataBaseEvents.ExecuteQuery(que_author, datasource);
            author_id = int.Parse(dt.Rows[0][0].ToString());
            dt = DataBaseEvents.ExecuteQuery(que_publisher, datasource);
            publisher_id = int.Parse(dt.Rows[0][0].ToString());
            dt = DataBaseEvents.ExecuteQuery(que_category, datasource);
            category_id = int.Parse(dt.Rows[0][0].ToString());
            dt = DataBaseEvents.ExecuteQuery(que_shelf, datasource);
            shelf_id = int.Parse(dt.Rows[0][0].ToString());

        }
        // Reads Authors, Publishers, Categories, Shelves from Database -- NEED TO CHANGE!!!!
        private void Fill_Comboboxes()
        {
            DataTable dt;
            string query = "";
            int i;
            int rows_count;

            
            query = string.Format("Select {0}.NAME From {0}", "Authors");
            dt = DataBaseEvents.ExecuteQuery(query, datasource);
            rows_count = dt.Rows.Count;
            if (rows_count <= 0)
            {
                return;
            }
            for (i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                cb_author.Items.Add(item);
            }
            cb_author.Items.Add("Add new Author");
            
            
            query = string.Format("Select {0}.NAME From {0}", "Publishers");
            dt = DataBaseEvents.ExecuteQuery(query, datasource);
            rows_count = dt.Rows.Count;
            if (rows_count <= 0)
            {
                return;
            }
            for (i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                cb_publisher.Items.Add(item);
            }

            cb_publisher.Items.Add("Add new Publisher");
            

            query = string.Format("Select {0}.NAME From {0}", "Categories");
            dt = DataBaseEvents.ExecuteQuery(query, datasource);
            rows_count = dt.Rows.Count;
            if (rows_count <= 0)
            {
                return;
            }
            for (i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                cb_category.Items.Add(item);
            }
            cb_category.Items.Add("Add new Category");


            query = string.Format("Select {0}.NAME From {0}", "Shelves");
            dt = DataBaseEvents.ExecuteQuery(query, datasource);
            rows_count = dt.Rows.Count;
            if (rows_count <= 0)
            {
                return;
            }
            for (i = 0; i < rows_count; i++)
            {
                string item = dt.Rows[i][0].ToString();
                cb_shelf.Items.Add(item);
            }
            cb_shelf.Items.Add("Add new Shelf");
        }
        // Clears all textboxes and comboboxes
        private void Clear()
        {
            this.cb_author.SelectedIndex = 0;
            this.cb_author.ForeColor = Color.Gray;
            this.cb_publisher.SelectedIndex = 0;
            this.cb_publisher.ForeColor = Color.Gray;
            this.cb_category.SelectedIndex = 0;
            this.cb_category.ForeColor = Color.Gray;
            this.cb_shelf.SelectedIndex = 0;
            this.cb_shelf.ForeColor = Color.Gray;
            tb_name.Text = "Book's Name";
            tb_name.ForeColor = Color.DimGray;
            tb_description.Text = "Description...";
            tb_description.ForeColor = Color.Gray;
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
             Add_Click_Func(is_edit);
        }
        private void Btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_Click_Func(is_edit);
            }

        }
        private void Change_Image_Click(object sender, EventArgs e)
        {
            change_image = true;
            picture_event.Choose_Image();
        }

        // TextBoxes Events

        private void tb_description_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_count_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tb_name_Enter(object sender, EventArgs e)
        {
            if (tb_name.Text == "Book's Name")
            {
                tb_name.Text = "";
                tb_name.ForeColor = Color.LightGray;
            }
        }
        private void tb_name_Leave(object sender, EventArgs e)
        {
            if (tb_name.Text == "")
            {
                tb_name.Text = "Book's Name";
                tb_name.ForeColor = Color.DimGray;
            }
        }
        private void tb_description_Enter(object sender, EventArgs e)
        {
            if (tb_description.Text == "Description...")
            {
                tb_description.Text = "";
                tb_description.ForeColor = Color.LightGray;
            }
        }
        private void tb_description_Leave(object sender, EventArgs e)
        {
            if (tb_description.Text == "")
            {
                tb_description.Text = "Description...";
                tb_description.ForeColor = Color.Gray;
            }
        }

        // Form closed - closing
        private void AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }
        private void AddBook_Load(object sender, EventArgs e)
        {
            this.Activate();
            this.tb_name.Select();
        }

        // Comboboxes Events
        private void Cb_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_index = cb_author.Items.Count - 1;

            if (cb_author.SelectedIndex == 0)
                cb_author.ForeColor = Color.Gray;

            else if (cb_author.SelectedIndex == last_index)
            {
                main_page.Create_Add_Author_Form();

                string query = string.Format("Select {0}.NAME From {0}", "Authors");
                DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
                int rows_count = dt.Rows.Count;

                if (rows_count <= 0)
                {
                    return;
                }

                cb_author.Items.Clear();

                cb_author.Items.Add("Author's Name");

                for (int i = 0; i < rows_count; i++)
                {
                    string item = dt.Rows[i][0].ToString();
                    cb_author.Items.Add(item);
                }
                cb_author.Items.Add("Add new Author");
                cb_author.SelectedIndex = 0;
            }

            else
                cb_author.ForeColor = Color.LightGray;
        }
        private void Cb_author_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            { }
            else if(e.KeyCode == Keys.Enter)
            {
                cb_author.SelectedIndex = cb_author.SelectedIndex;

            }
              else
                e.SuppressKeyPress = true;

        }
        private void Cb_publisher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_index = cb_publisher.Items.Count - 1;
            
            if (cb_publisher.SelectedIndex == 0)
                cb_publisher.ForeColor = Color.Gray;
            
            else if (cb_publisher.SelectedIndex == last_index) 
            { 
                main_page.Create_Add_Publisher_Form();
                
                string query = string.Format("Select {0}.NAME From {0}", "Publishers");
                DataTable dt = DataBaseEvents.ExecuteQuery(query, datasource);
                int rows_count = dt.Rows.Count;

                if(rows_count <= 0)
                {
                    return;
                }

                cb_publisher.Items.Clear();
                cb_publisher.Items.Add("Publisher's Name");

                for (int i = 0; i < rows_count; i++)
                {
                    string item = dt.Rows[i][0].ToString();
                    cb_publisher.Items.Add(item);
                }
                cb_publisher.Items.Add("Add new Publisher");
                cb_publisher.SelectedIndex = 0;
            }

            else
                cb_publisher.ForeColor = Color.LightGray;
        }
        private void Cb_publisher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            { }
            else if (e.KeyCode == Keys.Enter)
            {
                cb_publisher.SelectedIndex = cb_publisher.SelectedIndex;

            }
            else
                e.SuppressKeyPress = true;
        }
        private void Cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_index = cb_category.Items.Count - 1;

            if (cb_category.SelectedIndex == 0)
                cb_category.ForeColor = Color.Gray;
            else if (cb_category.SelectedIndex == last_index)
                MessageBox.Show("AddCategory Form");
            else
                cb_category.ForeColor = Color.LightGray;
        }
        private void Cb_category_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            { }
            else if (e.KeyCode == Keys.Enter)
            {
                cb_category.SelectedIndex = cb_category.SelectedIndex;

            }
            else
                e.SuppressKeyPress = true;
        }
        private void Cb_shelf_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_index = cb_shelf.Items.Count - 1;

            if (cb_shelf.SelectedIndex == 0)
                cb_shelf.ForeColor = Color.Gray;
            else if (cb_shelf.SelectedIndex == last_index)
                MessageBox.Show("AddShelf Form");
            else
                cb_shelf.ForeColor = Color.LightGray;
        }
        private void Cb_shelf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            { }
            else if (e.KeyCode == Keys.Enter)
            {
                cb_shelf.SelectedIndex = cb_shelf.SelectedIndex;

            }
            else
                e.SuppressKeyPress = true;
        }
        private void Cb_author_MouseClick(object sender, MouseEventArgs e)
        {
            cb_author.ForeColor = Color.LightGray;
        }
        private void Cb_publisher_MouseClick(object sender, MouseEventArgs e)
        {
            cb_publisher.ForeColor = Color.LightGray;
        }
        private void Cb_category_MouseClick(object sender, MouseEventArgs e)
        {
            cb_category.ForeColor = Color.LightGray;
        }
        private void Cb_shelf_MouseClick(object sender, MouseEventArgs e)
        {
            cb_shelf.ForeColor = Color.LightGray;
        }

        private void pnl_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
