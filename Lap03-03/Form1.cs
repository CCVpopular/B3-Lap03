using Microsoft.VisualBasic.Devices;
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

 /*       private void SearchStudent(string keyword)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[1].Cells[i].Value.Contains(keyword))
                {

                }
            }

            foreach (DataGridView)
            {
                if (student.Name.Contains(keyword) || student.StudentID.Contains(keyword))
                {
                    dataGridView1.Rows.Add(student.StudentID, student.Name, student.Age);
                }
            }
        }
 */
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem11_Click((object)sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}