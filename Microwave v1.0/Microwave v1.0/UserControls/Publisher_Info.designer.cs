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
            this.pnl_date_of_est = new System.Windows.Forms.Panel();
            this.lbl_date_of_est = new System.Windows.Forms.Label();
            this.btn_pub_remove = new System.Windows.Forms.Button();
            this.btn_pub_edit = new System.Windows.Forms.Button();
            this.pnl_pub_name.SuspendLayout();
            this.pnl_date_of_est.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_pub_name
            // 
            this.pnl_pub_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.pnl_pub_name.Controls.Add(this.lbl_pub_name);
            this.pnl_pub_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_pub_name.Location = new System.Drawing.Point(32, 0);
            this.pnl_pub_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_pub_name.Name = "pnl_pub_name";
            this.pnl_pub_name.Size = new System.Drawing.Size(255, 49);
            this.pnl_pub_name.TabIndex = 5;
            this.pnl_pub_name.Click += new System.EventHandler(this.Publisher_Info_Click);
            this.pnl_pub_name.MouseEnter += new System.EventHandler(this.Publisher_Info_Enter);
            this.pnl_pub_name.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // lbl_pub_name
            // 
            this.lbl_pub_name.AutoEllipsis = true;
            this.lbl_pub_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_pub_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pub_name.ForeColor = System.Drawing.Color.White;
            this.lbl_pub_name.Location = new System.Drawing.Point(4, 16);
            this.lbl_pub_name.Name = "lbl_pub_name";
            this.lbl_pub_name.Size = new System.Drawing.Size(179, 25);
            this.lbl_pub_name.TabIndex = 0;
            this.lbl_pub_name.Text = "Kürk Mantolu Madonna";
            this.lbl_pub_name.Click += new System.EventHandler(this.Publisher_Info_Click);
            this.lbl_pub_name.MouseEnter += new System.EventHandler(this.Publisher_Info_Enter);
            this.lbl_pub_name.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // pnl_date_of_est
            // 
            this.pnl_date_of_est.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.pnl_date_of_est.Controls.Add(this.lbl_date_of_est);
            this.pnl_date_of_est.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_date_of_est.Location = new System.Drawing.Point(292, 0);
            this.pnl_date_of_est.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_date_of_est.Name = "pnl_date_of_est";
            this.pnl_date_of_est.Size = new System.Drawing.Size(248, 49);
            this.pnl_date_of_est.TabIndex = 8;
            this.pnl_date_of_est.Click += new System.EventHandler(this.Publisher_Info_Click);
            this.pnl_date_of_est.MouseEnter += new System.EventHandler(this.Publisher_Info_Enter);
            this.pnl_date_of_est.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // lbl_date_of_est
            // 
            this.lbl_date_of_est.AutoEllipsis = true;
            this.lbl_date_of_est.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_date_of_est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date_of_est.ForeColor = System.Drawing.Color.White;
            this.lbl_date_of_est.Location = new System.Drawing.Point(3, 16);
            this.lbl_date_of_est.Name = "lbl_date_of_est";
            this.lbl_date_of_est.Size = new System.Drawing.Size(155, 25);
            this.lbl_date_of_est.TabIndex = 1;
            this.lbl_date_of_est.Text = "Sabahattin Ali";
            this.lbl_date_of_est.Click += new System.EventHandler(this.Publisher_Info_Click);
            this.lbl_date_of_est.MouseEnter += new System.EventHandler(this.Publisher_Info_Enter);
            this.lbl_date_of_est.MouseLeave += new System.EventHandler(this.lbl_pub_name_MouseLeave);
            // 
            // btn_pub_remove
            // 
            this.btn_pub_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pub_remove.FlatAppearance.BorderSize = 0;
            this.btn_pub_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pub_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_pub_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_pub_remove.Image")));
            this.btn_pub_remove.Location = new System.Drawing.Point(3, 25);
            this.btn_pub_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pub_remove.Name = "btn_pub_remove";
            this.btn_pub_remove.Size = new System.Drawing.Size(25, 23);
            this.btn_pub_remove.TabIndex = 11;
            this.btn_pub_remove.UseVisualStyleBackColor = true;
            this.btn_pub_remove.Click += new System.EventHandler(this.btn_pub_remove_Click);
            // 
            // btn_pub_edit
            // 
            this.btn_pub_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pub_edit.FlatAppearance.BorderSize = 0;
            this.btn_pub_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_pub_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_pub_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pub_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_pub_edit.Image")));
            this.btn_pub_edit.Location = new System.Drawing.Point(3, 0);
            this.btn_pub_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pub_edit.Name = "btn_pub_edit";
            this.btn_pub_edit.Size = new System.Drawing.Size(25, 23);
            this.btn_pub_edit.TabIndex = 10;
            this.btn_pub_edit.UseVisualStyleBackColor = true;
            this.btn_pub_edit.Click += new System.EventHandler(this.btn_pub_edit_Click);
            // 
            // Publisher_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.btn_pub_remove);
            this.Controls.Add(this.btn_pub_edit);
            this.Controls.Add(this.pnl_pub_name);
            this.Controls.Add(this.pnl_date_of_est);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Publisher_Info";
            this.Size = new System.Drawing.Size(545, 49);
            this.Load += new System.EventHandler(this.Publisher_Info_Load);
            this.Click += new System.EventHandler(this.Publisher_Info_Click);
            this.Enter += new System.EventHandler(this.Publisher_Info_Enter);
            this.MouseEnter += new System.EventHandler(this.Publisher_Info_Enter);
            this.pnl_pub_name.ResumeLayout(false);
            this.pnl_date_of_est.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pub_remove;
        private System.Windows.Forms.Button btn_pub_edit;
        private System.Windows.Forms.Panel pnl_pub_name;
        private System.Windows.Forms.Label lbl_pub_name;
        private System.Windows.Forms.Panel pnl_date_of_est;
        private System.Windows.Forms.Label lbl_date_of_est;
    }
}
