using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        public static class Globals
        {
            public static String curdir = "";
        }
        public Form3()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(Form3_KeyPress);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                String curcmd = "";
                curcmd = textBox1.Text;
                textBox1.Text = "";
                exec_cmd(curcmd);
            }
        }
        private void exec_cmd(String cmd)
        {
            String[] fcmd = cmd.Split(' ');
            if(fcmd[0]=="echo")
            {
                int x = 0;
                String outl="";
                outl = "OS" + Globals.curdir + ">";
                foreach (String pcmd in fcmd)
                {
                    if(x!=0)
                    {
                        outl = outl+" "+pcmd;
                    }
                    x = 69;
                }
                label1.Text = outl;
            }
            else if (fcmd[0] == "file-manager")
            {
                Form4 newf = new Form4();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "text-editor")
            {
                Form2 newf = new Form2();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "calculator")
            {
                Form8 newf = new Form8();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "media-player")
            {
                Form9 newf = new Form9();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "cpu-monitor")
            {
                Form12 newf = new Form12();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if (fcmd[0] == "calendar")
            {
                Form13 newf = new Form13();
                newf.MdiParent = this.ParentForm;
                newf.Show();
            }
            else if(fcmd[0]=="cp")//Not working
            {
                String at = Application.StartupPath + Globals.curdir;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C copy \""+at+"\\"+fcmd[1]+"\" \""+at+"\\"+fcmd[2]+"\"";
                process.Start();
                label1.Text = "/C copy " + at + "\\" + fcmd[1] + '\n' + at + "\\" + fcmd[2];
            }
            else if(fcmd[0]=="mkdir")
            {
                String at = Application.StartupPath + Globals.curdir;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C mkdir \""+at+"\\"+fcmd[1]+"\"";
                String outl = "OS" + Globals.curdir + ">";
                outl = outl + "Created directory. ";
                label1.Text = outl;
                process.Start();
            }
            else if(fcmd[0]=="touch")
            {
                String at = Application.StartupPath + Globals.curdir;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C echo.> \"" + at + "\\" + fcmd[1] + "\"";
                process.Start();
                String outl = "OS" + Globals.curdir + ">";
                outl = outl + "Created file.";
                label1.Text = outl;
            }
            else if(fcmd[0]=="ls")
            {
                String[] dir = Directory.GetDirectories(Application.StartupPath + Globals.curdir);
                String outl = "OS" + Globals.curdir + ">";
                outl = outl + '\n';
                foreach(String word in dir)
                {
                    int m = word.Length - 1;
                    while (m >= 0 && word[m] != '\\')
                    {
                        m--;
                    }
                    String nw = word.Substring(m + 1);
                    outl = outl + nw;
                    outl = outl + '\n';
                }
                String[] dir2 = Directory.GetFiles(Application.StartupPath + Globals.curdir);
                foreach (String word in dir2)
                {
                    int m = word.Length - 1;
                    while (m >= 0 && word[m] != '\\')
                    {
                        m--;
                    }
                    String nw = word.Substring(m + 1);
                    outl = outl + nw;
                    outl = outl + '\n';
                }
                label1.Text = outl;
            }
            else if (fcmd[0]=="cd")
            {
                if(fcmd[1]=="..")
                {
                    String outl="";
                    String temp="";
                    temp = Globals.curdir;
                    int x = temp.Length;
                    x = x - 2;
                    while(x>=0 && temp[x]!='\\')
                    {
                        x--;
                    }
                    if(x>=0)
                    {
                        Globals.curdir = temp.Substring(0, x);
                        outl = "OS" + Globals.curdir + ">";
                        label1.Text = outl;
                    }
                }
                else
                {
                    int x = 0;
                    int f = 0;
                    String outl = "OS";
                    foreach (String pcmd in fcmd)
                    {
                        String[] dir = Directory.GetDirectories(Application.StartupPath+Globals.curdir);
                        foreach(String word in dir)
                        {
                            int m = word.Length-1;
                            while(m>=0 && word[m]!='\\')
                            {
                                m--;
                            }
                            String nw = word.Substring(m+1);
                            if(pcmd==nw)
                            {
                                if (x != 0)
                                {
                                    Globals.curdir = Globals.curdir + "\\" + pcmd;
                                    f = 69;
                                }
                            }
                        }
                        x = 69;
                    }
                    if(f!=69)
                    {
                        outl = "OS" + Globals.curdir + ">";
                        outl = outl + " " + "The specified directory doesn't exist!";
                        label1.Text = outl;
                    }
                    else
                    {
                        outl = "OS" + Globals.curdir + ">";
                        outl = outl + " " + "(Y)";
                        label1.Text = outl;
                    }
                }
            }
            else
            {
                String outl;
                outl = "OS" + Globals.curdir + ">";
                outl = outl + " " + "Invalid Command";
                label1.Text = outl;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String curcmd = "";
            curcmd = textBox1.Text;
            textBox1.Text = "";
            exec_cmd(curcmd);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
