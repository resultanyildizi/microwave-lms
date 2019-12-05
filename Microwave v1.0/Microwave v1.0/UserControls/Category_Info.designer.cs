namespace Microwave_v1._0.UserControls
{
    partial class Category_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Info));
            this.pnl_category_name = new System.Windows.Forms.Panel();
            this.lbl_category = new System.Windows.Forms.Label();
            this.btn_category_id = new System.Windows.Forms.Button();
            this.btn_category_remove = new System.Windows.Forms.Button();
            this.btn_category_edit = new System.Windows.Forms.Button();
            this.pb_category = new System.Windows.Forms.PictureBox();
            this.pnl_category_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_category)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_category_name
            // 
            this.pnl_category_name.AllowDrop = true;
            this.pnl_category_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.pnl_category_name.Controls.Add(this.lbl_category);
            this.pnl_category_name.Location = new System.Drawing.Point(12, 191);
            this.pnl_category_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_category_name.Name = "pnl_category_name";
            this.pnl_category_name.Size = new System.Drawing.Size(131, 28);
            this.pnl_category_name.TabIndex = 21;
            this.pnl_category_name.Click += new System.EventHandler(this.Category_Info_Click);
            this.pnl_category_name.DoubleClick += new System.EventHandler(this.Category_Info_DoubleClick);
            this.pnl_category_name.MouseEnter += new System.EventHandler(this.lbl_category_name_MouseEnter);
            this.pnl_category_name.MouseLeave += new System.EventHandler(this.lbl_category_name_MouseLeave);
            // 
            // lbl_category
            // 
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_category.ForeColor = System.Drawing.Color.White;
            this.lbl_category.Location = new System.Drawing.Point(0, 0);
            this.lbl_category.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(131, 27);
            this.lbl_category.TabIndex = 0;
            this.lbl_category.Text = "Category Name";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_category.Click += new System.EventHandler(this.Category_Info_Click);
            this.lbl_category.DoubleClick += new System.EventHandler(this.Category_Info_DoubleClick);
            this.lbl_category.MouseEnter += new System.EventHandler(this.lbl_category_name_MouseEnter);
            this.lbl_category.MouseLeave += new System.EventHandler(this.lbl_category_name_MouseLeave);
            // 
            // btn_category_id
            // 
            this.btn_category_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category_id.FlatAppearance.BorderSize = 0;
            this.btn_category_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_category_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_category_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_category_id.ForeColor = System.Drawing.Color.White;
            this.btn_category_id.Image = ((System.Drawing.Image)(resources.GetObject("btn_category_id.Image")));
            this.btn_category_id.Location = new System.Drawing.Point(131, -4);
            this.btn_category_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_category_id.Name = "btn_category_id";
            this.btn_category_id.Size = new System.Drawing.Size(29, 37);
            this.btn_category_id.TabIndex = 24;
            this.btn_category_id.UseVisualStyleBackColor = true;
            // 
            // btn_category_remove
            // 
            this.btn_category_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category_remove.FlatAppearance.BorderSize = 0;
            this.btn_category_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_category_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_category_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_category_remove.Image")));
            this.btn_category_remove.Location = new System.Drawing.Point(2, 20);
            this.btn_category_remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_category_remove.Name = "btn_category_remove";
            this.btn_category_remove.Size = new System.Drawing.Size(19, 19);
            this.btn_category_remove.TabIndex = 23;
            this.btn_category_remove.UseVisualStyleBackColor = true;
            this.btn_category_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_category_edit
            // 
            this.btn_category_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_category_edit.FlatAppearance.BorderSize = 0;
            this.btn_category_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_category_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_category_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_category_edit.Image")));
            this.btn_category_edit.Location = new System.Drawing.Point(2, 2);
            this.btn_category_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_category_edit.Name = "btn_category_edit";
            this.btn_category_edit.Size = new System.Drawing.Size(19, 19);
            this.btn_category_edit.TabIndex = 22;
            this.btn_category_edit.UseVisualStyleBackColor = true;
            this.btn_category_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pb_category
            // 
            this.pb_category.Image = ((System.Drawing.Image)(resources.GetObject("pb_category.Image")));
            this.pb_category.Location = new System.Drawing.Point(26, 20);
            this.pb_category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_category.Name = "pb_category";
            this.pb_category.Size = new System.Drawing.Size(105, 154);
            this.pb_category.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_category.TabIndex = 20;
            this.pb_category.TabStop = false;
            this.pb_category.Click += new System.EventHandler(this.Category_Info_Click);
            this.pb_category.DoubleClick += new System.EventHandler(this.Category_Info_DoubleClick);
            this.pb_category.MouseEnter += new System.EventHandler(this.lbl_category_name_MouseEnter);
            this.pb_category.MouseLeave += new System.EventHandler(this.lbl_category_name_MouseLeave);
            // 
            // Category_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.btn_category_id);
            this.Controls.Add(this.btn_category_remove);
            this.Controls.Add(this.btn_category_edit);
            this.Controls.Add(this.pnl_category_name);
            this.Controls.Add(this.pb_category);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Category_Info";
            this.Size = new System.Drawing.Size(160, 229);
            this.Click += new System.EventHandler(this.Category_Info_Click);
            this.DoubleClick += new System.EventHandler(this.Category_Info_DoubleClick);
            this.MouseEnter += new System.EventHandler(this.lbl_category_name_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lbl_category_name_MouseLeave);
            this.pnl_category_name.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_category_id;
        private System.Windows.Forms.Button btn_category_remove;
        private System.Windows.Forms.Button btn_category_edit;
        private System.Windows.Forms.Panel pnl_category_name;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.PictureBox pb_category;
    }
}
