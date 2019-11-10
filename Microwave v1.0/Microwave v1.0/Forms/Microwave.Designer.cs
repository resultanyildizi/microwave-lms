using System.Windows.Forms;

namespace Microwave_v1._0
{
    partial class Microwave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Microwave));
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.pnl_stick = new System.Windows.Forms.Panel();
            this.btn_book = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.lbl_logo_lms = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_profil = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lbl_book_title = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_book_author = new System.Windows.Forms.Label();
            this.lbl_book_publisher = new System.Windows.Forms.Label();
            this.lbl_book_date = new System.Windows.Forms.Label();
            this.lbl_book_count = new System.Windows.Forms.Label();
            this.pnl_book_list = new System.Windows.Forms.Panel();
            this.pnl_book = new System.Windows.Forms.Panel();
            this.pnl_seperater = new System.Windows.Forms.Panel();
            this.pnl_user = new System.Windows.Forms.Panel();
            this.pnl_user_list = new System.Windows.Forms.Panel();
            this.lbl_user_date = new System.Windows.Forms.Label();
            this.lbl_user_surname = new System.Windows.Forms.Label();
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_user_gender = new System.Windows.Forms.Label();
            this.lbl_user_age = new System.Windows.Forms.Label();
            this.lbl_user_email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_tag = new System.Windows.Forms.Panel();
            this.cover_image_list = new System.Windows.Forms.ImageList(this.components);
            this.pnl_left.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.pnl_header.SuspendLayout();
            this.pnl_book.SuspendLayout();
            this.pnl_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.Black;
            this.pnl_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_left.Controls.Add(this.pnl_menu);
            this.pnl_left.Controls.Add(this.pic_logo);
            this.pnl_left.Controls.Add(this.lbl_logo);
            this.pnl_left.Controls.Add(this.lbl_logo_lms);
            this.pnl_left.Location = new System.Drawing.Point(0, 0);
            this.pnl_left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(287, 752);
            this.pnl_left.TabIndex = 1;
            this.pnl_left.Click += new System.EventHandler(this.Pnl_left_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_menu.Controls.Add(this.btn_about);
            this.pnl_menu.Controls.Add(this.btn_add);
            this.pnl_menu.Controls.Add(this.btn_email);
            this.pnl_menu.Controls.Add(this.btn_user);
            this.pnl_menu.Controls.Add(this.pnl_stick);
            this.pnl_menu.Controls.Add(this.btn_book);
            this.pnl_menu.Location = new System.Drawing.Point(0, 130);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(287, 619);
            this.pnl_menu.TabIndex = 9;
            this.pnl_menu.Click += new System.EventHandler(this.Pnl_menu_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_about.ForeColor = System.Drawing.Color.White;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_about.Location = new System.Drawing.Point(29, 160);
            this.btn_about.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(213, 42);
            this.btn_about.TabIndex = 7;
            this.btn_about.Text = "      About Us";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(224, 561);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 54);
            this.btn_add.TabIndex = 6;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_Add_Book_Click);
            // 
            // btn_email
            // 
            this.btn_email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_email.FlatAppearance.BorderSize = 0;
            this.btn_email.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email.ForeColor = System.Drawing.Color.White;
            this.btn_email.Image = ((System.Drawing.Image)(resources.GetObject("btn_email.Image")));
            this.btn_email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_email.Location = new System.Drawing.Point(29, 112);
            this.btn_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(213, 42);
            this.btn_email.TabIndex = 6;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.FlatAppearance.BorderSize = 0;
            this.btn_user.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Image = ((System.Drawing.Image)(resources.GetObject("btn_user.Image")));
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(29, 64);
            this.btn_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(213, 42);
            this.btn_user.TabIndex = 5;
            this.btn_user.Text = "Users";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_stick
            // 
            this.pnl_stick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_stick.Location = new System.Drawing.Point(0, 16);
            this.pnl_stick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_stick.Name = "pnl_stick";
            this.pnl_stick.Size = new System.Drawing.Size(11, 42);
            this.pnl_stick.TabIndex = 4;
            // 
            // btn_book
            // 
            this.btn_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book.ForeColor = System.Drawing.Color.White;
            this.btn_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_book.Image")));
            this.btn_book.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_book.Location = new System.Drawing.Point(29, 16);
            this.btn_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(213, 42);
            this.btn_book.TabIndex = 4;
            this.btn_book.Text = "Book";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 12);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(123, 98);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 4;
            this.pic_logo.TabStop = false;
            this.pic_logo.Click += new System.EventHandler(this.Pic_logo_Click);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoEllipsis = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.White;
            this.lbl_logo.Location = new System.Drawing.Point(131, 30);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(139, 32);
            this.lbl_logo.TabIndex = 8;
            this.lbl_logo.Text = "Microwave";
            this.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_logo_lms
            // 
            this.lbl_logo_lms.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo_lms.ForeColor = System.Drawing.Color.White;
            this.lbl_logo_lms.Location = new System.Drawing.Point(131, 49);
            this.lbl_logo_lms.Name = "lbl_logo_lms";
            this.lbl_logo_lms.Size = new System.Drawing.Size(143, 74);
            this.lbl_logo_lms.TabIndex = 4;
            this.lbl_logo_lms.Text = "Library Management System";
            this.lbl_logo_lms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_header.Controls.Add(this.panel8);
            this.pnl_header.Controls.Add(this.tb_search);
            this.pnl_header.Controls.Add(this.btn_search);
            this.pnl_header.Controls.Add(this.btn_profil);
            this.pnl_header.Controls.Add(this.btn_settings);
            this.pnl_header.Location = new System.Drawing.Point(287, 0);
            this.pnl_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1085, 49);
            this.pnl_header.TabIndex = 2;
            this.pnl_header.Click += new System.EventHandler(this.Pnl_header_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(-1, 47);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(801, 702);
            this.panel8.TabIndex = 6;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.DimGray;
            this.tb_search.Location = new System.Drawing.Point(33, 9);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(289, 30);
            this.tb_search.TabIndex = 5;
            this.tb_search.Text = "Search A Book...";
            this.tb_search.Click += new System.EventHandler(this.Tb_search_Click);
            this.tb_search.Enter += new System.EventHandler(this.tb_search_Enter);
            this.tb_search.Leave += new System.EventHandler(this.tb_search_Leave);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(329, 7);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(56, 36);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_profil
            // 
            this.btn_profil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profil.FlatAppearance.BorderSize = 0;
            this.btn_profil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_profil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profil.Image = ((System.Drawing.Image)(resources.GetObject("btn_profil.Image")));
            this.btn_profil.Location = new System.Drawing.Point(921, 6);
            this.btn_profil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_profil.Name = "btn_profil";
            this.btn_profil.Size = new System.Drawing.Size(56, 36);
            this.btn_profil.TabIndex = 2;
            this.btn_profil.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            this.btn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_settings.Image")));
            this.btn_settings.Location = new System.Drawing.Point(983, 6);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(56, 36);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.UseVisualStyleBackColor = true;
            // 
            // lbl_book_title
            // 
            this.lbl_book_title.AutoSize = true;
            this.lbl_book_title.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_book_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_title.ForeColor = System.Drawing.Color.White;
            this.lbl_book_title.Location = new System.Drawing.Point(24, 25);
            this.lbl_book_title.Name = "lbl_book_title";
            this.lbl_book_title.Size = new System.Drawing.Size(175, 51);
            this.lbl_book_title.TabIndex = 4;
            this.lbl_book_title.Text = "BOOKS";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.ForeColor = System.Drawing.Color.White;
            this.lbl_book_name.Location = new System.Drawing.Point(27, 98);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_book_name.TabIndex = 8;
            this.lbl_book_name.Text = "Name";
            // 
            // lbl_book_author
            // 
            this.lbl_book_author.AutoSize = true;
            this.lbl_book_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_author.ForeColor = System.Drawing.Color.White;
            this.lbl_book_author.Location = new System.Drawing.Point(223, 98);
            this.lbl_book_author.Name = "lbl_book_author";
            this.lbl_book_author.Size = new System.Drawing.Size(99, 32);
            this.lbl_book_author.TabIndex = 10;
            this.lbl_book_author.Text = "Author";
            // 
            // lbl_book_publisher
            // 
            this.lbl_book_publisher.AutoSize = true;
            this.lbl_book_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_publisher.ForeColor = System.Drawing.Color.White;
            this.lbl_book_publisher.Location = new System.Drawing.Point(387, 98);
            this.lbl_book_publisher.Name = "lbl_book_publisher";
            this.lbl_book_publisher.Size = new System.Drawing.Size(135, 32);
            this.lbl_book_publisher.TabIndex = 11;
            this.lbl_book_publisher.Text = "Publisher";
            // 
            // lbl_book_date
            // 
            this.lbl_book_date.AutoSize = true;
            this.lbl_book_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_date.ForeColor = System.Drawing.Color.White;
            this.lbl_book_date.Location = new System.Drawing.Point(567, 98);
            this.lbl_book_date.Name = "lbl_book_date";
            this.lbl_book_date.Size = new System.Drawing.Size(75, 32);
            this.lbl_book_date.TabIndex = 12;
            this.lbl_book_date.Text = "Date";
            // 
            // lbl_book_count
            // 
            this.lbl_book_count.AutoSize = true;
            this.lbl_book_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_count.ForeColor = System.Drawing.Color.White;
            this.lbl_book_count.Location = new System.Drawing.Point(677, 98);
            this.lbl_book_count.Name = "lbl_book_count";
            this.lbl_book_count.Size = new System.Drawing.Size(91, 32);
            this.lbl_book_count.TabIndex = 13;
            this.lbl_book_count.Text = "Count";
            // 
            // pnl_book_list
            // 
            this.pnl_book_list.AutoScroll = true;
            this.pnl_book_list.AutoScrollMargin = new System.Drawing.Size(0, 2);
            this.pnl_book_list.Location = new System.Drawing.Point(-1, 146);
            this.pnl_book_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_book_list.Name = "pnl_book_list";
            this.pnl_book_list.Size = new System.Drawing.Size(797, 505);
            this.pnl_book_list.TabIndex = 14;
            this.pnl_book_list.Click += new System.EventHandler(this.Pnl_list_Click);
            // 
            // pnl_book
            // 
            this.pnl_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_book.Controls.Add(this.lbl_book_name);
            this.pnl_book.Controls.Add(this.lbl_book_title);
            this.pnl_book.Controls.Add(this.lbl_book_count);
            this.pnl_book.Controls.Add(this.lbl_book_date);
            this.pnl_book.Controls.Add(this.lbl_book_publisher);
            this.pnl_book.Controls.Add(this.lbl_book_author);
            this.pnl_book.Controls.Add(this.pnl_seperater);
            this.pnl_book.Controls.Add(this.pnl_book_list);
            this.pnl_book.Location = new System.Drawing.Point(287, 48);
            this.pnl_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_book.Name = "pnl_book";
            this.pnl_book.Size = new System.Drawing.Size(809, 704);
            this.pnl_book.TabIndex = 15;
            this.pnl_book.Click += new System.EventHandler(this.Panel9_Click);
            // 
            // pnl_seperater
            // 
            this.pnl_seperater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_seperater.Location = new System.Drawing.Point(32, 142);
            this.pnl_seperater.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_seperater.Name = "pnl_seperater";
            this.pnl_seperater.Size = new System.Drawing.Size(728, 1);
            this.pnl_seperater.TabIndex = 7;
            // 
            // pnl_user
            // 
            this.pnl_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_user.Controls.Add(this.pnl_user_list);
            this.pnl_user.Controls.Add(this.lbl_user_date);
            this.pnl_user.Controls.Add(this.lbl_user_surname);
            this.pnl_user.Controls.Add(this.lbl_user_name);
            this.pnl_user.Controls.Add(this.label2);
            this.pnl_user.Controls.Add(this.lbl_user_gender);
            this.pnl_user.Controls.Add(this.lbl_user_age);
            this.pnl_user.Controls.Add(this.lbl_user_email);
            this.pnl_user.Controls.Add(this.panel2);
            this.pnl_user.Location = new System.Drawing.Point(287, 48);
            this.pnl_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_user.Name = "pnl_user";
            this.pnl_user.Size = new System.Drawing.Size(1077, 707);
            this.pnl_user.TabIndex = 16;
            this.pnl_user.Click += new System.EventHandler(this.pnl_user_Click);
            // 
            // pnl_user_list
            // 
            this.pnl_user_list.AutoScroll = true;
            this.pnl_user_list.Location = new System.Drawing.Point(-1, 146);
            this.pnl_user_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_user_list.Name = "pnl_user_list";
            this.pnl_user_list.Size = new System.Drawing.Size(1083, 505);
            this.pnl_user_list.TabIndex = 14;
            this.pnl_user_list.Click += new System.EventHandler(this.pnl_user_list_Click);
            // 
            // lbl_user_date
            // 
            this.lbl_user_date.AutoSize = true;
            this.lbl_user_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_date.ForeColor = System.Drawing.Color.White;
            this.lbl_user_date.Location = new System.Drawing.Point(863, 96);
            this.lbl_user_date.Name = "lbl_user_date";
            this.lbl_user_date.Size = new System.Drawing.Size(75, 32);
            this.lbl_user_date.TabIndex = 16;
            this.lbl_user_date.Text = "Date";
            // 
            // lbl_user_surname
            // 
            this.lbl_user_surname.AutoSize = true;
            this.lbl_user_surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_user_surname.Location = new System.Drawing.Point(189, 96);
            this.lbl_user_surname.Name = "lbl_user_surname";
            this.lbl_user_surname.Size = new System.Drawing.Size(130, 32);
            this.lbl_user_surname.TabIndex = 11;
            this.lbl_user_surname.Text = "Surname";
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_name.ForeColor = System.Drawing.Color.White;
            this.lbl_user_name.Location = new System.Drawing.Point(27, 96);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(90, 32);
            this.lbl_user_name.TabIndex = 15;
            this.lbl_user_name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "USERS";
            // 
            // lbl_user_gender
            // 
            this.lbl_user_gender.AutoSize = true;
            this.lbl_user_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_user_gender.Location = new System.Drawing.Point(371, 96);
            this.lbl_user_gender.Name = "lbl_user_gender";
            this.lbl_user_gender.Size = new System.Drawing.Size(110, 32);
            this.lbl_user_gender.TabIndex = 13;
            this.lbl_user_gender.Text = "Gender";
            // 
            // lbl_user_age
            // 
            this.lbl_user_age.AutoSize = true;
            this.lbl_user_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_age.ForeColor = System.Drawing.Color.White;
            this.lbl_user_age.Location = new System.Drawing.Point(527, 96);
            this.lbl_user_age.Name = "lbl_user_age";
            this.lbl_user_age.Size = new System.Drawing.Size(66, 32);
            this.lbl_user_age.TabIndex = 12;
            this.lbl_user_age.Text = "Age";
            // 
            // lbl_user_email
            // 
            this.lbl_user_email.AutoSize = true;
            this.lbl_user_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_email.ForeColor = System.Drawing.Color.White;
            this.lbl_user_email.Location = new System.Drawing.Point(647, 96);
            this.lbl_user_email.Name = "lbl_user_email";
            this.lbl_user_email.Size = new System.Drawing.Size(87, 32);
            this.lbl_user_email.TabIndex = 11;
            this.lbl_user_email.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.panel2.Location = new System.Drawing.Point(32, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 1);
            this.panel2.TabIndex = 7;
            // 
            // pnl_tag
            // 
            this.pnl_tag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_tag.Location = new System.Drawing.Point(1093, 47);
            this.pnl_tag.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_tag.Name = "pnl_tag";
            this.pnl_tag.Size = new System.Drawing.Size(254, 705);
            this.pnl_tag.TabIndex = 16;
            // 
            // cover_image_list
            // 
            this.cover_image_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cover_image_list.ImageStream")));
            this.cover_image_list.TransparentColor = System.Drawing.Color.Transparent;
            this.cover_image_list.Images.SetKeyName(0, "0");
            // 
            // Microwave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1346, 752);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_book);
            this.Controls.Add(this.pnl_tag);
            this.Controls.Add(this.pnl_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(18, 47);
            this.Name = "Microwave";
            this.Opacity = 0.96D;
            this.ShowIcon = false;
            this.Text = "Microwave";
            this.Load += new System.EventHandler(this.Microwave_Load);
            this.Click += new System.EventHandler(this.Microwave_Click);
            this.pnl_left.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_book.ResumeLayout(false);
            this.pnl_book.PerformLayout();
            this.pnl_user.ResumeLayout(false);
            this.pnl_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_profil;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_user_surname;
        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_user_date;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Label lbl_logo_lms;
        private System.Windows.Forms.Label lbl_book_title;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_book_author;
        private System.Windows.Forms.Label lbl_book_publisher;
        private System.Windows.Forms.Label lbl_book_date;
        private System.Windows.Forms.Label lbl_book_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_user_gender;
        private System.Windows.Forms.Label lbl_user_age;
        private System.Windows.Forms.Label lbl_user_email;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_stick;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_book_list;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel pnl_book;
        private System.Windows.Forms.Panel pnl_tag;
        private System.Windows.Forms.Panel pnl_seperater;
        private System.Windows.Forms.Panel pnl_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_user_list;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.TextBox tb_search;
        private ImageList cover_image_list;

        public Panel Pnl_book_list { get => pnl_book_list; set => pnl_book_list = value; }
        public Button Btn_add { get => btn_add; set => btn_add = value; }
        public Panel Pnl_user_list { get => pnl_user_list; set => pnl_user_list = value; }
        public Panel Pnl_tag { get => pnl_tag; set => pnl_tag = value; }
        public Button Btn_settings { get => btn_settings; set => btn_settings = value; }
        public Button Btn_search { get => btn_search; set => btn_search = value; }
        public Button Btn_profil { get => btn_profil; set => btn_profil = value; }
        public Button Btn_book { get => btn_book; set => btn_book = value; }
        public Button Btn_about { get => btn_about; set => btn_about = value; }
        public Button Btn_email { get => btn_email; set => btn_email = value; }
        public Button Btn_user { get => btn_user; set => btn_user = value; }
        public ImageList Cover_image_list { get => cover_image_list; set => cover_image_list = value; }
    }
}

