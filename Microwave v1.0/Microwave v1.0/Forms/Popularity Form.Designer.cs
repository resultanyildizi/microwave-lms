namespace Microwave_v1._0.Forms
{
    partial class Popularity_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popularity_Form));
            this.dgw_popularity = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_pop_title = new System.Windows.Forms.Label();
            this.pnl_sep1 = new System.Windows.Forms.Panel();
            this.pnl_operation = new System.Windows.Forms.Panel();
            this.lbl_msg2 = new System.Windows.Forms.Label();
            this.lbl_msg1 = new System.Windows.Forms.Label();
            this.pnl_sep2 = new System.Windows.Forms.Panel();
            this.lbl_operation_title = new System.Windows.Forms.Label();
            this.tb_score = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_popularity)).BeginInit();
            this.pnl_operation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgw_popularity
            // 
            this.dgw_popularity.AllowUserToAddRows = false;
            this.dgw_popularity.AllowUserToDeleteRows = false;
            this.dgw_popularity.AllowUserToResizeColumns = false;
            this.dgw_popularity.AllowUserToResizeRows = false;
            this.dgw_popularity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_popularity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.dgw_popularity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgw_popularity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgw_popularity.ColumnHeadersHeight = 29;
            this.dgw_popularity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgw_popularity.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgw_popularity.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.dgw_popularity.Location = new System.Drawing.Point(12, 73);
            this.dgw_popularity.MultiSelect = false;
            this.dgw_popularity.Name = "dgw_popularity";
            this.dgw_popularity.ReadOnly = true;
            this.dgw_popularity.RowHeadersVisible = false;
            this.dgw_popularity.RowHeadersWidth = 51;
            this.dgw_popularity.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_popularity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_popularity.Size = new System.Drawing.Size(400, 220);
            this.dgw_popularity.TabIndex = 43;
            this.dgw_popularity.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_popularity_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = global::Microwave_v1._0.Properties.Resources.pencil__1_1;
            this.btn_edit.Location = new System.Drawing.Point(483, 20);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(41, 44);
            this.btn_edit.TabIndex = 45;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(440, 20);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(41, 44);
            this.btn_add.TabIndex = 44;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_remove.FlatAppearance.BorderSize = 0;
            this.btn_remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_remove.Image")));
            this.btn_remove.Location = new System.Drawing.Point(528, 20);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(41, 44);
            this.btn_remove.TabIndex = 46;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_pop_title
            // 
            this.lbl_pop_title.AutoEllipsis = true;
            this.lbl_pop_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pop_title.ForeColor = System.Drawing.Color.White;
            this.lbl_pop_title.Location = new System.Drawing.Point(11, 24);
            this.lbl_pop_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pop_title.Name = "lbl_pop_title";
            this.lbl_pop_title.Size = new System.Drawing.Size(195, 39);
            this.lbl_pop_title.TabIndex = 47;
            this.lbl_pop_title.Text = "Popularity Types";
            // 
            // pnl_sep1
            // 
            this.pnl_sep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.pnl_sep1.Location = new System.Drawing.Point(14, 66);
            this.pnl_sep1.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_sep1.Name = "pnl_sep1";
            this.pnl_sep1.Size = new System.Drawing.Size(561, 1);
            this.pnl_sep1.TabIndex = 48;
            // 
            // pnl_operation
            // 
            this.pnl_operation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_operation.Controls.Add(this.lbl_msg2);
            this.pnl_operation.Controls.Add(this.lbl_msg1);
            this.pnl_operation.Controls.Add(this.pnl_sep2);
            this.pnl_operation.Controls.Add(this.lbl_operation_title);
            this.pnl_operation.Controls.Add(this.tb_score);
            this.pnl_operation.Controls.Add(this.lbl_score);
            this.pnl_operation.Controls.Add(this.tb_name);
            this.pnl_operation.Controls.Add(this.lbl_name);
            this.pnl_operation.Controls.Add(this.btn_ok);
            this.pnl_operation.Location = new System.Drawing.Point(420, 74);
            this.pnl_operation.Name = "pnl_operation";
            this.pnl_operation.Size = new System.Drawing.Size(160, 220);
            this.pnl_operation.TabIndex = 49;
            // 
            // lbl_msg2
            // 
            this.lbl_msg2.AutoSize = true;
            this.lbl_msg2.Location = new System.Drawing.Point(62, 102);
            this.lbl_msg2.Name = "lbl_msg2";
            this.lbl_msg2.Size = new System.Drawing.Size(35, 13);
            this.lbl_msg2.TabIndex = 59;
            this.lbl_msg2.Text = "label2";
            // 
            // lbl_msg1
            // 
            this.lbl_msg1.AutoSize = true;
            this.lbl_msg1.Location = new System.Drawing.Point(62, 48);
            this.lbl_msg1.Name = "lbl_msg1";
            this.lbl_msg1.Size = new System.Drawing.Size(35, 13);
            this.lbl_msg1.TabIndex = 58;
            this.lbl_msg1.Text = "label1";
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
            // tb_score
            // 
            this.tb_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_score.ForeColor = System.Drawing.Color.White;
            this.tb_score.Location = new System.Drawing.Point(6, 118);
            this.tb_score.Name = "tb_score";
            this.tb_score.Size = new System.Drawing.Size(135, 22);
            this.tb_score.TabIndex = 54;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.White;
            this.lbl_score.Location = new System.Drawing.Point(2, 95);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(55, 20);
            this.lbl_score.TabIndex = 53;
            this.lbl_score.Text = "Score:";
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.White;
            this.tb_name.Location = new System.Drawing.Point(6, 66);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(135, 22);
            this.tb_name.TabIndex = 52;
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
            // Popularity_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(589, 304);
            this.Controls.Add(this.pnl_operation);
            this.Controls.Add(this.pnl_sep1);
            this.Controls.Add(this.lbl_pop_title);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dgw_popularity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Popularity_Form";
            this.Text = "Popularity Form";
            this.Load += new System.EventHandler(this.Popularity_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_popularity)).EndInit();
            this.pnl_operation.ResumeLayout(false);
            this.pnl_operation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_popularity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Label lbl_pop_title;
        private System.Windows.Forms.Panel pnl_sep1;
        private System.Windows.Forms.Panel pnl_operation;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Panel pnl_sep2;
        private System.Windows.Forms.Label lbl_operation_title;
        private System.Windows.Forms.TextBox tb_score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label lbl_msg2;
        private System.Windows.Forms.Label lbl_msg1;
    }
}