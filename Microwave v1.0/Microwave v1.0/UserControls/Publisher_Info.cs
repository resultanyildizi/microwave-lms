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
    public partial class Publisher_Info : UserControl
    {
        private Microwave main_page;
        private Publisher_List main_pub_list;
        private Forms.AddPublisher edit_pub_form = null;

        private string pub_description;
        private string pub_name;
        private string pub_date_of_est;
        private string pub_pic_path_file;
        private bool chosen = false;
        private int publisher_id;
        public int Publisher_id { get => publisher_id; set => publisher_id = value; }
        public Publisher_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_pub_list = main_page.Main_pub_list;
            this.btn_pub_edit.Hide();
            this.btn_pub_remove.Hide();
        }
        public void Initialize_Publisher_Info(int publisher_id, string pub_name, string pub_date_of_est, string pub_pic_path_file)
        {
            this.publisher_id = publisher_id;
            this.lbl_pub_name.Text = pub_name;
            this.lbl_date_of_est.Text = pub_date_of_est;
            this.pub_name = pub_name;
            this.pub_date_of_est = pub_date_of_est;
            this.pub_pic_path_file = pub_pic_path_file;
        }


        public void Draw_Publisher_Obj(ref int y)
        {
            main_page.Pnl_pub_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(0, y);
            y += 45;
        }
        public void Select_Publisher_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            this.pnl_date_of_est.BackColor = back_color;
            this.pnl_pub_name.BackColor = back_color;

            this.btn_pub_edit.Show();
            this.btn_pub_remove.Show();

        }
        public void Deselect_Publisher_Info()
        {
            chosen = false;
            Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
            this.pnl_date_of_est.BackColor = back_color;
            this.pnl_pub_name.BackColor = back_color;
            this.btn_pub_edit.Hide();
            this.btn_pub_remove.Hide();
        }
        public void Publisher_Info_Click(object sender, EventArgs e)
        {
            main_pub_list.Deselect_All_Publisher_Infos();
            this.Select_Publisher_Info();
        }



        private void Publisher_Info_Load(object sender, EventArgs e)
        {

        }

        private void btn_pub_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_pub_remove_Click(object sender, EventArgs e)
        {

        }


        

   

        public void Pub_Hover()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);

                this.pnl_date_of_est.BackColor = back_color;
                this.pnl_pub_name.BackColor = back_color;
            }
        }
        private void Publisher_Info_Enter(object sender, EventArgs e)
        {
            Pub_Hover();
        }

        public void Pub_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = System.Drawing.Color.FromArgb(55, 57, 68); // light gray
                this.pnl_pub_name.BackColor = back_color;
                this.pnl_date_of_est.BackColor = back_color;
            }
        }
        private void lbl_pub_name_MouseLeave(object sender, EventArgs e)
        {
            Pub_Mouse_Leave();
        }
    }
}
