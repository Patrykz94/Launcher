namespace Launcher
{
    partial class LibraryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.outlineLeft = new System.Windows.Forms.Panel();
            this.outlineRight = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outlineTop = new System.Windows.Forms.Panel();
            this.labelLibraries = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.ButtonLibrariesClose = new System.Windows.Forms.Button();
            this.ButtonAddLibrary = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Results = new System.Windows.Forms.Panel();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.libLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libDefault = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.libFreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libTotalSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // outlineLeft
            // 
            this.outlineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.outlineLeft.Location = new System.Drawing.Point(0, 2);
            this.outlineLeft.Name = "outlineLeft";
            this.outlineLeft.Size = new System.Drawing.Size(2, 246);
            this.outlineLeft.TabIndex = 18;
            // 
            // outlineRight
            // 
            this.outlineRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.outlineRight.Location = new System.Drawing.Point(798, 2);
            this.outlineRight.Name = "outlineRight";
            this.outlineRight.Size = new System.Drawing.Size(2, 246);
            this.outlineRight.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 2);
            this.panel2.TabIndex = 17;
            // 
            // outlineTop
            // 
            this.outlineTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outlineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.outlineTop.Location = new System.Drawing.Point(0, 0);
            this.outlineTop.Name = "outlineTop";
            this.outlineTop.Size = new System.Drawing.Size(800, 2);
            this.outlineTop.TabIndex = 16;
            // 
            // labelLibraries
            // 
            this.labelLibraries.AutoSize = true;
            this.labelLibraries.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibraries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.labelLibraries.Location = new System.Drawing.Point(0, 2);
            this.labelLibraries.Name = "labelLibraries";
            this.labelLibraries.Size = new System.Drawing.Size(155, 24);
            this.labelLibraries.TabIndex = 5;
            this.labelLibraries.Text = "Library Locations";
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
            this.buttonExit.Location = new System.Drawing.Point(766, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "✕";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.TopPanel.Controls.Add(this.labelLibraries);
            this.TopPanel.Controls.Add(this.buttonExit);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(2, 2);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(796, 28);
            this.TopPanel.TabIndex = 20;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // PanelBottom
            // 
            this.PanelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.PanelBottom.Controls.Add(this.ButtonLibrariesClose);
            this.PanelBottom.Controls.Add(this.ButtonAddLibrary);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBottom.Location = new System.Drawing.Point(2, 216);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(796, 32);
            this.PanelBottom.TabIndex = 22;
            // 
            // ButtonLibrariesClose
            // 
            this.ButtonLibrariesClose.AutoSize = true;
            this.ButtonLibrariesClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ButtonLibrariesClose.FlatAppearance.BorderSize = 0;
            this.ButtonLibrariesClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonLibrariesClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonLibrariesClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLibrariesClose.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLibrariesClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonLibrariesClose.Location = new System.Drawing.Point(690, 2);
            this.ButtonLibrariesClose.Name = "ButtonLibrariesClose";
            this.ButtonLibrariesClose.Size = new System.Drawing.Size(104, 28);
            this.ButtonLibrariesClose.TabIndex = 1;
            this.ButtonLibrariesClose.Text = "Close";
            this.ButtonLibrariesClose.UseVisualStyleBackColor = false;
            this.ButtonLibrariesClose.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonAddLibrary
            // 
            this.ButtonAddLibrary.AutoSize = true;
            this.ButtonAddLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ButtonAddLibrary.FlatAppearance.BorderSize = 0;
            this.ButtonAddLibrary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonAddLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ButtonAddLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddLibrary.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddLibrary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonAddLibrary.Location = new System.Drawing.Point(2, 2);
            this.ButtonAddLibrary.Margin = new System.Windows.Forms.Padding(1);
            this.ButtonAddLibrary.Name = "ButtonAddLibrary";
            this.ButtonAddLibrary.Size = new System.Drawing.Size(125, 28);
            this.ButtonAddLibrary.TabIndex = 0;
            this.ButtonAddLibrary.Text = "Add Library Folder";
            this.ButtonAddLibrary.UseVisualStyleBackColor = false;
            this.ButtonAddLibrary.Click += new System.EventHandler(this.ButtonAddLibrary_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // Results
            // 
            this.Results.Controls.Add(this.dataGridViewResults);
            this.Results.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Results.Location = new System.Drawing.Point(2, 30);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(796, 186);
            this.Results.TabIndex = 25;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewResults.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libLocation,
            this.libDefault,
            this.libFreeSpace,
            this.libTotalSpace});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewResults.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewResults.Size = new System.Drawing.Size(796, 186);
            this.dataGridViewResults.TabIndex = 0;
            // 
            // libLocation
            // 
            this.libLocation.FillWeight = 150F;
            this.libLocation.HeaderText = "Location";
            this.libLocation.Name = "libLocation";
            this.libLocation.ReadOnly = true;
            this.libLocation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // libDefault
            // 
            this.libDefault.FillWeight = 40F;
            this.libDefault.HeaderText = "Default";
            this.libDefault.Name = "libDefault";
            this.libDefault.ReadOnly = true;
            // 
            // libFreeSpace
            // 
            this.libFreeSpace.FillWeight = 40F;
            this.libFreeSpace.HeaderText = "Free Space";
            this.libFreeSpace.Name = "libFreeSpace";
            this.libFreeSpace.ReadOnly = true;
            this.libFreeSpace.ToolTipText = "Free space available to that library in gigabytes";
            // 
            // libTotalSpace
            // 
            this.libTotalSpace.FillWeight = 40F;
            this.libTotalSpace.HeaderText = "Total Space";
            this.libTotalSpace.Name = "libTotalSpace";
            this.libTotalSpace.ReadOnly = true;
            this.libTotalSpace.ToolTipText = "Total size of the drive in gigabytes";
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.outlineLeft);
            this.Controls.Add(this.outlineRight);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outlineTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagement";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.Results.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel outlineLeft;
        private System.Windows.Forms.Panel outlineRight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel outlineTop;
        private System.Windows.Forms.Label labelLibraries;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.Button ButtonLibrariesClose;
        private System.Windows.Forms.Button ButtonAddLibrary;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Panel Results;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn libLocation;
        private System.Windows.Forms.DataGridViewCheckBoxColumn libDefault;
        private System.Windows.Forms.DataGridViewTextBoxColumn libFreeSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn libTotalSpace;
    }
}