using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void SetQuestionWeight_Set100_Return100()
        {
            int weight = 100;
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = weight;

            //Assert
            Assert.AreEqual(question.Weight, weight);

        }

        [TestMethod]
        public void SetQuestionWeight_Set99_Return100()
        {
            int weight = 99;
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = weight;

            //Assert
            Assert.AreNotEqual(question.Weight, weight);

        }
    }
}
