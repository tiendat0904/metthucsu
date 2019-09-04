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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddComBoBox()
        {
            cbThoiGianGui.Items.Add("1");
            cbThoiGianGui.Items.Add("3");
            cbThoiGianGui.Items.Add("6");
            cbThoiGianGui.Items.Add("12");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            AddComBoBox();
            this.KeyPreview = true;
        }

        private void TbMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button_ThemMoi_Click(object sender, EventArgs e)
        {
            tbMaKH.Text = "";
            tbHoTenKH.Text = "";
            tbDiaChi.Text = "";
            tbSoTienGui.Text = "";
            NgayGui.Text = "";
            lbThoiGianGui.Text = "";
            cbThoiGianGui.Text = "";
            cbThoiGianGui.SelectedIndex = -1;
            radioButton_Thuong.Checked = false;
            radioButtonPhatLoc.Checked = false;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.M))
                {
                    Button_ThemMoi_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.H))
                {
                    Button_Thoat_Click(null, null);
                }
            }
        }

        private void Button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không ?", "thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Button_ThemDS_Click(object sender, EventArgs e)
        {
            int kt = 1;
            if (tbMaKH.TextLength < 6)
            {
                MessageBox.Show("Nhập lại mã vì < 6");
                kt = 0;
            }

            if (tbHoTenKH.TextLength == 0 && tbDiaChi.TextLength == 0)
            {
                MessageBox.Show("Nhập họ tên và địa  chỉ khách hàng");
                kt = 0;
            }

            //if(cbThoiGianGui.Text!="1" || cbThoiGianGui.Text != "3" || cbThoiGianGui.Text != "6" || cbThoiGianGui.Text != "12")
            //{
            //    MessageBox.Show("thời gian gửi chỉ trong định kì (1/3/6/12) tháng, vui lòng nhập lại");
            //    kt = 0;             
            //}

            double tienlai = 0;
            if (kt == 1)
            {
                if (radioButton_Thuong.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.06;
                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.07;
                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.08;
                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.09;
                    }
                }
                else if (radioButtonPhatLoc.Checked == true)
                {
                    if (cbThoiGianGui.SelectedItem == "1")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.07;
                    }
                    if (cbThoiGianGui.SelectedItem == "3")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.08;
                    }
                    if (cbThoiGianGui.SelectedItem == "6")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.09;
                    }
                    if (cbThoiGianGui.SelectedItem == "12")
                    {
                        tienlai = Convert.ToInt32(tbSoTienGui.Text) * 0.1;
                    }
                }

                HasagiDzo.Items.Add(tbMaKH.Text + " | " + tbHoTenKH.Text + "|" + tbDiaChi.Text + "|" + tbSoTienGui.Text + "|"
                    + NgayGui.Text + "|" + cbThoiGianGui.Text + " Tháng |" + tienlai);
  
            }
            List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
            listNguoiGuis.Add(new NguoiGui(Convert.ToInt32(tbMaKH.Text),
            tbHoTenKH.Text, tbDiaChi.Text, Convert.ToInt32(tbSoTienGui.Text),
            NgayGui.Text, cbThoiGianGui.Text, tienlai
            ));
            StaticData._NguoiGui = listNguoiGuis;

        }

        private void Button_TimKiem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
