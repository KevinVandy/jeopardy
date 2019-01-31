using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void SetQuestionType_Setfb_Returnfb() //invalid should not set and get default
        {
            string type = "fc";
            //Arrange
            Question question = new Question();

            //Act
            question.Type = type;

            //Assert
            Assert.AreEqual(question.Type, type);
        }

        [TestMethod]
        public void SetQuestionType_Setfc_Returnfb() //valid should set and get valid
        {
            string type = "fb";
            //Arrange
            Question question = new Question();

            //Act
            question.Type = type;

            //Assert
            Assert.AreEqual(question.Type, type);
        }

        [TestMethod]
        public void SetQuestionWeight_Set100_Return100() //valid should set and get valid
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
        public void SetQuestionWeight_Set99_Return0() //invalid should not set and get default
        {
            int weight = 99;
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = weight;

            //Assert
            Assert.AreEqual(question.Weight, 0); //0 is default and should be got

        }
    }
}
