using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Jeopardy
{
    public class DB_Delete
    {
        private static readonly OleDbConnection conn = DB_Conn.GetGamesConnection();

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
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                numRows = deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete game.", "Deletion Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete game.", "Deletion Error");
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

        public static int DeleteCategory(int? categoryId)
        {
            int numRows = 0;

            string deleteStatement =
                "DELETE FROM categories " +
                "WHERE Id = @categoryId";

            OleDbCommand deleteCommand = new OleDbCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@categoryId", categoryId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                numRows = deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete category.", "Deletion Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete category.", "Deletion Error");
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

        public static int DeleteQuestion(int? questionId)
        {
            int numRows = 0;

            string deleteStatement =
                "DELETE FROM questions " +
                "WHERE Id = @questionId";

            OleDbCommand deleteCommand = new OleDbCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                numRows = deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete questions.", "Deletion Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete questions.", "Deletion Error");
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

        public static int DeleteChoice(int? choiceId)
        {
            int numRows = 0;

            string deleteStatement =
                "DELETE FROM choices " +
                "WHERE Id = @choiceId";

            OleDbCommand deleteCommand = new OleDbCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@choiceId", choiceId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                numRows = deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete choices.", "Deletion Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to delete choices.", "Deletion Error");
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
