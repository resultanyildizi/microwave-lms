namespace Microwave_v1._0.UserControls
{
    partial class Shelf_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shelf_Info));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_shelf_id = new System.Windows.Forms.Button();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(8, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 7);
            this.panel1.TabIndex = 0;
            // 
            // btn_shelf_id
            // 
            this.btn_shelf_id.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shelf_id.FlatAppearance.BorderSize = 0;
            this.btn_shelf_id.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_shelf_id.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(63)))));
            this.btn_shelf_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shelf_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_shelf_id.ForeColor = System.Drawing.Color.White;
            this.btn_shelf_id.Image = ((System.Drawing.Image)(resources.GetObject("btn_shelf_id.Image")));
            this.btn_shelf_id.Location = new System.Drawing.Point(6, 0);
            this.btn_shelf_id.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shelf_id.Name = "btn_shelf_id";
            this.btn_shelf_id.Size = new System.Drawing.Size(29, 37);
            this.btn_shelf_id.TabIndex = 18;
            this.btn_shelf_id.UseVisualStyleBackColor = true;
            // 
            // pnl_name
            // 
            this.pnl_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.pnl_name.Controls.Add(this.lbl_name);
            this.pnl_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_name.Location = new System.Drawing.Point(666, 2);
            this.pnl_name.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(47, 35);
            this.pnl_name.TabIndex = 19;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(3, 9);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "#A01";
            // 
            // Shelf_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.btn_shelf_id);
            this.Controls.Add(this.panel1);
            this.Name = "Shelf_Info";
            this.Size = new System.Drawing.Size(715, 124);
            this.pnl_name.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_shelf_id;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name;
    }
}
