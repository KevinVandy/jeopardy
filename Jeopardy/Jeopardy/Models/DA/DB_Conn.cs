using JRO;
using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace Jeopardy
{
    internal class DB_Conn
    {
        //private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../games.accdb";
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\games.accdb";

        private static string tempConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\backups\\games.accdb";

        private static readonly string DBPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\games.accdb";
        private static readonly string BackupDBPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\backups\\games.accdb";
        private static readonly string currentdirectory = Directory.GetCurrentDirectory();
        

        public static OleDbConnection GetGamesConnection()
        {
            try
            {
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
            string oldmdbfile = connectionString;
            string newmdbfile = tempConnectionString;
            string oldmdbfilepath = DBPath;
            string newmdbfilepath = BackupDBPath;

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

        public static bool RestoreDBFromBackup()
        {
            try
            {
                File.Delete(DBPath);
                File.Copy(BackupDBPath, DBPath);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Please reinstall to restore functionality", "Failed to Restore");
            }
            return false;
        }
    }
}
