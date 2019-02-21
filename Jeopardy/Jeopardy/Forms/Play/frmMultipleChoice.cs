using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmMultipleChoice : Form
    {
        //Public variable used in and outside the form to set and determine whether the user...
        //Answered the question wrong or correct
        public bool Correct { get; set; }

        private Question currentQuestion = new Question();
        private TimeSpan timeLimit;

        public frmMultipleChoice(Question theQuestion, TimeSpan timeLimit)
        {
            currentQuestion = theQuestion;
            this.timeLimit = timeLimit;
            InitializeComponent();
        }

        private void frmMultipleChoice_Load(object sender, EventArgs e)
        {
            //Set up and display the question information
            lblQuestionText.Text = currentQuestion.QuestionText;

            //Set up the choices and their text
            if (currentQuestion.Choices.Count >= 4)
            {
                rdoFirstChoice.Text = currentQuestion.Choices[0].Text;
                rdoSecondChoice.Text = currentQuestion.Choices[1].Text;
                rdoThirdChoice.Text = currentQuestion.Choices[2].Text;
                rdoFourthChoice.Text = currentQuestion.Choices[3].Text;
            }
            else
            {
                //Multiples choices should have 4 choices, if not, then whoever made the game made a mistake
                MessageBox.Show("This question did not have 4 Choices", "Error");
                Close();
            }

            //Set up timer text
            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");

            //Start the timer
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Make sure the user has at least one radio button checked
            if (ValidateChecked())
            {
                //If they have selected something, check the answer
                Correct = CheckAnswer();
                
                //Method that colors the choice text based on whether the choice is the answer or not
                ColorChoices();

                //Stop the timer
                timer.Stop();

                // Enable/disable buttons as necessary
                btnSubmit.Enabled = false;
                btnDone.Enabled = true;
                btnCancel.Enabled = false;
            }
            else
            {
                MessageBox.Show("You must choose an answer.", "ERROR");
            }


        }

        private bool ValidateChecked()
        {
            //Makes sure the user has checked at least one option
            return rdoFirstChoice.Checked || rdoSecondChoice.Checked || rdoThirdChoice.Checked || rdoFourthChoice.Checked;
        }

        private bool CheckAnswer()
        {
            //Checks each radio button and sees if its the correct answer
            if (rdoFirstChoice.Checked == true && rdoFirstChoice.Text == currentQuestion.Answer)
            {
                return true;
            }
            else if (rdoSecondChoice.Checked == true && rdoSecondChoice.Text == currentQuestion.Answer)
            {
                return true;
            }
            else if (rdoThirdChoice.Checked == true && rdoThirdChoice.Text == currentQuestion.Answer)
            {
                return true;
            }
            else if (rdoFourthChoice.Checked == true && rdoFourthChoice.Text == currentQuestion.Answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ColorChoices()
        {
            //Colors each choice option based on whether it's the correct answer or not
            rdoFirstChoice.ForeColor = Color.Red;
            rdoSecondChoice.ForeColor = Color.Red;
            rdoThirdChoice.ForeColor = Color.Red;
            rdoFourthChoice.ForeColor = Color.Red;

            if (rdoFirstChoice.Text == currentQuestion.Answer)
            {
                rdoFirstChoice.ForeColor = Color.DarkGreen;
            }
            else if (rdoSecondChoice.Text == currentQuestion.Answer)
            {
                rdoSecondChoice.ForeColor = Color.DarkGreen;
            }
            else if (rdoThirdChoice.Text == currentQuestion.Answer)
            {
                rdoThirdChoice.ForeColor = Color.DarkGreen;
            }
            else if (rdoFourthChoice.Text == currentQuestion.Answer)
            {
                rdoFourthChoice.ForeColor = Color.DarkGreen;
            }
            else
            {
                MessageBox.Show("There was no correct answer! Either your teacher or the programmers made a mistake! Riot!");
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

                //If the user has selected any radio button, check it to see if it's correct
                if (ValidateChecked())
                {
                    btnSubmit_Click(sender, e);
                }
                else
                {
                    //Otherwise, assign it as incorrect, and color the choice text
                    Correct = false;
                    ColorChoices();
                }

                // Enable/disable buttons as necessary
                btnDone.Enabled = true;
                btnSubmit.Enabled = false;
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

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }
    }
}
