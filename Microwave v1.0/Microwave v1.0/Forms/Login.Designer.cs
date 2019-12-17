namespace Microwave_v1._0.Forms
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_microwave_welcome = new System.Windows.Forms.Label();
            this.pb_welcome_logo = new System.Windows.Forms.PictureBox();
            this.lbl_microwae_welcome = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_welcome_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_microwave_welcome
            // 
            this.lbl_microwave_welcome.AutoEllipsis = true;
            this.lbl_microwave_welcome.AutoSize = true;
            this.lbl_microwave_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_microwave_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_microwave_welcome.Location = new System.Drawing.Point(591, 98);
            this.lbl_microwave_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_microwave_welcome.Name = "lbl_microwave_welcome";
            this.lbl_microwave_welcome.Size = new System.Drawing.Size(220, 46);
            this.lbl_microwave_welcome.TabIndex = 14;
            this.lbl_microwave_welcome.Text = "Microwave";
            this.lbl_microwave_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pb_welcome_logo
            // 
            this.pb_welcome_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_welcome_logo.Image")));
            this.pb_welcome_logo.Location = new System.Drawing.Point(355, 65);
            this.pb_welcome_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pb_welcome_logo.Name = "pb_welcome_logo";
            this.pb_welcome_logo.Size = new System.Drawing.Size(232, 191);
            this.pb_welcome_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_welcome_logo.TabIndex = 12;
            this.pb_welcome_logo.TabStop = false;
            // 
            // lbl_microwae_welcome
            // 
            this.lbl_microwae_welcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_microwae_welcome.ForeColor = System.Drawing.Color.White;
            this.lbl_microwae_welcome.Location = new System.Drawing.Point(594, 81);
            this.lbl_microwae_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_microwae_welcome.Name = "lbl_microwae_welcome";
            this.lbl_microwae_welcome.Size = new System.Drawing.Size(202, 233);
            this.lbl_microwae_welcome.TabIndex = 13;
            this.lbl_microwae_welcome.Text = "Library Management System";
            this.lbl_microwae_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(426, 357);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(49, 18);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email:";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.DimGray;
            this.tb_email.Location = new System.Drawing.Point(523, 355);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(218, 23);
            this.tb_email.TabIndex = 15;
            this.tb_email.Text = "Email";
            this.tb_email.Enter += new System.EventHandler(this.tb_email_Enter);
            this.tb_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_email_KeyPress);
            this.tb_email.Leave += new System.EventHandler(this.tb_email_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(426, 394);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(79, 18);
            this.lbl_password.TabIndex = 18;
            this.lbl_password.Text = "Password:";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.DimGray;
            this.tb_password.Location = new System.Drawing.Point(523, 392);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(218, 23);
            this.tb_password.TabIndex = 17;
            this.tb_password.Text = "Password";
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.Enter += new System.EventHandler(this.textBox1_Enter);
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_email_KeyPress);
            this.tb_password.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.Location = new System.Drawing.Point(696, 433);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(45, 34);
            this.btn_login.TabIndex = 19;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(520, 321);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 16);
            this.lbl_message.TabIndex = 25;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1199, 609);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_microwave_welcome);
            this.Controls.Add(this.lbl_microwae_welcome);
            this.Controls.Add(this.pb_welcome_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microwave";
            ((System.ComponentModel.ISupportInitialize)(this.pb_welcome_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_microwave_welcome;
        private System.Windows.Forms.PictureBox pb_welcome_logo;
        private System.Windows.Forms.Label lbl_microwae_welcome;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_message;
    }
}