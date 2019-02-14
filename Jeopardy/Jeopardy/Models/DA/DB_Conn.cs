using JRO;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Jeopardy
{
    internal class DB_Conn
    {
        private static readonly string currentdirectory = Directory.GetCurrentDirectory();

        public static OleDbConnection GetGamesConnection()
        {
            try
            {
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../games.accdb";
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
            string oldmdbfile = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + currentdirectory + "\\games.accdb;";
            string newmdbfile = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + currentdirectory + "\\games-temp.accdb;";
            string oldmdbfilepath = currentdirectory + "\\games.accdb";
            string newmdbfilepath = currentdirectory + "\\games-temp.accdb";

            try
            {
                JetEngine engine = new JetEngine();
                engine.CompactDatabase(oldmdbfile, newmdbfile);
                File.Delete(oldmdbfilepath);
                File.Move(newmdbfilepath, oldmdbfilepath);

                Console.WriteLine("Database successfully Repaired and Compacted\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database failed to Repair and Compact\n" + ex.ToString());
            }
        }
    }
}
