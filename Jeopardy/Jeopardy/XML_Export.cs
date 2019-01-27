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
    class XML_Export
    {


        public XML_Export()
        {
            
        }

        public static void exportXML(Game selectedGame)
        {
            string gameName = selectedGame.GameName;
            String downloadPath = KnownFolders.Downloads.Path + $"\\{gameName}.xml";

            XmlSerializer xs = new XmlSerializer(typeof(Game));
            TextWriter tw = new StreamWriter(downloadPath);
            xs.Serialize(tw, selectedGame);
        }

        

       

    }
}
