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
    public class DB_Update
    {
        readonly static OleDbConnection conn = DB_Conn.GetGamesConnection();

        //TODO BY FORREST, more at bottom of this file too

        //public static bool UpdateGame(Game game)


        //public static bool UpdateCategory(Category category)


        //public static bool UpdateQuestion(Question question)


        //public static bool UpdateChoice(Choice choice)


        public static bool UpdateGameName(string newGameName, int? gameId)
        {
            string updateStatement =
                "UPDATE games " +
                "SET GameName = @newGameName " +
                "WHERE Id = @gameId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@newGameName", newGameName);
            updateCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if(numRows > 0)
                {
                    return true;
                }

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

            return false;
        }

        //Forrest, implement these

        //public static bool UpdateGameQuestionTimeLimit(TimeSpan newTimeLimit, int? gameId)


        //public static bool UpdateGameNumCategories(int newNumCategories, int? gameId)


        //public static bool UpdateGameNumQuestionsPerCategory(int newNumQuestionsPerCategory, int? gameId)


        //public static bool UpdateCategoryTitle(string newTitle, int? categoryId)


        //public static bool UpdateCategorySubtitle(string newSubtitle, int? categoryId)


        //public static bool UpdateQuestionType(string newQuestionType, int? questionId)


        //public static bool UpdateQuestionText(string newQuestionText, int? questionId)


        //public static bool UpdateQuestionAnswer(string newAnswer, int? questionId)


        //public static bool UpdateQuestionAnswer(int newWeight, int? questionId)


        //public static bool UpdateChoiceText(string newChoiceText, int? choiceId)


    }
}
