namespace Microwave_v1._0.Forms
{
    partial class AddPublisher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPublisher));
            this.lbl_pub_message = new System.Windows.Forms.Label();
            this.lbl_pub_description = new System.Windows.Forms.Label();
            this.tb_pub_description = new System.Windows.Forms.TextBox();
            this.lbl_date_of_est = new System.Windows.Forms.Label();
            this.lbl_pub_name = new System.Windows.Forms.Label();
            this.tb_pub_name = new System.Windows.Forms.TextBox();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_book = new System.Windows.Forms.PictureBox();
            this.dtp_publisher = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pub_message
            // 
            this.lbl_pub_message.AutoSize = true;
            this.lbl_pub_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_message.Location = new System.Drawing.Point(19, 10);
            this.lbl_pub_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_pub_message.Name = "lbl_pub_message";
            this.lbl_pub_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_pub_message.TabIndex = 44;
            // 
            // lbl_pub_description
            // 
            this.lbl_pub_description.AutoSize = true;
            this.lbl_pub_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_description.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_description.Location = new System.Drawing.Point(19, 84);
            this.lbl_pub_description.Name = "lbl_pub_description";
            this.lbl_pub_description.Size = new System.Drawing.Size(109, 24);
            this.lbl_pub_description.TabIndex = 42;
            this.lbl_pub_description.Text = "Description:";
            // 
            // tb_pub_description
            // 
            this.tb_pub_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_pub_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pub_description.ForeColor = System.Drawing.Color.DimGray;
            this.tb_pub_description.Location = new System.Drawing.Point(139, 84);
            this.tb_pub_description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pub_description.Multiline = true;
            this.tb_pub_description.Name = "tb_pub_description";
            this.tb_pub_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_pub_description.Size = new System.Drawing.Size(274, 130);
            this.tb_pub_description.TabIndex = 33;
            this.tb_pub_description.Text = "Description...";
            this.tb_pub_description.Enter += new System.EventHandler(this.tb_pub_description_Enter);
            this.tb_pub_description.Leave += new System.EventHandler(this.tb_pub_description_Leave);
            // 
            // lbl_date_of_est
            // 
            this.lbl_date_of_est.AutoSize = true;
            this.lbl_date_of_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date_of_est.ForeColor = System.Drawing.Color.White;
            this.lbl_date_of_est.Location = new System.Drawing.Point(19, 229);
            this.lbl_date_of_est.Name = "lbl_date_of_est";
            this.lbl_date_of_est.Size = new System.Drawing.Size(53, 24);
            this.lbl_date_of_est.TabIndex = 37;
            this.lbl_date_of_est.Text = "Date:";
            // 
            // lbl_pub_name
            // 
            this.lbl_pub_name.AutoSize = true;
            this.lbl_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_name.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_name.Location = new System.Drawing.Point(19, 43);
            this.lbl_pub_name.Name = "lbl_pub_name";
            this.lbl_pub_name.Size = new System.Drawing.Size(66, 24);
            this.lbl_pub_name.TabIndex = 36;
            this.lbl_pub_name.Text = "Name:";
            // 
            // tb_pub_name
            // 
            this.tb_pub_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pub_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_pub_name.Location = new System.Drawing.Point(139, 43);
            this.tb_pub_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_pub_name.Name = "tb_pub_name";
            this.tb_pub_name.Size = new System.Drawing.Size(274, 27);
            this.tb_pub_name.TabIndex = 29;
            this.tb_pub_name.Text = "Publisher\'s Name";
            this.tb_pub_name.Enter += new System.EventHandler(this.tb_pub_name_Enter);
            this.tb_pub_name.Leave += new System.EventHandler(this.tb_pub_name_Leave);
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(211, 428);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 43;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.Change_Image_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.correct_symbol__1_;
            this.btn_add.Location = new System.Drawing.Point(23, 423);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 57);
            this.btn_add.TabIndex = 40;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // pic_book
            // 
            this.pic_book.Image = ((System.Drawing.Image)(resources.GetObject("pic_book.Image")));
            this.pic_book.Location = new System.Drawing.Point(280, 311);
            this.pic_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_book.Name = "pic_book";
            this.pic_book.Size = new System.Drawing.Size(133, 169);
            this.pic_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_book.TabIndex = 39;
            this.pic_book.TabStop = false;
            // 
            // dtp_publisher
            // 
            this.dtp_publisher.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.dtp_publisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtp_publisher.Location = new System.Drawing.Point(139, 231);
            this.dtp_publisher.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_publisher.Name = "dtp_publisher";
            this.dtp_publisher.Size = new System.Drawing.Size(274, 22);
            this.dtp_publisher.TabIndex = 47;
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(440, 497);
            this.Controls.Add(this.dtp_publisher);
            this.Controls.Add(this.lbl_pub_message);
            this.Controls.Add(this.btn_add_pic);
            this.Controls.Add(this.lbl_pub_description);
            this.Controls.Add(this.tb_pub_description);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_book);
            this.Controls.Add(this.lbl_date_of_est);
            this.Controls.Add(this.lbl_pub_name);
            this.Controls.Add(this.tb_pub_name);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AddPublisher";
            this.Opacity = 0.95D;
            this.Text = "AddPublisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPublisher_FormClosed);
            this.Load += new System.EventHandler(this.AddPublisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pub_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Label lbl_pub_description;
        private System.Windows.Forms.TextBox tb_pub_description;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_book;
        private System.Windows.Forms.Label lbl_date_of_est;
        private System.Windows.Forms.Label lbl_pub_name;
        private System.Windows.Forms.TextBox tb_pub_name;
        private System.Windows.Forms.DateTimePicker dtp_publisher;
    }
}