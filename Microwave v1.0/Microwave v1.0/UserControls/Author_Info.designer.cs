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
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.lbl_author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_author)).BeginInit();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_author
            // 
            this.pb_author.Image = ((System.Drawing.Image)(resources.GetObject("pb_author.Image")));
            this.pb_author.Location = new System.Drawing.Point(35, 25);
            this.pb_author.Name = "pb_author";
            this.pb_author.Size = new System.Drawing.Size(140, 190);
            this.pb_author.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_author.TabIndex = 0;
            this.pb_author.TabStop = false;
            // 
            // pnl_name
            // 
            this.pnl_name.AllowDrop = true;
            this.pnl_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_name.Controls.Add(this.lbl_author);
            this.pnl_name.Location = new System.Drawing.Point(3, 233);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(194, 34);
            this.pnl_name.TabIndex = 2;
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(3, 25);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(25, 23);
            this.btn_remove.TabIndex = 6;
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.Location = new System.Drawing.Point(3, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(25, 23);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_author.ForeColor = System.Drawing.Color.White;
            this.lbl_author.Location = new System.Drawing.Point(38, 5);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(127, 25);
            this.lbl_author.TabIndex = 0;
            this.lbl_author.Text = "Author Name";
            // 
            // Author_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.pb_author);
            this.Name = "Author_Info";
            this.Size = new System.Drawing.Size(205, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pb_author)).EndInit();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_author;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_edit;
    }
}
