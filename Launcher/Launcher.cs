using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class LauncherForm : Form
    {
        public Point mouseLocation;
        GamesLibrary gamesLib = new GamesLibrary();
        int numGames = 0;

        public LauncherForm()
        {
            InitializeComponent();

            LocationsManager locations = new LocationsManager();
        }

        public void PopulateLibrary()
        {
            // Remove all game buttons that are currently visible in the library
            // Using a for loop in reverse as forward loops don't work well
            // when removing elements from it midrun
            for (var b = Sidebar.Controls.OfType<Button>().Count() - 1; b >= 0; b--)
            {
                if (Sidebar.Controls.OfType<Button>().ElementAt(b).Name.StartsWith("ButtonApp"))
                {
                    Sidebar.Controls.Remove(Sidebar.Controls.OfType<Button>().ElementAt(b));
                }
            }

            // Add buttons for each game in the library
            int i = 0;
            foreach (GamesLibrary.Game g in gamesLib.GetAllGames())
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(64, 64, 64);
                btn.FlatAppearance.BorderColor = Color.FromArgb(32, 32, 32);
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(88, 88, 88);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 76, 76);
                btn.FlatStyle = FlatStyle.Flat;
                btn.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                btn.ForeColor = Color.FromArgb(224, 224, 224);
                btn.Image = Image.FromFile(LocationsManager.appIcons + "\\" + g.iconFile);
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.Location = new Point(0, i * 40);
                btn.Margin = new Padding(0);
                btn.Name = "ButtonApp" + i.ToString();
                btn.Size = new Size(200, 40);
                btn.Text = "  " + g.name;
                btn.TextImageRelation = TextImageRelation.ImageBeforeText;
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(ButtonApp_Click);
                Sidebar.Controls.Add(btn);
                i++;
            }
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            gamesLib.LoadGames();
            numGames = Math.Max(gamesLib.GetAllGames().Count, 0);
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
            MainGamePanel oldPanel = new MainGamePanel();
            foreach (MainGamePanel p in MainPanelHolder.Controls.OfType<MainGamePanel>())
            {
                if (p.Name == "MainGamePanel")
                {
                    oldPanel = p;
                }
            }

            int gameID = int.Parse(button.Name.Substring(9));
            GamesLibrary.Game game = gamesLib.GetGame(gameID);

            if (game != null)
            {
                MainGamePanel mainPanel = new MainGamePanel();

                mainPanel.Dock = DockStyle.Fill;

                MainPanelHolder.Controls.Add(mainPanel);

                // Set title of the game
                Control[] LabelGameName = mainPanel.Controls.Find("LabelGameName", true);
                LabelGameName[0].Text = game.name;

                // Set title of the game
                Control[] LabelDescriptionText = mainPanel.Controls.Find("LabelDescriptionText", true);
                LabelDescriptionText[0].Text = game.description;

                // Remove old panel
                MainPanelHolder.Controls.Remove(oldPanel);
            }
        }
    }
}
