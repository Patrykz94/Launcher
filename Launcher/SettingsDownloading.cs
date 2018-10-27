using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class SettingsDownloading : UserControl
    {
        public SettingsDownloading()
        {
            InitializeComponent();
        }

        private void ButtonLibraries_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "LibraryManagement")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (!isOpen)
            {
                LibraryManagement libs = new LibraryManagement();
                libs.Show();
            }
        }
    }
}
