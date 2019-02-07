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
    public partial class frmReviewWrongQuestions : Form
    {
        List<Question> WrongQuestions;
        Team[] Teams;
        int questionIndex = -1;

        public frmReviewWrongQuestions(List<Question> wrongQuestions, Team[] teams)
        {
            WrongQuestions = wrongQuestions;
            Teams = teams;
            InitializeComponent();
        }

        private void frmReviewWrongQuestions_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = "";
            
            foreach(Team t in Teams)
            {
                if(t != null)
                {
                    lblQuestionText.Text = t.TeamName + ": " + t.Score.ToString() + "\n";
                }
            }
            lblIndex.Hide();
            txtCorrectAnswer.Hide();
            btnPrevious.Hide();
            btnNext.Text = "Review";
            btnRevealAnswer.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            questionIndex++;
            if (btnNext.Text == "Review")
            {
                
                btnNext.Text = "Next";
                lblIndex.Text = "1 of " + WrongQuestions.Count.ToString();
                lblIndex.Show();
                txtCorrectAnswer.Show();
                btnPrevious.Show();
                btnRevealAnswer.Show();
            }
            else if(questionIndex < WrongQuestions.Count)
            {
                ShowQuestion(questionIndex);
            }
            else //done
            {
                
            }
        }

        private void btnRevealAnswer_Click(object sender, EventArgs e)
        {
            ShowAnswer(questionIndex);
        }

        private void ShowQuestion(int i)
        {
            lblQuestionText.Text = WrongQuestions[i].QuestionText;

        }

        private void ShowAnswer(int i)
        {
            txtCorrectAnswer.Text = WrongQuestions[i].Answer;
        }

        
    }
}
