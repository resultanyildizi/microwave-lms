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
    public partial class AddBook : Form
    {
        private string name;
        private string author;
        private string publisher;
        private string date;
        private string count;
        private string description;
        private string pic_source_file;
        private string pic_dest_path = @"..\..\Resources\Book Covers\";
        private string pic_default_file = @"..\..\Resources\Book Covers\TheSunInHisEyes.jpg";
        Microwave main_page;
       

        public AddBook()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            System.IO.Directory.CreateDirectory(pic_dest_path);
            this.BringToFront();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Add_Book();
        }

        private void Add_Book()
        {
            name = tb_name.Text;
            author = tb_author.Text;
            publisher = tb_publisher.Text;
            date = tb_date.Text;
            //count = tb_count.Text;
            count = numUpDown_count.Value.ToString();
            description = tb_description.Text;

            //******************************\\

            lbl_message.Text = "";

            if (name == "")
            {
                lbl_message.Text = "* Please enter the title of the book. / book's name ?";
                lbl_message.ForeColor = Color.Red;
                tb_name.Focus();
                return;
            }

            if (author == "")
            {
                lbl_message.Text = "* Please enter the author's name.";
                lbl_message.ForeColor = Color.Red;
                tb_author.Focus();
                return;
            }

            if (publisher == "")
            {
                lbl_message.Text = "* Please enter the publisher's name.";
                lbl_message.ForeColor = Color.Red;
                tb_publisher.Focus();
                return;
            }
            
            if (description == "")
            {
                lbl_message.Text = "* Please enter the book's description";
                lbl_message.ForeColor = Color.Red;
                tb_description.Focus();
                return;
            }

            if (count == "")
            {
                lbl_message.Text = "* Please enter count of the book.";
                lbl_message.ForeColor = Color.Red;
                tb_count.Focus();
                return;
            }

            if (pic_source_file == null)
            {
                lbl_message.Text = "* Please add picture of the book.";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            //******************************\\

            Copy_The_Picture();
            Book book = new Book(name, author, publisher, date, description, count, pic_source_file);
            main_page.book_list.Add_Book_to_List(book);
            main_page.pnl_list.VerticalScroll.Value = 0;

            book.Info.Draw_Book_Obj(ref Book.point_y);


            main_page.book_list.Deselect_All_Book_Infos();
            book.Info.Select_Book_Info();

        }

        private void Change_Image_Click(object sender, EventArgs e)
        {
            OpenFileDialog choose_pic = new OpenFileDialog();
            choose_pic.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            choose_pic.ShowDialog();
            pic_source_file = choose_pic.FileName;


            try
            {
                this.pic_book.Load(pic_source_file);
            }catch(System.InvalidOperationException d)
            {
                pic_source_file = pic_default_file;
                this.pic_book.Load(pic_source_file);
            }
            
        }

        private void Copy_The_Picture()
        {
            string pic_target_file;
            string pic_name = name + ".jpg";


            //
            pic_target_file = System.IO.Path.Combine(pic_dest_path, pic_name);



            try
            {
                System.IO.File.Copy(pic_source_file, pic_target_file, true);
                pic_source_file = pic_target_file;
            }
            catch (System.ArgumentException d)
            {
                pic_source_file = pic_default_file;
                System.IO.File.Copy(pic_source_file, pic_target_file, true);
            }

            

        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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

        private void tb_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
    }
}
