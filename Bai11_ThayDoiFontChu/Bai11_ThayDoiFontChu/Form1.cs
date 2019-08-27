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
            comboBox_font.Items.Add(".vnTime");
            comboBox_font.Items.Add(".vnTimeH");
            comboBox_font.Items.Add(".vnArial");
            comboBox_font.Items.Add(".vnArialH");
            comboBox_font.Items.Add(".vnUniverse");
            comboBox_font.Items.Add(".vnUniverseH");

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
            comboBox_font.Text = "";
            comboBox_kichthuoc.Text = "";
        }

        private void ComboBox_font_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_dam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dam.Checked == true)
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Bold);
            }
            else if (checkBox_nghieng.Checked == true)
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Italic);
            }
            else if (checkBox_gachchan.Checked == true)
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.un);
            }
            else
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Regular);

            }
        }

        private void CheckBox_nghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nghieng.Checked == true)
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Italic);
            }
            else
            {

                


                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Regular);

            }
        }

        private void CheckBox_gachchan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_gachchan.Checked == true)
            {
                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Underline);
            }
            else
            {

               


                tb_chu.Font = new Font(tb_chu.Font, FontStyle.Regular);

            }
        }
    }
}
