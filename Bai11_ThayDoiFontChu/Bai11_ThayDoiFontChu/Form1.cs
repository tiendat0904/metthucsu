using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11_ThayDoiFontChu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addcombobox_fontchu()
        {
            comboBox_font.Items.Add("Arial");
            comboBox_font.Items.Add("Times New Roman");

            comboBox_font.Items.Add("ArialH");
            comboBox_font.Items.Add("Bahnschrift");
            comboBox_font.Items.Add("UniverseH");

        }

        private void addcombobox_kichthuoc()
        {
            for (int i = 14; i <= 24; i++)
            {
                comboBox_kichthuoc.Items.Add(i);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            addcombobox_fontchu();
            addcombobox_kichthuoc();
            this.KeyPreview = true;
            comboBox_font.Text = "Times New Roman";
            comboBox_kichthuoc.Text = "18";
            tb_chu.Font = new Font(tb_chu.Font, FontStyle.Regular);
            Button_lamlai_Click(sender, e);

        }

        private void Button_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không ?", "thông báo", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.T))
                {
                    Button_Thoat_Click(null, null);
                }
                if (e.KeyCode.Equals(Keys.L))
                {
                    Button_lamlai_Click(null, null);
                }
            }
        }

        private void Button_lamlai_Click(object sender, EventArgs e)
        {
            checkBox_dam.Checked = false;
            checkBox_nghieng.Checked = false;
            checkBox_gachchan.Checked = false;
            radioButton_do.Checked = false;
            radioButton_xanhla.Checked = false;
            radioButton_den.Checked = false;
            comboBox_font.Text = "";
            comboBox_kichthuoc.Text = "";
            RadioButton_den_CheckedChanged(sender, e);
        }

        private void ComboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kich_thuoc;
            if (int.TryParse(comboBox_kichthuoc.Text, out kich_thuoc))
            {
                tb_chu.Font = new Font(comboBox_font.Text, kich_thuoc, FontStyle.Regular);

            }
            else
            {
                tb_chu.Font = new Font(comboBox_font.Text, 18, FontStyle.Regular);
            }

        }

        private void CheckBox_dam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dam.CheckState == CheckState.Checked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Bold);
            }
            else if (checkBox_dam.CheckState == CheckState.Unchecked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Bold);
                
            }
            
        }

        private void CheckBox_nghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nghieng.CheckState == CheckState.Checked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Italic);
            }
            else if (checkBox_nghieng.CheckState == CheckState.Unchecked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Italic);
                
            }
            
        }

        private void CheckBox_gachchan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gachchan.CheckState == CheckState.Checked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Underline);
            }
            else if (checkBox_gachchan.CheckState == CheckState.Unchecked)
            {
                tb_chu.Font = new Font(tb_chu.Font.Name, tb_chu.Font.Size, tb_chu.Font.Style ^ FontStyle.Underline);
               
            }
            
        }

        private void RadioButton_do_CheckedChanged(object sender, EventArgs e)
        {

            tb_chu.ForeColor = Color.Red;
        }

        private void RadioButton_xanhla_CheckedChanged(object sender, EventArgs e)
        {
            tb_chu.ForeColor = Color.Green;
        }

        private void RadioButton_den_CheckedChanged(object sender, EventArgs e)
        {
            tb_chu.ForeColor = Color.Black;
        }

        private void ComboBox_kichthuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_chu.Font = new Font(comboBox_font.Text, Convert.ToInt32(comboBox_kichthuoc.Text), FontStyle.Bold);
        }
    }
}
