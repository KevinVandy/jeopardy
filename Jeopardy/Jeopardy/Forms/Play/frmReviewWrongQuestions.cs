using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmReviewWrongQuestions : Form
    {
        private List<Question> WrongQuestions;
        private Team[] Teams;
        private int questionIndex = -1;

        public frmReviewWrongQuestions(List<Question> wrongQuestions, Team[] teams)
        {
            WrongQuestions = wrongQuestions;
            Teams = teams;
            InitializeComponent();
        }

        private void frmReviewWrongQuestions_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = "";

            //On form load, display each team and their scores
            foreach (Team t in Teams)
            {
                if (t != null)
                {
                    lblQuestionText.Text += t.TeamName + ": " + t.Score.ToString() + "\n";
                }
            }

            lblQuestionText.Text += "\n\nClick 'Review' to Review the Questions you Missed!";

            lblIndex.Hide();
            txtCorrectAnswer.Hide();
            btnPrevious.Hide();
            btnNext.Text = "Review";
            btnRevealAnswer.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Displays the next question in the wrong questions list
            if (btnNext.Text == "Review")
            {
                questionIndex++;
                btnNext.Text = "Next";
                lblIndex.Text = "1 of " + WrongQuestions.Count.ToString();
                lblIndex.Show();
                txtCorrectAnswer.Show();
                btnPrevious.Show();
                btnPrevious.Enabled = false;
                btnRevealAnswer.Show();
                ShowQuestion(questionIndex);
            }
            else if (questionIndex < WrongQuestions.Count - 1)
            {
                btnPrevious.Enabled = true;
                questionIndex++;
                ShowQuestion(questionIndex);
            }

            if ((questionIndex + 1) == WrongQuestions.Count)
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (questionIndex > 0)
            {
                btnNext.Enabled = true;
                questionIndex--;
                ShowQuestion(questionIndex);
            }
            if (questionIndex == 0)
            {
                btnPrevious.Enabled = false;
            }
        }

        private void btnRevealAnswer_Click(object sender, EventArgs e)
        {
            ShowAnswer(questionIndex);
        }

        private void ShowQuestion(int i)
        {
            lblQuestionText.Text = WrongQuestions[i].QuestionText;
            lblIndex.Text = (questionIndex + 1).ToString() + " of " + WrongQuestions.Count.ToString();
            txtCorrectAnswer.Text = "";
        }

        private void ShowAnswer(int i)
        {
            txtCorrectAnswer.Text = WrongQuestions[i].Answer;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
