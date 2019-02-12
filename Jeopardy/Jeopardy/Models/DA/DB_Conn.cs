using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Jeopardy
{
    class DB_Conn
    {
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

        public static void CompactAndRepair(string accessFile, Microsoft.Office.Interop.Access.Application app)
        {
            string tempFile = Path.Combine(Path.GetDirectoryName(accessFile),
                              Path.GetRandomFileName() + Path.GetExtension(accessFile));

            app.CompactRepair(accessFile, tempFile, false);
            app.Visible = false;

            FileInfo temp = new FileInfo(tempFile);
            temp.CopyTo(accessFile, true);
            temp.Delete();
        }
    }
}
