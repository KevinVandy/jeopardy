using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmFillInTheBlank : Form
    {      
        public bool correct { get; set; }

        private Question currentQuestion = new Question();

        public frmFillInTheBlank(Question theQuestion)
        {
            currentQuestion = theQuestion;
            InitializeComponent();
        }

        private void frmFillInTheBlank_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = currentQuestion.QuestionText;
            //TODO: progress bar/question time needs start on form load
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text) == true)
            {
                string userAnswer = txtUserAnswer.Text.Trim().ToLower();
                string correctAnswer = currentQuestion.Answer.Trim().ToLower();

                txtCorrectAnswer.Text = currentQuestion.Answer;

                if(userAnswer == correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.ForestGreen;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    //TODO: Insert a delay so the users can see the answers
                    this.correct = true;
                    this.Close();
                    
                }
                else if(userAnswer != correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.Red;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    //TODO: Insert a delay so the users can see the answers
                    this.correct = false;
                    this.Close();
                }               
            }
            else
            {
                MessageBox.Show("Please enter something for your answer.", "ANSWER ERROR");
            }
        }
    }
}
