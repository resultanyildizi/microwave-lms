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

        private string datasource = @"data source = ..\..\Resources\Databases\LMS_Database.db";


        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);

            // Make comboboxes default
            this.cb_author.SelectedIndex = 0;
            this.cb_publisher.SelectedIndex = 0;
            this.cb_category.SelectedIndex = 0;
            this.cb_shelf.SelectedIndex = 0;

            // Read Authors, Publishers, Categories, Shelves from Database
            Fill_Comboboxes();


            this.BringToFront();
        }

        private void Add_Book()
        {
            description = tb_description.Text.Replace('\'', ' ');
            name        = (tb_name.Text.Trim()).Replace('\'', ' ');
            author      = cb_author.SelectedItem.ToString();
            publisher   = cb_publisher.SelectedItem.ToString();
            category    = cb_category.SelectedItem.ToString();
            shelf       = cb_shelf.SelectedItem.ToString();
            count       = (int)numUpDown_count.Value;
            date        =  DateTime.Now.ToString();

            lbl_message.Text = "";

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

            if (picture_event.Pic_source_file == null || picture_event.Pic_source_file == pic_default_file)
            {
                lbl_message.Text = "* Please choose a picture.";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                picture_event.Choose_Image();
                return;
            }

            picture_event.Copy_The_Picture(name);

            Join_Tables();

            Create_New_Book_And_Set();
           
            Clear();

        }

        // Reads ID's from database
        private void Join_Tables()
        {
            string que_author = string.Format("Select Authors.AUTHOR_ID from Authors where Authors.NAME = '{0}'", author);
            string que_publisher = string.Format("Select Publishers.PUBLISHER_ID from Publishers where Publishers.NAME = '{0}'", publisher);
            string que_category = string.Format("Select Categories.CATEGORY_ID from Categories where Categories.NAME = '{0}'", category);
            string que_shelf = string.Format("Select Shelves.SHELF_ID from Shelves where Shelves.NAME= '{0}'", shelf);

            author_id = DataBaseEvents.ExecuteQuery_Int32(que_author, datasource);
            publisher_id = DataBaseEvents.ExecuteQuery_Int32(que_publisher, datasource);
            category_id = DataBaseEvents.ExecuteQuery_Int32(que_category, datasource);
            shelf_id = DataBaseEvents.ExecuteQuery_Int32(que_shelf, datasource);

        }
        // Reads Authors, Publishers, Categories, Shelves from Database 
        private void Fill_Comboboxes()
        {
            SQLiteConnection con = new SQLiteConnection(datasource);
            SQLiteCommand cmd = null;
            SQLiteDataReader reader = null;
            string query = "";



            con.Open();
            query = string.Format("Select {0}.NAME From {0}", "Authors");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_author.Items.Add(reader.GetString(0));
            }
            cb_author.Items.Add("Add new Author");
            cmd.Dispose();
            
            query = string.Format("Select {0}.NAME From {0}", "Publishers");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_publisher.Items.Add(reader.GetString(0));
            }
            cb_publisher.Items.Add("Add new Publisher");
            cmd.Dispose();

            query = string.Format("Select {0}.NAME From {0}", "Categories");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_category.Items.Add(reader.GetString(0));
            }
            cb_category.Items.Add("Add new Category");

            cmd.Dispose();

            query = string.Format("Select {0}.NAME From {0}", "Shelves");
            cmd = new SQLiteCommand(query, con);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb_shelf.Items.Add(reader.GetString(0));
            }
            cb_shelf.Items.Add("Add new Shelf");
            cmd.Dispose();
            con.Close();
        }

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
        }


        private void Create_New_Book_And_Set()
        {
            /* ONEMLI */
            int librarian_id = 0;
            Book book = new Book(0, author_id, publisher_id, category_id, librarian_id, shelf_id, name, count, date, description, picture_event.Pic_source_file, 1, 0);
            book.Add_Book_To_Database();
            book.Add_Cover_Pic_to_Image_List();

            main_page.Main_list.Add_Book_to_List(book);
            main_page.Pnl_book_list.VerticalScroll.Value = 0;

            book.Info.Draw_Book_Obj(ref Book.point_y);

            main_page.Main_list.Deselect_All_Book_Infos();
            book.Info.Select_Book_Info();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add_Book();
        }

        private void Btn_add_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Add_Book();
            }

        }

        private void Change_Image_Click(object sender, EventArgs e)
        {
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

        private void Cb_author_SelectedIndexChanged(object sender, EventArgs e)
        {
            int last_index = cb_author.Items.Count - 1;

            if (cb_author.SelectedIndex == 0)
                cb_author.ForeColor = Color.Gray;
            else if(cb_author.SelectedIndex == last_index)
                MessageBox.Show("AddAuthor Form");
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
                MessageBox.Show("AddPublisher Form");
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

    }
}
