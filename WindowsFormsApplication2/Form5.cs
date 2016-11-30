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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(Form5_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                if (textBox1.Text == "admin" && textBox2.Text == "pass")
                {
                    Form1 newf = new Form1();
                    newf.Show();
                    
                }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 1000000;
            progressBar1.Step = 1;
            for(int i=0;i<= 1000000;i++)
            {
                progressBar1.PerformStep();
            }
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="admin" && textBox2.Text=="pass")
            {
                Form1 newf = new Form1();
                newf.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
