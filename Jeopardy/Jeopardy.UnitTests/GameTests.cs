using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void SetGameName_SetLength25_ReturnLength25()
        {
            Game game = new Game();

            game.GameName = "Advanced Programming";

            Assert.AreEqual(game.GameName, "Advanced Programming");
        }

        [TestMethod]
        public void SetGameName_SetTooLong_ReturnBlank()
        {
            Game game = new Game();

            game.GameName = "Anaheim, Azusa, and Cucamonga Sewing Circle, Book Review, and Timing Association";

            Assert.AreEqual(game.GameName, "Untitled Game");
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set30Sec_Return30Sec()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0,0,30);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0,0,30));
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set01Min_Return01Min()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0, 1, 0);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0, 1, 0));
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set01Min30Sec_Return01Min30Sec()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0, 1, 30);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0, 1, 30));
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set02Min_Return02Min()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0, 2, 0);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0, 2, 0));
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set03Min_Return03Min()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0, 3, 0);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0, 3, 0));
        }

        [TestMethod]
        public void SetQuestionTimeLimit_Set05Min_Return01Min()
        {
            Game game = new Game();

            game.QuestionTimeLimit = new TimeSpan(0, 5, 0);

            Assert.AreEqual(game.QuestionTimeLimit, new TimeSpan(0, 1, 0));
        }

        [TestMethod]
        public void SetNumCategories_Set6_Return6()
        {
            Game game = new Game();

            game.NumCategories = 6;

            Assert.AreEqual(game.NumCategories, 6);
        }

        [TestMethod]
        public void SetNumCategories_Set2_Return5()
        {
            Game game = new Game();

            game.NumCategories = 2;

            Assert.AreEqual(game.NumCategories, 5);
        }

        [TestMethod]
        public void SetNumQuestionsPerCategory_Set5_Return5()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 5;

            Assert.AreEqual(game.NumQuestionsPerCategory, 5);
        }

        [TestMethod]
        public void SetNumQuestionsPerCategory_Set2_Return6()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 2;

            Assert.AreEqual(game.NumQuestionsPerCategory, 6);
        }
    }
}
