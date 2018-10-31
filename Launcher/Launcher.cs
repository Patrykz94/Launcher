using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        public Point mouseLocation;

        public LauncherForm()
        {
            InitializeComponent();

            LocationsManager locations = new LocationsManager();
        }

        public void PopulateLibrary()
        {
            string gameLocations = LocationsManager.dataDir + "\\libFiles";
            string gameLocationsFile = gameLocations + "\\main.xml";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(gameLocationsFile);
                XmlNode root = doc.FirstChild;
                XmlNodeList nodeList = root.SelectNodes("descendant::download");
                List<string> downloads = new List<string>();

                foreach (XmlNode n in nodeList)
                {
                    if (n.HasChildNodes)
                    {
                        foreach (XmlNode c in n.ChildNodes)
                        {
                            if (c.Name == "infoFile")
                            {
                                downloads.Add(c.InnerText);
                            }
                        }
                    }
                }

                int i = 0;
                foreach (Button b in Sidebar.Controls.OfType<Button>())
                {
                    if (b.Name.StartsWith("ButtonApp"))
                    {
                        Sidebar.Controls.Remove(b);
                    }
                }

                foreach (string d in downloads)
                {
                    XmlDocument game = new XmlDocument();
                    try
                    {
                        game.Load(gameLocations + d);
                        string title = game.DocumentElement.SelectSingleNode("title").InnerText;
                        string iconPath = gameLocations + game.DocumentElement.SelectSingleNode("icon").InnerText;

                        Button btn = new Button();
                        btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
                        btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
                        btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
                        btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                        btn.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        btn.Image = Image.FromFile(iconPath);
                        btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                        btn.Location = new System.Drawing.Point(0, i * 40);
                        btn.Margin = new System.Windows.Forms.Padding(0);
                        btn.Name = "ButtonApp" + i.ToString();
                        btn.Size = new System.Drawing.Size(200, 40);
                        btn.Text = "  " + title;
                        btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
                        btn.UseVisualStyleBackColor = false;
                        btn.Click += new EventHandler(ButtonApp_Click);
                        Sidebar.Controls.Add(btn);
                        i++;
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            PopulateLibrary();
            // Once loaded, check for updates
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "SettingsScreen")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isOpen)
            {
                SettingsScreen settings = new SettingsScreen();
                settings.Show();
            }
        }

        private void ButtonApp_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // Find the game description form and replace with the one corresponding to the button clicked
            foreach (MainGamePanel p in Form.ActiveForm.Controls.OfType<MainGamePanel>())
            {
                if (p.Name == "MainGamePanel")
                {
                    Form.ActiveForm.Controls.Remove(p);
                }
            }

            string gameInfoFile = LocationsManager.dataDir + "\\libFiles\\downloads\\" + button.Text.Substring(2) + "\\info.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(gameInfoFile);

            MainGamePanel mainPanel = new MainGamePanel();

            mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;

            MainPanelHolder.Controls.Add(mainPanel);

            // Set title of the game
            Control[] LabelGameName = mainPanel.Controls.Find("LabelGameName", true);
            LabelGameName[0].Text = doc.DocumentElement.SelectSingleNode("title").InnerText;

            // Set title of the game
            Control[] LabelDescriptionText = mainPanel.Controls.Find("LabelDescriptionText", true);
            LabelDescriptionText[0].Text = doc.DocumentElement.SelectSingleNode("description").InnerText;
        }
    }
}
