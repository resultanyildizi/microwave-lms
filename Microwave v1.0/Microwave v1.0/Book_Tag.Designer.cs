namespace Microwave_v1._0
{
    partial class Book_Tag
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Tag));
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.lbl_bookname = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_book
            // 
            this.pic_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_book.Image = ((System.Drawing.Image)(resources.GetObject("pic_book.Image")));
            this.pic_book.Location = new System.Drawing.Point(39, 107);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(163, 226);
            this.pic_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_book.TabIndex = 0;
            this.pic_book.TabStop = false;
            // 
            // lbl_bookname
            // 
            this.lbl_bookname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bookname.ForeColor = System.Drawing.Color.White;
            this.lbl_bookname.Location = new System.Drawing.Point(3, 336);
            this.lbl_bookname.Name = "lbl_bookname";
            this.lbl_bookname.Size = new System.Drawing.Size(239, 99);
            this.lbl_bookname.TabIndex = 1;
            this.lbl_bookname.Text = "Book Name";
            this.lbl_bookname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_description
            // 
            this.lbl_description.AllowDrop = true;
            this.lbl_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.lbl_description.Font = new System.Drawing.Font("SansSerif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(13, 435);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(215, 179);
            this.lbl_description.TabIndex = 2;
            this.lbl_description.Text = resources.GetString("lbl_description.Text");
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_author
            // 
            this.lbl_author.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(21, 614);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(198, 62);
            this.lbl_author.TabIndex = 3;
            this.lbl_author.Text = "-Author Name";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 101);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Book_Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(98)))), ((int)(((byte)(120)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_bookname);
            this.Controls.Add(this.pic_book);
            this.Name = "Book_Tag";
            this.Size = new System.Drawing.Size(242, 676);
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_book;
        public System.Windows.Forms.Label lbl_bookname;
        public System.Windows.Forms.Label lbl_description;
        public System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
