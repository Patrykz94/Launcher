using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Launcher
{
    class LocationsManager
    {
        public LocationsManager()
        {
            // Check if directories exist and create missing ones
            if (!Directory.Exists(dataDir)) Directory.CreateDirectory(dataDir);
            if (!Directory.Exists(defAppDir)) Directory.CreateDirectory(defAppDir);
        }

        public static string mainDir = Environment.CurrentDirectory;
        public static string dataDir = mainDir + "\\Data";
        public static string defAppDir = mainDir + "\\LauncherLibrary";
    }
}
