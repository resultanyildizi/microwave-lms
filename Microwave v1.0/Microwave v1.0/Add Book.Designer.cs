namespace Microwave_v1._0
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_count = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.tb_publisher = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.btn_add_pic);
            this.pnl_main.Controls.Add(this.lbl_description);
            this.pnl_main.Controls.Add(this.tb_description);
            this.pnl_main.Controls.Add(this.tb_count);
            this.pnl_main.Controls.Add(this.lbl_count);
            this.pnl_main.Controls.Add(this.btn_add);
            this.pnl_main.Controls.Add(this.pic_book);
            this.pnl_main.Controls.Add(this.lbl_date);
            this.pnl_main.Controls.Add(this.tb_date);
            this.pnl_main.Controls.Add(this.lbl_publisher);
            this.pnl_main.Controls.Add(this.tb_publisher);
            this.pnl_main.Controls.Add(this.lbl_author);
            this.pnl_main.Controls.Add(this.tb_author);
            this.pnl_main.Controls.Add(this.lbl_name);
            this.pnl_main.Controls.Add(this.tb_name);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_main.Location = new System.Drawing.Point(0, -1);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(470, 562);
            this.pnl_main.TabIndex = 1;
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(227, 500);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 23;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.Change_Image_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(14, 226);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(99, 20);
            this.lbl_description.TabIndex = 22;
            this.lbl_description.Text = "Description:";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.ForeColor = System.Drawing.Color.White;
            this.tb_description.Location = new System.Drawing.Point(140, 224);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(290, 129);
            this.tb_description.TabIndex = 21;
            // 
            // tb_count
            // 
            this.tb_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_count.ForeColor = System.Drawing.Color.White;
            this.tb_count.Location = new System.Drawing.Point(140, 379);
            this.tb_count.Name = "tb_count";
            this.tb_count.Size = new System.Drawing.Size(75, 27);
            this.tb_count.TabIndex = 19;
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_count.ForeColor = System.Drawing.Color.White;
            this.lbl_count.Location = new System.Drawing.Point(14, 381);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(58, 20);
            this.lbl_count.TabIndex = 18;
            this.lbl_count.Text = "Count:";
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(11, 496);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 56);
            this.btn_add.TabIndex = 17;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // pic_book
            // 
            this.pic_book.Image = ((System.Drawing.Image)(resources.GetObject("pic_book.Image")));
            this.pic_book.Location = new System.Drawing.Point(296, 379);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(134, 169);
            this.pic_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_book.TabIndex = 16;
            this.pic_book.TabStop = false;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(14, 173);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(49, 20);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "Date:";
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_date.ForeColor = System.Drawing.Color.White;
            this.tb_date.Location = new System.Drawing.Point(140, 171);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(290, 27);
            this.tb_date.TabIndex = 14;
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_publisher.ForeColor = System.Drawing.Color.White;
            this.lbl_publisher.Location = new System.Drawing.Point(14, 127);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(84, 20);
            this.lbl_publisher.TabIndex = 13;
            this.lbl_publisher.Text = "Publisher:";
            // 
            // tb_publisher
            // 
            this.tb_publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_publisher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publisher.ForeColor = System.Drawing.Color.White;
            this.tb_publisher.Location = new System.Drawing.Point(140, 122);
            this.tb_publisher.Name = "tb_publisher";
            this.tb_publisher.Size = new System.Drawing.Size(290, 27);
            this.tb_publisher.TabIndex = 12;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(14, 78);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(63, 20);
            this.lbl_author.TabIndex = 11;
            this.lbl_author.Text = "Author:";
            // 
            // tb_author
            // 
            this.tb_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.ForeColor = System.Drawing.Color.White;
            this.tb_author.Location = new System.Drawing.Point(140, 73);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(290, 27);
            this.tb_author.TabIndex = 10;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("SansSerif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(14, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(58, 20);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(140, 24);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(290, 27);
            this.tb_name.TabIndex = 6;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(470, 561);
            this.Controls.Add(this.pnl_main);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBook";
            this.Text = "AddBook";
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.TextBox tb_publisher;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tb_count;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_add_pic;
    }
}