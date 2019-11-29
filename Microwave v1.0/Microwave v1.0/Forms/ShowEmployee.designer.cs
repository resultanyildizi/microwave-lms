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
            this.pnl_employee = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lb_book_search = new System.Windows.Forms.ListBox();
            this.lbl_emp_surname = new System.Windows.Forms.Label();
            this.lbl_book_id = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.pnl_seperater = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_show_search_types = new System.Windows.Forms.Button();
            this.tb_search_user = new System.Windows.Forms.TextBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_dep_name = new System.Windows.Forms.Label();
            this.pnl_book_st = new System.Windows.Forms.Panel();
            this.lbl_search_by = new System.Windows.Forms.Label();
            this.rb_book_pop = new System.Windows.Forms.RadioButton();
            this.rb_book_shelf = new System.Windows.Forms.RadioButton();
            this.rb_book_category = new System.Windows.Forms.RadioButton();
            this.rb_book_publis = new System.Windows.Forms.RadioButton();
            this.rb_book_author = new System.Windows.Forms.RadioButton();
            this.rb_book_id = new System.Windows.Forms.RadioButton();
            this.rb_book_name = new System.Windows.Forms.RadioButton();
            this.pnl_employee_list = new System.Windows.Forms.Panel();
            this.Cover_path_file = new System.Windows.Forms.ImageList(this.components);
            this.pnl_emp_tag.SuspendLayout();
            this.pnl_employee.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.pnl_book_st.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_emp_tag
            // 
            this.pnl_emp_tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_emp_tag.Controls.Add(this.book_Tag1);
            this.pnl_emp_tag.Location = new System.Drawing.Point(736, 0);
            this.pnl_emp_tag.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_emp_tag.Name = "pnl_emp_tag";
            this.pnl_emp_tag.Size = new System.Drawing.Size(193, 517);
            this.pnl_emp_tag.TabIndex = 17;
            // 
            // book_Tag1
            // 
            this.book_Tag1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(98)))), ((int)(((byte)(120)))));
            this.book_Tag1.Location = new System.Drawing.Point(0, 0);
            this.book_Tag1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_Tag1.Name = "book_Tag1";
            this.book_Tag1.Size = new System.Drawing.Size(188, 554);
            this.book_Tag1.TabIndex = 0;
            // 
            // pnl_employee
            // 
            this.pnl_employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_employee.Controls.Add(this.btn_add);
            this.pnl_employee.Controls.Add(this.lbl_email);
            this.pnl_employee.Controls.Add(this.lb_book_search);
            this.pnl_employee.Controls.Add(this.lbl_emp_surname);
            this.pnl_employee.Controls.Add(this.lbl_book_id);
            this.pnl_employee.Controls.Add(this.lbl_book_name);
            this.pnl_employee.Controls.Add(this.lbl_gender);
            this.pnl_employee.Controls.Add(this.panel1);
            this.pnl_employee.Controls.Add(this.pnl_book_st);
            this.pnl_employee.Controls.Add(this.pnl_employee_list);
            this.pnl_employee.Controls.Add(this.pnl_seperater);
            this.pnl_employee.Location = new System.Drawing.Point(1, -6);
            this.pnl_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_employee.Name = "pnl_employee";
            this.pnl_employee.Size = new System.Drawing.Size(736, 523);
            this.pnl_employee.TabIndex = 18;
            this.pnl_employee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_book_Paint);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(665, 448);
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
            this.lbl_email.Location = new System.Drawing.Point(366, 117);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(74, 26);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "E-Mail";
            // 
            // lb_book_search
            // 
            this.lb_book_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_book_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book_search.ForeColor = System.Drawing.Color.White;
            this.lb_book_search.FormattingEnabled = true;
            this.lb_book_search.ItemHeight = 16;
            this.lb_book_search.Location = new System.Drawing.Point(489, 102);
            this.lb_book_search.Name = "lb_book_search";
            this.lb_book_search.Size = new System.Drawing.Size(235, 68);
            this.lb_book_search.TabIndex = 68;
            // 
            // lbl_emp_surname
            // 
            this.lbl_emp_surname.AutoSize = true;
            this.lbl_emp_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_emp_surname.Location = new System.Drawing.Point(210, 117);
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
            this.lbl_book_id.Location = new System.Drawing.Point(32, 117);
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
            this.lbl_book_name.Location = new System.Drawing.Point(100, 117);
            this.lbl_book_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(71, 26);
            this.lbl_book_name.TabIndex = 8;
            this.lbl_book_name.Text = "Name";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(550, 117);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(84, 26);
            this.lbl_gender.TabIndex = 12;
            this.lbl_gender.Text = "Gender";
            // 
            // pnl_seperater
            // 
            this.pnl_seperater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_seperater.Location = new System.Drawing.Point(14, 152);
            this.pnl_seperater.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_seperater.Name = "pnl_seperater";
            this.pnl_seperater.Size = new System.Drawing.Size(650, 1);
            this.pnl_seperater.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_show_search_types);
            this.panel1.Controls.Add(this.tb_search_user);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.lbl_dep_name);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 97);
            this.panel1.TabIndex = 0;
            // 
            // btn_show_search_types
            // 
            this.btn_show_search_types.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_show_search_types.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show_search_types.FlatAppearance.BorderSize = 0;
            this.btn_show_search_types.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_show_search_types.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_search_types.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_search_types.ForeColor = System.Drawing.Color.White;
            this.btn_show_search_types.Image = ((System.Drawing.Image)(resources.GetObject("btn_show_search_types.Image")));
            this.btn_show_search_types.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_show_search_types.Location = new System.Drawing.Point(457, 62);
            this.btn_show_search_types.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_search_types.Name = "btn_show_search_types";
            this.btn_show_search_types.Size = new System.Drawing.Size(26, 29);
            this.btn_show_search_types.TabIndex = 66;
            this.btn_show_search_types.UseVisualStyleBackColor = true;
            // 
            // tb_search_user
            // 
            this.tb_search_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_search_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_user.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_user.Location = new System.Drawing.Point(489, 65);
            this.tb_search_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search_user.Name = "tb_search_user";
            this.tb_search_user.Size = new System.Drawing.Size(235, 24);
            this.tb_search_user.TabIndex = 65;
            this.tb_search_user.Text = "Search a user";
            this.tb_search_user.TextChanged += new System.EventHandler(this.tb_search_user_TextChanged);
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(9, 7);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(92, 80);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 22;
            this.pic_logo.TabStop = false;
            // 
            // lbl_dep_name
            // 
            this.lbl_dep_name.AutoSize = true;
            this.lbl_dep_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lbl_dep_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_dep_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dep_name.ForeColor = System.Drawing.Color.White;
            this.lbl_dep_name.Location = new System.Drawing.Point(114, 31);
            this.lbl_dep_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dep_name.Name = "lbl_dep_name";
            this.lbl_dep_name.Size = new System.Drawing.Size(253, 33);
            this.lbl_dep_name.TabIndex = 4;
            this.lbl_dep_name.Text = "Department Name";
            // 
            // pnl_book_st
            // 
            this.pnl_book_st.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_book_st.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_book_st.Controls.Add(this.lbl_search_by);
            this.pnl_book_st.Controls.Add(this.rb_book_pop);
            this.pnl_book_st.Controls.Add(this.rb_book_shelf);
            this.pnl_book_st.Controls.Add(this.rb_book_category);
            this.pnl_book_st.Controls.Add(this.rb_book_publis);
            this.pnl_book_st.Controls.Add(this.rb_book_author);
            this.pnl_book_st.Controls.Add(this.rb_book_id);
            this.pnl_book_st.Controls.Add(this.rb_book_name);
            this.pnl_book_st.Location = new System.Drawing.Point(466, 102);
            this.pnl_book_st.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_book_st.Name = "pnl_book_st";
            this.pnl_book_st.Size = new System.Drawing.Size(261, 116);
            this.pnl_book_st.TabIndex = 67;
            // 
            // lbl_search_by
            // 
            this.lbl_search_by.AutoSize = true;
            this.lbl_search_by.ForeColor = System.Drawing.Color.White;
            this.lbl_search_by.Location = new System.Drawing.Point(3, 4);
            this.lbl_search_by.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_search_by.Name = "lbl_search_by";
            this.lbl_search_by.Size = new System.Drawing.Size(58, 13);
            this.lbl_search_by.TabIndex = 7;
            this.lbl_search_by.Text = "Search by:";
            // 
            // rb_book_pop
            // 
            this.rb_book_pop.AutoSize = true;
            this.rb_book_pop.ForeColor = System.Drawing.Color.White;
            this.rb_book_pop.Location = new System.Drawing.Point(133, 64);
            this.rb_book_pop.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_pop.Name = "rb_book_pop";
            this.rb_book_pop.Size = new System.Drawing.Size(71, 17);
            this.rb_book_pop.TabIndex = 6;
            this.rb_book_pop.TabStop = true;
            this.rb_book_pop.Text = "Popularity";
            this.rb_book_pop.UseVisualStyleBackColor = true;
            // 
            // rb_book_shelf
            // 
            this.rb_book_shelf.AutoSize = true;
            this.rb_book_shelf.ForeColor = System.Drawing.Color.White;
            this.rb_book_shelf.Location = new System.Drawing.Point(133, 42);
            this.rb_book_shelf.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_shelf.Name = "rb_book_shelf";
            this.rb_book_shelf.Size = new System.Drawing.Size(49, 17);
            this.rb_book_shelf.TabIndex = 5;
            this.rb_book_shelf.TabStop = true;
            this.rb_book_shelf.Text = "Shelf";
            this.rb_book_shelf.UseVisualStyleBackColor = true;
            // 
            // rb_book_category
            // 
            this.rb_book_category.AutoSize = true;
            this.rb_book_category.ForeColor = System.Drawing.Color.White;
            this.rb_book_category.Location = new System.Drawing.Point(133, 20);
            this.rb_book_category.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_category.Name = "rb_book_category";
            this.rb_book_category.Size = new System.Drawing.Size(67, 17);
            this.rb_book_category.TabIndex = 4;
            this.rb_book_category.TabStop = true;
            this.rb_book_category.Text = "Category";
            this.rb_book_category.UseVisualStyleBackColor = true;
            // 
            // rb_book_publis
            // 
            this.rb_book_publis.AutoSize = true;
            this.rb_book_publis.ForeColor = System.Drawing.Color.White;
            this.rb_book_publis.Location = new System.Drawing.Point(5, 86);
            this.rb_book_publis.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_publis.Name = "rb_book_publis";
            this.rb_book_publis.Size = new System.Drawing.Size(68, 17);
            this.rb_book_publis.TabIndex = 3;
            this.rb_book_publis.TabStop = true;
            this.rb_book_publis.Text = "Publisher";
            this.rb_book_publis.UseVisualStyleBackColor = true;
            // 
            // rb_book_author
            // 
            this.rb_book_author.AutoSize = true;
            this.rb_book_author.ForeColor = System.Drawing.Color.White;
            this.rb_book_author.Location = new System.Drawing.Point(5, 64);
            this.rb_book_author.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_author.Name = "rb_book_author";
            this.rb_book_author.Size = new System.Drawing.Size(56, 17);
            this.rb_book_author.TabIndex = 2;
            this.rb_book_author.TabStop = true;
            this.rb_book_author.Text = "Author";
            this.rb_book_author.UseVisualStyleBackColor = true;
            // 
            // rb_book_id
            // 
            this.rb_book_id.AutoSize = true;
            this.rb_book_id.ForeColor = System.Drawing.Color.White;
            this.rb_book_id.Location = new System.Drawing.Point(5, 42);
            this.rb_book_id.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_id.Name = "rb_book_id";
            this.rb_book_id.Size = new System.Drawing.Size(36, 17);
            this.rb_book_id.TabIndex = 1;
            this.rb_book_id.TabStop = true;
            this.rb_book_id.Text = "ID";
            this.rb_book_id.UseVisualStyleBackColor = true;
            // 
            // rb_book_name
            // 
            this.rb_book_name.AutoSize = true;
            this.rb_book_name.ForeColor = System.Drawing.Color.White;
            this.rb_book_name.Location = new System.Drawing.Point(5, 20);
            this.rb_book_name.Margin = new System.Windows.Forms.Padding(2);
            this.rb_book_name.Name = "rb_book_name";
            this.rb_book_name.Size = new System.Drawing.Size(53, 17);
            this.rb_book_name.TabIndex = 0;
            this.rb_book_name.TabStop = true;
            this.rb_book_name.Text = "Name";
            this.rb_book_name.UseVisualStyleBackColor = true;
            // 
            // pnl_employee_list
            // 
            this.pnl_employee_list.AutoScroll = true;
            this.pnl_employee_list.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.pnl_employee_list.Location = new System.Drawing.Point(18, 159);
            this.pnl_employee_list.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_employee_list.Name = "pnl_employee_list";
            this.pnl_employee_list.Size = new System.Drawing.Size(643, 333);
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
            this.ClientSize = new System.Drawing.Size(924, 514);
            this.Controls.Add(this.pnl_employee);
            this.Controls.Add(this.pnl_emp_tag);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowEmployee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            this.pnl_emp_tag.ResumeLayout(false);
            this.pnl_employee.ResumeLayout(false);
            this.pnl_employee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.pnl_book_st.ResumeLayout(false);
            this.pnl_book_st.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_emp_tag;
        private System.Windows.Forms.Panel pnl_employee;
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
        private ImageList Cover_path_file;
        private PictureBox pic_logo;
        private TextBox tb_search_user;
        private Panel panel1;
        private Button btn_show_search_types;
        private Panel pnl_book_st;
        private Label lbl_search_by;
        private RadioButton rb_book_pop;
        private RadioButton rb_book_shelf;
        private RadioButton rb_book_category;
        private RadioButton rb_book_publis;
        private RadioButton rb_book_author;
        private RadioButton rb_book_id;
        private RadioButton rb_book_name;
        private ListBox lb_book_search;

        public Panel Pnl_employee_list { get => pnl_employee_list; set => pnl_employee_list = value; }
    }
}