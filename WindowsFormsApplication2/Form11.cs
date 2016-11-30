using System;
using System.Windows.Forms;
using System.Diagnostics;
namespace WindowsFormsApplication2
{
    public partial class Form11 : Form
    {
        PerformanceCounter cpu = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter mem = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter sys = new PerformanceCounter("System", "System Up Time");


        public Form11()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar4.Value = (int)(cpu.NextValue());
            label4.Text = "CPU" + " " + (int)cpu.NextValue() + " " + "%"; 

            progressBar5.Value = (int)(mem.NextValue());
            label5.Text = "Memory" + " " + (int)mem.NextValue() + " " + "%";

            progressBar4.Value = (int)(sys.NextValue());
            label6.Text = "System" + " " + (int)sys.NextValue() + " " + "%";
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
