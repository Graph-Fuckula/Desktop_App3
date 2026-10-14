using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btn_save_as_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(saveFileDialog1.FileName))
                {
                    sr.WriteLine(textBox1.Text);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void øðèôòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }
    }
}