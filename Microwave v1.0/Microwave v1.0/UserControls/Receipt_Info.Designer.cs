namespace Microwave_v1._0.UserControls
{
    partial class Receipt_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt_Info));
            this.btn_receipt = new System.Windows.Forms.Button();
            this.lbl_receipt_name = new System.Windows.Forms.Label();
            this.lbl_receipt_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_receipt
            // 
            this.btn_receipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_receipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_receipt.FlatAppearance.BorderSize = 0;
            this.btn_receipt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_receipt.ForeColor = System.Drawing.Color.White;
            this.btn_receipt.Image = ((System.Drawing.Image)(resources.GetObject("btn_receipt.Image")));
            this.btn_receipt.Location = new System.Drawing.Point(1, 3);
            this.btn_receipt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_receipt.Name = "btn_receipt";
            this.btn_receipt.Size = new System.Drawing.Size(44, 34);
            this.btn_receipt.TabIndex = 5;
            this.btn_receipt.UseVisualStyleBackColor = true;
            this.btn_receipt.Click += new System.EventHandler(this.Receipt_Double_Click);
            // 
            // lbl_receipt_name
            // 
            this.lbl_receipt_name.AutoSize = true;
            this.lbl_receipt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receipt_name.ForeColor = System.Drawing.Color.White;
            this.lbl_receipt_name.Location = new System.Drawing.Point(44, 12);
            this.lbl_receipt_name.Name = "lbl_receipt_name";
            this.lbl_receipt_name.Size = new System.Drawing.Size(130, 24);
            this.lbl_receipt_name.TabIndex = 6;
            this.lbl_receipt_name.Text = "Receipt Name";
            this.lbl_receipt_name.Click += new System.EventHandler(this.Receipt_Info_Click);
            this.lbl_receipt_name.DoubleClick += new System.EventHandler(this.Receipt_Double_Click);
            this.lbl_receipt_name.MouseEnter += new System.EventHandler(this.Receipt_MouseEnter);
            this.lbl_receipt_name.MouseLeave += new System.EventHandler(this.Receipt_MouseLeave);
            // 
            // lbl_receipt_id
            // 
            this.lbl_receipt_id.AutoSize = true;
            this.lbl_receipt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_receipt_id.ForeColor = System.Drawing.Color.White;
            this.lbl_receipt_id.Location = new System.Drawing.Point(177, 12);
            this.lbl_receipt_id.Name = "lbl_receipt_id";
            this.lbl_receipt_id.Size = new System.Drawing.Size(40, 24);
            this.lbl_receipt_id.TabIndex = 7;
            this.lbl_receipt_id.Text = "#15";
            this.lbl_receipt_id.Click += new System.EventHandler(this.Receipt_Info_Click);
            this.lbl_receipt_id.DoubleClick += new System.EventHandler(this.Receipt_Double_Click);
            this.lbl_receipt_id.MouseEnter += new System.EventHandler(this.Receipt_MouseEnter);
            this.lbl_receipt_id.MouseLeave += new System.EventHandler(this.Receipt_Info_Click);
            // 
            // Receipt_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(68)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbl_receipt_id);
            this.Controls.Add(this.lbl_receipt_name);
            this.Controls.Add(this.btn_receipt);
            this.Name = "Receipt_Info";
            this.Size = new System.Drawing.Size(223, 43);
            this.Click += new System.EventHandler(this.Receipt_Info_Click);
            this.DoubleClick += new System.EventHandler(this.Receipt_Double_Click);
            this.MouseEnter += new System.EventHandler(this.Receipt_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Receipt_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_receipt;
        private System.Windows.Forms.Label lbl_receipt_name;
        private System.Windows.Forms.Label lbl_receipt_id;
    }
}
