namespace Microwave_v1._0.Forms
{
    partial class Receipt_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Detail));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_message = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.RichTextBox();
            this.lbl_user_email_val = new System.Windows.Forms.Label();
            this.lbl_users_email = new System.Windows.Forms.Label();
            this.lbl_lib_name_val = new System.Windows.Forms.Label();
            this.lbl_lib_id_val = new System.Windows.Forms.Label();
            this.lbl_user_name_val = new System.Windows.Forms.Label();
            this.lbl_user_id_val = new System.Windows.Forms.Label();
            this.lbl_book_name_val = new System.Windows.Forms.Label();
            this.lbl_book_id_val = new System.Windows.Forms.Label();
            this.lbl_libs_name = new System.Windows.Forms.Label();
            this.lbl_users_name = new System.Windows.Forms.Label();
            this.lbl_books_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_rcpt_name = new System.Windows.Forms.Label();
            this.lbl_libs_id = new System.Windows.Forms.Label();
            this.lbl_users_id = new System.Windows.Forms.Label();
            this.lbl_books_id = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.pb_book = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dragControl1 = new Microwave_v1._0.DragControl();
            this.pnl_drag = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_main.Controls.Add(this.button1);
            this.pnl_main.Controls.Add(this.lbl_message);
            this.pnl_main.Controls.Add(this.tb_message);
            this.pnl_main.Controls.Add(this.btn_remove);
            this.pnl_main.Controls.Add(this.lbl_user_email_val);
            this.pnl_main.Controls.Add(this.lbl_users_email);
            this.pnl_main.Controls.Add(this.lbl_lib_name_val);
            this.pnl_main.Controls.Add(this.lbl_lib_id_val);
            this.pnl_main.Controls.Add(this.lbl_user_name_val);
            this.pnl_main.Controls.Add(this.lbl_user_id_val);
            this.pnl_main.Controls.Add(this.lbl_book_name_val);
            this.pnl_main.Controls.Add(this.lbl_book_id_val);
            this.pnl_main.Controls.Add(this.lbl_libs_name);
            this.pnl_main.Controls.Add(this.lbl_users_name);
            this.pnl_main.Controls.Add(this.lbl_books_name);
            this.pnl_main.Controls.Add(this.lbl_date);
            this.pnl_main.Controls.Add(this.lbl_rcpt_name);
            this.pnl_main.Controls.Add(this.lbl_libs_id);
            this.pnl_main.Controls.Add(this.lbl_users_id);
            this.pnl_main.Controls.Add(this.lbl_books_id);
            this.pnl_main.Controls.Add(this.pb_book);
            this.pnl_main.Controls.Add(this.pnl_drag);
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(600, 293);
            this.pnl_main.TabIndex = 25;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.White;
            this.lbl_message.Location = new System.Drawing.Point(40, 211);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(76, 16);
            this.lbl_message.TabIndex = 23;
            this.lbl_message.Text = "Message:";
            // 
            // tb_message
            // 
            this.tb_message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_message.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_message.ForeColor = System.Drawing.Color.White;
            this.tb_message.Location = new System.Drawing.Point(151, 209);
            this.tb_message.Name = "tb_message";
            this.tb_message.ReadOnly = true;
            this.tb_message.Size = new System.Drawing.Size(378, 68);
            this.tb_message.TabIndex = 22;
            this.tb_message.Text = "";
            // 
            // lbl_user_email_val
            // 
            this.lbl_user_email_val.AutoSize = true;
            this.lbl_user_email_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_email_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_email_val.Location = new System.Drawing.Point(284, 119);
            this.lbl_user_email_val.Name = "lbl_user_email_val";
            this.lbl_user_email_val.Size = new System.Drawing.Size(158, 16);
            this.lbl_user_email_val.TabIndex = 18;
            this.lbl_user_email_val.Text = "rsltnyldzz@gmail.com";
            // 
            // lbl_users_email
            // 
            this.lbl_users_email.AutoSize = true;
            this.lbl_users_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_email.ForeColor = System.Drawing.Color.White;
            this.lbl_users_email.Location = new System.Drawing.Point(148, 119);
            this.lbl_users_email.Name = "lbl_users_email";
            this.lbl_users_email.Size = new System.Drawing.Size(100, 16);
            this.lbl_users_email.TabIndex = 17;
            this.lbl_users_email.Text = "User\'s Email:";
            // 
            // lbl_lib_name_val
            // 
            this.lbl_lib_name_val.AutoSize = true;
            this.lbl_lib_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_lib_name_val.Location = new System.Drawing.Point(284, 161);
            this.lbl_lib_name_val.Name = "lbl_lib_name_val";
            this.lbl_lib_name_val.Size = new System.Drawing.Size(160, 16);
            this.lbl_lib_name_val.TabIndex = 14;
            this.lbl_lib_name_val.Text = "Doğan Dinçer Demirci";
            // 
            // lbl_lib_id_val
            // 
            this.lbl_lib_id_val.AutoSize = true;
            this.lbl_lib_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lib_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_lib_id_val.Location = new System.Drawing.Point(284, 177);
            this.lbl_lib_id_val.Name = "lbl_lib_id_val";
            this.lbl_lib_id_val.Size = new System.Drawing.Size(16, 16);
            this.lbl_lib_id_val.TabIndex = 13;
            this.lbl_lib_id_val.Text = "0";
            // 
            // lbl_user_name_val
            // 
            this.lbl_user_name_val.AutoSize = true;
            this.lbl_user_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_name_val.Location = new System.Drawing.Point(284, 103);
            this.lbl_user_name_val.Name = "lbl_user_name_val";
            this.lbl_user_name_val.Size = new System.Drawing.Size(176, 16);
            this.lbl_user_name_val.TabIndex = 12;
            this.lbl_user_name_val.Text = "Nurettin Resul Tanyıldızı";
            // 
            // lbl_user_id_val
            // 
            this.lbl_user_id_val.AutoSize = true;
            this.lbl_user_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_user_id_val.Location = new System.Drawing.Point(284, 136);
            this.lbl_user_id_val.Name = "lbl_user_id_val";
            this.lbl_user_id_val.Size = new System.Drawing.Size(24, 16);
            this.lbl_user_id_val.TabIndex = 11;
            this.lbl_user_id_val.Text = "32";
            // 
            // lbl_book_name_val
            // 
            this.lbl_book_name_val.AutoSize = true;
            this.lbl_book_name_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name_val.ForeColor = System.Drawing.Color.White;
            this.lbl_book_name_val.Location = new System.Drawing.Point(284, 61);
            this.lbl_book_name_val.Name = "lbl_book_name_val";
            this.lbl_book_name_val.Size = new System.Drawing.Size(171, 16);
            this.lbl_book_name_val.TabIndex = 10;
            this.lbl_book_name_val.Text = "Türkiye\'nin Yakın Tarihi";
            // 
            // lbl_book_id_val
            // 
            this.lbl_book_id_val.AutoSize = true;
            this.lbl_book_id_val.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_id_val.ForeColor = System.Drawing.Color.White;
            this.lbl_book_id_val.Location = new System.Drawing.Point(284, 77);
            this.lbl_book_id_val.Name = "lbl_book_id_val";
            this.lbl_book_id_val.Size = new System.Drawing.Size(24, 16);
            this.lbl_book_id_val.TabIndex = 9;
            this.lbl_book_id_val.Text = "45";
            // 
            // lbl_libs_name
            // 
            this.lbl_libs_name.AutoSize = true;
            this.lbl_libs_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libs_name.ForeColor = System.Drawing.Color.White;
            this.lbl_libs_name.Location = new System.Drawing.Point(148, 161);
            this.lbl_libs_name.Name = "lbl_libs_name";
            this.lbl_libs_name.Size = new System.Drawing.Size(130, 16);
            this.lbl_libs_name.TabIndex = 8;
            this.lbl_libs_name.Text = "Librarian\'s Name:";
            // 
            // lbl_users_name
            // 
            this.lbl_users_name.AutoSize = true;
            this.lbl_users_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_name.ForeColor = System.Drawing.Color.White;
            this.lbl_users_name.Location = new System.Drawing.Point(148, 103);
            this.lbl_users_name.Name = "lbl_users_name";
            this.lbl_users_name.Size = new System.Drawing.Size(102, 16);
            this.lbl_users_name.TabIndex = 7;
            this.lbl_users_name.Text = "User\'s Name:";
            // 
            // lbl_books_name
            // 
            this.lbl_books_name.AutoSize = true;
            this.lbl_books_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_books_name.ForeColor = System.Drawing.Color.White;
            this.lbl_books_name.Location = new System.Drawing.Point(148, 61);
            this.lbl_books_name.Name = "lbl_books_name";
            this.lbl_books_name.Size = new System.Drawing.Size(105, 16);
            this.lbl_books_name.TabIndex = 6;
            this.lbl_books_name.Text = "Book\'s Name:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(423, 23);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(80, 16);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "02.12.2019";
            // 
            // lbl_rcpt_name
            // 
            this.lbl_rcpt_name.AutoSize = true;
            this.lbl_rcpt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rcpt_name.ForeColor = System.Drawing.Color.White;
            this.lbl_rcpt_name.Location = new System.Drawing.Point(12, 17);
            this.lbl_rcpt_name.Name = "lbl_rcpt_name";
            this.lbl_rcpt_name.Size = new System.Drawing.Size(163, 24);
            this.lbl_rcpt_name.TabIndex = 4;
            this.lbl_rcpt_name.Text = "RECEIPT NAME";
            // 
            // lbl_libs_id
            // 
            this.lbl_libs_id.AutoSize = true;
            this.lbl_libs_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_libs_id.ForeColor = System.Drawing.Color.White;
            this.lbl_libs_id.Location = new System.Drawing.Point(148, 177);
            this.lbl_libs_id.Name = "lbl_libs_id";
            this.lbl_libs_id.Size = new System.Drawing.Size(104, 16);
            this.lbl_libs_id.TabIndex = 3;
            this.lbl_libs_id.Text = "Librarian\'s ID:";
            // 
            // lbl_users_id
            // 
            this.lbl_users_id.AutoSize = true;
            this.lbl_users_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_users_id.ForeColor = System.Drawing.Color.White;
            this.lbl_users_id.Location = new System.Drawing.Point(148, 136);
            this.lbl_users_id.Name = "lbl_users_id";
            this.lbl_users_id.Size = new System.Drawing.Size(76, 16);
            this.lbl_users_id.TabIndex = 2;
            this.lbl_users_id.Text = "User\'s ID:";
            // 
            // lbl_books_id
            // 
            this.lbl_books_id.AutoSize = true;
            this.lbl_books_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_books_id.ForeColor = System.Drawing.Color.White;
            this.lbl_books_id.Location = new System.Drawing.Point(148, 77);
            this.lbl_books_id.Name = "lbl_books_id";
            this.lbl_books_id.Size = new System.Drawing.Size(79, 16);
            this.lbl_books_id.TabIndex = 1;
            this.lbl_books_id.Text = "Book\'s ID:";
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.White;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(546, 228);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(39, 34);
            this.btn_remove.TabIndex = 21;
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // pb_book
            // 
            this.pb_book.Image = ((System.Drawing.Image)(resources.GetObject("pb_book.Image")));
            this.pb_book.Location = new System.Drawing.Point(16, 56);
            this.pb_book.Name = "pb_book";
            this.pb_book.Size = new System.Drawing.Size(100, 137);
            this.pb_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_book.TabIndex = 0;
            this.pb_book.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(544, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnl_drag;
            // 
            // pnl_drag
            // 
            this.pnl_drag.Location = new System.Drawing.Point(0, 3);
            this.pnl_drag.Name = "pnl_drag";
            this.pnl_drag.Size = new System.Drawing.Size(597, 38);
            this.pnl_drag.TabIndex = 25;
            // 
            // Receipt_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 289);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt_Detail";
            this.Text = "Receipt_Detail";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Receipt_Detail_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.RichTextBox tb_message;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_user_email_val;
        private System.Windows.Forms.Label lbl_users_email;
        private System.Windows.Forms.Label lbl_lib_name_val;
        private System.Windows.Forms.Label lbl_lib_id_val;
        private System.Windows.Forms.Label lbl_user_name_val;
        private System.Windows.Forms.Label lbl_user_id_val;
        private System.Windows.Forms.Label lbl_book_name_val;
        private System.Windows.Forms.Label lbl_book_id_val;
        private System.Windows.Forms.Label lbl_libs_name;
        private System.Windows.Forms.Label lbl_users_name;
        private System.Windows.Forms.Label lbl_books_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_rcpt_name;
        private System.Windows.Forms.Label lbl_libs_id;
        private System.Windows.Forms.Label lbl_users_id;
        private System.Windows.Forms.Label lbl_books_id;
        private System.Windows.Forms.PictureBox pb_book;
        private System.Windows.Forms.Button button1;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel pnl_drag;
    }
}