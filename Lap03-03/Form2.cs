using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Lap03_03
{
    public partial class Form2 : Form
    {
        public Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            comboBox1.SelectedIndex = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.SelectedIndex == -1 || textBox3.Text == "")
                {
                    throw new Exception("Vui long nhap day du thong tin sinh vien!");
                }
                int chondong = dulieu(textBox1.Text);
                if (float.Parse(textBox3.Text) < 0 || float.Parse(textBox3.Text) > 10)
                {
                    throw new Exception("tttt");
                }
                if (chondong == -1)
                {
                    chondong = form1.dataGridView1.Rows.Add();
                    nhap(chondong);
                    MessageBox.Show("Them du lieu thanh cong!", "Thong bao", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Nhập trùng Mã số sinh viên!", "thông báo", MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int dulieu(string MSSV)
        {
            for (int i = 0; i < form1.dataGridView1.Rows.Count; i++)
            {
                if (form1.dataGridView1.Rows[i].Cells[1].Value == null)
                {
                    return -1;
                }
                if (form1.dataGridView1.Rows[i].Cells[1].Value.ToString() == MSSV)
                {
                    return i;
                }
            }
            return -1;
        }

        public void nhap(int chondong)
        {
            form1.dataGridView1.Rows[chondong].Cells[0].Value = "1";
            form1.dataGridView1.Rows[chondong].Cells[1].Value = textBox1.Text;
            form1.dataGridView1.Rows[chondong].Cells[2].Value = textBox2.Text;
            form1.dataGridView1.Rows[chondong].Cells[3].Value = comboBox1.SelectedItem.ToString();
            form1.dataGridView1.Rows[chondong].Cells[4].Value = textBox3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}