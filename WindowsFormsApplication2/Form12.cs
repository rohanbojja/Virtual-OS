using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication2
{
    public partial class Form12 : Form
    {
        PerformanceCounter cpu = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter mem = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter sys = new PerformanceCounter("System", "System Up Time");
        public Form12()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(cpu.NextValue());
            label1.Text = "CPU" + " " + progressBar1.Value.ToString() + " " + "%";

           //rogressBar2.Value = (int)(mem.NextValue());
            label2.Text = "Memory" + " " + mem.NextValue() + " " + "MB";

            //ogressBar3.Value = (int)(sys.NextValue()) / 60 / 60;
            label3.Text = "System Up Time:"+ " " + sys.NextValue()/60/60 + "Hours";

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}
