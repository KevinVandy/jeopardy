using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Jeopardy
{
    class XML_IO
    {


        public static void exportXML(Game selectedGame)
        {
            string gameName = selectedGame.GameName;
           // String downloadPath = KnownFolders.Downloads.Path + $"\\{gameName}.xml";

            String downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + $"\\{gameName}.xml";

            XmlSerializer xs = new XmlSerializer(typeof(Game));
            TextWriter tw = new StreamWriter(downloadPath);
            xs.Serialize(tw, selectedGame);
        }

        public static void importXML(String path, string fileName)
        {
            //TODO Validate if file is xml


            XmlSerializer xs = new XmlSerializer(typeof(Game));
            using (var sr = new StreamReader(path))
            {
                Game importedGame = (Game)xs.Deserialize(sr);

                importedGame.Id = null;
                importedGame.GameName = fileName;

               int? id = DB_Insert.InsertGame(importedGame);

            }
        }

       

    }
}
