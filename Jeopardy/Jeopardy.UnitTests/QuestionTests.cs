using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jeopardy.UnitTests
{
    [TestClass]
    public class QuestionTests
    {
        [TestMethod]
        public void SetQuestionType_Setfb_Returnfb() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Type = "fb";

            //Assert
            Assert.AreEqual(question.Type, "fb");
        }

        [TestMethod]
        public void SetQuestionType_Setmc_Returnmc() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Type = "mc";

            //Assert
            Assert.AreEqual(question.Type, "mc");
        }

        [TestMethod]
        public void SetQuestionType_Settf_Returntf() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Type = "tf";

            //Assert
            Assert.AreEqual(question.Type, "tf");
        }

        [TestMethod]
        public void SetQuestionType_SetInvalid_ReturnDefault() //invalid should not set and get default
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Type = "aa";

            //Assert
            Assert.AreEqual(question.Type, "fb"); //fb is default (it means fill in the blank)
        }

        [TestMethod]
        public void SetQuestionWeight_Set100_Return100() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = 100;

            //Assert
            Assert.AreEqual(question.Weight, 100);
        }

        [TestMethod]
        public void SetQuestionText_SetValid_ReturnValid() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "What is a question";

            //Assert
            Assert.AreEqual(question.QuestionText, "What is a question");
        }

        [TestMethod]
        public void SetQuestionText_SetNULL_ReturnSpace() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "";

            //Assert
            Assert.AreEqual(question.QuestionText, " ");
        }

        [TestMethod]
        public void SetQuestionText_SetTooLong_ReturnSpace() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of  (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32."; //too long(should be under 1000 characters)

            //Assert
            Assert.AreEqual(question.QuestionText, " "); // empty space is default
        }

        [TestMethod]
        public void SetQuestionAnswerFBMC_SetValid_ReturnValid() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "This is an answer"; //fb

            //Assert
            Assert.AreEqual(question.QuestionText, "This is an answer");
        }

        [TestMethod]
        public void SetQuestionAnswerTF_SetTrue_ReturnTrue() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "True"; //fb

            //Assert
            Assert.AreEqual(question.QuestionText, "True");
        }

        [TestMethod]
        public void SetQuestionAnswerTF_SetFalse_ReturnFalse() //valid should set and get valid
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = "False"; //fb

            //Assert
            Assert.AreEqual(question.QuestionText, "False");
        }

        public void SetQuestionAnswerTF_SetNull_ReturnSpace() //invalid should not set and get default
        {
            //Arrange
            Question question = new Question();

            //Act
            question.QuestionText = ""; //fb

            //Assert
            Assert.AreEqual(question.QuestionText, " ");
        }

        [TestMethod]
        public void SetQuestionWeight_Set99_Return0() //invalid should not set and get default
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = 99;

            //Assert
            Assert.AreEqual(question.Weight, 0); //0 is default and should be got

        }
    }
}
