using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmFillInTheBlank : Form
    {
        //Public variable used in and outside the form to set and determine whether the user...
        //Answered the question wrong or correct
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
            //Set up and display the question information
            lblQuestionText.Text = currentQuestion.QuestionText;

            //Set up the timer text
            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");

            //Start the timer
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Make sure the user entered at least something before attempting to determine if it's correct or not
            if (ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text) == true && txtUserAnswer.Text.Trim() != "")
            {
                //Stop the timer
                timer.Stop();

                //Grab the user's answer and the actual question answer
                string userAnswer = txtUserAnswer.Text.Trim().ToLower();
                string correctAnswer = currentQuestion.Answer.Trim().ToLower();

                txtCorrectAnswer.Text = currentQuestion.Answer;

                if (userAnswer == correctAnswer)
                {
                    //Show that they got the answer correct in green, show correct answer in green
                    txtUserAnswer.ForeColor = Color.ForestGreen;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.Text = "Correct";
                    Correct = true;
                }
                else if (userAnswer != correctAnswer)
                {
                    //Show that they got the answer wrong in red, show correct answer in green
                    txtUserAnswer.ForeColor = Color.Red;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    lblCorrectIncorrect.ForeColor = Color.Red;
                    lblCorrectIncorrect.Text = "Incorrect";
                    Correct = false;
                }

                // Enabled/Disable buttons now that the user has answered
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
            DialogResult = DialogResult.OK; //This was a valid question experience (count the points)
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            DialogResult = DialogResult.Cancel; //They clicked on this button by mistake or something (don't count the points)
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblTimer.Text == "0:00")
            {
                //If the timer hits zero, stop the timer
                timer.Stop(); //todo

                //If the user has anything in the the textbox, check to see if it's correct
                if (ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text))
                {
                    btnSubmit_Click(sender, e);
                }
                //Otherwise, if they don't have anything, mark it as incorrect
                else
                {
                    Correct = false;
                }
                btnDone.Enabled = true;
                btnOverwrite.Enabled = true;
            }
            else
            {
                //If the timer is not 0 and is still running, than grab the timer text on the form and parse...
                //it into a timespan variable
                TimeSpan currentTime = TimeSpan.ParseExact(lblTimer.Text, "m\\:ss", CultureInfo.InstalledUICulture);

                currentTime = currentTime.Subtract(new TimeSpan(0, 0, 1)); //subtrack 1 second every tick

                //Update the timer text on the form
                lblTimer.Text = currentTime.Minutes.ToString("0") + ":" + currentTime.Seconds.ToString("00");
            }

            //Once the timer hits 10 seconds...
            if (lblTimer.Text == "0:10")
            {
                System.Media.SystemSounds.Hand.Play(); //warning sound
                lblTimer.ForeColor = Color.DarkRed;
            }
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            //Allows the teacher to overwrite whether or not they got the answer correct
            //[In case the user answer string and question answer string don't match exactly]
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
