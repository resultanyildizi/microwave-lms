using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0
{
    /* NOTE:
     * Book Info class shows information taken form Book Class's objects to user.
     * It is iherited from C# UserControl class.
     */
    public partial class Book_Info : UserControl
    {
        private Microwave main_page;
        private Book_List main_list;  
        
       
        private string description;
        private string name;
        private string author;
        private string pic_path_file;
        private bool chosen = false;
        private int book_id;

        public int Book_id { get => book_id; set => book_id = value; }

        public Book_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"]; 
            main_list = main_page.Main_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

       
        public void Initialize_Book_Info(int book_id, string name, string author, string publisher, string date, int count, string description, string pic_path_file)
        {
            this.book_id = book_id;
            this.lbl_name.Text = name;
            this.lbl_author.Text = author;
            this.lbl_publisher.Text = publisher;
            this.lbl_date.Text = date;
            this.lbl_count.Text = count.ToString();
            this.description = description;
            this.author = author;
            this.name = name;
            this.pic_path_file = pic_path_file;
        }

        
        public void Draw_Book_Obj(ref int y)
        {
            main_page.Pnl_book_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }


       
        public void Book_Info_Click(object sender, EventArgs e)
        {
            main_list.Deselect_All_Book_Infos(); 
            this.Select_Book_Info(); 
        }

       
        public void Select_Book_Info()
        {
            chosen = true;
            Book_Tag main_book_tag = main_page.Book_tag;
         
            Color back_color = Color.FromArgb(33, 37, 48);
            main_book_tag.Edit_Book_Tag(name, description, author, book_id.ToString());
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;

            this.btn_edit.Show();
            this.btn_remove.Show();

        }

        public void Deselect_Book_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

        public void Hover()
        {
            if(!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);

                this.pnl_author.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_date.BackColor = back_color;
                this.pnl_count.BackColor = back_color;
                this.pnl_publisher.BackColor = back_color;

            }
        }


        public void Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.pnl_author.BackColor = back_color;
                this.pnl_name.BackColor = back_color;
                this.pnl_date.BackColor = back_color;
                this.pnl_count.BackColor = back_color;
                this.pnl_publisher.BackColor = back_color;
            }
        }
        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete a book?";
            Action method = Remove;
            main_page.Create_Warning_Form(message, method, Color.DarkRed);
        }

        private void Remove()
        {
            main_page.Cover_image_list.Images[book_id.ToString()].Dispose();
            main_page.Cover_image_list.Images.RemoveByKey(Book_id.ToString());
            main_page.Book_tag.Edit_Book_Tag("Select A Book to Show", "Select A Book to Show", "", "0");
            main_list.Delete_Book_from_List(book_id);
            this.Dispose();

            main_page.Pnl_book_list.VerticalScroll.Value = 0;
            Book.point_y = 5;
            main_list.Show_All_Books();
        }

        private void Book_Info_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Delete)
            {
                string message = "Do you want to delete a book?";
                Action method = Remove;
                main_page.Create_Warning_Form(message, method, Color.DarkRed);
            }
        }

        private void Book_Info_Enter(object sender, EventArgs e)
        {
            Hover();
        }

        private void Pnl_name_MouseLeave(object sender, EventArgs e)
        {
            Mouse_Leave();
        }

    }
}
