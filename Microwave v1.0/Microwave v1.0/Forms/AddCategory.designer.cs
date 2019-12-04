namespace Microwave_v1._0.Forms
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.lbl_category_message = new System.Windows.Forms.Label();
            this.lbl_category_name = new System.Windows.Forms.Label();
            this.tb_category_name = new System.Windows.Forms.TextBox();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_category = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_category)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_category_message
            // 
            this.lbl_category_message.AutoSize = true;
            this.lbl_category_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category_message.Location = new System.Drawing.Point(12, 4);
            this.lbl_category_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_category_message.Name = "lbl_category_message";
            this.lbl_category_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_category_message.TabIndex = 61;
            // 
            // lbl_category_name
            // 
            this.lbl_category_name.AutoSize = true;
            this.lbl_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category_name.ForeColor = System.Drawing.Color.White;
            this.lbl_category_name.Location = new System.Drawing.Point(12, 37);
            this.lbl_category_name.Name = "lbl_category_name";
            this.lbl_category_name.Size = new System.Drawing.Size(66, 24);
            this.lbl_category_name.TabIndex = 58;
            this.lbl_category_name.Text = "Name:";
            // 
            // tb_category_name
            // 
            this.tb_category_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_category_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_category_name.ForeColor = System.Drawing.Color.DimGray;
            this.tb_category_name.Location = new System.Drawing.Point(157, 37);
            this.tb_category_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_category_name.Name = "tb_category_name";
            this.tb_category_name.Size = new System.Drawing.Size(289, 27);
            this.tb_category_name.TabIndex = 52;
            this.tb_category_name.Text = "Category\'s Name";
            this.tb_category_name.Enter += new System.EventHandler(this.tb_category_name_Enter);
            
            this.tb_category_name.Leave += new System.EventHandler(this.tb_category_name_Leave);
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(227, 218);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 56;
            this.btn_add_pic.UseVisualStyleBackColor = true;
            this.btn_add_pic.Click += new System.EventHandler(this.btn_add_pic_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::Microwave_v1._0.Properties.Resources.correct_symbol__1_;
            this.btn_add.Location = new System.Drawing.Point(13, 213);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 57);
            this.btn_add.TabIndex = 57;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_category
            // 
            this.pic_category.Image = ((System.Drawing.Image)(resources.GetObject("pic_category.Image")));
            this.pic_category.Location = new System.Drawing.Point(295, 101);
            this.pic_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_category.Name = "pic_category";
            this.pic_category.Size = new System.Drawing.Size(133, 169);
            this.pic_category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_category.TabIndex = 60;
            this.pic_category.TabStop = false;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.lbl_category_message);
            this.Controls.Add(this.btn_add_pic);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.pic_category);
            this.Controls.Add(this.lbl_category_name);
            this.Controls.Add(this.tb_category_name);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddCategory_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddCategory_FormClosed);
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_category_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_category;
        private System.Windows.Forms.Label lbl_category_name;
        private System.Windows.Forms.TextBox tb_category_name;
    }
}