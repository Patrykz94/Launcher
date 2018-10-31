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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.outlineLeft = new System.Windows.Forms.Panel();
            this.outlineRight = new System.Windows.Forms.Panel();
            this.outlineTop = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.labelLibrary = new System.Windows.Forms.Label();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.buttonAppMiniCiv = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LabelDescriptionText = new System.Windows.Forms.Label();
            this.PanelGameStats = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelLastPlayed = new System.Windows.Forms.Label();
            this.LabelGameDescription = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButtonInstall = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelGameName = new System.Windows.Forms.Label();
            this.LauncherToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TopPanel.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelGameStats.SuspendLayout();
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
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopPanel.Controls.Add(this.labelLibrary);
            this.TopPanel.Controls.Add(this.ButtonSettings);
            this.TopPanel.Controls.Add(this.ButtonMinimize);
            this.TopPanel.Controls.Add(this.ButtonExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(946, 48);
            this.TopPanel.TabIndex = 13;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.BackColor = System.Drawing.Color.Transparent;
            this.labelLibrary.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelLibrary.Location = new System.Drawing.Point(56, 19);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(88, 29);
            this.labelLibrary.TabIndex = 6;
            this.labelLibrary.Text = "Library";
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSettings.BackgroundImage")));
            this.ButtonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSettings.FlatAppearance.BorderSize = 0;
            this.ButtonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ButtonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSettings.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSettings.ForeColor = System.Drawing.Color.Silver;
            this.ButtonSettings.Location = new System.Drawing.Point(796, 0);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(50, 50);
            this.ButtonSettings.TabIndex = 5;
            this.LauncherToolTip.SetToolTip(this.ButtonSettings, "Settings");
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMinimize.ForeColor = System.Drawing.Color.Silver;
            this.ButtonMinimize.Location = new System.Drawing.Point(846, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(50, 50);
            this.ButtonMinimize.TabIndex = 4;
            this.ButtonMinimize.Text = "    ";
            this.LauncherToolTip.SetToolTip(this.ButtonMinimize, "Minimize");
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.Silver;
            this.ButtonExit.Location = new System.Drawing.Point(896, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(50, 50);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "✕";
            this.LauncherToolTip.SetToolTip(this.ButtonExit, "Exit");
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.AutoScroll = true;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Sidebar.Controls.Add(this.buttonAppMiniCiv);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(2, 50);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(200, 448);
            this.Sidebar.TabIndex = 14;
            // 
            // buttonAppMiniCiv
            // 
            this.buttonAppMiniCiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonAppMiniCiv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonAppMiniCiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.buttonAppMiniCiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.buttonAppMiniCiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAppMiniCiv.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAppMiniCiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAppMiniCiv.Image = ((System.Drawing.Image)(resources.GetObject("buttonAppMiniCiv.Image")));
            this.buttonAppMiniCiv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAppMiniCiv.Location = new System.Drawing.Point(0, 0);
            this.buttonAppMiniCiv.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAppMiniCiv.Name = "buttonAppMiniCiv";
            this.buttonAppMiniCiv.Size = new System.Drawing.Size(200, 40);
            this.buttonAppMiniCiv.TabIndex = 1;
            this.buttonAppMiniCiv.Text = "  MiniCiv";
            this.buttonAppMiniCiv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAppMiniCiv.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.separator.Dock = System.Windows.Forms.DockStyle.Left;
            this.separator.Location = new System.Drawing.Point(202, 50);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(2, 448);
            this.separator.TabIndex = 15;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainPanel.Controls.Add(this.LabelDescriptionText);
            this.MainPanel.Controls.Add(this.PanelGameStats);
            this.MainPanel.Controls.Add(this.LabelGameDescription);
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.ButtonInstall);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.LabelGameName);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(204, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(744, 448);
            this.MainPanel.TabIndex = 16;
            // 
            // LabelDescriptionText
            // 
            this.LabelDescriptionText.AutoSize = true;
            this.LabelDescriptionText.Location = new System.Drawing.Point(24, 190);
            this.LabelDescriptionText.MaximumSize = new System.Drawing.Size(650, 0);
            this.LabelDescriptionText.Name = "LabelDescriptionText";
            this.LabelDescriptionText.Size = new System.Drawing.Size(649, 364);
            this.LabelDescriptionText.TabIndex = 5;
            this.LabelDescriptionText.Text = resources.GetString("LabelDescriptionText.Text");
            // 
            // PanelGameStats
            // 
            this.PanelGameStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelGameStats.Controls.Add(this.label1);
            this.PanelGameStats.Controls.Add(this.LabelLastPlayed);
            this.PanelGameStats.Location = new System.Drawing.Point(250, 65);
            this.PanelGameStats.Name = "PanelGameStats";
            this.PanelGameStats.Size = new System.Drawing.Size(417, 100);
            this.PanelGameStats.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Play Time: 0 Hours";
            // 
            // LabelLastPlayed
            // 
            this.LabelLastPlayed.AutoSize = true;
            this.LabelLastPlayed.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLastPlayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LabelLastPlayed.Location = new System.Drawing.Point(12, 19);
            this.LabelLastPlayed.Name = "LabelLastPlayed";
            this.LabelLastPlayed.Size = new System.Drawing.Size(174, 22);
            this.LabelLastPlayed.TabIndex = 5;
            this.LabelLastPlayed.Text = "Last Played:       Never";
            // 
            // LabelGameDescription
            // 
            this.LabelGameDescription.AutoSize = true;
            this.LabelGameDescription.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameDescription.Location = new System.Drawing.Point(23, 150);
            this.LabelGameDescription.Name = "LabelGameDescription";
            this.LabelGameDescription.Size = new System.Drawing.Size(105, 24);
            this.LabelGameDescription.TabIndex = 3;
            this.LabelGameDescription.Text = "Description";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Location = new System.Drawing.Point(20, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 2);
            this.panel3.TabIndex = 2;
            // 
            // ButtonInstall
            // 
            this.ButtonInstall.AutoSize = true;
            this.ButtonInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonInstall.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ButtonInstall.FlatAppearance.BorderSize = 2;
            this.ButtonInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.ButtonInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.ButtonInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInstall.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonInstall.Location = new System.Drawing.Point(20, 80);
            this.ButtonInstall.Name = "ButtonInstall";
            this.ButtonInstall.Size = new System.Drawing.Size(160, 50);
            this.ButtonInstall.TabIndex = 2;
            this.ButtonInstall.Text = "Install";
            this.ButtonInstall.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 2);
            this.panel1.TabIndex = 1;
            // 
            // LabelGameName
            // 
            this.LabelGameName.AutoSize = true;
            this.LabelGameName.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGameName.Location = new System.Drawing.Point(20, 10);
            this.LabelGameName.Name = "LabelGameName";
            this.LabelGameName.Size = new System.Drawing.Size(119, 40);
            this.LabelGameName.TabIndex = 0;
            this.LabelGameName.Text = "MiniCiv";
            // 
            // LauncherToolTip
            // 
            this.LauncherToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.LauncherToolTip.ForeColor = System.Drawing.Color.White;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.Sidebar);
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
            this.Sidebar.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PanelGameStats.ResumeLayout(false);
            this.PanelGameStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel outlineLeft;
        private System.Windows.Forms.Panel outlineRight;
        private System.Windows.Forms.Panel outlineTop;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button buttonAppMiniCiv;
        private System.Windows.Forms.Panel separator;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonSettings;
        private System.Windows.Forms.ToolTip LauncherToolTip;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.Label LabelGameName;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelGameDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabelDescriptionText;
        private System.Windows.Forms.Panel PanelGameStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelLastPlayed;
    }
}

