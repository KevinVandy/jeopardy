using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public class DB_Delete
    {
        readonly static OleDbConnection conn = DB_Conn.GetGamesConnection();

        public static int DeleteGame(int? gameId)
        {
            int numRows = 0;

            string deleteStatement = 
                "DELETE FROM games " +
                "WHERE Id = @gameId";
            
            OleDbCommand deleteCommand = new OleDbCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                conn.Open();
                numRows = deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Database exception\n\n" + ex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("General exception\n\n" + ex.ToString());
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return numRows;
        }
    }
}
