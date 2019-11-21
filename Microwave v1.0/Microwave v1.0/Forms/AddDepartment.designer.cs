namespace Microwave_v1._0.Forms
{
    partial class AddDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDepartment));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_add_pic = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pic_department = new System.Windows.Forms.PictureBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_department)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Controls.Add(this.btn_add);
            this.pnl_main.Controls.Add(this.btn_add_pic);
            this.pnl_main.Controls.Add(this.pic_department);
            this.pnl_main.Controls.Add(this.lbl_message);
            this.pnl_main.Controls.Add(this.lbl_department);
            this.pnl_main.Controls.Add(this.tb_department);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_main.Location = new System.Drawing.Point(0, -4);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(452, 274);
            this.pnl_main.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_message.Location = new System.Drawing.Point(13, 20);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 20);
            this.lbl_message.TabIndex = 24;
            // 
            // btn_add_pic
            // 
            this.btn_add_pic.FlatAppearance.BorderSize = 0;
            this.btn_add_pic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_pic.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_pic.Image")));
            this.btn_add_pic.Location = new System.Drawing.Point(223, 202);
            this.btn_add_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add_pic.Name = "btn_add_pic";
            this.btn_add_pic.Size = new System.Drawing.Size(63, 52);
            this.btn_add_pic.TabIndex = 23;
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
            this.btn_add.Location = new System.Drawing.Point(17, 207);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(55, 57);
            this.btn_add.TabIndex = 17;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pic_department
            // 
            this.pic_department.Image = ((System.Drawing.Image)(resources.GetObject("pic_department.Image")));
            this.pic_department.Location = new System.Drawing.Point(292, 85);
            this.pic_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_department.Name = "pic_department";
            this.pic_department.Size = new System.Drawing.Size(133, 169);
            this.pic_department.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_department.TabIndex = 16;
            this.pic_department.TabStop = false;
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_department.ForeColor = System.Drawing.Color.White;
            this.lbl_department.Location = new System.Drawing.Point(12, 36);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(112, 24);
            this.lbl_department.TabIndex = 13;
            this.lbl_department.Text = "Department:";
            // 
            // tb_department
            // 
            this.tb_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_department.ForeColor = System.Drawing.Color.DimGray;
            this.tb_department.Location = new System.Drawing.Point(136, 36);
            this.tb_department.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(289, 27);
            this.tb_department.TabIndex = 1;
            this.tb_department.Text = "Department\'s Name";
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(452, 270);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddDepartment";
            this.Opacity = 0.95D;
            this.Text = "AddDepartment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddDepartment_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDepartment_FormClosed);
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_department)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.Button btn_add_pic;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.PictureBox pic_department;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.TextBox tb_department;
    }
}