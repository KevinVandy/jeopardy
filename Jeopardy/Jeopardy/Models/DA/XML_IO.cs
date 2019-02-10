//to use know KnownFolders .NET library for retrieving and changing all special Windows folder paths
//Install-Package Syroot.Windows.IO.KnownFolders -Version 1.2.1//
//using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;



namespace Jeopardy
{
    class XML_IO
    {
        public static void exportXML(Game selectedGame)
        {
            string gameName = selectedGame.GameName;
            // can be used to get path for export was not giving unauthorized changes error
            // String downloadPath = KnownFolders.Downloads.Path + $"\\{gameName}.xml";


            //export works with Controlled folder access disabled in Windows Defender Security Center 
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    String downloadPath = fbd.SelectedPath + $"\\{gameName}.xml";

                    XmlSerializer xs = new XmlSerializer(typeof(Game));
                    TextWriter tw = new StreamWriter(downloadPath);
                    xs.Serialize(tw, selectedGame);

                    MessageBox.Show($"File was saved at {fbd.SelectedPath} ", "Successful Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        public static void importXML(String path, string fileName)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Game));
                using (var sr = new StreamReader(path))
                {
                    Game importedGame = (Game)xs.Deserialize(sr);

                    importedGame.Id = null;
                    importedGame.GameName = fileName;

                    int? id = DB_Insert.InsertGame(importedGame);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("This file is not in the correct format for this game. The game cannot be imported", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Console.WriteLine(ex.ToString());
            }
            
        }

       

    }
}
