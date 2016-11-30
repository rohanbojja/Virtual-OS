using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Form7 newf1 = new Form7();
            //newf1.DesktopLocation = new Point(400, 400);
            //newf1.MdiParent = this;
            //newf1.Show();
            Form7 form2 = new Form7();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Left = 950;
            form2.Top = 60;
            form2.MdiParent = this;
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newf = new Form2();
            newf.MdiParent = this;
            newf.Show();
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newf = new Form3();
            newf.MdiParent = this;
            newf.Show();
        }

        private void fileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newf = new Form4();
            newf.MdiParent = this;
            newf.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 newf = new Form8();
            newf.MdiParent = this;
            newf.Show();
        }

        private void mediaPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 newf = new Form9();
            newf.MdiParent = this;
            newf.Show();
        }

        private void recycleBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 newf = new Form10();
            newf.MdiParent = this;
            newf.Show();
        }

        private void cPUMonitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 newf = new Form12();
            newf.MdiParent = this;
            newf.Show();
        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form13 newf = new Form13();
            newf.MdiParent = this;
            newf.Show();
        }
    }
}
