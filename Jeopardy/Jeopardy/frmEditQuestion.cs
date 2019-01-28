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
    public partial class frmEditQuestion : Form
    {
        int gameId;
        string categoryName;
        Question question;
        

        public frmEditQuestion(Question selectedQuestion, int theGameId, string theCategoryName)
        {
            question = selectedQuestion;
            gameId = theGameId;
            categoryName = theCategoryName;

            InitializeComponent();
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {
            lblCategoryTitle.Text = categoryName;
            lblWeight.Text = question.Weight.ToString();

            txtQuestionText.Text = question.QuestionText;
            txtAnswer.Text = question.Answer;
            
            if(question.Type == "fb")
            {
                rdoFillInTheBlank.Checked = true;
            }
            else if (question.Type == "mc")
            {
                rdoMultipleChoice.Checked = true;
                txtChoiceA.Text = question.Choices[0].Text;
                txtChoiceB.Text = question.Choices[1].Text;
                txtChoiceC.Text = question.Choices[2].Text;
                txtChoiceD.Text = question.Choices[3].Text;
            }
            else if (question.Type == "tf")
            {
                rdoTrueFalse.Checked = true;
            }

            txtQuestionText.Focus();
            txtQuestionText.SelectAll();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoType_CheckChanged(object sender, EventArgs e)
        {
            if (rdoFillInTheBlank.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "";
                rdoChoiceB.Text = "";
                rdoChoiceC.Text = "";
                rdoChoiceD.Text = "";

                rdoChoiceA.Enabled = false;
                rdoChoiceB.Enabled = false;
                rdoChoiceC.Enabled = false;
                rdoChoiceD.Enabled = false;

                txtChoiceA.Text = "";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = false;
                txtChoiceB.Enabled = false;
                txtChoiceC.Enabled = false;
                txtChoiceD.Enabled = false;

                txtAnswer.Enabled = true;
            }
            else if (rdoMultipleChoice.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "a";
                rdoChoiceB.Text = "b";
                rdoChoiceC.Text = "c";
                rdoChoiceD.Text = "d";

                rdoChoiceA.Enabled = true;
                rdoChoiceB.Enabled = true;
                rdoChoiceC.Enabled = true;
                rdoChoiceD.Enabled = true;

                txtChoiceA.Text = "";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = true;
                txtChoiceB.Enabled = true;
                txtChoiceC.Enabled = true;
                txtChoiceD.Enabled = true;

                txtAnswer.Enabled = false;
            }
            else if (rdoTrueFalse.Checked)
            {
                rdoChoiceA.Checked = false;
                rdoChoiceB.Checked = false;
                rdoChoiceC.Checked = false;
                rdoChoiceD.Checked = false;

                rdoChoiceA.Text = "T";
                rdoChoiceB.Text = "";
                rdoChoiceC.Text = "F";
                rdoChoiceD.Text = "";

                rdoChoiceA.Enabled = true;
                rdoChoiceB.Enabled = false;
                rdoChoiceC.Enabled = true;
                rdoChoiceD.Enabled = false;
                
                txtChoiceA.Text = "True";
                txtChoiceB.Text = "";
                txtChoiceC.Text = "False";
                txtChoiceD.Text = "";

                txtChoiceA.Enabled = false;
                txtChoiceB.Enabled = false;
                txtChoiceC.Enabled = false;
                txtChoiceD.Enabled = false;

                txtAnswer.Enabled = false;
            }

        }

        private void rdoChoices_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChoiceA.Checked)
            {
                txtChoiceA.ForeColor = Color.DarkGreen;
                txtChoiceB.ForeColor = Color.Black;
                txtChoiceC.ForeColor = Color.Black;
                txtChoiceD.ForeColor = Color.Black;

                txtAnswer.Text = txtChoiceA.Text;
            }
            else if (rdoChoiceB.Checked)
            {
                txtChoiceA.ForeColor = Color.Black;
                txtChoiceB.ForeColor = Color.DarkGreen;
                txtChoiceC.ForeColor = Color.Black;
                txtChoiceD.ForeColor = Color.Black;

                txtAnswer.Text = txtChoiceB.Text;
            }
            else if (rdoChoiceC.Checked)
            {
                txtChoiceA.ForeColor = Color.Black;
                txtChoiceB.ForeColor = Color.Black;
                txtChoiceC.ForeColor = Color.DarkGreen;
                txtChoiceD.ForeColor = Color.Black;

                txtAnswer.Text = txtChoiceC.Text;
            }
            else if (rdoChoiceD.Checked)
            {
                txtChoiceA.ForeColor = Color.Black;
                txtChoiceB.ForeColor = Color.Black;
                txtChoiceC.ForeColor = Color.Black;
                txtChoiceD.ForeColor = Color.DarkGreen;

                txtAnswer.Text =txtChoiceD.Text;
            }
            else
            {
                txtChoiceA.ForeColor = Color.Black;
                txtChoiceB.ForeColor = Color.Black;
                txtChoiceC.ForeColor = Color.Black;
                txtChoiceD.ForeColor = Color.Black;

                txtAnswer.Text = "";
            }
        }

        private void txtChoiceA_TextChanged(object sender, EventArgs e)
        {
            if (rdoChoiceA.Checked)
            {
                txtAnswer.Text = txtChoiceA.Text;
            }
        }

        private void txtChoiceB_TextChanged(object sender, EventArgs e)
        {
            if (rdoChoiceB.Checked)
            {
                txtAnswer.Text = txtChoiceB.Text;
            }
        }

        private void txtChoiceC_TextChanged(object sender, EventArgs e)
        {
            if (rdoChoiceC.Checked)
            {
                txtAnswer.Text = txtChoiceC.Text;
            }
        }

        private void txtChoiceD_TextChanged(object sender, EventArgs e)
        {
            if (rdoChoiceD.Checked)
            {
                txtAnswer.Text = txtChoiceD.Text;
            }
        }
    }
}
