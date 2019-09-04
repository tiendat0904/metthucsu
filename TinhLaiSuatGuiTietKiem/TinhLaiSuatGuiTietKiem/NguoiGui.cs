﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhLaiSuatGuiTietKiem
{
    class NguoiGui
    {
        private int MaKH;
        private string TenKH;
        private string DiaChi;
        private int SoTienGui;
        private string NgayGui;
        private string ThoiGianGui;
        private double Tien;

        public NguoiGui(int maKH)
        {
            MaKH = maKH;
        }
        public NguoiGui(String Tenkh)
        {
            TenKH = Tenkh;
        }
        public NguoiGui(int maKH, string tenKH, string diaChi, int soTienGui, string
        ngayGui, string thoiGianGui, double tien)
        {
            MaKH = maKH;
            TenKH = tenKH;
            DiaChi = diaChi;
            SoTienGui = soTienGui;
            NgayGui = ngayGui;
            ThoiGianGui = thoiGianGui;
            Tien = tien;
        }

        public double Tien1 { get => Tien; set => Tien = value; }
        public int MaKH1 { get => MaKH; set => MaKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
    }
}
