using Microwave_v1._0.UserControls;

namespace Microwave_v1._0.Forms
{
    partial class Receipt_Detail
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
            this.detail_info = new Microwave_v1._0.UserControls.Receipt_Info();
            this.SuspendLayout();
            // 
            // detail_info
            // 
            this.detail_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.detail_info.Location = new System.Drawing.Point(0, 0);
            this.detail_info.Name = "detail_info";
            this.detail_info.Size = new System.Drawing.Size(655, 277);
            this.detail_info.TabIndex = 0;
            // 
            // Receipt_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 275);
            this.Controls.Add(this.detail_info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Receipt_Detail";
            this.Text = "Receipt_Detail";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Receipt_Info detail_info;

        public Receipt_Info Detail_info { get => detail_info; set => detail_info = value; }
    }
}