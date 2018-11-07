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
            if (!Directory.Exists(dataDirectory)) Directory.CreateDirectory(dataDirectory);
            if (!Directory.Exists(defaultAppDirecory)) Directory.CreateDirectory(defaultAppDirecory);
            if (!Directory.Exists(appResources)) Directory.CreateDirectory(appResources);
            if (!Directory.Exists(appIcons)) Directory.CreateDirectory(appIcons);
        }

        public static string mainDirectory = Environment.CurrentDirectory;
        public static string dataDirectory = mainDirectory + "\\Data";
        public static string defaultAppDirecory = mainDirectory + "\\LauncherLibrary";
        public static string appResources = dataDirectory + "\\GameRes";
        public static string appIcons = appResources + "\\Icons";
    }
}
