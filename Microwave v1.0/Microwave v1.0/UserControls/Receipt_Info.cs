using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microwave_v1._0.Model;
using Microwave_v1._0.Forms;

namespace Microwave_v1._0.UserControls
{
    public partial class Receipt_Info : UserControl
    {

        private Microwave main_page = null;
        private Receipt_List main_list = null;
        private Receipt_Detail detail_form = null;

        private int receipt_id;
        private string receipt_name;
        private bool chosen = false;
        private Color color = Color.White;

        public int Receipt_id { get => receipt_id; set => receipt_id = value; }

        public Receipt_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            main_list = main_page.Main_receipt_list;
        }

        public void Initialize_Receipt_Info(int receipt_id, string receipt_name)
        {
            this.receipt_id = receipt_id;
            this.receipt_name = receipt_name;
            this.lbl_receipt_name.Text = receipt_name;
            this.lbl_receipt_id.Text = "#" + receipt_id.ToString();

            if (this.receipt_name == "CHECKED IN")
                this.color = Color.Gold;
            else if (this.receipt_name == "RETURN")
                this.color = Color.PaleGreen;
            else if (this.receipt_name == "PENALTY")
                this.color = Color.Red;

            this.lbl_receipt_name.ForeColor = color;
            this.lbl_receipt_id.ForeColor = color;
        }

        public void Hide_Info()
        {
            main_page.Pnl_receipt_list.Controls.Remove(this);
        }

        public void Draw_Receipt_Obj(ref int x, ref int y)
        {
            main_page.Pnl_receipt_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(x, y);
            if (x > 500)
            {
                y += 50;
                x = 25;
            }
            else
            {
                x += 240;
            }
        }

        public void Select_Receipt_Info()
        {
            chosen = true;

            Color back_color = Color.FromArgb(33, 37, 48);
            this.BackColor = back_color;
        }

        public void Deselect_Receipt_Info()
        {
            chosen = false;

            Color back_color = Color.FromArgb(55, 57, 68);
            this.BackColor = back_color;
        }

        public void Receipt_Info_Click(object sender, EventArgs e)
        {
            main_list.Deselect_All_Infos();
            main_page.Receipt_search_list.Deselect_All_Infos();
            this.Select_Receipt_Info();
        }

        public void Create_Receipt_Detail_Form(Receipt receipt, Book book, User user)
        {
            if (detail_form == null)
            {
                detail_form = new Receipt_Detail(receipt, book, user);
                detail_form.Show();
            }
            else
            {
                try
                {
                    detail_form.Show();
                }
                catch (Exception)
                {
                    detail_form = new Receipt_Detail(receipt, book, user);
                    detail_form.Show();
                }
            }

        }

        public void Receipt_Hover()
        {
            if(!chosen)
            {
                Color back_color = Color.FromArgb(43, 47, 58);
                this.BackColor = back_color;
            }
        }

        public void Receipt_Mouse_Leave()
        {
            if (!chosen)
            {
                Color back_color = Color.FromArgb(55,57,68);
                this.BackColor = back_color;
            }
        }

        private void Receipt_MouseLeave(object sender, EventArgs e)
        {
            Receipt_Mouse_Leave();
        }

        private void Receipt_MouseEnter(object sender, EventArgs e)
        {
            Receipt_Hover();
        }

        private void Receipt_Double_Click(object sender, EventArgs e)
        {
            Receipt current = main_list.Find_Receipt_By_ID(receipt_id);
            Book book = main_page.Main_book_list.Find_Book_By_ID(current.Book_id);
            User user = main_page.Main_user_list.Find_User_By_ID(current.User_id);
            Create_Receipt_Detail_Form(current, book, user);
        }

    }
}
