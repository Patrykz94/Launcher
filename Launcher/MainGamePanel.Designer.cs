namespace Launcher
{
    partial class MainGamePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGamePanel));
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
            this.MainPanel.SuspendLayout();
            this.PanelGameStats.SuspendLayout();
            this.SuspendLayout();
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
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(730, 592);
            this.MainPanel.TabIndex = 17;
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
            // MainGamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Name = "MainGamePanel";
            this.Size = new System.Drawing.Size(730, 592);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PanelGameStats.ResumeLayout(false);
            this.PanelGameStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label LabelDescriptionText;
        private System.Windows.Forms.Panel PanelGameStats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelLastPlayed;
        private System.Windows.Forms.Label LabelGameDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButtonInstall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelGameName;
    }
}
