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
            this.pic_dprtmnt = new System.Windows.Forms.PictureBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.btn_user_remove = new System.Windows.Forms.Button();
            this.btn_user_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dprtmnt)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_dprtmnt
            // 
            this.pic_dprtmnt.Image = ((System.Drawing.Image)(resources.GetObject("pic_dprtmnt.Image")));
            this.pic_dprtmnt.Location = new System.Drawing.Point(35, 25);
            this.pic_dprtmnt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_dprtmnt.Name = "pic_dprtmnt";
            this.pic_dprtmnt.Size = new System.Drawing.Size(140, 190);
            this.pic_dprtmnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_dprtmnt.TabIndex = 0;
            this.pic_dprtmnt.TabStop = false;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_department.ForeColor = System.Drawing.Color.Snow;
            this.lbl_department.Location = new System.Drawing.Point(54, 228);
            this.lbl_department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(101, 23);
            this.lbl_department.TabIndex = 1;
            this.lbl_department.Text = "CLEANER";
            // 
            // btn_user_remove
            // 
            this.btn_user_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_remove.FlatAppearance.BorderSize = 0;
            this.btn_user_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_user_remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_user_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_user_remove.Image")));
            this.btn_user_remove.Location = new System.Drawing.Point(3, 25);
            this.btn_user_remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_user_remove.Name = "btn_user_remove";
            this.btn_user_remove.Size = new System.Drawing.Size(25, 23);
            this.btn_user_remove.TabIndex = 11;
            this.btn_user_remove.UseVisualStyleBackColor = true;
            // 
            // btn_user_edit
            // 
            this.btn_user_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_edit.FlatAppearance.BorderSize = 0;
            this.btn_user_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_user_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_user_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_user_edit.Image")));
            this.btn_user_edit.Location = new System.Drawing.Point(3, 2);
            this.btn_user_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_user_edit.Name = "btn_user_edit";
            this.btn_user_edit.Size = new System.Drawing.Size(25, 23);
            this.btn_user_edit.TabIndex = 10;
            this.btn_user_edit.UseVisualStyleBackColor = true;
            // 
            // Department_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_user_remove);
            this.Controls.Add(this.btn_user_edit);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.pic_dprtmnt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Department_Info";
            this.Size = new System.Drawing.Size(203, 268);
            this.Load += new System.EventHandler(this.Department_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dprtmnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_dprtmnt;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Button btn_user_remove;
        private System.Windows.Forms.Button btn_user_edit;
    }
}
