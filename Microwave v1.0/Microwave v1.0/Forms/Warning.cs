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
        private string message;
        private string password = "admin";
        private string email = "deneme@gmail.com";
        private Action method = null;
        public static Color Default_Color = Color.FromArgb(32, 33, 38);

        
        public string Message { get => message; set => message = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public Warning()
        {
            InitializeComponent();
            main_page = (Microwave)Application.OpenForms["Microwave"];
        }


        public void Initialize_Warning(string message, Action method, Color color)
        {
            this.BackColor = color;
            this.lbl_email.Text = email;
            this.message = message;
            this.lbl_message.Text = this.message;
            this.method = method;
            this.tb_password.Select();
        }

        private void Yes()
        {
            if (tb_password.Text == password)
            {
                method.Invoke();
                this.Close();
            }
            else
            {
                lbl_error.Text = "Password is incorrect.";
                lbl_error.ForeColor = Color.Red;
            }
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            Yes();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
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
