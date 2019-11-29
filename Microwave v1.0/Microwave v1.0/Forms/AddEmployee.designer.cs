namespace Microwave_v1._0.Forms
{
    partial class AddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.lbl_birthdate = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_employee = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.lbl_department = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // rdo_female
            // 
            this.rdo_female.AutoSize = true;
            this.rdo_female.ForeColor = System.Drawing.SystemColors.Window;
            this.rdo_female.Location = new System.Drawing.Point(210, 106);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(59, 17);
            this.rdo_female.TabIndex = 65;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "Female";
            this.rdo_female.UseVisualStyleBackColor = true;
            // 
            // rdo_male
            // 
            this.rdo_male.AutoSize = true;
            this.rdo_male.ForeColor = System.Drawing.SystemColors.Window;
            this.rdo_male.Location = new System.Drawing.Point(105, 106);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(48, 17);
            this.rdo_male.TabIndex = 64;
            this.rdo_male.TabStop = true;
            this.rdo_male.Text = "Male";
            this.rdo_male.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(12, 106);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(61, 18);
            this.lbl_gender.TabIndex = 63;
            this.lbl_gender.Text = "Gender:";
            // 
            // tb_surname
            // 
            this.tb_surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surname.ForeColor = System.Drawing.Color.DimGray;
            this.tb_surname.Location = new System.Drawing.Point(106, 70);
            this.tb_surname.Margin = new System.Windows.Forms.Padding(2);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(223, 23);
            this.tb_surname.TabIndex = 62;
            this.tb_surname.Text = "Employee\'s Surname";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_surname.Location = new System.Drawing.Point(12, 70);
            this.lbl_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(72, 18);
            this.lbl_surname.TabIndex = 61;
            this.lbl_surname.Text = "Surname:";
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(24, 9);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 16);
            this.lbl_message.TabIndex = 60;
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(334, 150);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(47, 42);
            this.btn_add_pic.TabIndex = 59;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.btn_add_pic_Click);
            // 
            // lbl_birthdate
            // 
            this.lbl_birthdate.AutoSize = true;
            this.lbl_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birthdate.ForeColor = System.Drawing.Color.White;
            this.lbl_birthdate.Location = new System.Drawing.Point(12, 140);
            this.lbl_birthdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_birthdate.Name = "lbl_birthdate";
            this.lbl_birthdate.Size = new System.Drawing.Size(43, 18);
            this.lbl_birthdate.TabIndex = 58;
            this.lbl_birthdate.Text = "Date:";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.correct_symbol__1_;
            this.btn_add.Location = new System.Drawing.Point(383, 189);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 46);
            this.btn_add.TabIndex = 57;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_employee
            // 
            this.pic_employee.Image = ((System.Drawing.Image)(resources.GetObject("pic_employee.Image")));
            this.pic_employee.Location = new System.Drawing.Point(338, 11);
            this.pic_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pic_employee.Name = "pic_employee";
            this.pic_employee.Size = new System.Drawing.Size(100, 137);
            this.pic_employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_employee.TabIndex = 56;
            this.pic_employee.TabStop = false;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(12, 30);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_name.TabIndex = 55;
            this.lbl_name.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_name.Location = new System.Drawing.Point(106, 30);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(223, 23);
            this.tb_name.TabIndex = 53;
            this.tb_name.Text = "Employee\'s Name";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(12, 169);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(54, 18);
            this.lbl_email.TabIndex = 66;
            this.lbl_email.Text = "E-Mail:";
            // 
            // tb_email
            // 
            this.tb_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.ForeColor = System.Drawing.Color.DimGray;
            this.tb_email.Location = new System.Drawing.Point(106, 169);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(223, 23);
            this.tb_email.TabIndex = 67;
            this.tb_email.Text = "Employee\'s E-mail";
            // 
            // dtp_time
            // 
            this.dtp_time.Location = new System.Drawing.Point(106, 138);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(223, 20);
            this.dtp_time.TabIndex = 69;
            // 
            // cb_department
            // 
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Location = new System.Drawing.Point(106, 203);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(223, 21);
            this.cb_department.TabIndex = 70;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_department.ForeColor = System.Drawing.Color.White;
            this.lbl_department.Location = new System.Drawing.Point(12, 206);
            this.lbl_department.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(89, 18);
            this.lbl_department.TabIndex = 71;
            this.lbl_department.Text = "Department:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(446, 239);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.cb_department);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.rdo_female);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.tb_surname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_add_pic);
            this.Controls.Add(this.lbl_birthdate);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_employee);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.tb_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pic_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox tb_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Label lbl_birthdate;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_employee;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label lbl_department;
    }
}