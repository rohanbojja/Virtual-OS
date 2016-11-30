namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cPUMonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediaPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recycleBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowItemReorder = true;
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.windowsToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.calendarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(400, 60);
            this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1,
            this.cPUMonitorToolStripMenuItem});
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.exitToolStripMenuItem.Text = "OS";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlText;
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Shut Down";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // cPUMonitorToolStripMenuItem
            // 
            this.cPUMonitorToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.cPUMonitorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.cPUMonitorToolStripMenuItem.Name = "cPUMonitorToolStripMenuItem";
            this.cPUMonitorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cPUMonitorToolStripMenuItem.Text = "CPU Monitor";
            this.cPUMonitorToolStripMenuItem.Click += new System.EventHandler(this.cPUMonitorToolStripMenuItem_Click);
            // 
            // windowsToolStripMenuItem
            // 
            this.windowsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
            this.windowsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsToolStripMenuItem.Text = "Windows";
            this.windowsToolStripMenuItem.Click += new System.EventHandler(this.windowsToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textEditorToolStripMenuItem,
            this.shellToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.fileManagerToolStripMenuItem,
            this.mediaPlayerToolStripMenuItem,
            this.recycleBinToolStripMenuItem});
            this.applicationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.applicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationsToolStripMenuItem.Image")));
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // textEditorToolStripMenuItem
            // 
            this.textEditorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.textEditorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.textEditorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("textEditorToolStripMenuItem.Image")));
            this.textEditorToolStripMenuItem.Name = "textEditorToolStripMenuItem";
            this.textEditorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.textEditorToolStripMenuItem.Text = "Text Editor";
            this.textEditorToolStripMenuItem.Click += new System.EventHandler(this.textEditorToolStripMenuItem_Click);
            // 
            // shellToolStripMenuItem
            // 
            this.shellToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.shellToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.shellToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("shellToolStripMenuItem.Image")));
            this.shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            this.shellToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.shellToolStripMenuItem.Text = "Shell";
            this.shellToolStripMenuItem.Click += new System.EventHandler(this.shellToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.calculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.calculatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorToolStripMenuItem.Image")));
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // fileManagerToolStripMenuItem
            // 
            this.fileManagerToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.fileManagerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileManagerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileManagerToolStripMenuItem.Image")));
            this.fileManagerToolStripMenuItem.Name = "fileManagerToolStripMenuItem";
            this.fileManagerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fileManagerToolStripMenuItem.Text = "File manager";
            this.fileManagerToolStripMenuItem.Click += new System.EventHandler(this.fileManagerToolStripMenuItem_Click);
            // 
            // mediaPlayerToolStripMenuItem
            // 
            this.mediaPlayerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.mediaPlayerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.mediaPlayerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mediaPlayerToolStripMenuItem.Image")));
            this.mediaPlayerToolStripMenuItem.Name = "mediaPlayerToolStripMenuItem";
            this.mediaPlayerToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.mediaPlayerToolStripMenuItem.Text = "Media Player";
            this.mediaPlayerToolStripMenuItem.Click += new System.EventHandler(this.mediaPlayerToolStripMenuItem_Click);
            // 
            // recycleBinToolStripMenuItem
            // 
            this.recycleBinToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText;
            this.recycleBinToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.recycleBinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recycleBinToolStripMenuItem.Image")));
            this.recycleBinToolStripMenuItem.Name = "recycleBinToolStripMenuItem";
            this.recycleBinToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.recycleBinToolStripMenuItem.Text = "Recycle Bin";
            this.recycleBinToolStripMenuItem.Click += new System.EventHandler(this.recycleBinToolStripMenuItem_Click);
            // 
            // calendarToolStripMenuItem
            // 
            this.calendarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.calendarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calendarToolStripMenuItem.Image")));
            this.calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            this.calendarToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calendarToolStripMenuItem.Text = "Calendar";
            this.calendarToolStripMenuItem.Click += new System.EventHandler(this.calendarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 297);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileManagerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediaPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recycleBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cPUMonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
    }
}

