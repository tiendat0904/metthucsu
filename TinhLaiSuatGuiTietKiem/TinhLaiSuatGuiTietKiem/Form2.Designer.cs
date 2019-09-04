namespace TinhLaiSuatGuiTietKiem
{
    partial class Form2
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
            this.labelMaKH = new System.Windows.Forms.Label();
            this.textTimKiem_KH = new System.Windows.Forms.TextBox();
            this.button_timkiem = new System.Windows.Forms.Button();
            this.listBox_timkiem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(12, 24);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(46, 17);
            this.labelMaKH.TabIndex = 0;
            this.labelMaKH.Text = "maKH";
            // 
            // textTimKiem_KH
            // 
            this.textTimKiem_KH.Location = new System.Drawing.Point(161, 24);
            this.textTimKiem_KH.Name = "textTimKiem_KH";
            this.textTimKiem_KH.Size = new System.Drawing.Size(275, 22);
            this.textTimKiem_KH.TabIndex = 1;
            this.textTimKiem_KH.TextChanged += new System.EventHandler(this.TextTimKiem_KH_TextChanged);
            // 
            // button_timkiem
            // 
            this.button_timkiem.Location = new System.Drawing.Point(12, 101);
            this.button_timkiem.Name = "button_timkiem";
            this.button_timkiem.Size = new System.Drawing.Size(82, 35);
            this.button_timkiem.TabIndex = 2;
            this.button_timkiem.Text = "Tìm Kiếm";
            this.button_timkiem.UseVisualStyleBackColor = true;
            this.button_timkiem.Click += new System.EventHandler(this.Button_timkiem_Click);
            // 
            // listBox_timkiem
            // 
            this.listBox_timkiem.FormattingEnabled = true;
            this.listBox_timkiem.ItemHeight = 16;
            this.listBox_timkiem.Location = new System.Drawing.Point(161, 101);
            this.listBox_timkiem.Name = "listBox_timkiem";
            this.listBox_timkiem.Size = new System.Drawing.Size(265, 84);
            this.listBox_timkiem.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox_timkiem);
            this.Controls.Add(this.button_timkiem);
            this.Controls.Add(this.textTimKiem_KH);
            this.Controls.Add(this.labelMaKH);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.TextBox textTimKiem_KH;
        private System.Windows.Forms.Button button_timkiem;
        private System.Windows.Forms.ListBox listBox_timkiem;
    }
}