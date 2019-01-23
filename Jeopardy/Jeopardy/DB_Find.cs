using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeopardy
{
    public class DB_Find
    {
        readonly static OleDbConnection conn = DB_Conn.GetGamesConnection();
    }
}
