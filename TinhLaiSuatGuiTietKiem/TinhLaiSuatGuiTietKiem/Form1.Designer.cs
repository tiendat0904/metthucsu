namespace TinhLaiSuatGuiTietKiem
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
            this.button_ThemDS = new System.Windows.Forms.Button();
            this.button_ThemMoi = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonPhatLoc = new System.Windows.Forms.RadioButton();
            this.radioButton_Thuong = new System.Windows.Forms.RadioButton();
            this.cbThoiGianGui = new System.Windows.Forms.ComboBox();
            this.NgayGui = new System.Windows.Forms.DateTimePicker();
            this.tbSoTienGui = new System.Windows.Forms.TextBox();
            this.lbThoiGianGui = new System.Windows.Forms.Label();
            this.lbNgayGui = new System.Windows.Forms.Label();
            this.lbSoTienGui = new System.Windows.Forms.Label();
            this.lbDiaChi = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbKH = new System.Windows.Forms.Label();
            this.tbDiaChi = new System.Windows.Forms.TextBox();
            this.tbHoTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HasagiDzo = new System.Windows.Forms.ListBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ThemDS);
            this.groupBox1.Controls.Add(this.button_ThemMoi);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbThoiGianGui);
            this.groupBox1.Controls.Add(this.NgayGui);
            this.groupBox1.Controls.Add(this.tbSoTienGui);
            this.groupBox1.Controls.Add(this.lbThoiGianGui);
            this.groupBox1.Controls.Add(this.lbNgayGui);
            this.groupBox1.Controls.Add(this.lbSoTienGui);
            this.groupBox1.Controls.Add(this.lbDiaChi);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.lbKH);
            this.groupBox1.Controls.Add(this.tbDiaChi);
            this.groupBox1.Controls.Add(this.tbHoTenKH);
            this.groupBox1.Controls.Add(this.tbMaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 563);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // button_ThemDS
            // 
            this.button_ThemDS.Location = new System.Drawing.Point(36, 522);
            this.button_ThemDS.Name = "button_ThemDS";
            this.button_ThemDS.Size = new System.Drawing.Size(143, 35);
            this.button_ThemDS.TabIndex = 2;
            this.button_ThemDS.Text = "Thêm Vào DS";
            this.button_ThemDS.UseVisualStyleBackColor = true;
            this.button_ThemDS.Click += new System.EventHandler(this.Button_ThemDS_Click);
            // 
            // button_ThemMoi
            // 
            this.button_ThemMoi.Location = new System.Drawing.Point(203, 522);
            this.button_ThemMoi.Name = "button_ThemMoi";
            this.button_ThemMoi.Size = new System.Drawing.Size(127, 35);
            this.button_ThemMoi.TabIndex = 3;
            this.button_ThemMoi.Text = "Thêm Mới";
            this.button_ThemMoi.UseVisualStyleBackColor = true;
            this.button_ThemMoi.Click += new System.EventHandler(this.Button_ThemMoi_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonPhatLoc);
            this.groupBox3.Controls.Add(this.radioButton_Thuong);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 444);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 61);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Tiết Kiệm";
            // 
            // radioButtonPhatLoc
            // 
            this.radioButtonPhatLoc.AutoSize = true;
            this.radioButtonPhatLoc.Location = new System.Drawing.Point(176, 21);
            this.radioButtonPhatLoc.Name = "radioButtonPhatLoc";
            this.radioButtonPhatLoc.Size = new System.Drawing.Size(97, 24);
            this.radioButtonPhatLoc.TabIndex = 1;
            this.radioButtonPhatLoc.TabStop = true;
            this.radioButtonPhatLoc.Text = "Phát Lộc";
            this.radioButtonPhatLoc.UseVisualStyleBackColor = true;
            // 
            // radioButton_Thuong
            // 
            this.radioButton_Thuong.AutoSize = true;
            this.radioButton_Thuong.Location = new System.Drawing.Point(27, 21);
            this.radioButton_Thuong.Name = "radioButton_Thuong";
            this.radioButton_Thuong.Size = new System.Drawing.Size(85, 24);
            this.radioButton_Thuong.TabIndex = 0;
            this.radioButton_Thuong.TabStop = true;
            this.radioButton_Thuong.Text = "Thường";
            this.radioButton_Thuong.UseVisualStyleBackColor = true;
            // 
            // cbThoiGianGui
            // 
            this.cbThoiGianGui.FormattingEnabled = true;
            this.cbThoiGianGui.Location = new System.Drawing.Point(174, 405);
            this.cbThoiGianGui.Name = "cbThoiGianGui";
            this.cbThoiGianGui.Size = new System.Drawing.Size(121, 28);
            this.cbThoiGianGui.TabIndex = 11;
            // 
            // NgayGui
            // 
            this.NgayGui.Location = new System.Drawing.Point(174, 337);
            this.NgayGui.Name = "NgayGui";
            this.NgayGui.Size = new System.Drawing.Size(200, 27);
            this.NgayGui.TabIndex = 10;
            // 
            // tbSoTienGui
            // 
            this.tbSoTienGui.Location = new System.Drawing.Point(174, 271);
            this.tbSoTienGui.Name = "tbSoTienGui";
            this.tbSoTienGui.Size = new System.Drawing.Size(100, 27);
            this.tbSoTienGui.TabIndex = 9;
            this.tbSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbSoTienGui_KeyPress);
            // 
            // lbThoiGianGui
            // 
            this.lbThoiGianGui.AutoSize = true;
            this.lbThoiGianGui.Location = new System.Drawing.Point(-3, 405);
            this.lbThoiGianGui.Name = "lbThoiGianGui";
            this.lbThoiGianGui.Size = new System.Drawing.Size(112, 20);
            this.lbThoiGianGui.TabIndex = 8;
            this.lbThoiGianGui.Text = "Thời Gian Gửi";
            // 
            // lbNgayGui
            // 
            this.lbNgayGui.AutoSize = true;
            this.lbNgayGui.Location = new System.Drawing.Point(6, 337);
            this.lbNgayGui.Name = "lbNgayGui";
            this.lbNgayGui.Size = new System.Drawing.Size(78, 20);
            this.lbNgayGui.TabIndex = 7;
            this.lbNgayGui.Text = "Ngày Gửi";
            // 
            // lbSoTienGui
            // 
            this.lbSoTienGui.AutoSize = true;
            this.lbSoTienGui.Location = new System.Drawing.Point(6, 271);
            this.lbSoTienGui.Name = "lbSoTienGui";
            this.lbSoTienGui.Size = new System.Drawing.Size(97, 20);
            this.lbSoTienGui.TabIndex = 6;
            this.lbSoTienGui.Text = "Số Tiền Gửi";
            // 
            // lbDiaChi
            // 
            this.lbDiaChi.AutoSize = true;
            this.lbDiaChi.Location = new System.Drawing.Point(6, 199);
            this.lbDiaChi.Name = "lbDiaChi";
            this.lbDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lbDiaChi.TabIndex = 5;
            this.lbDiaChi.Text = "Địa Chỉ";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(6, 119);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(93, 20);
            this.lbHoTen.TabIndex = 4;
            this.lbHoTen.Text = "Họ Tên KH";
            // 
            // lbKH
            // 
            this.lbKH.AutoSize = true;
            this.lbKH.Location = new System.Drawing.Point(6, 41);
            this.lbKH.Name = "lbKH";
            this.lbKH.Size = new System.Drawing.Size(61, 20);
            this.lbKH.TabIndex = 3;
            this.lbKH.Text = "Mã KH";
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Location = new System.Drawing.Point(174, 199);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Size = new System.Drawing.Size(100, 27);
            this.tbDiaChi.TabIndex = 2;
            // 
            // tbHoTenKH
            // 
            this.tbHoTenKH.Location = new System.Drawing.Point(174, 119);
            this.tbHoTenKH.Name = "tbHoTenKH";
            this.tbHoTenKH.Size = new System.Drawing.Size(100, 27);
            this.tbHoTenKH.TabIndex = 1;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(174, 41);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(100, 27);
            this.tbMaKH.TabIndex = 0;
            this.tbMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbMaKH_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.HasagiDzo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(424, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 441);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // HasagiDzo
            // 
            this.HasagiDzo.FormattingEnabled = true;
            this.HasagiDzo.ItemHeight = 29;
            this.HasagiDzo.Location = new System.Drawing.Point(6, 43);
            this.HasagiDzo.Name = "HasagiDzo";
            this.HasagiDzo.Size = new System.Drawing.Size(655, 381);
            this.HasagiDzo.TabIndex = 0;
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.Location = new System.Drawing.Point(742, 520);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(112, 32);
            this.button_TimKiem.TabIndex = 2;
            this.button_TimKiem.Text = "Tìm Kiếm";
            this.button_TimKiem.UseVisualStyleBackColor = true;
            this.button_TimKiem.Click += new System.EventHandler(this.Button_TimKiem_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.Location = new System.Drawing.Point(905, 517);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(94, 35);
            this.button_Thoat.TabIndex = 3;
            this.button_Thoat.Text = "Thoát";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.Button_Thoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 575);
            this.Controls.Add(this.button_TimKiem);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tính Lãi Suất Tiền Gửi Tiết Kiệm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbThoiGianGui;
        private System.Windows.Forms.Label lbNgayGui;
        private System.Windows.Forms.Label lbSoTienGui;
        private System.Windows.Forms.Label lbDiaChi;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbKH;
        private System.Windows.Forms.TextBox tbDiaChi;
        private System.Windows.Forms.TextBox tbHoTenKH;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbThoiGianGui;
        private System.Windows.Forms.DateTimePicker NgayGui;
        private System.Windows.Forms.TextBox tbSoTienGui;
        private System.Windows.Forms.Button button_ThemDS;
        private System.Windows.Forms.Button button_ThemMoi;
        private System.Windows.Forms.RadioButton radioButtonPhatLoc;
        private System.Windows.Forms.RadioButton radioButton_Thuong;
        private System.Windows.Forms.ListBox HasagiDzo;
        private System.Windows.Forms.Button button_TimKiem;
        private System.Windows.Forms.Button button_Thoat;
    }
}

