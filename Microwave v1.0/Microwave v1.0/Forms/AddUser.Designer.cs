namespace Microwave_v1._0
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.pnl_user_main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_user_email = new System.Windows.Forms.TextBox();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.numUpDown_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_user_message = new System.Windows.Forms.Label();
            this.lbl_user_age = new System.Windows.Forms.Label();
            this.lbl_user_email = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_user_gender = new System.Windows.Forms.Label();
            this.lbl_user_surname = new System.Windows.Forms.Label();
            this.tb_user_surname = new System.Windows.Forms.TextBox();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.tb_user_name = new System.Windows.Forms.TextBox();
            this.pnl_user_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_age)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_user_main
            // 
            this.pnl_user_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_user_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_user_main.Controls.Add(this.pictureBox1);
            this.pnl_user_main.Controls.Add(this.tb_user_email);
            this.pnl_user_main.Controls.Add(this.rb_female);
            this.pnl_user_main.Controls.Add(this.rb_male);
            this.pnl_user_main.Controls.Add(this.numUpDown_age);
            this.pnl_user_main.Controls.Add(this.lbl_user_message);
            this.pnl_user_main.Controls.Add(this.lbl_user_age);
            this.pnl_user_main.Controls.Add(this.lbl_user_email);
            this.pnl_user_main.Controls.Add(this.btn_add);
            this.pnl_user_main.Controls.Add(this.lbl_user_gender);
            this.pnl_user_main.Controls.Add(this.lbl_user_surname);
            this.pnl_user_main.Controls.Add(this.tb_user_surname);
            this.pnl_user_main.Controls.Add(this.lbl_user_name);
            this.pnl_user_main.Controls.Add(this.tb_user_name);
            this.pnl_user_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_user_main.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_user_main.Location = new System.Drawing.Point(0, -1);
            this.pnl_user_main.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_user_main.Name = "pnl_user_main";
            this.pnl_user_main.Size = new System.Drawing.Size(352, 327);
            this.pnl_user_main.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(290, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // tb_user_email
            // 
            this.tb_user_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_user_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_email.ForeColor = System.Drawing.Color.DimGray;
            this.tb_user_email.Location = new System.Drawing.Point(104, 113);
            this.tb_user_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user_email.Name = "tb_user_email";
            this.tb_user_email.Size = new System.Drawing.Size(218, 23);
            this.tb_user_email.TabIndex = 3;
            this.tb_user_email.Text = "Email";
            this.tb_user_email.Enter += new System.EventHandler(this.Tb_user_email_Enter);
            this.tb_user_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_user_email_KeyPress);
            this.tb_user_email.Leave += new System.EventHandler(this.Tb_user_email_Leave);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Location = new System.Drawing.Point(206, 155);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(59, 17);
            this.rb_female.TabIndex = 5;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Location = new System.Drawing.Point(104, 155);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(48, 17);
            this.rb_male.TabIndex = 4;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // numUpDown_age
            // 
            this.numUpDown_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.numUpDown_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUpDown_age.ForeColor = System.Drawing.Color.LightGray;
            this.numUpDown_age.Location = new System.Drawing.Point(104, 189);
            this.numUpDown_age.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_age.Name = "numUpDown_age";
            this.numUpDown_age.Size = new System.Drawing.Size(57, 26);
            this.numUpDown_age.TabIndex = 6;
            this.numUpDown_age.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numUpDown_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumUpDown_age_KeyPress);
            // 
            // lbl_user_message
            // 
            this.lbl_user_message.AutoSize = true;
            this.lbl_user_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_message.Location = new System.Drawing.Point(9, 9);
            this.lbl_user_message.Name = "lbl_user_message";
            this.lbl_user_message.Size = new System.Drawing.Size(0, 16);
            this.lbl_user_message.TabIndex = 24;
            // 
            // lbl_user_age
            // 
            this.lbl_user_age.AutoSize = true;
            this.lbl_user_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_age.ForeColor = System.Drawing.Color.White;
            this.lbl_user_age.Location = new System.Drawing.Point(9, 192);
            this.lbl_user_age.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_age.Name = "lbl_user_age";
            this.lbl_user_age.Size = new System.Drawing.Size(37, 18);
            this.lbl_user_age.TabIndex = 22;
            this.lbl_user_age.Text = "Age:";
            // 
            // lbl_user_email
            // 
            this.lbl_user_email.AutoSize = true;
            this.lbl_user_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_email.ForeColor = System.Drawing.Color.White;
            this.lbl_user_email.Location = new System.Drawing.Point(9, 114);
            this.lbl_user_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_email.Name = "lbl_user_email";
            this.lbl_user_email.Size = new System.Drawing.Size(49, 18);
            this.lbl_user_email.TabIndex = 18;
            this.lbl_user_email.Text = "Email:";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(10, 277);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 46);
            this.btn_add.TabIndex = 7;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_user_gender
            // 
            this.lbl_user_gender.AutoSize = true;
            this.lbl_user_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_user_gender.Location = new System.Drawing.Point(9, 153);
            this.lbl_user_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_gender.Name = "lbl_user_gender";
            this.lbl_user_gender.Size = new System.Drawing.Size(61, 18);
            this.lbl_user_gender.TabIndex = 13;
            this.lbl_user_gender.Text = "Gender:";
            // 
            // lbl_user_surname
            // 
            this.lbl_user_surname.AutoSize = true;
            this.lbl_user_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_user_surname.Location = new System.Drawing.Point(9, 75);
            this.lbl_user_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_surname.Name = "lbl_user_surname";
            this.lbl_user_surname.Size = new System.Drawing.Size(72, 18);
            this.lbl_user_surname.TabIndex = 11;
            this.lbl_user_surname.Text = "Surname:";
            // 
            // tb_user_surname
            // 
            this.tb_user_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_user_surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_surname.ForeColor = System.Drawing.Color.DimGray;
            this.tb_user_surname.Location = new System.Drawing.Point(104, 74);
            this.tb_user_surname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user_surname.Name = "tb_user_surname";
            this.tb_user_surname.Size = new System.Drawing.Size(218, 23);
            this.tb_user_surname.TabIndex = 2;
            this.tb_user_surname.Text = "Surname";
            this.tb_user_surname.Enter += new System.EventHandler(this.Tb_user_surname_Enter);
            this.tb_user_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_user_name_KeyPress);
            this.tb_user_surname.Leave += new System.EventHandler(this.Tb_user_surname_Leave);
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_user_name.Location = new System.Drawing.Point(9, 36);
            this.lbl_user_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_user_name.TabIndex = 9;
            this.lbl_user_name.Text = "Name:";
            // 
            // tb_user_name
            // 
            this.tb_user_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_user_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_user_name.Location = new System.Drawing.Point(104, 35);
            this.tb_user_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_user_name.Name = "tb_user_name";
            this.tb_user_name.Size = new System.Drawing.Size(218, 23);
            this.tb_user_name.TabIndex = 1;
            this.tb_user_name.Text = "Name";
            this.tb_user_name.Enter += new System.EventHandler(this.Tb_user_name_Enter);
            this.tb_user_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_user_name_KeyPress);
            this.tb_user_name.Leave += new System.EventHandler(this.Tb_user_name_Leave);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(352, 326);
            this.Controls.Add(this.pnl_user_main);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddUser";
            this.Opacity = 0.95D;
            this.Text = "AddUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddUser_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUser_FormClosed);
            this.pnl_user_main.ResumeLayout(false);
            this.pnl_user_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_age)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_user_main;
        private System.Windows.Forms.NumericUpDown numUpDown_age;
        private System.Windows.Forms.Label lbl_user_message;
        private System.Windows.Forms.Label lbl_user_age;
        private System.Windows.Forms.Label lbl_user_email;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_user_gender;
        private System.Windows.Forms.Label lbl_user_surname;
        private System.Windows.Forms.TextBox tb_user_surname;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.TextBox tb_user_name;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.TextBox tb_user_email;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}