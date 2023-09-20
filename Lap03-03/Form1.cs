using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lap03_03
{
    public partial class Form1 : Form
    {
        public Form1 form1;
        public Form2 form2;
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form2>().Count() == 1)
                Application.OpenForms.OfType<Form2>().First().Close();
            form2 = new Form2(this);
            form2.Show(this);
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void sreach(object sender, EventArgs e)
        {
            string sreach = toolStripTextBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string studentName = row.Cells[3].Value.ToString().ToLower();

                if (studentName.Contains(sreach))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }

        }*/

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem11_Click((object)sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}