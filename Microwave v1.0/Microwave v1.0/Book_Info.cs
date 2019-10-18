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

        public Book_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"]; 
            main_list = main_page.main_list;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

       
        public void Initialize_Book_Info(string name, string author, string publisher, string date, int count, string description, string pic_path_file)
        {
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
            main_page.pnl_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }


       
        public void Book_Info_Click(object sender, EventArgs e)
        {
            main_list.Deselect_All_Book_Infos(); 
            this.Select_Book_Info(); 
            this.Focus();
        }

       
        public void Select_Book_Info()
        {
            Book_Tag main_book_tag = main_page.Book_tag;
         
            Color back_color = Color.FromArgb(33, 37, 48);
            main_book_tag.Edit_Book_Tag(name, description, author, pic_path_file);
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
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.pnl_author.BackColor = back_color;
            this.pnl_name.BackColor = back_color;
            this.pnl_date.BackColor = back_color;
            this.pnl_count.BackColor = back_color;
            this.pnl_publisher.BackColor = back_color;
            this.btn_edit.Hide();
            this.btn_remove.Hide();
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
