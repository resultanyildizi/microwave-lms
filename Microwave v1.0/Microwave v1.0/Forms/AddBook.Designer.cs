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
            this.cb_shelf = new System.Windows.Forms.ComboBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.cb_publisher = new System.Windows.Forms.ComboBox();
            this.cb_author = new System.Windows.Forms.ComboBox();
            this.lbl_shelf = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.numUpDown_count = new System.Windows.Forms.NumericUpDown();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.lbl_description = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.cb_shelf);
            this.pnl_main.Controls.Add(this.cb_category);
            this.pnl_main.Controls.Add(this.cb_publisher);
            this.pnl_main.Controls.Add(this.cb_author);
            this.pnl_main.Controls.Add(this.lbl_shelf);
            this.pnl_main.Controls.Add(this.lbl_category);
            this.pnl_main.Controls.Add(this.numUpDown_count);
            this.pnl_main.Controls.Add(this.lbl_message);
            this.pnl_main.Controls.Add(this.btn_add_pic);
            this.pnl_main.Controls.Add(this.lbl_description);
            this.pnl_main.Controls.Add(this.tb_description);
            this.pnl_main.Controls.Add(this.lbl_count);
            this.pnl_main.Controls.Add(this.btn_add);
            this.pnl_main.Controls.Add(this.pic_book);
            this.pnl_main.Controls.Add(this.lbl_publisher);
            this.pnl_main.Controls.Add(this.lbl_author);
            this.pnl_main.Controls.Add(this.lbl_name);
            this.pnl_main.Controls.Add(this.tb_name);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_main.Location = new System.Drawing.Point(0, -1);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(455, 562);
            this.pnl_main.TabIndex = 1;
            // 
            // cb_shelf
            // 
            this.cb_shelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.cb_shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_shelf.ForeColor = System.Drawing.Color.Gray;
            this.cb_shelf.FormattingEnabled = true;
            this.cb_shelf.Items.AddRange(new object[] {
            "###"});
            this.cb_shelf.Location = new System.Drawing.Point(139, 390);
            this.cb_shelf.Name = "cb_shelf";
            this.cb_shelf.Size = new System.Drawing.Size(76, 28);
            this.cb_shelf.TabIndex = 6;
            this.cb_shelf.SelectedIndexChanged += new System.EventHandler(this.Cb_shelf_SelectedIndexChanged);
            this.cb_shelf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_shelf_KeyDown);
            this.cb_shelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            // 
            // cb_category
            // 
            this.cb_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.cb_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_category.ForeColor = System.Drawing.Color.Gray;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Items.AddRange(new object[] {
            "Category"});
            this.cb_category.Location = new System.Drawing.Point(139, 182);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(290, 28);
            this.cb_category.TabIndex = 4;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.Cb_category_SelectedIndexChanged);
            this.cb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_category_KeyDown);
            this.cb_category.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            // 
            // cb_publisher
            // 
            this.cb_publisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.cb_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_publisher.ForeColor = System.Drawing.Color.Gray;
            this.cb_publisher.FormattingEnabled = true;
            this.cb_publisher.Items.AddRange(new object[] {
            "Publisher\'s Name"});
            this.cb_publisher.Location = new System.Drawing.Point(139, 136);
            this.cb_publisher.Name = "cb_publisher";
            this.cb_publisher.Size = new System.Drawing.Size(290, 28);
            this.cb_publisher.TabIndex = 3;
            this.cb_publisher.SelectedIndexChanged += new System.EventHandler(this.Cb_publisher_SelectedIndexChanged);
            this.cb_publisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_publisher_KeyDown);
            this.cb_publisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            // 
            // cb_author
            // 
            this.cb_author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.cb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_author.ForeColor = System.Drawing.Color.Gray;
            this.cb_author.FormattingEnabled = true;
            this.cb_author.Items.AddRange(new object[] {
            "Author\'s Name"});
            this.cb_author.Location = new System.Drawing.Point(139, 90);
            this.cb_author.Name = "cb_author";
            this.cb_author.Size = new System.Drawing.Size(290, 28);
            this.cb_author.TabIndex = 2;
            this.cb_author.SelectedIndexChanged += new System.EventHandler(this.Cb_author_SelectedIndexChanged);
            this.cb_author.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_author_KeyDown);
            this.cb_author.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            // 
            // lbl_shelf
            // 
            this.lbl_shelf.AutoSize = true;
            this.lbl_shelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shelf.ForeColor = System.Drawing.Color.White;
            this.lbl_shelf.Location = new System.Drawing.Point(12, 390);
            this.lbl_shelf.Name = "lbl_shelf";
            this.lbl_shelf.Size = new System.Drawing.Size(57, 24);
            this.lbl_shelf.TabIndex = 28;
            this.lbl_shelf.Text = "Shelf:";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(12, 182);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(90, 24);
            this.lbl_category.TabIndex = 26;
            this.lbl_category.Text = "Category:";
            // 
            // numUpDown_count
            // 
            this.numUpDown_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.numUpDown_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUpDown_count.ForeColor = System.Drawing.Color.LightGray;
            this.numUpDown_count.Location = new System.Drawing.Point(139, 431);
            this.numUpDown_count.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDown_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDown_count.Name = "numUpDown_count";
            this.numUpDown_count.Size = new System.Drawing.Size(76, 30);
            this.numUpDown_count.TabIndex = 7;
            this.numUpDown_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(12, 11);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_message.TabIndex = 24;
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(227, 500);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 23;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.Change_Image_Click);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(12, 228);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(109, 24);
            this.lbl_description.TabIndex = 22;
            this.lbl_description.Text = "Description:";
            // 
            // tb_description
            // 
            this.tb_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_description.ForeColor = System.Drawing.Color.DimGray;
            this.tb_description.Location = new System.Drawing.Point(139, 229);
            this.tb_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_description.Size = new System.Drawing.Size(290, 129);
            this.tb_description.TabIndex = 5;
            this.tb_description.Text = "Description...";
            this.tb_description.Enter += new System.EventHandler(this.tb_description_Enter);
            this.tb_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            this.tb_description.Leave += new System.EventHandler(this.tb_description_Leave);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_count.ForeColor = System.Drawing.Color.White;
            this.lbl_count.Location = new System.Drawing.Point(12, 434);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(65, 24);
            this.lbl_count.TabIndex = 18;
            this.lbl_count.Text = "Count:";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(11, 496);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 57);
            this.btn_add.TabIndex = 17;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_Add_Click);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            // 
            // pic_book
            // 
            this.pic_book.Image = ((System.Drawing.Image)(resources.GetObject("pic_book.Image")));
            this.pic_book.Location = new System.Drawing.Point(296, 379);
            this.pic_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(133, 169);
            this.pic_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_book.TabIndex = 16;
            this.pic_book.TabStop = false;
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoSize = true;
            this.lbl_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_publisher.ForeColor = System.Drawing.Color.White;
            this.lbl_publisher.Location = new System.Drawing.Point(12, 136);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(94, 24);
            this.lbl_publisher.TabIndex = 13;
            this.lbl_publisher.Text = "Publisher:";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(12, 90);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(71, 24);
            this.lbl_author.TabIndex = 11;
            this.lbl_author.Text = "Author:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(12, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(66, 24);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_name.Location = new System.Drawing.Point(139, 45);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(290, 27);
            this.tb_name.TabIndex = 1;
            this.tb_name.Text = "Book\'s Name";
            this.tb_name.Enter += new System.EventHandler(this.tb_name_Enter);
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            this.tb_name.Leave += new System.EventHandler(this.tb_name_Leave);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(455, 561);
            this.Controls.Add(this.pnl_main);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AddBook";
            this.Opacity = 0.95D;
            this.Text = "AddBook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBook_FormClosing);
            this.Load += new System.EventHandler(this.AddBook_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_add_KeyPress);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label lbl_publisher;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_count;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.NumericUpDown numUpDown_count;
        private System.Windows.Forms.Label lbl_shelf;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cb_shelf;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.ComboBox cb_publisher;
        private System.Windows.Forms.ComboBox cb_author;
        private System.Windows.Forms.TextBox tb_name;
    }
}