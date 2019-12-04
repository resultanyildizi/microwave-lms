namespace Microwave_v1._0.UserControls
{
    partial class Book_Info_For_Shelf
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
            this.btn_book_name = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_book_name
            // 
            this.btn_book_name.ForeColor = System.Drawing.Color.White;
            this.btn_book_name.Location = new System.Drawing.Point(0, 0);
            this.btn_book_name.Name = "btn_book_name";
            this.btn_book_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_book_name.Size = new System.Drawing.Size(23, 100);
            this.btn_book_name.TabIndex = 0;
            this.btn_book_name.UseVisualStyleBackColor = true;
            // 
            // Book_Info_For_Shelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.btn_book_name);
            this.Name = "Book_Info_For_Shelf";
            this.Size = new System.Drawing.Size(23, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_book_name;
    }
}
