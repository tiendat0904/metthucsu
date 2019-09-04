namespace Bai11_ThayDoiFontChu
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
            this.tb_chu = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.GroupBox();
            this.lb_kichthuoc = new System.Windows.Forms.Label();
            this.lb_font = new System.Windows.Forms.Label();
            this.comboBox_kichthuoc = new System.Windows.Forms.ComboBox();
            this.comboBox_font = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_dam = new System.Windows.Forms.CheckBox();
            this.checkBox_nghieng = new System.Windows.Forms.CheckBox();
            this.checkBox_gachchan = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_den = new System.Windows.Forms.RadioButton();
            this.radioButton_xanhla = new System.Windows.Forms.RadioButton();
            this.radioButton_do = new System.Windows.Forms.RadioButton();
            this.button_lamlai = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.a.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_chu
            // 
            this.tb_chu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_chu.ForeColor = System.Drawing.Color.Black;
            this.tb_chu.Location = new System.Drawing.Point(12, 53);
            this.tb_chu.Name = "tb_chu";
            this.tb_chu.Size = new System.Drawing.Size(756, 38);
            this.tb_chu.TabIndex = 1;
            this.tb_chu.Text = "Bài Thi Môn Tin Học Đại Cương";
            this.tb_chu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a
            // 
            this.a.Controls.Add(this.lb_kichthuoc);
            this.a.Controls.Add(this.lb_font);
            this.a.Controls.Add(this.comboBox_kichthuoc);
            this.a.Controls.Add(this.comboBox_font);
            this.a.Location = new System.Drawing.Point(46, 124);
            this.a.Name = "a";
            this.a.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.a.Size = new System.Drawing.Size(697, 100);
            this.a.TabIndex = 2;
            this.a.TabStop = false;
            this.a.Text = "Kiểu Chữ";
            // 
            // lb_kichthuoc
            // 
            this.lb_kichthuoc.AutoSize = true;
            this.lb_kichthuoc.Location = new System.Drawing.Point(450, 47);
            this.lb_kichthuoc.Name = "lb_kichthuoc";
            this.lb_kichthuoc.Size = new System.Drawing.Size(79, 17);
            this.lb_kichthuoc.TabIndex = 3;
            this.lb_kichthuoc.Text = "Kích Thước";
            // 
            // lb_font
            // 
            this.lb_font.AutoSize = true;
            this.lb_font.Location = new System.Drawing.Point(61, 48);
            this.lb_font.Name = "lb_font";
            this.lb_font.Size = new System.Drawing.Size(36, 17);
            this.lb_font.TabIndex = 2;
            this.lb_font.Text = "Font";
            // 
            // comboBox_kichthuoc
            // 
            this.comboBox_kichthuoc.FormattingEnabled = true;
            this.comboBox_kichthuoc.Location = new System.Drawing.Point(551, 44);
            this.comboBox_kichthuoc.Name = "comboBox_kichthuoc";
            this.comboBox_kichthuoc.Size = new System.Drawing.Size(121, 24);
            this.comboBox_kichthuoc.TabIndex = 1;
            this.comboBox_kichthuoc.SelectedIndexChanged += new System.EventHandler(this.ComboBox_kichthuoc_SelectedIndexChanged);
            // 
            // comboBox_font
            // 
            this.comboBox_font.FormattingEnabled = true;
            this.comboBox_font.Location = new System.Drawing.Point(170, 45);
            this.comboBox_font.Name = "comboBox_font";
            this.comboBox_font.Size = new System.Drawing.Size(121, 24);
            this.comboBox_font.TabIndex = 0;
            this.comboBox_font.SelectedIndexChanged += new System.EventHandler(this.ComboBox_font_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_dam);
            this.groupBox1.Controls.Add(this.checkBox_nghieng);
            this.groupBox1.Controls.Add(this.checkBox_gachchan);
            this.groupBox1.Location = new System.Drawing.Point(46, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(697, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiệu Ứng Chữ";
            // 
            // checkBox_dam
            // 
            this.checkBox_dam.AutoSize = true;
            this.checkBox_dam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dam.Location = new System.Drawing.Point(32, 46);
            this.checkBox_dam.Name = "checkBox_dam";
            this.checkBox_dam.Size = new System.Drawing.Size(62, 21);
            this.checkBox_dam.TabIndex = 5;
            this.checkBox_dam.Text = "Đậm";
            this.checkBox_dam.UseVisualStyleBackColor = true;
            this.checkBox_dam.CheckedChanged += new System.EventHandler(this.CheckBox_dam_CheckedChanged);
            // 
            // checkBox_nghieng
            // 
            this.checkBox_nghieng.AutoSize = true;
            this.checkBox_nghieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nghieng.Location = new System.Drawing.Point(255, 46);
            this.checkBox_nghieng.Name = "checkBox_nghieng";
            this.checkBox_nghieng.Size = new System.Drawing.Size(83, 21);
            this.checkBox_nghieng.TabIndex = 6;
            this.checkBox_nghieng.Text = "Nghiêng";
            this.checkBox_nghieng.UseVisualStyleBackColor = true;
            this.checkBox_nghieng.CheckedChanged += new System.EventHandler(this.CheckBox_nghieng_CheckedChanged);
            // 
            // checkBox_gachchan
            // 
            this.checkBox_gachchan.AutoSize = true;
            this.checkBox_gachchan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_gachchan.Location = new System.Drawing.Point(490, 46);
            this.checkBox_gachchan.Name = "checkBox_gachchan";
            this.checkBox_gachchan.Size = new System.Drawing.Size(101, 21);
            this.checkBox_gachchan.TabIndex = 7;
            this.checkBox_gachchan.Text = "Gạch Chân";
            this.checkBox_gachchan.UseVisualStyleBackColor = true;
            this.checkBox_gachchan.CheckedChanged += new System.EventHandler(this.CheckBox_gachchan_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_den);
            this.groupBox2.Controls.Add(this.radioButton_xanhla);
            this.groupBox2.Controls.Add(this.radioButton_do);
            this.groupBox2.Location = new System.Drawing.Point(46, 396);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(697, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu Chữ";
            // 
            // radioButton_den
            // 
            this.radioButton_den.AutoSize = true;
            this.radioButton_den.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_den.Location = new System.Drawing.Point(562, 50);
            this.radioButton_den.Name = "radioButton_den";
            this.radioButton_den.Size = new System.Drawing.Size(58, 21);
            this.radioButton_den.TabIndex = 2;
            this.radioButton_den.TabStop = true;
            this.radioButton_den.Text = "Đen";
            this.radioButton_den.UseVisualStyleBackColor = true;
            this.radioButton_den.CheckedChanged += new System.EventHandler(this.RadioButton_den_CheckedChanged);
            // 
            // radioButton_xanhla
            // 
            this.radioButton_xanhla.AutoSize = true;
            this.radioButton_xanhla.ForeColor = System.Drawing.Color.Green;
            this.radioButton_xanhla.Location = new System.Drawing.Point(334, 50);
            this.radioButton_xanhla.Name = "radioButton_xanhla";
            this.radioButton_xanhla.Size = new System.Drawing.Size(110, 21);
            this.radioButton_xanhla.TabIndex = 1;
            this.radioButton_xanhla.TabStop = true;
            this.radioButton_xanhla.Text = "Xanh Lá Cây";
            this.radioButton_xanhla.UseVisualStyleBackColor = true;
            this.radioButton_xanhla.CheckedChanged += new System.EventHandler(this.RadioButton_xanhla_CheckedChanged);
            // 
            // radioButton_do
            // 
            this.radioButton_do.AutoSize = true;
            this.radioButton_do.ForeColor = System.Drawing.Color.Red;
            this.radioButton_do.Location = new System.Drawing.Point(64, 50);
            this.radioButton_do.Name = "radioButton_do";
            this.radioButton_do.Size = new System.Drawing.Size(47, 21);
            this.radioButton_do.TabIndex = 0;
            this.radioButton_do.TabStop = true;
            this.radioButton_do.Text = "Đỏ";
            this.radioButton_do.UseVisualStyleBackColor = true;
            this.radioButton_do.CheckedChanged += new System.EventHandler(this.RadioButton_do_CheckedChanged);
            // 
            // button_lamlai
            // 
            this.button_lamlai.Location = new System.Drawing.Point(236, 514);
            this.button_lamlai.Name = "button_lamlai";
            this.button_lamlai.Size = new System.Drawing.Size(101, 35);
            this.button_lamlai.TabIndex = 3;
            this.button_lamlai.Text = "Làm Lại";
            this.button_lamlai.UseVisualStyleBackColor = true;
            this.button_lamlai.Click += new System.EventHandler(this.Button_lamlai_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(431, 514);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(99, 35);
            this.button_Thoat.TabIndex = 4;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.Button_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.button_lamlai);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.a);
            this.Controls.Add(this.tb_chu);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.a.ResumeLayout(false);
            this.a.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_chu;
        private System.Windows.Forms.GroupBox a;
        private System.Windows.Forms.Label lb_kichthuoc;
        private System.Windows.Forms.Label lb_font;
        private System.Windows.Forms.ComboBox comboBox_kichthuoc;
        private System.Windows.Forms.ComboBox comboBox_font;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_dam;
        private System.Windows.Forms.CheckBox checkBox_nghieng;
        private System.Windows.Forms.CheckBox checkBox_gachchan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_lamlai;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.RadioButton radioButton_den;
        private System.Windows.Forms.RadioButton radioButton_xanhla;
        private System.Windows.Forms.RadioButton radioButton_do;
    }
}

