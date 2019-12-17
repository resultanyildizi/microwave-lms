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
    public partial class Popularity_Form : Form
    {
        private string data_source = System.Configuration.ConfigurationManager.AppSettings["data_source"];
        private bool add_clicked = false;
        private bool edit_clicked = false;
        private OPERATION opr = OPERATION.ADD;

        private string name;
        private int score;
        private int id = -1;

        enum OPERATION
        {
            ADD, EDIT
        }
        public Popularity_Form()
        {
            InitializeComponent();
        }

        private void Popularity_Form_Load(object sender, EventArgs e)
        {
            this.dgw_popularity.Size = new Size(568, 220);
            this.dgw_popularity.DataSource = Popularity.Show_All_Popularities();
            this.pnl_operation.Hide();
            this.lbl_msg1.Text = "";
            this.lbl_msg2.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.dgw_popularity.Size = new Size(400, 220);
            edit_clicked = false;
            this.id = -1;
            if (!add_clicked)
            {
                this.pnl_operation.Show();
                opr = OPERATION.ADD;

                this.tb_name.Text = "";
                this.tb_score.Text = "";
            }
            else
            {
                this.pnl_operation.Hide();
                this.dgw_popularity.Size = new Size(568, 220);
            }
            add_clicked = !add_clicked;
            this.lbl_operation_title.Text = "ADD";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.dgw_popularity.Size = new Size(400, 220);
            add_clicked = false;

            if (!edit_clicked)
            {
                this.pnl_operation.Show();
                opr = OPERATION.EDIT;
            }
            else
            {
                this.pnl_operation.Hide();
                this.dgw_popularity.Size = new Size(568, 220);
            }
            edit_clicked = !edit_clicked;

            this.lbl_operation_title.Text = "EDIT";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.lbl_msg1.Text = "";
            this.lbl_msg2.Text = "";

            if(tb_name.Text.Trim() == "")
            {
                lbl_msg1.Text = "*Invalid";
                lbl_msg1.ForeColor = Color.Red;
                return;
            }
            if (tb_score.Text.Trim() == "")
            {
                lbl_msg2.Text = "*Invalid";
                lbl_msg2.ForeColor = Color.Red;
                return;
            }

            
            this.name = tb_name.Text.Trim();
            this.score = int.Parse(tb_score.Text.Trim());

            if (Popularity.Contains_Name(name) != this.id && Popularity.Contains_Name(name) != -1)
            {
                lbl_msg1.Text = "*Exist";
                lbl_msg1.ForeColor = Color.Red;
                return;
            }

            if (Popularity.Contains_Score(score) != this.id && Popularity.Contains_Score(score) != -1)
            {
                lbl_msg2.Text = "*Exist";
                lbl_msg2.ForeColor = Color.Red;
                return;
            }


            if (opr == OPERATION.ADD)
            {


                Popularity new_pop = new Popularity(0, name, score);
                new_pop.Add();

                dgw_popularity.DataSource = Popularity.Show_All_Popularities();
                new_pop = null;
            }
            else if(opr == OPERATION.EDIT)
            {
                
                Popularity curr_pop = new Popularity(id, name, score);
                curr_pop.Edit();
                dgw_popularity.DataSource = Popularity.Show_All_Popularities();
                curr_pop = null;
            }

        }

        private void dgw_popularity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row_index = e.RowIndex;

            if (row_index < 0)
                return;

            if (opr == OPERATION.EDIT)
            {
                this.id = int.Parse(dgw_popularity.Rows[row_index].Cells[0].Value.ToString());
                this.tb_name.Text = dgw_popularity.Rows[row_index].Cells[1].Value.ToString();
                this.tb_score.Text = dgw_popularity.Rows[row_index].Cells[2].Value.ToString();
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            Microwave main_page = (Microwave)Application.OpenForms["Microwave"];



            string msg = "Are you sure to delete a popularity type?";
            main_page.Create_Warning_Form(msg, Color.DarkRed);
           
            if(main_page.Warning_form.Result)
            {
                main_page.Warning_form.Refresh_Form();
                this.id = int.Parse(dgw_popularity.SelectedRows[0].Cells[0].Value.ToString());

                if (this.id == -1)
                    return;

                if (this.id == 0)
                {
                    MessageBox.Show("Default cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Popularity pop_delete = new Popularity(id, name, score);
                pop_delete.Delete();

                this.dgw_popularity.DataSource = Popularity.Show_All_Popularities();
            }
            main_page.Warning_form.Refresh_Form();


            return;
            
        }
    }
}
