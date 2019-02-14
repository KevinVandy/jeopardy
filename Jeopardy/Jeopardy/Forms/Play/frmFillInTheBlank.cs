using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmFillInTheBlank : Form
    {
        public bool Correct { get; set; }

        private Question currentQuestion = new Question();
        private TimeSpan timeLimit;

        public frmFillInTheBlank(Question theQuestion, TimeSpan timeLimit)
        {
            currentQuestion = theQuestion;
            this.timeLimit = timeLimit;
            InitializeComponent();
        }

        private void frmFillInTheBlank_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = currentQuestion.QuestionText;

            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text) == true && txtUserAnswer.Text.Trim() != "")
            {
                timer.Stop();

                string userAnswer = txtUserAnswer.Text.Trim().ToLower();
                string correctAnswer = currentQuestion.Answer.Trim().ToLower();

                txtCorrectAnswer.Text = currentQuestion.Answer;

                if (userAnswer == correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.ForestGreen;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.Text = "Correct";
                    Correct = true;
                }
                else if (userAnswer != correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.Red;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.ForeColor = Color.Red;
                    lblCorrectIncorrect.Text = "Incorrect";
                    Correct = false;
                }
                lblCorrectIncorrect.Visible = true;
                btnSubmit.Enabled = false;
                btnDone.Enabled = true;
                btnCancel.Enabled = false;
                btnOverwrite.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter something for your answer.", "ANSWER ERROR");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblTimer.Text == "0:00")
            {
                timer.Stop(); //todo
                if (ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text))
                {
                    btnSubmit_Click(sender, e);
                }
                else
                {
                    Correct = false;
                }
                btnDone.Enabled = true;
                btnOverwrite.Enabled = true;
            }
            else
            {
                TimeSpan currentTime = TimeSpan.ParseExact(lblTimer.Text, "m\\:ss", CultureInfo.InstalledUICulture);

                currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtrack 1 second every tick

                lblTimer.Text = currentTime.Minutes.ToString("0") + ":" + currentTime.Seconds.ToString("00");
            }

            if (lblTimer.Text == "0:10")
            {
                System.Media.SystemSounds.Hand.Play(); //warning sound
                lblTimer.ForeColor = Color.DarkRed;
            }
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            if (Correct == false)
            {
                Correct = true;
                lblCorrectIncorrect.ForeColor = Color.ForestGreen;
                lblCorrectIncorrect.Text = "Correct";
            }
            else if (Correct == true)
            {
                Correct = false;
                lblCorrectIncorrect.ForeColor = Color.Red;
                lblCorrectIncorrect.Text = "Incorrect";
            }

        }
    }
}
