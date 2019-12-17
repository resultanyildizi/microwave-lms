namespace Microwave_v1._0.Forms
{
    partial class GivePenalty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GivePenalty));
            this.pnl_operation = new System.Windows.Forms.Panel();
            this.pnl_sep2 = new System.Windows.Forms.Panel();
            this.lbl_operation_title = new System.Windows.Forms.Label();
            this.tb_fee = new System.Windows.Forms.TextBox();
            this.lbl_fee = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.pnl_sep1 = new System.Windows.Forms.Panel();
            this.lbl_penalty_title = new System.Windows.Forms.Label();
            this.dgw_penalties = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cb_penalties = new System.Windows.Forms.ComboBox();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.pnl_operation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_penalties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_operation
            // 
            this.pnl_operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_operation.Controls.Add(this.lbl_book_name);
            this.pnl_operation.Controls.Add(this.cb_penalties);
            this.pnl_operation.Controls.Add(this.pnl_sep2);
            this.pnl_operation.Controls.Add(this.lbl_operation_title);
            this.pnl_operation.Controls.Add(this.tb_fee);
            this.pnl_operation.Controls.Add(this.lbl_fee);
            this.pnl_operation.Controls.Add(this.lbl_name);
            this.pnl_operation.Controls.Add(this.btn_ok);
            this.pnl_operation.Location = new System.Drawing.Point(419, 69);
            this.pnl_operation.Name = "pnl_operation";
            this.pnl_operation.Size = new System.Drawing.Size(160, 220);
            this.pnl_operation.TabIndex = 56;
            // 
            // pnl_sep2
            // 
            this.pnl_sep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_sep2.Location = new System.Drawing.Point(5, 32);
            this.pnl_sep2.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_sep2.Name = "pnl_sep2";
            this.pnl_sep2.Size = new System.Drawing.Size(140, 1);
            this.pnl_sep2.TabIndex = 49;
            // 
            // lbl_operation_title
            // 
            this.lbl_operation_title.AutoSize = true;
            this.lbl_operation_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_operation_title.ForeColor = System.Drawing.Color.White;
            this.lbl_operation_title.Location = new System.Drawing.Point(2, 10);
            this.lbl_operation_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_operation_title.Name = "lbl_operation_title";
            this.lbl_operation_title.Size = new System.Drawing.Size(44, 20);
            this.lbl_operation_title.TabIndex = 57;
            this.lbl_operation_title.Text = "ADD";
            // 
            // tb_fee
            // 
            this.tb_fee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fee.ForeColor = System.Drawing.Color.White;
            this.tb_fee.Location = new System.Drawing.Point(6, 118);
            this.tb_fee.Name = "tb_fee";
            this.tb_fee.ReadOnly = true;
            this.tb_fee.Size = new System.Drawing.Size(135, 22);
            this.tb_fee.TabIndex = 54;
            // 
            // lbl_fee
            // 
            this.lbl_fee.AutoSize = true;
            this.lbl_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fee.ForeColor = System.Drawing.Color.White;
            this.lbl_fee.Location = new System.Drawing.Point(2, 95);
            this.lbl_fee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_fee.Name = "lbl_fee";
            this.lbl_fee.Size = new System.Drawing.Size(41, 20);
            this.lbl_fee.TabIndex = 53;
            this.lbl_fee.Text = "Fee:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(2, 43);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(55, 20);
            this.lbl_name.TabIndex = 51;
            this.lbl_name.Text = "Name:";
            // 
            // pnl_sep1
            // 
            this.pnl_sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_sep1.Location = new System.Drawing.Point(13, 61);
            this.pnl_sep1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_sep1.Name = "pnl_sep1";
            this.pnl_sep1.Size = new System.Drawing.Size(561, 1);
            this.pnl_sep1.TabIndex = 55;
            // 
            // lbl_penalty_title
            // 
            this.lbl_penalty_title.AutoEllipsis = true;
            this.lbl_penalty_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_penalty_title.ForeColor = System.Drawing.Color.White;
            this.lbl_penalty_title.Location = new System.Drawing.Point(10, 19);
            this.lbl_penalty_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_penalty_title.Name = "lbl_penalty_title";
            this.lbl_penalty_title.Size = new System.Drawing.Size(116, 39);
            this.lbl_penalty_title.TabIndex = 54;
            this.lbl_penalty_title.Text = "Penalties";
            // 
            // dgw_penalties
            // 
            this.dgw_penalties.AllowUserToAddRows = false;
            this.dgw_penalties.AllowUserToDeleteRows = false;
            this.dgw_penalties.AllowUserToResizeColumns = false;
            this.dgw_penalties.AllowUserToResizeRows = false;
            this.dgw_penalties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_penalties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.dgw_penalties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_penalties.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_penalties.ColumnHeadersHeight = 29;
            this.dgw_penalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_penalties.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_penalties.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.dgw_penalties.Location = new System.Drawing.Point(11, 68);
            this.dgw_penalties.MultiSelect = false;
            this.dgw_penalties.Name = "dgw_penalties";
            this.dgw_penalties.ReadOnly = true;
            this.dgw_penalties.RowHeadersVisible = false;
            this.dgw_penalties.RowHeadersWidth = 51;
            this.dgw_penalties.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_penalties.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_penalties.Size = new System.Drawing.Size(400, 221);
            this.dgw_penalties.TabIndex = 50;
            // 
            // btn_ok
            // 
            this.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ok.FlatAppearance.BorderSize = 0;
            this.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.Location = new System.Drawing.Point(109, 169);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(41, 44);
            this.btn_ok.TabIndex = 50;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cb_penalties
            // 
            this.cb_penalties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.cb_penalties.ForeColor = System.Drawing.Color.White;
            this.cb_penalties.FormattingEnabled = true;
            this.cb_penalties.Location = new System.Drawing.Point(6, 67);
            this.cb_penalties.Name = "cb_penalties";
            this.cb_penalties.Size = new System.Drawing.Size(135, 21);
            this.cb_penalties.TabIndex = 58;
            this.cb_penalties.SelectedIndexChanged += new System.EventHandler(this.cb_penalties_SelectedIndexChanged);
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoEllipsis = true;
            this.lbl_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book_name.ForeColor = System.Drawing.Color.Blue;
            this.lbl_book_name.Location = new System.Drawing.Point(3, 147);
            this.lbl_book_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(116, 20);
            this.lbl_book_name.TabIndex = 57;
            this.lbl_book_name.Text = "For Book Name";
            // 
            // GivePenalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(589, 304);
            this.Controls.Add(this.pnl_operation);
            this.Controls.Add(this.pnl_sep1);
            this.Controls.Add(this.lbl_penalty_title);
            this.Controls.Add(this.dgw_penalties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GivePenalty";
            this.Text = "Give Penalty";
            this.Load += new System.EventHandler(this.GivePenalty_Load);
            this.pnl_operation.ResumeLayout(false);
            this.pnl_operation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_penalties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_operation;
        private System.Windows.Forms.Panel pnl_sep2;
        private System.Windows.Forms.Label lbl_operation_title;
        private System.Windows.Forms.TextBox tb_fee;
        private System.Windows.Forms.Label lbl_fee;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel pnl_sep1;
        private System.Windows.Forms.Label lbl_penalty_title;
        private System.Windows.Forms.DataGridView dgw_penalties;
        private System.Windows.Forms.ComboBox cb_penalties;
        private System.Windows.Forms.Label lbl_book_name;
    }
}