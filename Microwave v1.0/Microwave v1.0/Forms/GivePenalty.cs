using Microwave_v1._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    public partial class GivePenalty : Form
    {
        private Microwave main_page = null;
        SystemManager manager = null;
        Detail detail_form;
        private string pt_name;
        private int fee;
        private Book book;
        private User user;

        private bool add_clicked = true;
        
        public GivePenalty(SystemManager manager, Detail dt_form, Book book, User user)
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            Fill_Combobox();
            this.cb_penalties.SelectedIndex = 0;

            this.manager = manager;
            this.detail_form = dt_form;
            this.book = book;
            this.user = user;
        }

        private void GivePenalty_Load(object sender, EventArgs e)
        {
            this.dgw_penalties.Size = new Size(400, 220);
            this.dgw_penalties.DataSource = user.Show_All_Penalties();
            this.pnl_operation.Show();
            this.lbl_book_name.Text = "For " + book.Name;
        }

        private void Fill_Combobox()
        {
            Dictionary<string, int> penalty_types = main_page.Penalty_types;

            int count = penalty_types.Keys.Count;
            string[] items = new string[count];
            penalty_types.Keys.CopyTo(items, 0);

            for(int i = 0; i < count; i++)
            {
                this.cb_penalties.Items.Add(items[i]);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {


            if (!add_clicked)
            {
                this.dgw_penalties.Size = new Size(400, 220);
                this.pnl_operation.Show();
            }
            else
            {
                this.pnl_operation.Hide();
                this.dgw_penalties.Size = new Size(568, 220);
            }
            add_clicked = !add_clicked;
            this.lbl_operation_title.Text = "ADD";
        }

        private void cb_penalties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, int> penalty_types = main_page.Penalty_types;

            string item = cb_penalties.SelectedItem.ToString();
            this.tb_fee.Text = penalty_types[item].ToString();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            string msg = "Are you sure to give a penalty?";
            main_page.Create_Warning_Form(msg, Color.DarkRed);

            if (main_page.Warning_form.Result)
            {
                this.pt_name = cb_penalties.SelectedItem.ToString().Trim();
                this.fee = int.Parse(this.tb_fee.Text.Trim());
                Receipt new_penalty = new Penalty(0, book.Book_id, user.User_id, manager.Employee_id, pt_name, fee);
                manager.Give_Penalty_To_User(user, book, new_penalty, detail_form);
                this.dgw_penalties.DataSource = user.Show_All_Penalties();
            }

            main_page.Warning_form.Refresh_Form();
        }
    }
}
