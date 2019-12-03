using System.Windows.Forms;

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
            this.lbl_date_of_est = new System.Windows.Forms.Label();
            this.lbl_pub_name = new System.Windows.Forms.Label();
            this.tb_pub_name = new System.Windows.Forms.TextBox();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_publisher = new System.Windows.Forms.PictureBox();
            this.dtp_publisher = new System.Windows.Forms.DateTimePicker();
            this.lbl_pub_email = new System.Windows.Forms.Label();
            this.tb_pub_email = new System.Windows.Forms.TextBox();
            this.lbl_pub_phone_num = new System.Windows.Forms.Label();
            this.tb_pub_phone_num = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_publisher)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pub_message
            // 
            this.lbl_pub_message.AutoSize = true;
            this.lbl_pub_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_message.Location = new System.Drawing.Point(14, 8);
            this.lbl_pub_message.Name = "lbl_pub_message";
            this.lbl_pub_message.Size = new System.Drawing.Size(0, 16);
            this.lbl_pub_message.TabIndex = 44;
            // 
            // lbl_date_of_est
            // 
            this.lbl_date_of_est.AutoSize = true;
            this.lbl_date_of_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_date_of_est.ForeColor = System.Drawing.Color.White;
            this.lbl_date_of_est.Location = new System.Drawing.Point(14, 137);
            this.lbl_date_of_est.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date_of_est.Name = "lbl_date_of_est";
            this.lbl_date_of_est.Size = new System.Drawing.Size(43, 18);
            this.lbl_date_of_est.TabIndex = 37;
            this.lbl_date_of_est.Text = "Date:";
            // 
            // lbl_pub_name
            // 
            this.lbl_pub_name.AutoSize = true;
            this.lbl_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_name.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_name.Location = new System.Drawing.Point(14, 35);
            this.lbl_pub_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pub_name.Name = "lbl_pub_name";
            this.lbl_pub_name.Size = new System.Drawing.Size(52, 18);
            this.lbl_pub_name.TabIndex = 36;
            this.lbl_pub_name.Text = "Name:";
            // 
            // tb_pub_name
            // 
            this.tb_pub_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pub_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_pub_name.Location = new System.Drawing.Point(135, 35);
            this.tb_pub_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pub_name.Name = "tb_pub_name";
            this.tb_pub_name.Size = new System.Drawing.Size(206, 23);
            this.tb_pub_name.TabIndex = 29;
            this.tb_pub_name.Text = "Publisher\'s Name";
            this.tb_pub_name.Enter += new System.EventHandler(this.tb_pub_name_Enter);
            this.tb_pub_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            this.tb_pub_name.Leave += new System.EventHandler(this.tb_pub_name_Leave);
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(189, 301);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(47, 42);
            this.btn_add_pic.TabIndex = 33;
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
            this.btn_add.Location = new System.Drawing.Point(17, 297);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 46);
            this.btn_add.TabIndex = 34;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // pic_publisher
            // 
            this.pic_publisher.Image = ((System.Drawing.Image)(resources.GetObject("pic_publisher.Image")));
            this.pic_publisher.Location = new System.Drawing.Point(241, 206);
            this.pic_publisher.Margin = new System.Windows.Forms.Padding(2);
            this.pic_publisher.Name = "pic_publisher";
            this.pic_publisher.Size = new System.Drawing.Size(100, 137);
            this.pic_publisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_publisher.TabIndex = 39;
            this.pic_publisher.TabStop = false;
            // 
            // dtp_publisher
            // 
            this.dtp_publisher.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtp_publisher.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.dtp_publisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_publisher.CustomFormat = "yyyy";
            this.dtp_publisher.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_publisher.Location = new System.Drawing.Point(136, 137);
            this.dtp_publisher.Name = "dtp_publisher";
            this.dtp_publisher.Size = new System.Drawing.Size(206, 20);
            this.dtp_publisher.TabIndex = 32;
            this.dtp_publisher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            // 
            // lbl_pub_email
            // 
            this.lbl_pub_email.AutoSize = true;
            this.lbl_pub_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_email.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_email.Location = new System.Drawing.Point(14, 69);
            this.lbl_pub_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pub_email.Name = "lbl_pub_email";
            this.lbl_pub_email.Size = new System.Drawing.Size(49, 18);
            this.lbl_pub_email.TabIndex = 49;
            this.lbl_pub_email.Text = "Email:";
            // 
            // tb_pub_email
            // 
            this.tb_pub_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_pub_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pub_email.ForeColor = System.Drawing.Color.DimGray;
            this.tb_pub_email.Location = new System.Drawing.Point(135, 69);
            this.tb_pub_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pub_email.Name = "tb_pub_email";
            this.tb_pub_email.Size = new System.Drawing.Size(206, 23);
            this.tb_pub_email.TabIndex = 30;
            this.tb_pub_email.Text = "Publisher\'s Email";
            this.tb_pub_email.Enter += new System.EventHandler(this.tb_pub_email_Enter);
            this.tb_pub_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            this.tb_pub_email.Leave += new System.EventHandler(this.tb_pub_email_Leave);
            // 
            // lbl_pub_phone_num
            // 
            this.lbl_pub_phone_num.AutoSize = true;
            this.lbl_pub_phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_phone_num.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_phone_num.Location = new System.Drawing.Point(14, 103);
            this.lbl_pub_phone_num.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pub_phone_num.Name = "lbl_pub_phone_num";
            this.lbl_pub_phone_num.Size = new System.Drawing.Size(112, 18);
            this.lbl_pub_phone_num.TabIndex = 51;
            this.lbl_pub_phone_num.Text = "Phone Number:";
            // 
            // tb_pub_phone_num
            // 
            this.tb_pub_phone_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_pub_phone_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pub_phone_num.ForeColor = System.Drawing.Color.DimGray;
            this.tb_pub_phone_num.Location = new System.Drawing.Point(135, 103);
            this.tb_pub_phone_num.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pub_phone_num.Name = "tb_pub_phone_num";
            this.tb_pub_phone_num.Size = new System.Drawing.Size(206, 23);
            this.tb_pub_phone_num.TabIndex = 31;
            this.tb_pub_phone_num.Text = "Publisher\'s Phone Number";
            this.tb_pub_phone_num.Enter += new System.EventHandler(this.tb_pub_phone_num_Enter);
            this.tb_pub_phone_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            this.tb_pub_phone_num.Leave += new System.EventHandler(this.tb_pub_phone_num_Leave);
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(364, 366);
            this.Controls.Add(this.lbl_pub_phone_num);
            this.Controls.Add(this.tb_pub_phone_num);
            this.Controls.Add(this.lbl_pub_email);
            this.Controls.Add(this.tb_pub_email);
            this.Controls.Add(this.dtp_publisher);
            this.Controls.Add(this.lbl_pub_message);
            this.Controls.Add(this.btn_add_pic);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_publisher);
            this.Controls.Add(this.lbl_date_of_est);
            this.Controls.Add(this.lbl_pub_name);
            this.Controls.Add(this.tb_pub_name);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddPublisher";
            this.Opacity = 0.95D;
            this.Text = "AddPublisher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddPublisher_FormClosed);
            this.Load += new System.EventHandler(this.AddPublisher_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_add_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pic_publisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pub_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_publisher;
        private System.Windows.Forms.Label lbl_date_of_est;
        private System.Windows.Forms.Label lbl_pub_name;
        private System.Windows.Forms.TextBox tb_pub_name;
        private System.Windows.Forms.DateTimePicker dtp_publisher;
        private Label lbl_pub_email;
        private TextBox tb_pub_email;
        private Label lbl_pub_phone_num;
        private TextBox tb_pub_phone_num;

        public DateTimePicker Dtp_publisher { get => dtp_publisher; set => dtp_publisher = value; }
    }
}