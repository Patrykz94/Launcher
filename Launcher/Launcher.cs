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

        public LauncherForm()
        {
            InitializeComponent();

            LocationsManager locations = new LocationsManager();
        }

        private void LauncherForm_Load(object sender, EventArgs e)
        {
            // Once loaded, check for updates
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStripItemSettings_Click(object sender, EventArgs e)
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
    }
}
