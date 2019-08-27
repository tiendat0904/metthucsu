using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.H))
                {
                    Button_Thoat_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    Button_Lammoi_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.D))
                {
                    Button_themvaods_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.X))
                {
                    Button_Xoakhoixs_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.N))
                {
                    Button_Tinhtong_Click(null, null);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Tinhtong.Enabled = false;
            button_timmax.Enabled = false;
            button_timmin.Enabled = false;
            button_Xoakhoixs.Enabled = false;
            lb_timmax.Hide();
            lb_Timmin.Hide();
            lb_tinhtong.Hide();
            this.KeyPreview = true;
        }

        private void Button_Lammoi_Click(object sender, EventArgs e)
        {
            tb_Nhap_so.Text = "";
            dayso.Items.Clear();
            Form1_Load(sender, e);
        }

        private void Button_themvaods_Click(object sender, EventArgs e)
        {
            double input;
            if (tb_Nhap_so.Text != "")
            {
                if (!double.TryParse(tb_Nhap_so.Text, out input))
                {
                    MessageBox.Show("bạn phải nhập số ", "Thông báo");
                }
                else
                {
                    dayso.Items.Add(input);
                }
            }
            else
            {
                MessageBox.Show("yêu cầu nhập số vào ", "Thông Báo");
            }
            button_Tinhtong.Enabled = true;
            button_timmax.Enabled = true;
            button_timmin.Enabled = true;
            button_Xoakhoixs.Enabled = true;
            tb_Nhap_so.Text = "";
            tb_Nhap_so.Focus();
        }

        private void Button_Xoakhoixs_Click(object sender, EventArgs e)
        {
            if (dayso.SelectedIndex != -1)
            {

                dayso.Items.Remove(dayso.SelectedItem);
            }
            else
            {
                MessageBox.Show("vui lòng chọn số để xóa ", "Thông Báo");
            }

            if (dayso.Items.Count == 0)
            {
                button_Tinhtong.Enabled = false;
                button_timmax.Enabled = false;
                button_timmin.Enabled = false;
                button_Xoakhoixs.Enabled = false;
            }
            {

            }
        }

        private void Button_Tinhtong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < dayso.Items.Count; i++)
            {
                tong += Convert.ToInt32(dayso.Items[i].ToString());
            }

            lb_tinhtong.Text = "Tổng =" +  tong.ToString();
            lb_tinhtong.Show();

        }

        private void Button_timmax_Click(object sender, EventArgs e)
        {
            double max = Convert.ToDouble(dayso.Items[0]);
            for(int i = 0; i < dayso.Items.Count; i++)
            {
                if(max < Convert.ToDouble(dayso.Items[i]))
                {
                    max = Convert.ToDouble(dayso.Items[i]);
                }
            }
            lb_timmax.Text = "Max = " + max.ToString();
            lb_timmax.Show();
        }

        private void Button_timmin_Click(object sender, EventArgs e)
        {
            double min = Convert.ToDouble(dayso.Items[0]);
            for (int i = 0; i < dayso.Items.Count; i++)
            {
                if (min > Convert.ToDouble(dayso.Items[i]))
                {
                    min = Convert.ToDouble(dayso.Items[i]);
                }
            }
            lb_Timmin.Text = "Min = " + min.ToString();
            lb_Timmin.Show();
        }
    }
}
