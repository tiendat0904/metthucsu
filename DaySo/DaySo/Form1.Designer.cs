namespace DaySo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dayso = new System.Windows.Forms.ListBox();
            this.tb_Nhap_so = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Xoakhoixs = new System.Windows.Forms.Button();
            this.button_themvaods = new System.Windows.Forms.Button();
            this.button_Lammoi = new System.Windows.Forms.Button();
            this.button_Tinhtong = new System.Windows.Forms.Button();
            this.button_timmax = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.button_timmin = new System.Windows.Forms.Button();
            this.lb_tinhtong = new System.Windows.Forms.Label();
            this.lb_timmax = new System.Windows.Forms.Label();
            this.lb_Timmin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dayso);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(319, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dãy Số";
            // 
            // dayso
            // 
            this.dayso.FormattingEnabled = true;
            this.dayso.ItemHeight = 20;
            this.dayso.Location = new System.Drawing.Point(49, 42);
            this.dayso.Name = "dayso";
            this.dayso.Size = new System.Drawing.Size(196, 224);
            this.dayso.TabIndex = 5;
            // 
            // tb_Nhap_so
            // 
            this.tb_Nhap_so.Location = new System.Drawing.Point(123, 39);
            this.tb_Nhap_so.Name = "tb_Nhap_so";
            this.tb_Nhap_so.Size = new System.Drawing.Size(125, 22);
            this.tb_Nhap_so.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Số :";
            // 
            // button_Xoakhoixs
            // 
            this.button_Xoakhoixs.Location = new System.Drawing.Point(63, 174);
            this.button_Xoakhoixs.Name = "button_Xoakhoixs";
            this.button_Xoakhoixs.Size = new System.Drawing.Size(185, 31);
            this.button_Xoakhoixs.TabIndex = 2;
            this.button_Xoakhoixs.Text = "Xóa khỏi danh sách";
            this.button_Xoakhoixs.UseVisualStyleBackColor = true;
            this.button_Xoakhoixs.Click += new System.EventHandler(this.Button_Xoakhoixs_Click);
            // 
            // button_themvaods
            // 
            this.button_themvaods.Location = new System.Drawing.Point(63, 109);
            this.button_themvaods.Name = "button_themvaods";
            this.button_themvaods.Size = new System.Drawing.Size(185, 31);
            this.button_themvaods.TabIndex = 3;
            this.button_themvaods.Text = "Thêm vào danh sách";
            this.button_themvaods.UseVisualStyleBackColor = true;
            this.button_themvaods.Click += new System.EventHandler(this.Button_themvaods_Click);
            // 
            // button_Lammoi
            // 
            this.button_Lammoi.Location = new System.Drawing.Point(63, 238);
            this.button_Lammoi.Name = "button_Lammoi";
            this.button_Lammoi.Size = new System.Drawing.Size(185, 31);
            this.button_Lammoi.TabIndex = 4;
            this.button_Lammoi.Text = "Làm Mới";
            this.button_Lammoi.UseVisualStyleBackColor = true;
            this.button_Lammoi.Click += new System.EventHandler(this.Button_Lammoi_Click);
            // 
            // button_Tinhtong
            // 
            this.button_Tinhtong.Location = new System.Drawing.Point(681, 35);
            this.button_Tinhtong.Name = "button_Tinhtong";
            this.button_Tinhtong.Size = new System.Drawing.Size(93, 31);
            this.button_Tinhtong.TabIndex = 6;
            this.button_Tinhtong.Text = "Tính Tổng";
            this.button_Tinhtong.UseVisualStyleBackColor = true;
            this.button_Tinhtong.Click += new System.EventHandler(this.Button_Tinhtong_Click);
            // 
            // button_timmax
            // 
            this.button_timmax.Location = new System.Drawing.Point(681, 109);
            this.button_timmax.Name = "button_timmax";
            this.button_timmax.Size = new System.Drawing.Size(93, 31);
            this.button_timmax.TabIndex = 7;
            this.button_timmax.Text = "Tìm Max";
            this.button_timmax.UseVisualStyleBackColor = true;
            this.button_timmax.Click += new System.EventHandler(this.Button_timmax_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Location = new System.Drawing.Point(681, 238);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(93, 31);
            this.button_Thoat.TabIndex = 8;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.Button_Thoat_Click);
            // 
            // button_timmin
            // 
            this.button_timmin.Location = new System.Drawing.Point(681, 174);
            this.button_timmin.Name = "button_timmin";
            this.button_timmin.Size = new System.Drawing.Size(93, 31);
            this.button_timmin.TabIndex = 9;
            this.button_timmin.Text = "Tìm Min";
            this.button_timmin.UseVisualStyleBackColor = true;
            this.button_timmin.Click += new System.EventHandler(this.Button_timmin_Click);
            // 
            // lb_tinhtong
            // 
            this.lb_tinhtong.AutoSize = true;
            this.lb_tinhtong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tinhtong.Location = new System.Drawing.Point(809, 41);
            this.lb_tinhtong.Name = "lb_tinhtong";
            this.lb_tinhtong.Size = new System.Drawing.Size(0, 20);
            this.lb_tinhtong.TabIndex = 10;
            // 
            // lb_timmax
            // 
            this.lb_timmax.AutoSize = true;
            this.lb_timmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timmax.Location = new System.Drawing.Point(809, 113);
            this.lb_timmax.Name = "lb_timmax";
            this.lb_timmax.Size = new System.Drawing.Size(0, 20);
            this.lb_timmax.TabIndex = 11;
            // 
            // lb_Timmin
            // 
            this.lb_Timmin.AutoSize = true;
            this.lb_Timmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Timmin.Location = new System.Drawing.Point(809, 178);
            this.lb_Timmin.Name = "lb_Timmin";
            this.lb_Timmin.Size = new System.Drawing.Size(0, 20);
            this.lb_Timmin.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 344);
            this.Controls.Add(this.lb_Timmin);
            this.Controls.Add(this.lb_timmax);
            this.Controls.Add(this.lb_tinhtong);
            this.Controls.Add(this.button_timmin);
            this.Controls.Add(this.button_Tinhtong);
            this.Controls.Add(this.button_timmax);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_Lammoi);
            this.Controls.Add(this.button_themvaods);
            this.Controls.Add(this.button_Xoakhoixs);
            this.Controls.Add(this.tb_Nhap_so);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Dãy Số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox dayso;
        private System.Windows.Forms.TextBox tb_Nhap_so;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Xoakhoixs;
        private System.Windows.Forms.Button button_themvaods;
        private System.Windows.Forms.Button button_Lammoi;
        private System.Windows.Forms.Button button_Tinhtong;
        private System.Windows.Forms.Button button_timmax;
        private System.Windows.Forms.Button button_Thoat;
        private System.Windows.Forms.Button button_timmin;
        private System.Windows.Forms.Label lb_tinhtong;
        private System.Windows.Forms.Label lb_timmax;
        private System.Windows.Forms.Label lb_Timmin;
    }
}

