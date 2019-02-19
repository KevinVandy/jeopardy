using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Jeopardy
{
    public class DB_Update
    {
        private static readonly OleDbConnection conn = DB_Conn.GetGamesConnection();

        public static bool UpdateGame(Game game)
        {
            string updateStatement =
                "UPDATE games " +
                "SET GameName = @newGameName, QuestionTimeLimit = @newTimeLimit, " +
                "NumCategories = @newNumCategories, NumQuestionsPerCategory = @newNumQuestionsPerCategory " +
                "Where Id = @gameId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@newGameName", game.GameName);
            updateCommand.Parameters.AddWithValue("@newTimeLimit", game.QuestionTimeLimit);
            updateCommand.Parameters.AddWithValue("@newNumCategories", game.NumCategories);
            updateCommand.Parameters.AddWithValue("@newNumQuestionsPerCategory", game.NumQuestionsPerCategory);
            updateCommand.Parameters.AddWithValue("@gameId", game.Id);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game information.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game information.", "Update Error");
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

        public static bool UpdateCategory(Category category)
        {
            string updateStatement =
                "UPDATE categories " +
                "SET [Index] = @newIndex, Title = @newTitle, Subtitle = @newSubtitle " +
                "Where Id = @categoryId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newIndex", category.Index);
            updateCommand.Parameters.AddWithValue("@newTitle", category.Title);
            updateCommand.Parameters.AddWithValue("@newSubtitle", category.Subtitle);
            updateCommand.Parameters.AddWithValue("@categoryId", category.Id);


            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update category information.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game information.", "Update Error");
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


        public static bool UpdateQuestion(Question question)
        {
            string updateStatement =
                "UPDATE questions " +
                "SET Type = @newType, QuestionText = @newQuestionText, Answer = @newAnswer, Weight = @newWeight " +
                "Where Id = @questionId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newType", question.Type);
            updateCommand.Parameters.AddWithValue("@newQuestionText", question.QuestionText);
            updateCommand.Parameters.AddWithValue("@newAnswer", question.Answer);
            updateCommand.Parameters.AddWithValue("@newWeight", question.Weight);
            updateCommand.Parameters.AddWithValue("@questionId", question.Id);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question information.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question information.", "Update Error");
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


        public static bool UpdateChoice(Choice choice)
        {
            string updateStatement =
                "UPDATE choices " +
                "SET ChoiceText = @newChoiceText " +
                "Where Id = @choiceId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newChoiceText", choice.Text);
            updateCommand.Parameters.AddWithValue("@choiceId", choice.Id);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update choice.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update choice.", "Update Error");
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

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game name.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game name.", "Update Error");
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

        public static bool UpdateGameQuestionTimeLimit(TimeSpan newTimeLimit, int? gameId)
        {
            string updateStatement =
                "UPDATE games " +
                "SET QuestionTimeLimit = @newTimeLimit " +
                "WHERE Id = @gameId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newTimeLimit", newTimeLimit.TotalSeconds);
            updateCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game question time limit.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update game question time limit.", "Update Error");
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


        public static bool UpdateGameNumCategories(int newNumCategories, int? gameId)
        {
            string updateStatement =
                "UPDATE games " +
                "SET NumCategories = @newNumCategories " +
                "WHERE Id = @gameId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newNumCategories", newNumCategories);
            updateCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update number of categories.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update number of categories.", "Update Error");
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


        public static bool UpdateGameNumQuestionsPerCategory(int newNumQuestionsPerCategory, int? gameId)
        {
            string updateStatement =
                "UPDATE games " +
                "SET NumQuestionsPerCategory = @newNumQuestionsPerCategory " +
                "WHERE Id = @gameId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newNumQuestionsPerCategory", newNumQuestionsPerCategory);
            updateCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update number of questions per category.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update number of questions per category.", "Update Error");
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


        public static bool UpdateCategoryTitle(string newTitle, int? categoryId)
        {
            string updateStatement =
                "UPDATE categories " +
                "SET Title = @newTitle " +
                "Where Id = @categoryId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newTitle", newTitle);
            updateCommand.Parameters.AddWithValue("@categoryId", categoryId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update category title.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update category title.", "Update Error");
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


        public static bool UpdateCategorySubtitle(string newSubtitle, int? categoryId)
        {
            string updateStatement =
                "UPDATE categories " +
                "SET Subtitle = @newSubtitle " +
                "Where Id = @categoryId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);
            updateCommand.Parameters.AddWithValue("@newSubtitle", newSubtitle);
            updateCommand.Parameters.AddWithValue("@categoryId", categoryId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
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


        public static bool UpdateQuestionType(string newQuestionType, int? questionId)
        {
            string updateStatement =
                "UPDATE questions " +
                "SET Type = @newType " +
                "Where Id = @questionId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newType", newQuestionType);
            updateCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question type.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question type.", "Update Error");
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


        public static bool UpdateQuestionText(string newQuestionText, int? questionId)
        {
            string updateStatement =
                "UPDATE questions " +
                "SET QuestionText = @newQuestionText " +
                "Where Id = @questionId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newQuestionText", newQuestionText);
            updateCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question text.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question text.", "Update Error");
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


        public static bool UpdateQuestionAnswer(string newAnswer, int? questionId)
        {
            string updateStatement =
                "UPDATE questions " +
                "SET Answer = @newAnswer " +
                "Where Id = @questionId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newAnswer", newAnswer);
            updateCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question answer.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question answer.", "Update Error");
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


        public static bool UpdateQuestionAnswer(int newWeight, int? questionId)
        {
            string updateStatement =
                "UPDATE questions " +
                "SET Weight = @newWeight " +
                "Where Id = @questionId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newWeight", newWeight);
            updateCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question weight.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update question weight.", "Update Error");
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


        public static bool UpdateChoiceText(string newChoiceText, int? choiceId)
        {
            string updateStatement =
                "UPDATE choices " +
                "SET ChoiceText = @newChoiceText " +
                "Where Id = @choiceId";

            OleDbCommand updateCommand = new OleDbCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@newChoiceText", newChoiceText);
            updateCommand.Parameters.AddWithValue("@choiceId", choiceId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                int numRows = updateCommand.ExecuteNonQuery();

                if (numRows > 0)
                {
                    return true;
                }

            }
            catch (OleDbException ex)
            {
                Console.WriteLine("Database exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update choice text.", "Update Error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception\n\n" + ex.ToString());
                MessageBox.Show("Failed to update choice text.", "Update Error");
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


    }
}
