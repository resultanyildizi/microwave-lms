namespace Microwave_v1._0.UserControls
{
    partial class Department_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Department_Info));
            this.pb_department = new System.Windows.Forms.PictureBox();
            this.btn_dprt_remove = new System.Windows.Forms.Button();
            this.btn_dprt_edit = new System.Windows.Forms.Button();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_department_name = new System.Windows.Forms.Label();
            this.btn_dep_id = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_department)).BeginInit();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_department
            // 
            this.pb_department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_department.ErrorImage = null;
            this.pb_department.Image = ((System.Drawing.Image)(resources.GetObject("pb_department.Image")));
            this.pb_department.Location = new System.Drawing.Point(26, 20);
            this.pb_department.Name = "pb_department";
            this.pb_department.Size = new System.Drawing.Size(105, 154);
            this.pb_department.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_department.TabIndex = 0;
            this.pb_department.TabStop = false;
            // 
            // btn_dprt_remove
            // 
            this.btn_dprt_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dprt_remove.FlatAppearance.BorderSize = 0;
            this.btn_dprt_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dprt_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_dprt_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dprt_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_dprt_remove.Image")));
            this.btn_dprt_remove.Location = new System.Drawing.Point(2, 20);
            this.btn_dprt_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dprt_remove.Name = "btn_dprt_remove";
            this.btn_dprt_remove.Size = new System.Drawing.Size(19, 19);
            this.btn_dprt_remove.TabIndex = 11;
            this.btn_dprt_remove.UseVisualStyleBackColor = true;
            this.btn_dprt_remove.Click += new System.EventHandler(this.btn_dprt_remove_Click);
            // 
            // btn_dprt_edit
            // 
            this.btn_dprt_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dprt_edit.FlatAppearance.BorderSize = 0;
            this.btn_dprt_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dprt_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_dprt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dprt_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_dprt_edit.Image")));
            this.btn_dprt_edit.Location = new System.Drawing.Point(2, 2);
            this.btn_dprt_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dprt_edit.Name = "btn_dprt_edit";
            this.btn_dprt_edit.Size = new System.Drawing.Size(19, 19);
            this.btn_dprt_edit.TabIndex = 10;
            this.btn_dprt_edit.UseVisualStyleBackColor = true;
            this.btn_dprt_edit.Click += new System.EventHandler(this.btn_dprt_edit_Click);
            // 
            // pnl_name
            // 
            this.pnl_name.AllowDrop = true;
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(65)))));
            this.pnl_name.Controls.Add(this.lbl_department_name);
            this.pnl_name.Location = new System.Drawing.Point(2, 189);
            this.pnl_name.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(146, 28);
            this.pnl_name.TabIndex = 12;
            // 
            // lbl_department_name
            // 
            this.lbl_department_name.AutoSize = true;
            this.lbl_department_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_department_name.ForeColor = System.Drawing.Color.White;
            this.lbl_department_name.Location = new System.Drawing.Point(10, 4);
            this.lbl_department_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_department_name.Name = "lbl_department_name";
            this.lbl_department_name.Size = new System.Drawing.Size(140, 20);
            this.lbl_department_name.TabIndex = 0;
            this.lbl_department_name.Text = "Department Name";
            this.lbl_department_name.Click += new System.EventHandler(this.lbl_department_name_Click);
            // 
            // btn_dep_id
            // 
            this.btn_dep_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dep_id.FlatAppearance.BorderSize = 0;
            this.btn_dep_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_dep_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_dep_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dep_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dep_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.btn_dep_id.Image = ((System.Drawing.Image)(resources.GetObject("btn_dep_id.Image")));
            this.btn_dep_id.Location = new System.Drawing.Point(131, -4);
            this.btn_dep_id.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dep_id.Name = "btn_dep_id";
            this.btn_dep_id.Size = new System.Drawing.Size(29, 37);
            this.btn_dep_id.TabIndex = 18;
            this.btn_dep_id.UseVisualStyleBackColor = true;
            // 
            // Department_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.btn_dep_id);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.btn_dprt_remove);
            this.Controls.Add(this.btn_dprt_edit);
            this.Controls.Add(this.pb_department);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Department_Info";
            this.Size = new System.Drawing.Size(162, 231);
            this.MouseEnter += new System.EventHandler(this.Department_Info_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Department_Info_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_department)).EndInit();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_department;
        private System.Windows.Forms.Button btn_dprt_remove;
        private System.Windows.Forms.Button btn_dprt_edit;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_department_name;
        private System.Windows.Forms.Button btn_dep_id;
    }
}
