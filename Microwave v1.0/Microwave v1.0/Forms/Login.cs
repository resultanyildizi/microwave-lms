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
    public partial class Login : Form
    {
        private string email;
        private string password;
        SystemManager manager = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login_click();
        }


        private void btn_login_click()
        {
            email = this.tb_email.Text.Trim();
            password = this.tb_password.Text.Trim();

            if (email == "")
            {
                lbl_message.Text = "*Please enter a valid email";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            if (password == "")
            {
                lbl_message.Text = "*Please enter a valid password";
                lbl_message.ForeColor = Color.Red;
                return;
            }

            manager = SystemManager.Login(email, password);
            if (manager == null)
            {
                this.lbl_message.Text = "*Wrong email or password!";
                this.lbl_message.ForeColor = Color.Red;
                return;
            }
            else
            {
                MessageBox.Show("Login is successful. Please wait a while...","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Microwave microwave = new Microwave(manager);
            microwave.Show();
            this.Hide();
        }
        private void tb_email_Enter(object sender, EventArgs e)
        {
            if(this.tb_email.Text == "Email")
            {
                this.tb_email.Text = "";
                this.tb_email.ForeColor = Color.LightGray;
                return;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (this.tb_password.Text == "Password")
            {
                this.tb_password.Text = "";
                this.tb_password.ForeColor = Color.LightGray;
                return;
            }
        }

        private void tb_email_Leave(object sender, EventArgs e)
        {
            if (this.tb_email.Text == "")
            {
                this.tb_email.Text = "Email";
                this.tb_email.ForeColor = Color.Gray;
                return;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (this.tb_password.Text == "")
            {
                this.tb_password.Text = "Password";
                this.tb_password.ForeColor = Color.Gray;
                return;
            }
        }

        private void tb_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_login_click();
            }
        }
    }
}
