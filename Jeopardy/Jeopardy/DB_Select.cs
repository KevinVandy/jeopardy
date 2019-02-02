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
    public class DB_Select
    {
        readonly static OleDbConnection conn = DB_Conn.GetGamesConnection();

        public static List<Game> SelectAllGames()
        {
            List<Game> games = new List<Game>();

            string query = "SELECT * FROM games";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.GameName = Convert.ToString(reader["GameName"]);
                    game.QuestionTimeLimit = TimeSpan.FromSeconds(Convert.ToInt32(reader["QuestionTimeLimit"]));
                    game.NumCategories = Convert.ToInt32(reader["NumCategories"]);
                    game.NumQuestionsPerCategory = Convert.ToInt32(reader["NumQuestionsPerCategory"]);
                    
                    games.Add(game);
                }
                reader.Close();

                foreach(Game game in games)
                {
                    game.Categories = SelectCategories_ByGameId(game.Id);
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

            return games;
        }

        public static Game SelectGame_ByGameId(int? gameId)
        {
            Game game = new Game();

            string query = "SELECT * FROM games WHERE Id = @gameId";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.GameName = Convert.ToString(reader["GameName"]);
                    game.QuestionTimeLimit = TimeSpan.FromSeconds(Convert.ToInt32(reader["QuestionTimeLimit"]));
                    game.NumCategories = Convert.ToInt32(reader["NumCategories"]);
                    game.NumQuestionsPerCategory = Convert.ToInt32(reader["NumQuestionsPerCategory"]);
                }
                else
                {
                    throw new CustomExceptions.IdNotFoundException("Game Id: " + gameId + " not found");
                }

                reader.Close();

                game.Categories = SelectCategories_ByGameId(game.Id);

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

            return game;
        }

        public static Category SelectCategory_ByCategoryId(int? categoryId)
        {
            Category category = new Category();

            string query = "SELECT * FROM categories WHERE Id = @categoryId";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@categoryId", categoryId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    category.Id = Convert.ToInt32(reader["Id"]);
                    category.GameId = Convert.ToInt32(reader["GameId"]);
                    category.Index = Convert.ToInt32(reader["Index"]);
                    category.Title = Convert.ToString(reader["Title"]);
                    category.Subtitle = Convert.ToString(reader["Subtitle"]);
                }
                else
                {
                    throw new CustomExceptions.IdNotFoundException("Category Id: " + categoryId + " not found");
                }
                reader.Close();

                category.Questions = SelectQuestions_ByCategoryId(category.Id);

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

            return category;
        }

        public static List<Category> SelectCategories_ByGameId(int? gameId)
        {
            List<Category> categories = new List<Category>();

            string query = "SELECT * FROM categories WHERE GameId = @gameId ORDER BY [Index]";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@gameId", gameId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();
                    category.Id = Convert.ToInt32(reader["Id"]);
                    category.GameId = Convert.ToInt32(reader["GameId"]);
                    category.Index = Convert.ToInt32(reader["Index"]);
                    category.Title = Convert.ToString(reader["Title"]);
                    category.Subtitle = Convert.ToString(reader["Subtitle"]);

                    categories.Add(category);
                }
                reader.Close();

                foreach(Category category in categories)
                {
                    category.Questions = SelectQuestions_ByCategoryId(category.Id);
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

            return categories;
        }

        public static Question SelectQuestion_ByQuestionId(int? questionId)
        {
            Question question = new Question();

            string query = "SELECT * FROM questions WHERE Id = @questionId";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    question.Id = Convert.ToInt32(reader["Id"]);
                    question.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    question.Type = Convert.ToString(reader["Type"]);
                    question.QuestionText = Convert.ToString(reader["QuestionText"]);
                    question.Answer = Convert.ToString(reader["Answer"]);
                    question.Weight = Convert.ToInt32(reader["Weight"]);
                }
                else
                {
                    throw new CustomExceptions.IdNotFoundException("Question Id: " + questionId + " not found");
                }
                reader.Close();

                if (question.Type == "mc")
                {
                    question.Choices = SelectChoices_ByQuestionId(question.Id);
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

            return question;
        }

        public static List<Question> SelectQuestions_ByCategoryId(int? categoryId)
        {
            List<Question> questions = new List<Question>();

            string query = "SELECT * FROM questions WHERE CategoryId = @categoryId ORDER BY Weight";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@categoryId", categoryId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Question question = new Question();
                    question.Id = Convert.ToInt32(reader["Id"]);
                    question.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                    question.Type = Convert.ToString(reader["Type"]);
                    question.QuestionText = Convert.ToString(reader["QuestionText"]);
                    question.Answer = Convert.ToString(reader["Answer"]);
                    question.Weight = Convert.ToInt32(reader["Weight"]);
                    
                    questions.Add(question);
                }
                reader.Close();

                foreach(Question question in questions)
                {
                    if (question.Type == "mc")
                    {
                        question.Choices = SelectChoices_ByQuestionId(question.Id);
                    }
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

            return questions;
        }

        public static Choice SelectChoice_ByChoiceId(int? choiceId)
        {
            Choice choice = new Choice();

            string query = "SELECT * FROM choices WHERE Id = @choiceId";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@choiceId", choiceId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                if (reader.Read())
                {
                    choice.Id = Convert.ToInt32(reader["Id"]);
                    choice.QuestionId = Convert.ToInt32(reader["QuestionId"]);
                    choice.Index = Convert.ToInt32(reader["Index"]);
                    choice.Text = Convert.ToString(reader["ChoiceText"]);
                }
                else
                {
                    throw new CustomExceptions.IdNotFoundException("Choice Id: " + choiceId + " not found");
                }
                reader.Close();
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

            return choice;
        }

        public static List<Choice> SelectChoices_ByQuestionId(int? questionId)
        {
            List<Choice> choices = new List<Choice>();

            string query = "SELECT * FROM choices WHERE QuestionId = @questionId ORDER BY [Index]";

            OleDbCommand selectCommand = new OleDbCommand(query, conn);
            selectCommand.Parameters.AddWithValue("@questionId", questionId);

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                OleDbDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Choice choice = new Choice();
                    choice.Id = Convert.ToInt32(reader["Id"]);
                    choice.QuestionId = Convert.ToInt32(reader["QuestionId"]);
                    choice.Index = Convert.ToInt32(reader["Index"]);
                    choice.Text = Convert.ToString(reader["ChoiceText"]);

                    choices.Add(choice);
                }
                reader.Close();
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

            return choices;
        }
    }
}
