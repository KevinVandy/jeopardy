using JRO;
using System;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Jeopardy
{
    internal class DB_Conn
    {
        //private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../games.accdb";
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\games.accdb";

        private static string tempConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Jeopardy2019\\gamesTemp.accdb";

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

        public static bool CompactAndRepair()
        {
            try
            {
                JetEngine engine = new JetEngine();
                engine.CompactDatabase(connectionString, tempConnectionString);
                File.Delete(DBPath);
                File.Move(DBPath, DBPath);

                Console.WriteLine("Database successfully Repaired and Compacted\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Database failed to Repair and Compact\n" + ex.ToString());
            }
            return false;
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

        public static bool InstallAccessRuntime()
        {
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "AccessDatabaseEngine.exe";
                Process.Start(start);
            }
            catch(System.ComponentModel.Win32Exception ex)
            {
                if(MessageBox.Show("The Acess Database Engine Installer 2010 was not found. Would you like to download and install it from the internet? \n the 32 bit install is recommended.", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("https://www.microsoft.com/en-us/download/details.aspx?id=13255");
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.GetType().ToString() + "You canceled the installation of Access Runtime 2010", "Attention");
            }
            return true;
        }
    }
}
