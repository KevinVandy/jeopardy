using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmTrueFalse : Form
    {
        //Public variable used in and outside the form to set and determine whether the user...
        //Answered the question wrong or correct
        public bool Correct { get; set; }

        private Question question;
        private TimeSpan timeLimit;
        
        public frmTrueFalse(Question question, TimeSpan timeLimit)
        {
            this.question = question;
            this.timeLimit = timeLimit;
            InitializeComponent();
        }

        private void frmTrueFalse_Load(object sender, EventArgs e)
        {
            //Set up and display the question information
            lblQuestion.Text = question.QuestionText.ToString();

            //Correct answer is set, but visible is set to false by default
            lblCorrectAnswer.Text = question.Answer;

            //Set up the timer text
            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");

            //Start the timer
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            // Enable/Disable other buttons as necessary
            btnDone.Enabled = true;
            btnCancel.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;

            //Determines whether or not if "True" is equal to the question answer
            if (question.Answer == "True")
            {
                Correct = true;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.ForestGreen;
            }
            else
            {
                Correct = false;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.Red;
            }

            //Stop the timer as the user answered the question
            timer.Stop();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            // Enable/Disable other buttons as necessary
            btnDone.Enabled = true;
            btnCancel.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;

            //Determines whether or not if "False" is equal to the question answer
            if (question.Answer == "False")
            {
                Correct = true;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.ForestGreen;
            }
            else
            {
                Correct = false;
                lblCorrectAnswer.Visible = true;
                lblCorrectAnswer.ForeColor = Color.Red;
            }

            //Stop the timer as the user answered the question
            timer.Stop();
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
                //If the timer hits zero, and they haven't answered...
                //Then set it so they answered incorrectly
                timer.Stop(); //todo
                Correct = false;
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

        private void frmTrueFalse_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
