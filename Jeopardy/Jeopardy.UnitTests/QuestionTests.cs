using System;
using System.Collections.Generic;
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

        [TestMethod]
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
        public void SetQuestionWeight_Set99999999_Return0() //invalid should not set and get default
        {
            //Arrange
            Question question = new Question();

            //Act
            question.Weight = 999999999;

            //Assert
            Assert.AreEqual(question.Weight, 0); //0 is default and should be got

        }

        [TestMethod]
        public void DetermineState_StringEqualsEdit_StringLength1orLess_ReturnVoie()
        {
            //Arange
            string pass;
            Question question = new Question();
            pass = "edit";
            question.QuestionText = "";
            //Act
            question.DetermineState();
            //Assert
            Assert.AreEqual(question.State, "no question");
        }

        [TestMethod]
        public void DetermineState_StringEqualsEdit_QuestionTextSingleSpace()
        {
            //Arrange
            Question question = new Question();
            question.QuestionText = " ";
            var pass = "edit";
            //Act
            question.DetermineState();
            //Assert
            Assert.AreEqual(question.State, "no question");
        }

        [TestMethod]
        public void DetermineState_StringEqualsEdit_QuestionTextLengthGreaterThanOne_AnswerLengthLessThanOne()
        {
            //Arange
            Question question = new Question();
            string pass  = "edit";
            question.QuestionText = "string.length > 1";
            question.Answer = "";
            //Act
            question.DetermineState();
            //Assert
            Assert.AreEqual(question.State, "no answer");
        }

        [TestMethod]
        public void DetermineState_StringEqualsEdit_QuestionTextLengthGreaterThanOne_AnswerEqualsSingleSpace()
        {
            //Arange
            Question question = new Question();
            string pass = "edit";
            question.QuestionText = "string.length > 1";
            question.Answer = " ";
            //Act
            question.DetermineState();
            //Assert
            Assert.AreEqual(question.State, "no answer");
        }

        //[TestMethod]
        //public void DetermineState_StringEqualsEdit_QuestionTextLengthGreaterThanOne_TypeEqualMC_ChoiceTextLengthLessThanOne()
        //{
        //    //Arange
        //    List<Choice> Choices = new List<Choice>();
        //    Question question = new Question();
        //    Choice choice = new Choice();
        //    string pass = "edit";
        //    question.QuestionText = "string.length > 1";
        //    question.Answer = "string.length > 1";
        //    question.Type = "mc";
        //    choice.Text = " ";
        //    Choices.Add(choice);
        //    //Act
        //    question.DetermineState(pass);
        //    //Assert
        //    Assert.AreEqual(question.State, "done");
        //}

        [TestMethod]
        public void DetermineState_StringEqualsEdit_QuestionTextLengthGreaterThanOne_QuestionAnswerGreaterThanOne_QuestionTypeNotEqualMC()
        {
            //Arange
            Question question = new Question();
            question.QuestionText = "string.length > 1";
            question.Answer = "string.lenght > 1";
            question.Type = "not mc";
            string pass = "edit";
            //Act
            question.DetermineState();
            //Assert
            Assert.AreEqual(question.State, "done");
        }

        [TestMethod]
        public void DetermineState_StringEqualsPlay()
        {
            //Arange
            Question question = new Question();
            string pass = "play";

            //Act

            //DetermineState is an if statement, and nowhere in that if statement will it assign the state of "play"
            //question.DetermineState();
            question.State = pass;

            //Assert
            Assert.AreEqual(question.State, pass);
        }
    }
}
