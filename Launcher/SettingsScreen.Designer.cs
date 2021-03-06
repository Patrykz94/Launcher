﻿namespace Launcher
{
    partial class SettingsScreen
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
            this.outlineLeft = new System.Windows.Forms.Panel();
            this.outlineRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outlineTop = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.buttonDownloadSettings = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Panel();
            this.settingsDownloading = new Launcher.SettingsDownloading();
            this.TopPanel.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // outlineLeft
            // 
            this.outlineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.outlineLeft.Location = new System.Drawing.Point(0, 2);
            this.outlineLeft.Name = "outlineLeft";
            this.outlineLeft.Size = new System.Drawing.Size(2, 446);
            this.outlineLeft.TabIndex = 14;
            // 
            // outlineRight
            // 
            this.outlineRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.outlineRight.Location = new System.Drawing.Point(598, 2);
            this.outlineRight.Name = "outlineRight";
            this.outlineRight.Size = new System.Drawing.Size(2, 446);
            this.outlineRight.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 448);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 2);
            this.panel2.TabIndex = 13;
            // 
            // outlineTop
            // 
            this.outlineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.outlineTop.Location = new System.Drawing.Point(0, 0);
            this.outlineTop.Name = "outlineTop";
            this.outlineTop.Size = new System.Drawing.Size(600, 2);
            this.outlineTop.TabIndex = 12;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopPanel.Controls.Add(this.labelSettings);
            this.TopPanel.Controls.Add(this.buttonExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(596, 28);
            this.TopPanel.TabIndex = 16;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelSettings.Location = new System.Drawing.Point(0, 2);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(79, 24);
            this.labelSettings.TabIndex = 5;
            this.labelSettings.Text = "Settings";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Silver;
            this.buttonExit.Location = new System.Drawing.Point(566, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "✕";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.AutoScroll = true;
            this.SettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SettingsPanel.Controls.Add(this.buttonDownloadSettings);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SettingsPanel.Location = new System.Drawing.Point(2, 30);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(175, 418);
            this.SettingsPanel.TabIndex = 18;
            // 
            // buttonDownloadSettings
            // 
            this.buttonDownloadSettings.BackColor = System.Drawing.Color.Silver;
            this.buttonDownloadSettings.FlatAppearance.BorderSize = 0;
            this.buttonDownloadSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.buttonDownloadSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonDownloadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadSettings.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonDownloadSettings.Location = new System.Drawing.Point(0, 0);
            this.buttonDownloadSettings.Name = "buttonDownloadSettings";
            this.buttonDownloadSettings.Size = new System.Drawing.Size(175, 28);
            this.buttonDownloadSettings.TabIndex = 0;
            this.buttonDownloadSettings.Text = "Downloading";
            this.buttonDownloadSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDownloadSettings.UseVisualStyleBackColor = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.separator.Dock = System.Windows.Forms.DockStyle.Left;
            this.separator.Location = new System.Drawing.Point(177, 30);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(2, 418);
            this.separator.TabIndex = 20;
            // 
            // settingsDownloading
            // 
            this.settingsDownloading.AutoScroll = true;
            this.settingsDownloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.settingsDownloading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsDownloading.Location = new System.Drawing.Point(179, 30);
            this.settingsDownloading.Name = "settingsDownloading";
            this.settingsDownloading.Size = new System.Drawing.Size(419, 418);
            this.settingsDownloading.TabIndex = 21;
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.settingsDownloading);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.outlineLeft);
            this.Controls.Add(this.outlineRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outlineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsScreen";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel outlineLeft;
        private System.Windows.Forms.Panel outlineRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel outlineTop;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button buttonDownloadSettings;
        private System.Windows.Forms.Panel separator;
        private SettingsDownloading settingsDownloading;
    }
}