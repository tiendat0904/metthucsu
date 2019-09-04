using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhLaiSuatGuiTietKiem
{
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }

        private void TextTimKiem_KH_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_timkiem_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.TenKH1 == (textTimKiem_KH.Text))
                {
                    timthay = 1;

                    listBox_timkiem.Items.Add("Khách hàng " + i.TenKH1 + "phải trả"

                    + i.Tien1 + " nghìn đồng");
                }
            }

            if (timthay == 0)
            {
                listBox_timkiem.Items.Add("Khách hàng " + listBox_timkiem.Text + " không có trong danh sách");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
