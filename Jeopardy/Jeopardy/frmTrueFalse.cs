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
    public partial class frmTrueFalse : Form
    {
        public bool Correct { get; set; }

        Question question;


        public frmTrueFalse(Question question, TimeSpan timeLimit)
        {
            this.question = question;
            InitializeComponent();
        }

        private void frmTrueFalse_Load(object sender, EventArgs e)
        {
            lblQuestion.Text = question.QuestionText.ToString();
            lblCorrectAnswer.Text = question.Answer;

            btnDone.Enabled = false;
        }

        private async void btnTrue_Click(object sender, EventArgs e)
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

            //await Task.Delay(3000); //show the answer for a bit      
            //this.Close();
        }

        private async void btnFalse_Click(object sender, EventArgs e)
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
    }
}
