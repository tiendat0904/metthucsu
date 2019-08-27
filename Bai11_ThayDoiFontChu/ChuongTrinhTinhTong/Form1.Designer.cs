namespace ChuongTrinhTinhTong
{
    partial class Form1
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
            this.textBox_nhapa = new System.Windows.Forms.TextBox();
            this.textBox_nhapb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tong = new System.Windows.Forms.Label();
            this.button_tong = new System.Windows.Forms.Button();
            this.button_lamlai = new System.Windows.Forms.Button();
            this.Thoát = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_nhapa
            // 
            this.textBox_nhapa.Location = new System.Drawing.Point(205, 38);
            this.textBox_nhapa.Name = "textBox_nhapa";
            this.textBox_nhapa.Size = new System.Drawing.Size(100, 22);
            this.textBox_nhapa.TabIndex = 0;
            this.textBox_nhapa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_nhapa_KeyPress);
            // 
            // textBox_nhapb
            // 
            this.textBox_nhapb.Location = new System.Drawing.Point(205, 111);
            this.textBox_nhapb.Name = "textBox_nhapb";
            this.textBox_nhapb.Size = new System.Drawing.Size(100, 22);
            this.textBox_nhapb.TabIndex = 1;
            this.textBox_nhapb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_nhapb_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập a =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập b =";
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Location = new System.Drawing.Point(154, 212);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(0, 17);
            this.lb_tong.TabIndex = 4;
            // 
            // button_tong
            // 
            this.button_tong.Location = new System.Drawing.Point(51, 236);
            this.button_tong.Name = "button_tong";
            this.button_tong.Size = new System.Drawing.Size(75, 23);
            this.button_tong.TabIndex = 5;
            this.button_tong.Text = "Tổng";
            this.button_tong.UseVisualStyleBackColor = true;
            this.button_tong.Click += new System.EventHandler(this.Button_tong_Click);
            // 
            // button_lamlai
            // 
            this.button_lamlai.Location = new System.Drawing.Point(187, 236);
            this.button_lamlai.Name = "button_lamlai";
            this.button_lamlai.Size = new System.Drawing.Size(75, 23);
            this.button_lamlai.TabIndex = 6;
            this.button_lamlai.Text = "Làm Lại";
            this.button_lamlai.UseVisualStyleBackColor = true;
            this.button_lamlai.Click += new System.EventHandler(this.Button_lamlai_Click);
            // 
            // Thoát
            // 
            this.Thoát.Location = new System.Drawing.Point(308, 236);
            this.Thoát.Name = "Thoát";
            this.Thoát.Size = new System.Drawing.Size(75, 23);
            this.Thoát.TabIndex = 7;
            this.Thoát.Text = "Thoát";
            this.Thoát.UseVisualStyleBackColor = true;
            this.Thoát.Click += new System.EventHandler(this.Thoát_Click);
            this.Thoát.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Thoát_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 314);
            this.Controls.Add(this.Thoát);
            this.Controls.Add(this.button_lamlai);
            this.Controls.Add(this.button_tong);
            this.Controls.Add(this.lb_tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_nhapb);
            this.Controls.Add(this.textBox_nhapa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nhapa;
        private System.Windows.Forms.TextBox textBox_nhapb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Button button_tong;
        private System.Windows.Forms.Button button_lamlai;
        private System.Windows.Forms.Button Thoát;
    }
}

