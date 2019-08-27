using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhTinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            new ToolTip().SetToolTip(textBox_nhapa, "nhập số nguyên");
            new ToolTip().SetToolTip(textBox_nhapb, "nhập số nguyên");
        }

        private void TextBox_nhapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox_nhapb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button_tong_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox_nhapa.Text);
            int b = Convert.ToInt32(textBox_nhapb.Text);
            int tong = 0;
            if(textBox_nhapa.Text!="" || textBox_nhapb.Text != "")
            {
                if (a < b)
                {
                    for(int i = a; i <= b; i++)
                    {
                        tong += i;
                    }
                }else if (b > a)
                {
                    for (int i = b; i <= a; i++)
                    {
                        tong += i;
                    }
                }
                lb_tong.Text = tong + "";
            }
            else
            {
                MessageBox.Show("vui lòng nhập a và b");
            }
        }

        private void Button_lamlai_Click(object sender, EventArgs e)
        {
            textBox_nhapa.Text = "";
            textBox_nhapb.Text = "";
            textBox_nhapa.Focus();
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không ? ", "thông báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Thoát_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    Thoát_Click(null, null);
                }
            }
        }
    }
}
