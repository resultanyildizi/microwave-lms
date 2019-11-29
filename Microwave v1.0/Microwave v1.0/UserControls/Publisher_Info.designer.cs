namespace Microwave_v1._0.UserControls
{
    partial class Publisher_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Publisher_Info));
            this.pnl_pub_name = new System.Windows.Forms.Panel();
            this.lbl_pub_name = new System.Windows.Forms.Label();
            this.btn_pub_remove = new System.Windows.Forms.Button();
            this.btn_pub_edit = new System.Windows.Forms.Button();
            this.pb_publisher = new System.Windows.Forms.PictureBox();
            this.btn_refreshing_icon = new System.Windows.Forms.Button();
            this.lbl_pub_id = new System.Windows.Forms.Label();
            this.pnl_pub_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_publisher)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_pub_name
            // 
            this.pnl_pub_name.AllowDrop = true;
            this.pnl_pub_name.Controls.Add(this.lbl_pub_name);
            this.pnl_pub_name.Location = new System.Drawing.Point(12, 191);
            this.pnl_pub_name.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_pub_name.Name = "pnl_pub_name";
            this.pnl_pub_name.Size = new System.Drawing.Size(131, 28);
            this.pnl_pub_name.TabIndex = 16;
            this.pnl_pub_name.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_pub_name_Paint);
            // 
            // lbl_pub_name
            // 
            this.lbl_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_name.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_name.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_pub_name.Location = new System.Drawing.Point(-1, 1);
            this.lbl_pub_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pub_name.Name = "lbl_pub_name";
            this.lbl_pub_name.Size = new System.Drawing.Size(131, 27);
            this.lbl_pub_name.TabIndex = 0;
            this.lbl_pub_name.Text = "Publisher Name";
            this.lbl_pub_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pub_name.Click += new System.EventHandler(this.lbl_pub_name_Click);
            this.lbl_pub_name.MouseEnter += new System.EventHandler(this.lbl_pub_name_MouseEnter);
            this.lbl_pub_name.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // btn_pub_remove
            // 
            this.btn_pub_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pub_remove.FlatAppearance.BorderSize = 0;
            this.btn_pub_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pub_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_pub_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_pub_remove.Image")));
            this.btn_pub_remove.Location = new System.Drawing.Point(2, 20);
            this.btn_pub_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pub_remove.Name = "btn_pub_remove";
            this.btn_pub_remove.Size = new System.Drawing.Size(19, 19);
            this.btn_pub_remove.TabIndex = 15;
            this.btn_pub_remove.UseVisualStyleBackColor = true;
            this.btn_pub_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // btn_pub_edit
            // 
            this.btn_pub_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pub_edit.FlatAppearance.BorderSize = 0;
            this.btn_pub_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pub_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_pub_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_pub_edit.Image")));
            this.btn_pub_edit.Location = new System.Drawing.Point(2, 2);
            this.btn_pub_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_pub_edit.Name = "btn_pub_edit";
            this.btn_pub_edit.Size = new System.Drawing.Size(19, 19);
            this.btn_pub_edit.TabIndex = 14;
            this.btn_pub_edit.UseVisualStyleBackColor = true;
            this.btn_pub_edit.Click += new System.EventHandler(this.btn_pub_edit_Click);
            // 
            // pb_publisher
            // 
            this.pb_publisher.Image = ((System.Drawing.Image)(resources.GetObject("pb_publisher.Image")));
            this.pb_publisher.Location = new System.Drawing.Point(26, 20);
            this.pb_publisher.Margin = new System.Windows.Forms.Padding(2);
            this.pb_publisher.Name = "pb_publisher";
            this.pb_publisher.Size = new System.Drawing.Size(105, 154);
            this.pb_publisher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_publisher.TabIndex = 13;
            this.pb_publisher.TabStop = false;
            this.pb_publisher.Click += new System.EventHandler(this.lbl_pub_name_Click);
            this.pb_publisher.MouseEnter += new System.EventHandler(this.lbl_pub_name_MouseEnter);
            this.pb_publisher.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // btn_refreshing_icon
            // 
            this.btn_refreshing_icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refreshing_icon.FlatAppearance.BorderSize = 0;
            this.btn_refreshing_icon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_refreshing_icon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_refreshing_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshing_icon.Image = ((System.Drawing.Image)(resources.GetObject("btn_refreshing_icon.Image")));
            this.btn_refreshing_icon.Location = new System.Drawing.Point(131, -4);
            this.btn_refreshing_icon.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refreshing_icon.Name = "btn_refreshing_icon";
            this.btn_refreshing_icon.Size = new System.Drawing.Size(29, 37);
            this.btn_refreshing_icon.TabIndex = 17;
            this.btn_refreshing_icon.UseVisualStyleBackColor = true;
            // 
            // lbl_pub_id
            // 
            this.lbl_pub_id.AutoSize = true;
            this.lbl_pub_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pub_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lbl_pub_id.Location = new System.Drawing.Point(139, 8);
            this.lbl_pub_id.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_pub_id.Name = "lbl_pub_id";
            this.lbl_pub_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_pub_id.TabIndex = 18;
            // 
            // Publisher_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.lbl_pub_id);
            this.Controls.Add(this.btn_refreshing_icon);
            this.Controls.Add(this.pnl_pub_name);
            this.Controls.Add(this.btn_pub_remove);
            this.Controls.Add(this.btn_pub_edit);
            this.Controls.Add(this.pb_publisher);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Publisher_Info";
            this.Size = new System.Drawing.Size(160, 229);
            this.Click += new System.EventHandler(this.lbl_pub_name_Click);
            this.MouseEnter += new System.EventHandler(this.lbl_pub_name_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            this.pnl_pub_name.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_publisher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_pub_name;
        private System.Windows.Forms.Label lbl_pub_name;
        private System.Windows.Forms.Button btn_pub_remove;
        private System.Windows.Forms.Button btn_pub_edit;
        private System.Windows.Forms.PictureBox pb_publisher;
        private System.Windows.Forms.Button btn_refreshing_icon;
        private System.Windows.Forms.Label lbl_pub_id;
    }
}