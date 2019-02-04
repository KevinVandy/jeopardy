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
    public partial class frmTrueFalse : Form
    {
        public bool Correct { get; set; }

        Question question;
        TimeSpan timeLimit;


        public frmTrueFalse(Question question, TimeSpan timeLimit)
        {
            this.question = question;
            this.timeLimit = timeLimit;
            InitializeComponent();
        }

        private void frmTrueFalse_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = question.QuestionText.ToString();
            lblCorrectAnswer.Text = question.Answer;

            lblTimer.Text = timeLimit.Minutes.ToString("0") + ":" + timeLimit.Seconds.ToString("00");
            timer.Start();

            btnDone.Enabled = false;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            btnDone.Enabled = true;
            btnCancel.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;

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

            timer.Stop();

            //await Task.Delay(3000); //show the answer for a bit      
            //this.Close();
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            btnDone.Enabled = true;
            btnCancel.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.Enabled = false;

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

            timer.Stop();

            //await Task.Delay(3000); //show the answer for a bit
            //this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; //This was a valid question experience (count the points)
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //They clicked on this button by mistake or something (don't count the points)
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (lblTimer.Text == "0:00")
            {
                timer.Stop(); //todo
                Correct = false;
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
