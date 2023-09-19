namespace Lap03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

        private void ToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem11_Click((object) sender, e);
        }
    }
}