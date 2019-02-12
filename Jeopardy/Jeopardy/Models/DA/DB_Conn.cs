using JRO;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Jeopardy
{
    internal class DB_Conn
    {
        public static OleDbConnection GetGamesConnection()
        {
            try
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=games.accdb"; //next to exe
                OleDbConnection conn = new OleDbConnection(connectionString);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not find the games.accdb database file.\n\n" + ex.ToString());
                return null;
            }
        }

        public static void CompactAndRepair()
        {
            string currentdirectory = Directory.GetCurrentDirectory();
            string oldmdbfile = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=games.accdb";
            string newmdbfile = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=gamesTemp.accdb";
            string oldmdbfilepath = currentdirectory + "\\games.accdb";
            string newmdbfilepath = currentdirectory + "\\gamesTemp.accdb";
            
            try
            {
                JRO.JetEngine engine = new JetEngine();
                engine.CompactDatabase(oldmdbfile, newmdbfile);
                File.Delete(oldmdbfilepath);
                File.Move(newmdbfilepath, oldmdbfilepath);

                Console.WriteLine("\nDatabase successfully Repaired and Compacted\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nDatabase failed to Repair and Compact\n" + ex.ToString());
            }
        }
    }
}
