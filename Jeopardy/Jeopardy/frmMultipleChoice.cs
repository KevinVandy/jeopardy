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
    public partial class frmMultipleChoice : Form
    {
        public bool correct { get; set; }

        private Question currentQuestion = new Question();

        public frmMultipleChoice(Question theQuestion)
        {
            currentQuestion = theQuestion;
            InitializeComponent();
        }

        private void frmMultipleChoice_Load(object sender, EventArgs e)
        {
            lblQuestionText.Text = currentQuestion.QuestionText;
            Insert_RDO_QuestionText();
        }

        private void Insert_RDO_QuestionText()
        {
            for (int x = 0; x < 4; x++)
            {
                if(rdoFirstChoice.Text == "")
                {
                    rdoFirstChoice.Text = currentQuestion.Choices[x].Text;
                }
                else if (rdoSecondChoice.Text == "")
                {
                    rdoSecondChoice.Text = currentQuestion.Choices[x].Text;
                }
                else if (rdoThirdChoice.Text == "")
                {
                    rdoThirdChoice.Text = currentQuestion.Choices[x].Text;
                }
                else if (rdoFourthChoice.Text == "")
                {
                    rdoFourthChoice.Text = currentQuestion.Choices[x].Text;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateChecked())
            {
                IsUserCorrect();
            }
            else
            {
                MessageBox.Show("Please check one of the options listed.", "ANSWER ERROR");
            }
        }

        private bool ValidateChecked()
        {
            bool isValid = false;

            if(rdoFirstChoice.Checked == true || rdoSecondChoice.Checked == true || rdoThirdChoice.Checked == true
                || rdoFourthChoice.Checked == true)
            {
                isValid = true;
            }

            return isValid;
        }

        private async void IsUserCorrect()
        {
            //I realize this code is messy and dumb
            //but it works
            if (rdoFirstChoice.Checked == true)
            {
                if (rdoFirstChoice.Text == currentQuestion.Answer)
                {
                    correct = true;
                    rdoFirstChoice.ForeColor = Color.ForestGreen;
                    rdoSecondChoice.ForeColor = Color.Red;
                    rdoThirdChoice.ForeColor = Color.Red;
                    rdoFourthChoice.ForeColor = Color.Red;
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
                else
                {
                    correct = false;
                    rdoFirstChoice.ForeColor = Color.Red;
                    if (rdoSecondChoice.Text == currentQuestion.Answer)
                    {
                        rdoSecondChoice.ForeColor = Color.ForestGreen;
                        rdoThirdChoice.ForeColor = Color.Red;
                        rdoFourthChoice.ForeColor = Color.Red;
                    }
                    else if (rdoThirdChoice.Text == currentQuestion.Answer)
                    {
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoThirdChoice.ForeColor = Color.ForestGreen;
                        rdoFourthChoice.ForeColor = Color.Red;
                    }
                    else if (rdoFourthChoice.Text == currentQuestion.Answer)
                    {
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoThirdChoice.ForeColor = Color.Red;
                        rdoFourthChoice.ForeColor = Color.ForestGreen;
                    }
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
            }
            else if (rdoSecondChoice.Checked == true)
                {
                    if (rdoSecondChoice.Text == currentQuestion.Answer)
                    {
                        correct = true;
                        rdoFirstChoice.ForeColor = Color.Red;
                        rdoSecondChoice.ForeColor = Color.ForestGreen;
                        rdoThirdChoice.ForeColor = Color.Red;
                        rdoFourthChoice.ForeColor = Color.Red;
                        await Task.Delay(3000); //show the answer for a bit
                        this.Close();
                    }
                    else
                    {
                        correct = false;
                        rdoSecondChoice.ForeColor = Color.Red;
                        if (rdoFirstChoice.Text == currentQuestion.Answer)
                        {
                            rdoFirstChoice.ForeColor = Color.ForestGreen;
                            rdoThirdChoice.ForeColor = Color.Red;
                            rdoFourthChoice.ForeColor = Color.Red;
                        }
                        else if (rdoThirdChoice.Text == currentQuestion.Answer)
                        {
                            rdoFirstChoice.ForeColor = Color.Red;
                            rdoThirdChoice.ForeColor = Color.ForestGreen;
                            rdoFourthChoice.ForeColor = Color.Red;
                        }
                        else if (rdoFourthChoice.Text == currentQuestion.Answer)
                        {
                            rdoFirstChoice.ForeColor = Color.Red;
                            rdoThirdChoice.ForeColor = Color.Red;
                            rdoFourthChoice.ForeColor = Color.ForestGreen;
                        }
                        await Task.Delay(3000); //show the answer for a bit
                        this.Close();
                    }
                }
            else if (rdoThirdChoice.Checked == true)
            {
                if (rdoThirdChoice.Text == currentQuestion.Answer)
                {
                    correct = true;
                    rdoFirstChoice.ForeColor = Color.Red;
                    rdoSecondChoice.ForeColor = Color.Red;
                    rdoThirdChoice.ForeColor = Color.ForestGreen;
                    rdoFourthChoice.ForeColor = Color.Red;
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
                else
                {
                    correct = false;
                    rdoThirdChoice.ForeColor = Color.Red;
                    if (rdoFirstChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.ForestGreen;
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoFourthChoice.ForeColor = Color.Red;
                    }
                    else if (rdoSecondChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.Red;
                        rdoSecondChoice.ForeColor = Color.ForestGreen;
                        rdoFourthChoice.ForeColor = Color.Red;
                    }
                    else if (rdoFourthChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.Red;
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoFourthChoice.ForeColor = Color.ForestGreen;
                    }
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
            }
            else if (rdoFourthChoice.Checked == true)
            {
                if (rdoFourthChoice.Text == currentQuestion.Answer)
                {
                    correct = true;
                    rdoFirstChoice.ForeColor = Color.Red;
                    rdoSecondChoice.ForeColor = Color.Red;
                    rdoThirdChoice.ForeColor = Color.Red;
                    rdoFourthChoice.ForeColor = Color.ForestGreen;
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
                else
                {
                    correct = false;
                    rdoFourthChoice.ForeColor = Color.Red;
                    if (rdoFirstChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.ForestGreen;
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoThirdChoice.ForeColor = Color.Red;
                    }
                    else if (rdoSecondChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.Red;
                        rdoSecondChoice.ForeColor = Color.ForestGreen;
                        rdoThirdChoice.ForeColor = Color.Red;
                    }
                    else if (rdoThirdChoice.Text == currentQuestion.Answer)
                    {
                        rdoFirstChoice.ForeColor = Color.Red;
                        rdoSecondChoice.ForeColor = Color.Red;
                        rdoThirdChoice.ForeColor = Color.ForestGreen;
                    }
                    await Task.Delay(3000); //show the answer for a bit
                    this.Close();
                }
            }

        }

        private void rdoFirstChoice_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
