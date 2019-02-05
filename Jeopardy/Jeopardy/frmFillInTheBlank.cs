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
    public partial class frmFillInTheBlank : Form
    {      
        public bool Correct { get; set; }

        private Question currentQuestion = new Question();
        TimeSpan timeLimit;

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
            if(ValidateData.ValidateQuestionAnswer(txtUserAnswer.Text) == true && txtUserAnswer.Text.Trim() != "")
            {
                timer.Stop();

                string userAnswer = txtUserAnswer.Text.Trim().ToLower();
                string correctAnswer = currentQuestion.Answer.Trim().ToLower();

                txtCorrectAnswer.Text = currentQuestion.Answer;

                if(userAnswer == correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.ForestGreen;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;                   
                    this.Correct = true;
                    //await Task.Delay(3000); //show the answer for a bit
                    //this.Close();
                    
                }
                else if(userAnswer != correctAnswer)
                {
                    txtUserAnswer.ForeColor = Color.Red;
                    txtCorrectAnswer.BackColor = txtCorrectAnswer.BackColor;
                    txtCorrectAnswer.ForeColor = Color.ForestGreen;
                    this.Correct = false;
                    //await Task.Delay(3000); //show the answer for a bit
                    //this.Close();
                }
                btnDone.Enabled = true;
                btnCancel.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter something for your answer.", "ANSWER ERROR");
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
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
    }
}
