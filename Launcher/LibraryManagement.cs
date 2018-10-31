using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Launcher
{
    public partial class LibraryManagement : Form
    {
        public Point mouseLocation;
        private string libraryFile = LocationsManager.dataDir + "\\libraries.xml";

        public LibraryManagement()
        {
            InitializeComponent();

            if (!File.Exists(libraryFile))
            {
                XmlDocument doc = new XmlDocument { PreserveWhitespace = true };
                doc.LoadXml("<libraries>\n" +
                "<library>" + LocationsManager.defAppDir + "</library>\n" +
                "</libraries>");
                doc.Save(libraryFile);
            }

            UpdateGridView();
        }

        private void UpdateGridView()
        {
            if (dataGridViewResults.Rows.Count > 0)
            {
                while (dataGridViewResults.Rows.Count > 0)
                {
                    dataGridViewResults.Rows.RemoveAt(0);
                }
            }
            // For each entry in the xml file, add new record into the grid view
            XmlDocument doc = new XmlDocument();
            doc.Load(libraryFile);
            XmlNode root = doc.FirstChild;
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    int n = dataGridViewResults.Rows.Add();
                    dataGridViewResults.Rows[n].Cells["libLocation"].Value = root.ChildNodes[i].InnerText;
                    if (i == 0)
                    {
                        dataGridViewResults.Rows[n].Cells["libDefault"].Value = true;
                    }
                    else
                    {
                        dataGridViewResults.Rows[n].Cells["libDefault"].Value = false;
                    }
                    dataGridViewResults.Rows[n].Cells["libFreeSpace"].Value = Math.Round((float)GetFreeSpaceOnDrive(root.ChildNodes[i].InnerText)/1073741824.0f,2).ToString() + " GB";
                    dataGridViewResults.Rows[n].Cells["libTotalSpace"].Value = Math.Round((float)GetTotalSpaceOnDrive(root.ChildNodes[i].InnerText)/1073741824.0f,2).ToString() + " GB";
                }
            }
        }

        private long GetFreeSpaceOnDrive(string path)
        {
            string rootDir = Directory.GetDirectoryRoot(path);

            DriveInfo driveInfo = new DriveInfo(rootDir);

            long availableFreeSpace = driveInfo.AvailableFreeSpace;
            return availableFreeSpace;
        }

        private long GetTotalSpaceOnDrive(string path)
        {
            string rootDir = Directory.GetDirectoryRoot(path);

            DriveInfo driveInfo = new DriveInfo(rootDir);

            long totalSpace = driveInfo.TotalSize;
            return totalSpace;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void ButtonAddLibrary_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string directoryPath = folderBrowserDialog.SelectedPath + "\\LauncherLibrary";
                // instantiate XmlDocument and load XML from file
                XmlDocument doc = new XmlDocument();
                doc.Load(libraryFile);
                XmlNode root = doc.FirstChild;

                // add a new library to the xml file
                XmlElement newLib = doc.CreateElement("library");
                newLib.InnerText = directoryPath;

                root.AppendChild(newLib);
                doc.Save(libraryFile);

                UpdateGridView();
            }
        }
    }
}
