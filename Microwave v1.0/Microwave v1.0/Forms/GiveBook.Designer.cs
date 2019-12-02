using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    partial class GiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveBook));
            this.pnl_book_list = new System.Windows.Forms.Panel();
            this.lb_book_search = new System.Windows.Forms.ListBox();
            this.pnl_book_st = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_user_gender = new System.Windows.Forms.RadioButton();
            this.rb_user_age = new System.Windows.Forms.RadioButton();
            this.rb_user_email = new System.Windows.Forms.RadioButton();
            this.rb_user_id = new System.Windows.Forms.RadioButton();
            this.rb_user_surname = new System.Windows.Forms.RadioButton();
            this.rb_user_name = new System.Windows.Forms.RadioButton();
            this.btn_give_book = new System.Windows.Forms.Button();
            this.btn_show_search_types = new System.Windows.Forms.Button();
            this.tb_search_book = new System.Windows.Forms.TextBox();
            this.pnl_book_list.SuspendLayout();
            this.pnl_book_st.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_book_list
            // 
            this.pnl_book_list.AutoScroll = true;
            this.pnl_book_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.pnl_book_list.Controls.Add(this.lb_book_search);
            this.pnl_book_list.Controls.Add(this.pnl_book_st);
            this.pnl_book_list.Location = new System.Drawing.Point(12, 56);
            this.pnl_book_list.Name = "pnl_book_list";
            this.pnl_book_list.Size = new System.Drawing.Size(615, 283);
            this.pnl_book_list.TabIndex = 0;
            // 
            // lb_book_search
            // 
            this.lb_book_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_book_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book_search.ForeColor = System.Drawing.Color.White;
            this.lb_book_search.FormattingEnabled = true;
            this.lb_book_search.ItemHeight = 16;
            this.lb_book_search.Location = new System.Drawing.Point(32, 0);
            this.lb_book_search.Name = "lb_book_search";
            this.lb_book_search.Size = new System.Drawing.Size(235, 68);
            this.lb_book_search.TabIndex = 67;
            this.lb_book_search.Visible = false;
            // 
            // pnl_book_st
            // 
            this.pnl_book_st.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_book_st.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_book_st.Controls.Add(this.label3);
            this.pnl_book_st.Controls.Add(this.rb_user_gender);
            this.pnl_book_st.Controls.Add(this.rb_user_age);
            this.pnl_book_st.Controls.Add(this.rb_user_email);
            this.pnl_book_st.Controls.Add(this.rb_user_id);
            this.pnl_book_st.Controls.Add(this.rb_user_surname);
            this.pnl_book_st.Controls.Add(this.rb_user_name);
            this.pnl_book_st.Location = new System.Drawing.Point(6, 0);
            this.pnl_book_st.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_book_st.Name = "pnl_book_st";
            this.pnl_book_st.Size = new System.Drawing.Size(261, 116);
            this.pnl_book_st.TabIndex = 66;
            this.pnl_book_st.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search by:";
            // 
            // rb_user_gender
            // 
            this.rb_user_gender.AutoSize = true;
            this.rb_user_gender.ForeColor = System.Drawing.Color.White;
            this.rb_user_gender.Location = new System.Drawing.Point(133, 42);
            this.rb_user_gender.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_gender.Name = "rb_user_gender";
            this.rb_user_gender.Size = new System.Drawing.Size(60, 17);
            this.rb_user_gender.TabIndex = 5;
            this.rb_user_gender.TabStop = true;
            this.rb_user_gender.Text = "Gender";
            this.rb_user_gender.UseVisualStyleBackColor = true;
            // 
            // rb_user_age
            // 
            this.rb_user_age.AutoSize = true;
            this.rb_user_age.ForeColor = System.Drawing.Color.White;
            this.rb_user_age.Location = new System.Drawing.Point(133, 20);
            this.rb_user_age.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_age.Name = "rb_user_age";
            this.rb_user_age.Size = new System.Drawing.Size(44, 17);
            this.rb_user_age.TabIndex = 4;
            this.rb_user_age.TabStop = true;
            this.rb_user_age.Text = "Age";
            this.rb_user_age.UseVisualStyleBackColor = true;
            // 
            // rb_user_email
            // 
            this.rb_user_email.AutoSize = true;
            this.rb_user_email.ForeColor = System.Drawing.Color.White;
            this.rb_user_email.Location = new System.Drawing.Point(5, 86);
            this.rb_user_email.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_email.Name = "rb_user_email";
            this.rb_user_email.Size = new System.Drawing.Size(50, 17);
            this.rb_user_email.TabIndex = 3;
            this.rb_user_email.TabStop = true;
            this.rb_user_email.Text = "Email";
            this.rb_user_email.UseVisualStyleBackColor = true;
            // 
            // rb_user_id
            // 
            this.rb_user_id.AutoSize = true;
            this.rb_user_id.ForeColor = System.Drawing.Color.White;
            this.rb_user_id.Location = new System.Drawing.Point(5, 64);
            this.rb_user_id.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_id.Name = "rb_user_id";
            this.rb_user_id.Size = new System.Drawing.Size(36, 17);
            this.rb_user_id.TabIndex = 2;
            this.rb_user_id.TabStop = true;
            this.rb_user_id.Text = "ID";
            this.rb_user_id.UseVisualStyleBackColor = true;
            // 
            // rb_user_surname
            // 
            this.rb_user_surname.AutoSize = true;
            this.rb_user_surname.ForeColor = System.Drawing.Color.White;
            this.rb_user_surname.Location = new System.Drawing.Point(5, 42);
            this.rb_user_surname.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_surname.Name = "rb_user_surname";
            this.rb_user_surname.Size = new System.Drawing.Size(67, 17);
            this.rb_user_surname.TabIndex = 1;
            this.rb_user_surname.TabStop = true;
            this.rb_user_surname.Text = "Surname";
            this.rb_user_surname.UseVisualStyleBackColor = true;
            // 
            // rb_user_name
            // 
            this.rb_user_name.AutoSize = true;
            this.rb_user_name.ForeColor = System.Drawing.Color.White;
            this.rb_user_name.Location = new System.Drawing.Point(5, 20);
            this.rb_user_name.Margin = new System.Windows.Forms.Padding(2);
            this.rb_user_name.Name = "rb_user_name";
            this.rb_user_name.Size = new System.Drawing.Size(53, 17);
            this.rb_user_name.TabIndex = 0;
            this.rb_user_name.TabStop = true;
            this.rb_user_name.Text = "Name";
            this.rb_user_name.UseVisualStyleBackColor = true;
            // 
            // btn_give_book
            // 
            this.btn_give_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_give_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_give_book.FlatAppearance.BorderSize = 0;
            this.btn_give_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_give_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_give_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_give_book.ForeColor = System.Drawing.Color.White;
            this.btn_give_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_give_book.Image")));
            this.btn_give_book.Location = new System.Drawing.Point(581, 10);
            this.btn_give_book.Margin = new System.Windows.Forms.Padding(2);
            this.btn_give_book.Name = "btn_give_book";
            this.btn_give_book.Size = new System.Drawing.Size(46, 44);
            this.btn_give_book.TabIndex = 54;
            this.btn_give_book.UseVisualStyleBackColor = true;
            this.btn_give_book.Click += new System.EventHandler(this.btn_give_book_Click);
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
            this.btn_show_search_types.Location = new System.Drawing.Point(12, 18);
            this.btn_show_search_types.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_show_search_types.Name = "btn_show_search_types";
            this.btn_show_search_types.Size = new System.Drawing.Size(26, 29);
            this.btn_show_search_types.TabIndex = 65;
            this.btn_show_search_types.UseVisualStyleBackColor = true;
            // 
            // tb_search_book
            // 
            this.tb_search_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_book.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_book.Location = new System.Drawing.Point(44, 21);
            this.tb_search_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search_book.Name = "tb_search_book";
            this.tb_search_book.Size = new System.Drawing.Size(235, 24);
            this.tb_search_book.TabIndex = 68;
            this.tb_search_book.Text = "Search a user";
            // 
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(639, 351);
            this.Controls.Add(this.btn_show_search_types);
            this.Controls.Add(this.btn_give_book);
            this.Controls.Add(this.tb_search_book);
            this.Controls.Add(this.pnl_book_list);
            this.Name = "GiveBook";
            this.Text = "GiveBook";
            this.pnl_book_list.ResumeLayout(false);
            this.pnl_book_st.ResumeLayout(false);
            this.pnl_book_st.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_book_list;
        private System.Windows.Forms.Button btn_give_book;
        private System.Windows.Forms.Panel pnl_book_st;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_user_gender;
        private System.Windows.Forms.RadioButton rb_user_age;
        private System.Windows.Forms.RadioButton rb_user_email;
        private System.Windows.Forms.RadioButton rb_user_id;
        private System.Windows.Forms.RadioButton rb_user_surname;
        private System.Windows.Forms.RadioButton rb_user_name;
        private System.Windows.Forms.ListBox lb_book_search;
        private System.Windows.Forms.Button btn_show_search_types;
        private System.Windows.Forms.TextBox tb_search_book;

        public Panel Pnl_book_list { get => pnl_book_list; set => pnl_book_list = value; }
    }
}