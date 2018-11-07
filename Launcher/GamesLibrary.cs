using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Launcher
{
    class GamesLibrary
    {
        [Serializable()]
        public class Game : ISerializable
        {
            // Constructor
            public Game(int ID, string name, string description, string iconFile)
            {
                this.ID = ID;
                this.name = name;
                this.description = description;
                this.iconFile = iconFile;
            }

            // Deserialize data
            public Game(SerializationInfo info, StreamingContext context)
            {
                ID = (int)info.GetValue("ID", typeof(int));
                name = (string)info.GetValue("name", typeof(string));
                description = (string)info.GetValue("description", typeof(string));
                iconFile = (string)info.GetValue("iconFile", typeof(string));
            }

            // Variables
            public int ID;
            public string name;
            public string description;
            public string iconFile;

            // Serialize data
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("ID", ID);
                info.AddValue("name", name);
                info.AddValue("description", description);
                info.AddValue("iconFile", iconFile);
            }
        }

        // Add a game to the list of games
        public void Add(int ID, string name, string description, string iconFile)
        {
            gamesList.Add(new Game(ID, name, description, iconFile));
        }

        // Remove a game from the list of games by its ID
        public bool Remove(int ID)
        {
            foreach (Game g in gamesList)
            {
                if (g.ID == ID)
                {
                    gamesList.Remove(g);
                    return true;
                }
            }
            return false;
        }

        // Get a specific game from the list by it's ID number
        public Game GetGame(int ID)
        {
            foreach (Game g in gamesList)
            {
                if (g.ID == ID)
                {
                    return g;
                }
            }
            return null;
        }

        // Returns a list of games currently available
        public List<Game> GetAllGames()
        {
            return gamesList;
        }

        // Load games from the file
        public void LoadGames()
        {
            if (File.Exists(LocationsManager.dataDirectory + "\\Games.dat"))
            {
                try
                {
                    using (Stream stream = File.Open(LocationsManager.dataDirectory + "\\Games.dat", FileMode.Open))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        gamesList = (List<Game>)bin.Deserialize(stream);
                    }
                }
                catch (IOException)
                {}
            }
        }

        // Save games to the file
        public void SaveGames()
        {
            try
            {
                if (gamesList.Count > 0)
                {
                    using (Stream stream = File.Open(LocationsManager.dataDirectory + "\\Games.dat", FileMode.Create))
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        bin.Serialize(stream, gamesList);
                    }
                }
                else
                {
                    if (File.Exists(LocationsManager.dataDirectory + "\\Games.dat"))
                    {
                        File.Delete(LocationsManager.dataDirectory + "\\Games.dat");
                    }
                }
            }
            catch (IOException)
            {}
        }

        // List of games loaded
        private List<Game> gamesList = new List<Game>();
    }
}
