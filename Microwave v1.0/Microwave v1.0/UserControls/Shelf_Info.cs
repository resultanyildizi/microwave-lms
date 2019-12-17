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
using Microwave_v1._0.Model;

namespace Microwave_v1._0.UserControls
{
    public partial class Shelf_Info : UserControl
    {
        private Microwave main_page;


        private int shelf_id;
        private string shelf_name;

        public int Shelf_id { get => shelf_id; set => shelf_id = value; }

        public Shelf_Info()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
            this.pnl_book_detail.Hide();

        }

        public void Initialize_Shelf_Info(int shelf_id, string shelf_name)
        {
            this.shelf_id = shelf_id;
            this.shelf_name = shelf_name;
            this.btn_shelf_id.Text = shelf_id.ToString();
            this.lbl_name.Text = "#" + shelf_name;
        }

        public void Draw_Shelf_Obj(ref int y)
        {
            main_page.Pnl_shelf_list.Controls.Add(this);
            this.Location = new System.Drawing.Point(22, y);
            y += 150;
        }

        private void Shelf_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
