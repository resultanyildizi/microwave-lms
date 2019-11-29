using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    partial class ShowEmployee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEmployee));
            this.pnl_emp_tag = new System.Windows.Forms.Panel();
            this.book_Tag1 = new Microwave_v1._0.Book_Tag();
            this.pnl_book = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_emp_surname = new System.Windows.Forms.Label();
            this.lbl_book_id = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_dep_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.pnl_seperater = new System.Windows.Forms.Panel();
            this.pnl_employee_list = new System.Windows.Forms.Panel();
            this.Cover_path_file = new System.Windows.Forms.ImageList(this.components);
            this.pnl_emp_tag.SuspendLayout();
            this.pnl_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_emp_tag
            // 
            this.pnl_emp_tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_emp_tag.Controls.Add(this.book_Tag1);
            this.pnl_emp_tag.Location = new System.Drawing.Point(799, -6);
            this.pnl_emp_tag.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_emp_tag.Name = "pnl_emp_tag";
            this.pnl_emp_tag.Size = new System.Drawing.Size(191, 523);
            this.pnl_emp_tag.TabIndex = 17;
            // 
            // book_Tag1
            // 
            this.book_Tag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(98)))), ((int)(((byte)(120)))));
            this.book_Tag1.Location = new System.Drawing.Point(2, 5);
            this.book_Tag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_Tag1.Name = "book_Tag1";
            this.book_Tag1.Size = new System.Drawing.Size(188, 517);
            this.book_Tag1.TabIndex = 0;
            // 
            // pnl_book
            // 
            this.pnl_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_book.Controls.Add(this.pictureBox1);
            this.pnl_book.Controls.Add(this.btn_add);
            this.pnl_book.Controls.Add(this.lbl_email);
            this.pnl_book.Controls.Add(this.lbl_emp_surname);
            this.pnl_book.Controls.Add(this.lbl_book_id);
            this.pnl_book.Controls.Add(this.lbl_book_name);
            this.pnl_book.Controls.Add(this.lbl_dep_name);
            this.pnl_book.Controls.Add(this.lbl_gender);
            this.pnl_book.Controls.Add(this.pnl_seperater);
            this.pnl_book.Controls.Add(this.pnl_employee_list);
            this.pnl_book.Location = new System.Drawing.Point(1, -6);
            this.pnl_book.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_book.Name = "pnl_book";
            this.pnl_book.Size = new System.Drawing.Size(803, 523);
            this.pnl_book.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(24, 446);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 44);
            this.btn_add.TabIndex = 21;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(424, 105);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(74, 26);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_emp_surname
            // 
            this.lbl_emp_surname.AutoSize = true;
            this.lbl_emp_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_emp_surname.Location = new System.Drawing.Point(268, 105);
            this.lbl_emp_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emp_surname.Name = "lbl_emp_surname";
            this.lbl_emp_surname.Size = new System.Drawing.Size(101, 26);
            this.lbl_emp_surname.TabIndex = 19;
            this.lbl_emp_surname.Text = "Surname";
            // 
            // lbl_book_id
            // 
            this.lbl_book_id.AutoSize = true;
            this.lbl_book_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id.ForeColor = System.Drawing.Color.White;
            this.lbl_book_id.Location = new System.Drawing.Point(90, 105);
            this.lbl_book_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_book_id.Name = "lbl_book_id";
            this.lbl_book_id.Size = new System.Drawing.Size(34, 26);
            this.lbl_book_id.TabIndex = 18;
            this.lbl_book_id.Text = "ID";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.ForeColor = System.Drawing.Color.White;
            this.lbl_book_name.Location = new System.Drawing.Point(158, 105);
            this.lbl_book_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(71, 26);
            this.lbl_book_name.TabIndex = 8;
            this.lbl_book_name.Text = "Name";
            // 
            // lbl_dep_name
            // 
            this.lbl_dep_name.AutoSize = true;
            this.lbl_dep_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_dep_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dep_name.ForeColor = System.Drawing.Color.White;
            this.lbl_dep_name.Location = new System.Drawing.Point(141, 35);
            this.lbl_dep_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dep_name.Name = "lbl_dep_name";
            this.lbl_dep_name.Size = new System.Drawing.Size(301, 39);
            this.lbl_dep_name.TabIndex = 4;
            this.lbl_dep_name.Text = "Department Name";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(618, 105);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(84, 26);
            this.lbl_gender.TabIndex = 12;
            this.lbl_gender.Text = "Gender";
            // 
            // pnl_seperater
            // 
            this.pnl_seperater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_seperater.Location = new System.Drawing.Point(24, 138);
            this.pnl_seperater.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_seperater.Name = "pnl_seperater";
            this.pnl_seperater.Size = new System.Drawing.Size(750, 1);
            this.pnl_seperater.TabIndex = 7;
            // 
            // pnl_employee_list
            // 
            this.pnl_employee_list.AutoScroll = true;
            this.pnl_employee_list.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.pnl_employee_list.Location = new System.Drawing.Point(77, 143);
            this.pnl_employee_list.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_employee_list.Name = "pnl_employee_list";
            this.pnl_employee_list.Size = new System.Drawing.Size(643, 357);
            this.pnl_employee_list.TabIndex = 14;
            // 
            // Cover_path_file
            // 
            this.Cover_path_file.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Cover_path_file.ImageSize = new System.Drawing.Size(16, 16);
            this.Cover_path_file.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(992, 514);
            this.Controls.Add(this.pnl_book);
            this.Controls.Add(this.pnl_emp_tag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            this.pnl_emp_tag.ResumeLayout(false);
            this.pnl_book.ResumeLayout(false);
            this.pnl_book.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_emp_tag;
        private System.Windows.Forms.Panel pnl_book;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_emp_surname;
        private System.Windows.Forms.Label lbl_book_id;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_dep_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Panel pnl_seperater;
        private System.Windows.Forms.Panel pnl_employee_list;
        private Button btn_add;
        private Book_Tag book_Tag1;
        private PictureBox pictureBox1;
        private ImageList Cover_path_file;

        public Panel Pnl_employee_list { get => pnl_employee_list; set => pnl_employee_list = value; }
    }
}