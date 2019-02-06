using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmMultipleChoice : Form
    {
        public bool Correct { get; set; }

        Question currentQuestion = new Question();
        TimeSpan timeLimit;

        public frmMultipleChoice(Question theQuestion, TimeSpan timeLimit)
        {
            currentQuestion = theQuestion;
            this.timeLimit = timeLimit;
            InitializeComponent();
        }

        private void frmMultipleChoice_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = currentQuestion.QuestionText;

            if (currentQuestion.Choices.Count >= 4)
            {
                rdoFirstChoice.Text = currentQuestion.Choices[0].Text;
                rdoSecondChoice.Text = currentQuestion.Choices[1].Text;
                rdoThirdChoice.Text = currentQuestion.Choices[2].Text;
                rdoFourthChoice.Text = currentQuestion.Choices[3].Text;
            }
            else
            {
                MessageBox.Show("This question did not have 4 Choices", "Error");
                Close();
            }

            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChecked())
            {
                Correct = CheckAnswer();
                ColorChoices();
            }

            timer.Stop();
            btnSubmit.Enabled = false;
            btnDone.Enabled = true;
            btnCancel.Enabled = false;
        }

        private bool ValidateChecked()
        {
            return rdoFirstChoice.Checked || rdoSecondChoice.Checked || rdoThirdChoice.Checked || rdoFourthChoice.Checked;
        }

        private bool CheckAnswer()
        {
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
                if (ValidateChecked())
                {
                    btnSubmit_Click(sender, e);
                }
                else
                {
                    Correct = false;
                    ColorChoices();
                }
                btnDone.Enabled = true;
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

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        //private void IsUserCorrect()
        //{
        //    //I realize this code is messy and dumb
        //    //but it works
        //    if (rdoFirstChoice.Checked == true)
        //    {
        //        if (rdoFirstChoice.Text == currentQuestion.Answer)
        //        {
        //            Correct = true;
        //            rdoFirstChoice.ForeColor = Color.ForestGreen;
        //            rdoSecondChoice.ForeColor = Color.Red;
        //            rdoThirdChoice.ForeColor = Color.Red;
        //            rdoFourthChoice.ForeColor = Color.Red;
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //        else
        //        {
        //            Correct = false;
        //            rdoFirstChoice.ForeColor = Color.Red;
        //            if (rdoSecondChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoSecondChoice.ForeColor = Color.ForestGreen;
        //                rdoThirdChoice.ForeColor = Color.Red;
        //                rdoFourthChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoThirdChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoThirdChoice.ForeColor = Color.ForestGreen;
        //                rdoFourthChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoFourthChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoThirdChoice.ForeColor = Color.Red;
        //                rdoFourthChoice.ForeColor = Color.ForestGreen;
        //            }
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //    }
        //    else if (rdoSecondChoice.Checked == true)
        //        {
        //            if (rdoSecondChoice.Text == currentQuestion.Answer)
        //            {
        //                Correct = true;
        //                rdoFirstChoice.ForeColor = Color.Red;
        //                rdoSecondChoice.ForeColor = Color.ForestGreen;
        //                rdoThirdChoice.ForeColor = Color.Red;
        //                rdoFourthChoice.ForeColor = Color.Red;
        //                //await Task.Delay(3000); //show the answer for a bit
        //                //this.Close();
        //            }
        //            else
        //            {
        //                Correct = false;
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                if (rdoFirstChoice.Text == currentQuestion.Answer)
        //                {
        //                    rdoFirstChoice.ForeColor = Color.ForestGreen;
        //                    rdoThirdChoice.ForeColor = Color.Red;
        //                    rdoFourthChoice.ForeColor = Color.Red;
        //                }
        //                else if (rdoThirdChoice.Text == currentQuestion.Answer)
        //                {
        //                    rdoFirstChoice.ForeColor = Color.Red;
        //                    rdoThirdChoice.ForeColor = Color.ForestGreen;
        //                    rdoFourthChoice.ForeColor = Color.Red;
        //                }
        //                else if (rdoFourthChoice.Text == currentQuestion.Answer)
        //                {
        //                    rdoFirstChoice.ForeColor = Color.Red;
        //                    rdoThirdChoice.ForeColor = Color.Red;
        //                    rdoFourthChoice.ForeColor = Color.ForestGreen;
        //                }
        //                //await Task.Delay(3000); //show the answer for a bit
        //                //this.Close();
        //            }
        //        }
        //    else if (rdoThirdChoice.Checked == true)
        //    {
        //        if (rdoThirdChoice.Text == currentQuestion.Answer)
        //        {
        //            Correct = true;
        //            rdoFirstChoice.ForeColor = Color.Red;
        //            rdoSecondChoice.ForeColor = Color.Red;
        //            rdoThirdChoice.ForeColor = Color.ForestGreen;
        //            rdoFourthChoice.ForeColor = Color.Red;
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //        else
        //        {
        //            Correct = false;
        //            rdoThirdChoice.ForeColor = Color.Red;
        //            if (rdoFirstChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.ForestGreen;
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoFourthChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoSecondChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.Red;
        //                rdoSecondChoice.ForeColor = Color.ForestGreen;
        //                rdoFourthChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoFourthChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.Red;
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoFourthChoice.ForeColor = Color.ForestGreen;
        //            }
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //    }
        //    else if (rdoFourthChoice.Checked == true)
        //    {
        //        if (rdoFourthChoice.Text == currentQuestion.Answer)
        //        {
        //            Correct = true;
        //            rdoFirstChoice.ForeColor = Color.Red;
        //            rdoSecondChoice.ForeColor = Color.Red;
        //            rdoThirdChoice.ForeColor = Color.Red;
        //            rdoFourthChoice.ForeColor = Color.ForestGreen;
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //        else
        //        {
        //            Correct = false;
        //            rdoFourthChoice.ForeColor = Color.Red;
        //            if (rdoFirstChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.ForestGreen;
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoThirdChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoSecondChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.Red;
        //                rdoSecondChoice.ForeColor = Color.ForestGreen;
        //                rdoThirdChoice.ForeColor = Color.Red;
        //            }
        //            else if (rdoThirdChoice.Text == currentQuestion.Answer)
        //            {
        //                rdoFirstChoice.ForeColor = Color.Red;
        //                rdoSecondChoice.ForeColor = Color.Red;
        //                rdoThirdChoice.ForeColor = Color.ForestGreen;
        //            }
        //            //await Task.Delay(3000); //show the answer for a bit
        //            //this.Close();
        //        }
        //    }
        //}

    }
}
