using System.Windows.Forms;

namespace Microwave_v1._0.Forms
{
    partial class GiveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiveBook));
            this.pnl_book_list = new System.Windows.Forms.Panel();
            this.lb_book_search = new System.Windows.Forms.ListBox();
            this.btn_give_book = new System.Windows.Forms.Button();
            this.tb_search_book = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.btn_return_book = new System.Windows.Forms.Button();
            this.pnl_book_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_book_list
            // 
            this.pnl_book_list.AutoScroll = true;
            this.pnl_book_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.pnl_book_list.Controls.Add(this.lb_book_search);
            this.pnl_book_list.Location = new System.Drawing.Point(12, 56);
            this.pnl_book_list.Name = "pnl_book_list";
            this.pnl_book_list.Size = new System.Drawing.Size(615, 283);
            this.pnl_book_list.TabIndex = 0;
            // 
            // lb_book_search
            // 
            this.lb_book_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.lb_book_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_book_search.ForeColor = System.Drawing.Color.White;
            this.lb_book_search.FormattingEnabled = true;
            this.lb_book_search.ItemHeight = 16;
            this.lb_book_search.Location = new System.Drawing.Point(17, 0);
            this.lb_book_search.Name = "lb_book_search";
            this.lb_book_search.Size = new System.Drawing.Size(235, 68);
            this.lb_book_search.TabIndex = 67;
            this.lb_book_search.Visible = false;
            this.lb_book_search.DoubleClick += new System.EventHandler(this.Lb_book_search_DoubleClick);
            this.lb_book_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Lb_book_search_KeyPress);
            this.lb_book_search.Leave += new System.EventHandler(this.Lb_book_search_Leave);
            // 
            // btn_give_book
            // 
            this.btn_give_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_give_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_give_book.FlatAppearance.BorderSize = 0;
            this.btn_give_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_give_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_give_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_give_book.ForeColor = System.Drawing.Color.White;
            this.btn_give_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_give_book.Image")));
            this.btn_give_book.Location = new System.Drawing.Point(580, 10);
            this.btn_give_book.Margin = new System.Windows.Forms.Padding(2);
            this.btn_give_book.Name = "btn_give_book";
            this.btn_give_book.Size = new System.Drawing.Size(46, 44);
            this.btn_give_book.TabIndex = 54;
            this.btn_give_book.UseVisualStyleBackColor = true;
            this.btn_give_book.Click += new System.EventHandler(this.btn_give_book_Click);
            // 
            // tb_search_book
            // 
            this.tb_search_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.tb_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search_book.ForeColor = System.Drawing.Color.Gray;
            this.tb_search_book.Location = new System.Drawing.Point(29, 21);
            this.tb_search_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search_book.Name = "tb_search_book";
            this.tb_search_book.Size = new System.Drawing.Size(235, 24);
            this.tb_search_book.TabIndex = 68;
            this.tb_search_book.Text = "Search a book";
            this.tb_search_book.TextChanged += new System.EventHandler(this.Tb_search_book_TextChanged);
            this.tb_search_book.Enter += new System.EventHandler(this.Tb_search_Enter);
            this.tb_search_book.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_search_book_KeyDown);
            this.tb_search_book.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_search_book_KeyPress);
            this.tb_search_book.Leave += new System.EventHandler(this.Tb_search_Leave);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_message.Location = new System.Drawing.Point(285, 29);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(70, 16);
            this.lbl_message.TabIndex = 69;
            this.lbl_message.Text = "*Message";
            // 
            // btn_return_book
            // 
            this.btn_return_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_return_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_return_book.FlatAppearance.BorderSize = 0;
            this.btn_return_book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_return_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return_book.ForeColor = System.Drawing.Color.White;
            this.btn_return_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_return_book.Image")));
            this.btn_return_book.Location = new System.Drawing.Point(580, 10);
            this.btn_return_book.Margin = new System.Windows.Forms.Padding(2);
            this.btn_return_book.Name = "btn_return_book";
            this.btn_return_book.Size = new System.Drawing.Size(46, 44);
            this.btn_return_book.TabIndex = 70;
            this.btn_return_book.UseVisualStyleBackColor = true;
            this.btn_return_book.Click += new System.EventHandler(this.btn_return_book_Click);
            // 
            // GiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(639, 351);
            this.Controls.Add(this.btn_return_book);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_give_book);
            this.Controls.Add(this.tb_search_book);
            this.Controls.Add(this.pnl_book_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GiveBook";
            this.Text = "GiveBook";
            this.pnl_book_list.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_book_list;
        private System.Windows.Forms.Button btn_give_book;
        private System.Windows.Forms.ListBox lb_book_search;
        private System.Windows.Forms.TextBox tb_search_book;
        private Label lbl_message;
        private Button btn_return_book;

        public Panel Pnl_book_list { get => pnl_book_list; set => pnl_book_list = value; }
    }
}