using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Forms;
using Microwave_v1._0.Classes;

namespace Microwave_v1._0.UserControls
{
    public partial class Author_Info : UserControl
    {
        private Microwave main_page;
        private Author_List author_list;
        private AddAuthor edit_form;

        private string name;
        private string pic_path_file;
        private int author_id;

        public int Author_id { get => author_id; set => author_id = value; }

        public Author_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            author_list = main_page.Main_author_list;
        }

        public void Initialize_Author_Info(string name, string pic_path_file)
        {
            this.name = name;
            this.pic_path_file = pic_path_file;
            this.lbl_author.Text = name;
            //this.pb_author.Image = main_page.Author_cover_image_list.Images[author_id.ToString()];
            this.pb_author.Image = Picture_Events.Get_Copy_Image_Bitmap(pic_path_file);
        }

        public void Draw_Author_Obj(ref int x, ref int y)
        {
            main_page.Pnl_author_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);
            
            if(x>500)
            {
                y += 240;
                x = 35;
            }
            else
            {
                x += 180;
            }
        }



    }
}
