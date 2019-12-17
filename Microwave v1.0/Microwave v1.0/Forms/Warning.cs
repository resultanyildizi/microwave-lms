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


namespace Microwave_v1._0
{
    public partial class Warning : Form
    {
        private Microwave main_page;
        SystemManager manager = null;
        private string message;
        private bool result = false;
        public static Color Default_Color = Color.FromArgb(32, 33, 38);

        
        public string Message { get => message; set => message = value; }
        public bool Result { get => result; set => result = value; }

        public Warning(SystemManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            main_page = (Microwave)Application.OpenForms["Microwave"];
        }


        public void Initialize_Warning(string message, Color color)
        {
            this.BackColor = color;
            this.lbl_email.Text = manager.Email; ;
            this.message = message;
            this.lbl_message.Text = this.message;
            this.tb_password.Select();
        }

        private void Yes()
        {
            if (tb_password.Text == manager.Password)
            {
                result = true;
                this.Close();
            }
            else
            {
                result = false;
                lbl_error.Text = "Password is incorrect.";
                lbl_error.ForeColor = Color.Red;
            }
        }

        public void Refresh_Form()
        {
            this.tb_password.Text = "";
            this.lbl_message.Text = "";
            this.lbl_error.Text = "";
            this.result = false;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Yes();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            result = false;
            this.Close();
            
        }

        private void Tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Yes();
            }
        }
    }
}
