using System.Windows.Forms;

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
            this.pnl_shelf = new System.Windows.Forms.Panel();
            this.btn_shelf_id = new System.Windows.Forms.Button();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_book_detail = new System.Windows.Forms.Panel();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_publisher = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.pnl_name.SuspendLayout();
            this.pnl_book_detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_shelf
            // 
            this.pnl_shelf.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnl_shelf.Location = new System.Drawing.Point(9, 103);
            this.pnl_shelf.Name = "pnl_shelf";
            this.pnl_shelf.Size = new System.Drawing.Size(695, 5);
            this.pnl_shelf.TabIndex = 0;
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
            this.btn_shelf_id.Location = new System.Drawing.Point(7, 1);
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
            this.pnl_name.Location = new System.Drawing.Point(657, 7);
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
            // pnl_book_detail
            // 
            this.pnl_book_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pnl_book_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_book_detail.Controls.Add(this.lbl_category);
            this.pnl_book_detail.Controls.Add(this.lbl_publisher);
            this.pnl_book_detail.Controls.Add(this.lbl_author);
            this.pnl_book_detail.Controls.Add(this.lbl_book_name);
            this.pnl_book_detail.Location = new System.Drawing.Point(431, 7);
            this.pnl_book_detail.Name = "pnl_book_detail";
            this.pnl_book_detail.Size = new System.Drawing.Size(146, 68);
            this.pnl_book_detail.TabIndex = 20;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoEllipsis = true;
            this.lbl_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_category.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_category.Location = new System.Drawing.Point(3, 48);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(140, 15);
            this.lbl_category.TabIndex = 3;
            this.lbl_category.Text = "label1";
            // 
            // lbl_publisher
            // 
            this.lbl_publisher.AutoEllipsis = true;
            this.lbl_publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_publisher.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_publisher.Location = new System.Drawing.Point(3, 33);
            this.lbl_publisher.Name = "lbl_publisher";
            this.lbl_publisher.Size = new System.Drawing.Size(140, 15);
            this.lbl_publisher.TabIndex = 2;
            this.lbl_publisher.Text = "label1";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoEllipsis = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_author.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_author.Location = new System.Drawing.Point(3, 17);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(140, 15);
            this.lbl_author.TabIndex = 1;
            this.lbl_author.Text = "label1";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoEllipsis = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_book_name.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_book_name.Location = new System.Drawing.Point(3, 1);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(140, 15);
            this.lbl_book_name.TabIndex = 0;
            this.lbl_book_name.Text = "label1";
            // 
            // Shelf_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_book_detail);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.btn_shelf_id);
            this.Controls.Add(this.pnl_shelf);
            this.Name = "Shelf_Info";
            this.Size = new System.Drawing.Size(713, 122);
            this.Load += new System.EventHandler(this.Shelf_Info_Load);
            this.pnl_name.ResumeLayout(false);
            this.pnl_book_detail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_shelf;
        private System.Windows.Forms.Button btn_shelf_id;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.Label lbl_name;
        private Panel pnl_book_detail;
        private Label lbl_publisher;
        private Label lbl_author;
        private Label lbl_book_name;
        private Label lbl_category;

        public Panel Pnl_shelf { get => pnl_shelf; set => pnl_shelf = value; }
        public Panel Pnl_book_detail { get => pnl_book_detail; set => pnl_book_detail = value; }
        public Label Lbl_publisher { get => lbl_publisher; set => lbl_publisher = value; }
        public Label Lbl_author { get => lbl_author; set => lbl_author = value; }
        public Label Lbl_book_name { get => lbl_book_name; set => lbl_book_name = value; }
        public Label Lbl_category { get => lbl_category; set => lbl_category = value; }
    }
}
