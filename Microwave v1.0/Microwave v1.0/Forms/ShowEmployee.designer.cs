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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowEmployee));
            this.pnl_emp_tag = new System.Windows.Forms.Panel();
            this.emp_tag = new Microwave_v1._0.Book_Tag();
            this.pnl_employee = new System.Windows.Forms.Panel();
            this.pnl_names = new System.Windows.Forms.Panel();
            this.lbl_dprt_name = new System.Windows.Forms.Label();
            this.lbl_employee_id = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_employee_name = new System.Windows.Forms.Label();
            this.lbl_emp_surname = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_top_side = new System.Windows.Forms.Panel();
            this.btn_show_search_types = new System.Windows.Forms.Button();
            this.tb_search_emp = new System.Windows.Forms.TextBox();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_dep_name = new System.Windows.Forms.Label();
            this.pnl_employee_list = new System.Windows.Forms.Panel();
            this.pnl_seperater = new System.Windows.Forms.Panel();
            this.pnl_emp_st = new System.Windows.Forms.Panel();
            this.lbl_search_by = new System.Windows.Forms.Label();
            this.rb_department = new System.Windows.Forms.RadioButton();
            this.rb_email = new System.Windows.Forms.RadioButton();
            this.rb_gender = new System.Windows.Forms.RadioButton();
            this.rb_emp_id = new System.Windows.Forms.RadioButton();
            this.rb_emp_name = new System.Windows.Forms.RadioButton();
            this.lb_emp_search = new System.Windows.Forms.ListBox();
            this.pnl_emp_tag.SuspendLayout();
            this.pnl_employee.SuspendLayout();
            this.pnl_names.SuspendLayout();
            this.pnl_top_side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.pnl_emp_st.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_emp_tag
            // 
            this.pnl_emp_tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_emp_tag.Controls.Add(this.emp_tag);
            this.pnl_emp_tag.Location = new System.Drawing.Point(792, 0);
            this.pnl_emp_tag.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_emp_tag.Name = "pnl_emp_tag";
            this.pnl_emp_tag.Size = new System.Drawing.Size(199, 548);
            this.pnl_emp_tag.TabIndex = 17;
            // 
            // emp_tag
            // 
            this.emp_tag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(98)))), ((int)(((byte)(120)))));
            this.emp_tag.Location = new System.Drawing.Point(0, 0);
            this.emp_tag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emp_tag.Name = "emp_tag";
            this.emp_tag.Size = new System.Drawing.Size(187, 549);
            this.emp_tag.TabIndex = 0;
            // 
            // pnl_employee
            // 
            this.pnl_employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_employee.Controls.Add(this.pnl_names);
            this.pnl_employee.Controls.Add(this.btn_add);
            this.pnl_employee.Controls.Add(this.pnl_top_side);
            this.pnl_employee.Controls.Add(this.pnl_employee_list);
            this.pnl_employee.Controls.Add(this.pnl_seperater);
            this.pnl_employee.Controls.Add(this.pnl_emp_st);
            this.pnl_employee.Location = new System.Drawing.Point(1, -6);
            this.pnl_employee.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_employee.Name = "pnl_employee";
            this.pnl_employee.Size = new System.Drawing.Size(793, 554);
            this.pnl_employee.TabIndex = 18;
            this.pnl_employee.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_book_Paint);
            // 
            // pnl_names
            // 
            this.pnl_names.BackColor = System.Drawing.Color.Transparent;
            this.pnl_names.Controls.Add(this.lbl_dprt_name);
            this.pnl_names.Controls.Add(this.lbl_employee_id);
            this.pnl_names.Controls.Add(this.lbl_gender);
            this.pnl_names.Controls.Add(this.lbl_email);
            this.pnl_names.Controls.Add(this.lbl_employee_name);
            this.pnl_names.Controls.Add(this.lbl_emp_surname);
            this.pnl_names.Location = new System.Drawing.Point(19, 118);
            this.pnl_names.Name = "pnl_names";
            this.pnl_names.Size = new System.Drawing.Size(745, 32);
            this.pnl_names.TabIndex = 0;
            // 
            // lbl_dprt_name
            // 
            this.lbl_dprt_name.AutoSize = true;
            this.lbl_dprt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dprt_name.ForeColor = System.Drawing.Color.White;
            this.lbl_dprt_name.Location = new System.Drawing.Point(577, 4);
            this.lbl_dprt_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dprt_name.Name = "lbl_dprt_name";
            this.lbl_dprt_name.Size = new System.Drawing.Size(126, 26);
            this.lbl_dprt_name.TabIndex = 13;
            this.lbl_dprt_name.Text = "Department";
            // 
            // lbl_employee_id
            // 
            this.lbl_employee_id.AutoSize = true;
            this.lbl_employee_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_id.ForeColor = System.Drawing.Color.White;
            this.lbl_employee_id.Location = new System.Drawing.Point(19, 4);
            this.lbl_employee_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employee_id.Name = "lbl_employee_id";
            this.lbl_employee_id.Size = new System.Drawing.Size(34, 26);
            this.lbl_employee_id.TabIndex = 18;
            this.lbl_employee_id.Text = "ID";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(442, 3);
            this.lbl_gender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(84, 26);
            this.lbl_gender.TabIndex = 12;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(326, 4);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(74, 26);
            this.lbl_email.TabIndex = 20;
            this.lbl_email.Text = "E-Mail";
            // 
            // lbl_employee_name
            // 
            this.lbl_employee_name.AutoSize = true;
            this.lbl_employee_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_employee_name.ForeColor = System.Drawing.Color.White;
            this.lbl_employee_name.Location = new System.Drawing.Point(89, 4);
            this.lbl_employee_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_employee_name.Name = "lbl_employee_name";
            this.lbl_employee_name.Size = new System.Drawing.Size(71, 26);
            this.lbl_employee_name.TabIndex = 8;
            this.lbl_employee_name.Text = "Name";
            // 
            // lbl_emp_surname
            // 
            this.lbl_emp_surname.AutoSize = true;
            this.lbl_emp_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_emp_surname.Location = new System.Drawing.Point(181, 4);
            this.lbl_emp_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emp_surname.Name = "lbl_emp_surname";
            this.lbl_emp_surname.Size = new System.Drawing.Size(101, 26);
            this.lbl_emp_surname.TabIndex = 19;
            this.lbl_emp_surname.Text = "Surname";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(9, 497);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 44);
            this.btn_add.TabIndex = 21;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_top_side
            // 
            this.pnl_top_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_top_side.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_top_side.Controls.Add(this.btn_show_search_types);
            this.pnl_top_side.Controls.Add(this.tb_search_emp);
            this.pnl_top_side.Controls.Add(this.pic_logo);
            this.pnl_top_side.Controls.Add(this.lbl_dep_name);
            this.pnl_top_side.Location = new System.Drawing.Point(2, 5);
            this.pnl_top_side.Name = "pnl_top_side";
            this.pnl_top_side.Size = new System.Drawing.Size(794, 97);
            this.pnl_top_side.TabIndex = 0;
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
            this.btn_show_search_types.Location = new System.Drawing.Point(516, 62);
            this.btn_show_search_types.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_search_types.Name = "btn_show_search_types";
            this.btn_show_search_types.Size = new System.Drawing.Size(26, 29);
            this.btn_show_search_types.TabIndex = 66;
            this.btn_show_search_types.UseVisualStyleBackColor = true;
            // 
            // tb_search_emp
            // 
            this.tb_search_emp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_search_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_emp.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_emp.Location = new System.Drawing.Point(547, 65);
            this.tb_search_emp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search_emp.Name = "tb_search_emp";
            this.tb_search_emp.Size = new System.Drawing.Size(235, 24);
            this.tb_search_emp.TabIndex = 65;
            this.tb_search_emp.Text = "Search an Employee";
            this.tb_search_emp.TextChanged += new System.EventHandler(this.tb_search_user_TextChanged);
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
            // pnl_employee_list
            // 
            this.pnl_employee_list.AutoScroll = true;
            this.pnl_employee_list.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.pnl_employee_list.Location = new System.Drawing.Point(18, 159);
            this.pnl_employee_list.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_employee_list.Name = "pnl_employee_list";
            this.pnl_employee_list.Size = new System.Drawing.Size(746, 334);
            this.pnl_employee_list.TabIndex = 14;
            // 
            // pnl_seperater
            // 
            this.pnl_seperater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_seperater.Location = new System.Drawing.Point(19, 152);
            this.pnl_seperater.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_seperater.Name = "pnl_seperater";
            this.pnl_seperater.Size = new System.Drawing.Size(746, 1);
            this.pnl_seperater.TabIndex = 7;
            // 
            // pnl_emp_st
            // 
            this.pnl_emp_st.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_emp_st.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_emp_st.Controls.Add(this.lbl_search_by);
            this.pnl_emp_st.Controls.Add(this.rb_department);
            this.pnl_emp_st.Controls.Add(this.rb_email);
            this.pnl_emp_st.Controls.Add(this.rb_gender);
            this.pnl_emp_st.Controls.Add(this.rb_emp_id);
            this.pnl_emp_st.Controls.Add(this.rb_emp_name);
            this.pnl_emp_st.Controls.Add(this.lb_emp_search);
            this.pnl_emp_st.Location = new System.Drawing.Point(524, 101);
            this.pnl_emp_st.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_emp_st.Name = "pnl_emp_st";
            this.pnl_emp_st.Size = new System.Drawing.Size(261, 94);
            this.pnl_emp_st.TabIndex = 67;
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
            // rb_department
            // 
            this.rb_department.AutoSize = true;
            this.rb_department.ForeColor = System.Drawing.Color.White;
            this.rb_department.Location = new System.Drawing.Point(133, 42);
            this.rb_department.Margin = new System.Windows.Forms.Padding(2);
            this.rb_department.Name = "rb_department";
            this.rb_department.Size = new System.Drawing.Size(80, 17);
            this.rb_department.TabIndex = 5;
            this.rb_department.TabStop = true;
            this.rb_department.Text = "Department";
            this.rb_department.UseVisualStyleBackColor = true;
            // 
            // rb_email
            // 
            this.rb_email.AutoSize = true;
            this.rb_email.ForeColor = System.Drawing.Color.White;
            this.rb_email.Location = new System.Drawing.Point(133, 20);
            this.rb_email.Margin = new System.Windows.Forms.Padding(2);
            this.rb_email.Name = "rb_email";
            this.rb_email.Size = new System.Drawing.Size(54, 17);
            this.rb_email.TabIndex = 4;
            this.rb_email.TabStop = true;
            this.rb_email.Text = "E-Mail";
            this.rb_email.UseVisualStyleBackColor = true;
            // 
            // rb_gender
            // 
            this.rb_gender.AutoSize = true;
            this.rb_gender.ForeColor = System.Drawing.Color.White;
            this.rb_gender.Location = new System.Drawing.Point(5, 64);
            this.rb_gender.Margin = new System.Windows.Forms.Padding(2);
            this.rb_gender.Name = "rb_gender";
            this.rb_gender.Size = new System.Drawing.Size(60, 17);
            this.rb_gender.TabIndex = 2;
            this.rb_gender.TabStop = true;
            this.rb_gender.Text = "Gender";
            this.rb_gender.UseVisualStyleBackColor = true;
            // 
            // rb_emp_id
            // 
            this.rb_emp_id.AutoSize = true;
            this.rb_emp_id.ForeColor = System.Drawing.Color.White;
            this.rb_emp_id.Location = new System.Drawing.Point(5, 42);
            this.rb_emp_id.Margin = new System.Windows.Forms.Padding(2);
            this.rb_emp_id.Name = "rb_emp_id";
            this.rb_emp_id.Size = new System.Drawing.Size(36, 17);
            this.rb_emp_id.TabIndex = 1;
            this.rb_emp_id.TabStop = true;
            this.rb_emp_id.Text = "ID";
            this.rb_emp_id.UseVisualStyleBackColor = true;
            // 
            // rb_emp_name
            // 
            this.rb_emp_name.AutoSize = true;
            this.rb_emp_name.ForeColor = System.Drawing.Color.White;
            this.rb_emp_name.Location = new System.Drawing.Point(5, 20);
            this.rb_emp_name.Margin = new System.Windows.Forms.Padding(2);
            this.rb_emp_name.Name = "rb_emp_name";
            this.rb_emp_name.Size = new System.Drawing.Size(53, 17);
            this.rb_emp_name.TabIndex = 0;
            this.rb_emp_name.TabStop = true;
            this.rb_emp_name.Text = "Name";
            this.rb_emp_name.UseVisualStyleBackColor = true;
            // 
            // lb_emp_search
            // 
            this.lb_emp_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_emp_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_emp_search.ForeColor = System.Drawing.Color.White;
            this.lb_emp_search.FormattingEnabled = true;
            this.lb_emp_search.ItemHeight = 16;
            this.lb_emp_search.Location = new System.Drawing.Point(24, -2);
            this.lb_emp_search.Name = "lb_emp_search";
            this.lb_emp_search.Size = new System.Drawing.Size(235, 68);
            this.lb_emp_search.TabIndex = 68;
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(973, 547);
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
            this.pnl_names.ResumeLayout(false);
            this.pnl_names.PerformLayout();
            this.pnl_top_side.ResumeLayout(false);
            this.pnl_top_side.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.pnl_emp_st.ResumeLayout(false);
            this.pnl_emp_st.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_emp_tag;
        private System.Windows.Forms.Panel pnl_employee;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_emp_surname;
        private System.Windows.Forms.Label lbl_employee_id;
        private System.Windows.Forms.Label lbl_employee_name;
        private System.Windows.Forms.Label lbl_dep_name;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Panel pnl_seperater;
        private System.Windows.Forms.Panel pnl_employee_list;
        private Button btn_add;
        private PictureBox pic_logo;
        private TextBox tb_search_emp;
        private Panel pnl_top_side;
        private Button btn_show_search_types;
        private Panel pnl_emp_st;
        private Label lbl_search_by;
        private RadioButton rb_department;
        private RadioButton rb_email;
        private RadioButton rb_gender;
        private RadioButton rb_emp_id;
        private RadioButton rb_emp_name;
        private ListBox lb_emp_search;
        private Label lbl_dprt_name;
        private Panel pnl_names;
        private Book_Tag emp_tag;

        public Panel Pnl_employee_list { get => pnl_employee_list; set => pnl_employee_list = value; }
    }
}