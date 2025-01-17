﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = Application.StartupPath;
            Uri path = new Uri(Application.StartupPath);
            webBrowser1.Url = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Uri path = new Uri(textBox1.Text);
            webBrowser1.Url = path;
        }
    }
}
