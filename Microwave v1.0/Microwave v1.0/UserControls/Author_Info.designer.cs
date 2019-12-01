namespace Microwave_v1._0.UserControls
{
    partial class Author_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Author_Info));
            this.pb_author = new System.Windows.Forms.PictureBox();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_author = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_author_id = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_author)).BeginInit();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_author
            // 
            this.pb_author.Image = ((System.Drawing.Image)(resources.GetObject("pb_author.Image")));
            this.pb_author.Location = new System.Drawing.Point(26, 20);
            this.pb_author.Margin = new System.Windows.Forms.Padding(2);
            this.pb_author.Name = "pb_author";
            this.pb_author.Size = new System.Drawing.Size(105, 154);
            this.pb_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_author.TabIndex = 0;
            this.pb_author.TabStop = false;
            this.pb_author.Click += new System.EventHandler(this.Author_Info_Click);
            this.pb_author.DoubleClick += new System.EventHandler(this.Author_Info_DoubleClick);
            this.pb_author.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this.pb_author.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            // 
            // pnl_name
            // 
            this.pnl_name.AllowDrop = true;
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.pnl_name.Controls.Add(this.lbl_author);
            this.pnl_name.Location = new System.Drawing.Point(12, 191);
            this.pnl_name.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(131, 28);
            this.pnl_name.TabIndex = 2;
            this.pnl_name.Click += new System.EventHandler(this.Author_Info_Click);
            this.pnl_name.DoubleClick += new System.EventHandler(this.Author_Info_DoubleClick);
            this.pnl_name.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this.pnl_name.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            // 
            // lbl_author
            // 
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(-1, 1);
            this.lbl_author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(131, 27);
            this.lbl_author.TabIndex = 0;
            this.lbl_author.Text = "Author Name";
            this.lbl_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_author.Click += new System.EventHandler(this.Author_Info_Click);
            this.lbl_author.DoubleClick += new System.EventHandler(this.Author_Info_DoubleClick);
            this.lbl_author.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this.lbl_author.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(2, 20);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(19, 19);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(2, 2);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(19, 19);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_author_id
            // 
            this.btn_author_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_author_id.FlatAppearance.BorderSize = 0;
            this.btn_author_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_author_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_author_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_author_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_author_id.ForeColor = System.Drawing.Color.White;
            this.btn_author_id.Image = ((System.Drawing.Image)(resources.GetObject("btn_author_id.Image")));
            this.btn_author_id.Location = new System.Drawing.Point(131, -4);
            this.btn_author_id.Margin = new System.Windows.Forms.Padding(2);
            this.btn_author_id.Name = "btn_author_id";
            this.btn_author_id.Size = new System.Drawing.Size(29, 37);
            this.btn_author_id.TabIndex = 19;
            this.btn_author_id.UseVisualStyleBackColor = true;
            // 
            // Author_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btn_author_id);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.pb_author);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Author_Info";
            this.Size = new System.Drawing.Size(160, 229);
            this.Click += new System.EventHandler(this.Author_Info_Click);
            this.DoubleClick += new System.EventHandler(this.Author_Info_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.lbl_name_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lbl_name_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_author)).EndInit();
            this.pnl_name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_author;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_author_id;
    }
}
