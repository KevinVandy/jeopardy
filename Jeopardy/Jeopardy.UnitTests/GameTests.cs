using System;
using System.Collections.Generic;
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
        public void SetGameName_SetNull_ReturnBlank()
        {
            Game game = new Game();

            game.GameName = "";

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
        public void SetNumCategories_Set3_Return3()
        {
            Game game = new Game();

            game.NumCategories = 3;

            Assert.AreEqual(game.NumCategories, 3);
        }

        [TestMethod]
        public void SetNumCategories_Set8_Return8()
        {
            Game game = new Game();

            game.NumCategories = 8;

            Assert.AreEqual(game.NumCategories, 8);
        }

        [TestMethod]
        public void SetNumCategories_Set2_Return5()
        {
            Game game = new Game();

            game.NumCategories = 2;

            Assert.AreEqual(game.NumCategories, 5);
        }

        [TestMethod]
        public void SetNumCategories_Set9_Return5()
        {
            Game game = new Game();

            game.NumCategories = 9;

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
        public void SetNumQuestionsPerCategory_Set3_Return3()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 3;

            Assert.AreEqual(game.NumQuestionsPerCategory, 3);
        }

        [TestMethod]
        public void SetNumQuestionsPerCategory_Set8_Return8()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 8;

            Assert.AreEqual(game.NumQuestionsPerCategory, 8);
        }

        [TestMethod]
        public void SetNumQuestionsPerCategory_Set2_Return6()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 2;

            Assert.AreEqual(game.NumQuestionsPerCategory, 6);
        }

        [TestMethod]
        public void SetNumQuestionsPerCategory_Set9_Return6()
        {
            Game game = new Game();

            game.NumQuestionsPerCategory = 9;

            Assert.AreEqual(game.NumQuestionsPerCategory, 6);
        }

        [TestMethod]
        public void CheckGameOver_IsTrue()
        {
            Game game = new Game();

            List<Question> theList = new List<Question>();

            Question q1 = new Question();
            q1.State = "Answered";
            theList.Add(q1);

            Question q2 = new Question();
            q2.State = "Answered";
            theList.Add(q2);

            List<Category> theCatList = new List<Category>();

            Category c1 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c1);

            Category c2 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c2);

            game.Categories = theCatList;

            bool isDone = game.CheckGameOver();

            Assert.AreEqual(isDone, true);
        }

        [TestMethod]
        public void CheckGameOver_IsFalse()
        {
            Game game = new Game();

            //Dummy Data
            List<Question> theList = new List<Question>();

            Question q1 = new Question();
            q1.State = "Something else";
            theList.Add(q1);

            Question q2 = new Question();
            q2.State = "Something else";
            theList.Add(q2);

            List<Category> theCatList = new List<Category>();

            Category c1 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c1);

            Category c2 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c2);

            game.Categories = theCatList;

            bool isDone = game.CheckGameOver();

            Assert.AreEqual(isDone, false);
        }

        [TestMethod]
        public void ResetStatesToNull_IsTrue()
        {
            Game game = new Game();

            List<Question> theList = new List<Question>();

            //Dummy Data
            Question q1 = new Question();
            q1.State = "Something else";
            theList.Add(q1);

            Question q2 = new Question();
            q2.State = "Something else";
            theList.Add(q2);

            Question q3 = new Question();
            q3.State = "Something else";
            theList.Add(q3);

            List<Category> theCatList = new List<Category>();

            Category c1 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c1);

            Category c2 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c2);

            game.Categories = theCatList;

            bool isReset = true;

            game.ResetStatesToNull();

            foreach (Category c in game.Categories)
            {
                foreach (Question q in c.Questions)
                {
                    if(q.State == "")
                    {
                        continue;
                    }
                    else
                    {
                        isReset = false;
                    }
                }
            }

            Assert.AreEqual(isReset, true);
        }

        [TestMethod]
        public void ResetStatesToNull_IsFalse()
        {
            Game game = new Game();

            List<Question> theList = new List<Question>();

            //Dummy Data
            Question q1 = new Question();
            q1.State = "Something else";
            theList.Add(q1);

            Question q2 = new Question();
            q2.State = "Something else";
            theList.Add(q2);

            Question q3 = new Question();
            q3.State = "Something else";
            theList.Add(q3);

            List<Category> theCatList = new List<Category>();

            Category c1 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c1);

            Category c2 = new Category(1, 1, 1, "asdf", "asdfa", theList);
            theCatList.Add(c2);

            game.Categories = theCatList;

            bool isReset = true;

            game.ResetStatesToNull();

            foreach (Category c in game.Categories)
            {
                foreach (Question q in c.Questions)
                {
                    if (q.State != "")
                    {
                        continue;
                    }
                    else
                    {
                        isReset = false;
                    }
                }
            }

            Assert.AreEqual(isReset, false);
        }
    }
}
