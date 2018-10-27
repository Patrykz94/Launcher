namespace Launcher
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.outlineLeft = new System.Windows.Forms.Panel();
            this.outlineRight = new System.Windows.Forms.Panel();
            this.outlineTop = new System.Windows.Forms.Panel();
            this.separator1 = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStripLauncher = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripItemNoHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLibrary = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.buttonAppMiniCiv = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 2);
            this.panel2.TabIndex = 10;
            // 
            // outlineLeft
            // 
            this.outlineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.outlineLeft.Location = new System.Drawing.Point(0, 2);
            this.outlineLeft.Name = "outlineLeft";
            this.outlineLeft.Size = new System.Drawing.Size(2, 496);
            this.outlineLeft.TabIndex = 11;
            // 
            // outlineRight
            // 
            this.outlineRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.outlineRight.Location = new System.Drawing.Point(948, 2);
            this.outlineRight.Name = "outlineRight";
            this.outlineRight.Size = new System.Drawing.Size(2, 496);
            this.outlineRight.TabIndex = 11;
            // 
            // outlineTop
            // 
            this.outlineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.outlineTop.Location = new System.Drawing.Point(0, 0);
            this.outlineTop.Name = "outlineTop";
            this.outlineTop.Size = new System.Drawing.Size(950, 2);
            this.outlineTop.TabIndex = 6;
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.separator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator1.Location = new System.Drawing.Point(2, 50);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(946, 2);
            this.separator1.TabIndex = 12;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.menuStrip);
            this.TopPanel.Controls.Add(this.labelLibrary);
            this.TopPanel.Controls.Add(this.buttonExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(946, 48);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripLauncher,
            this.menuStripHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(120, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "Launcher";
            // 
            // menuStripLauncher
            // 
            this.menuStripLauncher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuStripLauncher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuStripLauncher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemSettings,
            this.menuStripItemExit});
            this.menuStripLauncher.ForeColor = System.Drawing.Color.Gray;
            this.menuStripLauncher.Name = "menuStripLauncher";
            this.menuStripLauncher.Size = new System.Drawing.Size(68, 20);
            this.menuStripLauncher.Text = "Launcher";
            // 
            // menuStripItemSettings
            // 
            this.menuStripItemSettings.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripItemSettings.Name = "menuStripItemSettings";
            this.menuStripItemSettings.Size = new System.Drawing.Size(116, 22);
            this.menuStripItemSettings.Text = "Settings";
            this.menuStripItemSettings.Click += new System.EventHandler(this.menuStripItemSettings_Click);
            // 
            // menuStripItemExit
            // 
            this.menuStripItemExit.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripItemExit.Name = "menuStripItemExit";
            this.menuStripItemExit.Size = new System.Drawing.Size(116, 22);
            this.menuStripItemExit.Text = "Exit";
            this.menuStripItemExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStripHelp
            // 
            this.menuStripHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.menuStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripItemNoHelp});
            this.menuStripHelp.ForeColor = System.Drawing.Color.Gray;
            this.menuStripHelp.Name = "menuStripHelp";
            this.menuStripHelp.Size = new System.Drawing.Size(44, 20);
            this.menuStripHelp.Text = "Help";
            // 
            // menuStripItemNoHelp
            // 
            this.menuStripItemNoHelp.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripItemNoHelp.Name = "menuStripItemNoHelp";
            this.menuStripItemNoHelp.Size = new System.Drawing.Size(164, 22);
            this.menuStripItemNoHelp.Text = "There\'s no help...";
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.Font = new System.Drawing.Font("Helvetica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrary.ForeColor = System.Drawing.Color.DarkGray;
            this.labelLibrary.Location = new System.Drawing.Point(55, 21);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(84, 27);
            this.labelLibrary.TabIndex = 2;
            this.labelLibrary.Text = "Library";
            this.labelLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Silver;
            this.buttonExit.Location = new System.Drawing.Point(896, 0);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "✕";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.Sidebar.Controls.Add(this.buttonAppMiniCiv);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(2, 52);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(200, 446);
            this.Sidebar.TabIndex = 14;
            // 
            // buttonAppMiniCiv
            // 
            this.buttonAppMiniCiv.FlatAppearance.BorderSize = 0;
            this.buttonAppMiniCiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAppMiniCiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAppMiniCiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppMiniCiv.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppMiniCiv.ForeColor = System.Drawing.Color.Silver;
            this.buttonAppMiniCiv.Image = ((System.Drawing.Image)(resources.GetObject("buttonAppMiniCiv.Image")));
            this.buttonAppMiniCiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAppMiniCiv.Location = new System.Drawing.Point(0, 0);
            this.buttonAppMiniCiv.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAppMiniCiv.Name = "buttonAppMiniCiv";
            this.buttonAppMiniCiv.Size = new System.Drawing.Size(200, 40);
            this.buttonAppMiniCiv.TabIndex = 1;
            this.buttonAppMiniCiv.Text = "  MiniCiv";
            this.buttonAppMiniCiv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAppMiniCiv.UseVisualStyleBackColor = true;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.outlineLeft);
            this.Controls.Add(this.outlineRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outlineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.LauncherForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.Sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel outlineLeft;
        private System.Windows.Forms.Panel outlineRight;
        private System.Windows.Forms.Panel outlineTop;
        private System.Windows.Forms.Panel separator1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStripLauncher;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemSettings;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuStripHelp;
        private System.Windows.Forms.ToolStripMenuItem menuStripItemNoHelp;
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button buttonAppMiniCiv;
    }
}

