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
        private string date;
        private string description;
        private int count;
        Microwave main_page;


        Picture_Events picture_event;
        private string pic_default_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
        private string pic_dest_path = @"..\..\Resources\Book Covers\";


        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            picture_event = new Picture_Events(pic_dest_path, pic_default_file, ref this.pic_book);

            this.BringToFront();
        }

        private void Add_Book()
        {
           
            name = (tb_name.Text.Trim()).Replace('\'', ' ');
            author = (tb_author.Text.Trim()).Replace('\'', ' ');
            publisher = (tb_publisher.Text.Trim()).Replace('\'', ' ');
            date =  DateTime.Now.ToString();
            count = (int)numUpDown_count.Value;
            description = tb_description.Text.Replace('\'', ' ');


            lbl_message.Text = "";

            if (tb_name.Text.Trim() == "Book's Name" || tb_name.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter book's name.";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }

            if (tb_author.Text.Trim() == "Author's Name" || tb_author.Text.Trim() == "" )
            {
                lbl_message.Text = "* Please enter author's name.";
                lbl_message.ForeColor = Color.Red;
                tb_author.Focus();
                return;
            }

            if (tb_publisher.Text.Trim() == "Publisher's Name" || tb_publisher.Text.Trim() == "")
            {
                lbl_message.Text = "* Please enter publisher's name.";
                lbl_message.ForeColor = Color.Red;
                tb_publisher.Focus();
                return;
            }
            
            if (tb_description.Text == "Description..." || tb_description.Text == "")
            {
                lbl_message.Text = "* Please enter description.";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                return;
            }

            if(picture_event.Pic_source_file == null || picture_event.Pic_source_file == pic_default_file)
            {
                lbl_message.Text = "* Please choose a picture.";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                picture_event.Choose_Image();
                return;
            }

            picture_event.Copy_The_Picture(name);

            Create_New_Book_And_Set();
           
            Clear();

        }

        private void Clear()
        {
            tb_name.Text = "Book's Name";
            tb_name.ForeColor = Color.DimGray;
            tb_author.Text = "Author's Name";
            tb_author.ForeColor = Color.DimGray;
            tb_publisher.Text = "Publisher's Name";
            tb_publisher.ForeColor = Color.DimGray;
            tb_description.Text = "Description...";
            tb_description.ForeColor = Color.Gray;
            numUpDown_count.Value = 1;

            picture_event.Pic_source_file = pic_default_file;
            this.pic_book.Load(pic_default_file);
        }

        private void Create_New_Book_And_Set()
        {
            Book book = new Book(0,name, author, publisher, date, description, count, picture_event.Pic_source_file);

            book.Add_Book_To_Database();
            main_page.Main_list.Add_Book_to_List(book);

            book.Add_Picture_to_ImageList();

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
        private void tb_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_publisher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        private void tb_author_Enter(object sender, EventArgs e)
        {
            if (tb_author.Text == "Author's Name")
            {
                tb_author.Text = "";
                tb_author.ForeColor = Color.LightGray;
            }
        }

        private void tb_author_Leave(object sender, EventArgs e)
        {
            if (tb_author.Text == "")
            {
                tb_author.Text = "Author's Name";
                tb_author.ForeColor = Color.DimGray;
            }
        }
        private void tb_publisher_Enter(object sender, EventArgs e)
        {
            if (tb_publisher.Text == "Publisher's Name")
            {
                tb_publisher.Text = "";
                tb_publisher.ForeColor = Color.LightGray;
            }
        }

        private void tb_publisher_Leave(object sender, EventArgs e)
        {
            if (tb_publisher.Text == "")
            {
                tb_publisher.Text = "Publisher's Name";
                tb_publisher.ForeColor = Color.DimGray;
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

        private void AddBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            main_page.Btn_add.Enabled = true;
        }

    }
}
