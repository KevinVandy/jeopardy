using System.Data.OleDb;

namespace Jeopardy
{
    public class DB_Find
    {
        private static readonly OleDbConnection conn = DB_Conn.GetConnection();

        public static bool FindGameName(string gameName)
        {
            return false;
        }
    }
}
