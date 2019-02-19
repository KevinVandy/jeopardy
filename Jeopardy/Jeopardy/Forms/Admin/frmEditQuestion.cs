using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmEditQuestion : Form
    {
        private int gameId;
        private string categoryName;
        private Question question;


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

            if (question.Type == "fb")
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

                if (question.Choices[0].Text == question.Answer)
                {
                    rdoChoiceA.Checked = true;
                }
                else if (question.Choices[1].Text == question.Answer)
                {
                    rdoChoiceB.Checked = true;
                }
                else if (question.Choices[2].Text == question.Answer)
                {
                    rdoChoiceC.Checked = true;
                }
                else if (question.Choices[3].Text == question.Answer)
                {
                    rdoChoiceD.Checked = true;
                }
            }
            else if (question.Type == "tf")
            {
                rdoTrueFalse.Checked = true;
            }
            else
            {
                MessageBox.Show("Warning. This question does not have a valid type. Database may be corrupt", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtQuestionText.Focus();
            txtQuestionText.SelectAll();

        }



        private void bwCreateChoices_DoWork(object sender, DoWorkEventArgs e)
        {
            if (question.Choices == null || question.Choices.Count == 0)
            {
                question.Choices = new List<Choice>(new Choice[4]);

                for (int i = 0; i < 4; i++) //make 4 blank choices
                {
                    question.Choices[i] = new Choice();
                    question.Choices[i].QuestionId = (int)question.Id;
                    question.Choices[i].Index = i;
                    question.Choices[i].Text = " ";
                    question.Choices[i].Id = DB_Insert.InsertChoice(question.Choices[i]);
                }
            }
        }

        private void bwCreateChoices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            rdoFillInTheBlank.Enabled = true;
            rdoMultipleChoice.Enabled = true;
            rdoTrueFalse.Enabled = true;
        }

        private void bwRemoveChoices_DoWork(object sender, DoWorkEventArgs e)
        {
            if (question.Choices != null && question.Choices.Count > 0)
            {
                foreach (Choice c in question.Choices)
                {
                    DB_Delete.DeleteChoice(c.Id);
                }
            }
        }

        private void bwRemoveChoices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            question.Choices = new List<Choice>(); //reset to null
            rdoFillInTheBlank.Enabled = true;
            rdoMultipleChoice.Enabled = true;
            rdoTrueFalse.Enabled = true;
        }

        private void rdoType_CheckChanged(object sender, EventArgs e)
        {
            if (rdoFillInTheBlank.Checked)
            {
                if (!bwRemoveChoices.IsBusy)
                {
                    rdoFillInTheBlank.Enabled = false;
                    rdoMultipleChoice.Enabled = false;
                    rdoTrueFalse.Enabled = false;
                    bwRemoveChoices.RunWorkerAsync();
                }

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

                txtAnswer.ReadOnly = false;


            }
            else if (rdoMultipleChoice.Checked)
            {
                if (!bwCreateChoices.IsBusy)
                {
                    rdoFillInTheBlank.Enabled = false;
                    rdoMultipleChoice.Enabled = false;
                    rdoTrueFalse.Enabled = false;
                    bwCreateChoices.RunWorkerAsync();
                }

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

                txtAnswer.ReadOnly = true;
            }
            else if (rdoTrueFalse.Checked)
            {
                if (!bwRemoveChoices.IsBusy)
                {
                    rdoFillInTheBlank.Enabled = false;
                    rdoMultipleChoice.Enabled = false;
                    rdoTrueFalse.Enabled = false;
                    bwRemoveChoices.RunWorkerAsync();
                }

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

                txtAnswer.ReadOnly = true;
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

                txtAnswer.Text = txtChoiceD.Text;
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

        //MARK: Button Event Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.OK;

            //error / warning checking
            if (txtQuestionText.Text.Length > 1 && (txtAnswer.Text == "" || txtAnswer.Text == " "))
            {
                dialogResult = MessageBox.Show("Warning. This question does not have an answer. This question will be marked as incomplete and colored RED until you give it an answer", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            if (dialogResult == DialogResult.OK)
            {
                if (rdoFillInTheBlank.Checked)
                {
                    question.Type = "fb";
                }
                else if (rdoMultipleChoice.Checked)
                {
                    question.Type = "mc";

                    question.Choices[0].Text = txtChoiceA.Text;
                    question.Choices[1].Text = txtChoiceB.Text;
                    question.Choices[2].Text = txtChoiceC.Text;
                    question.Choices[3].Text = txtChoiceD.Text;

                    for (int i = 0; i < 4; i++)
                    {
                        DB_Update.UpdateChoiceText(question.Choices[i].Text, question.Choices[i].Id);
                    }

                }
                else if (rdoTrueFalse.Checked)
                {
                    question.Type = "tf";
                }

                question.QuestionText = txtQuestionText.Text;
                question.Answer = txtAnswer.Text;

                if (!DB_Update.UpdateQuestion(question))
                {
                    MessageBox.Show("Updating Question failed");
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }


        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImportQuestion importQuestionForm = new frmImportQuestion();
            DialogResult dialogResult = importQuestionForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                //if going from multiple choice to another type, delete the choices
                if (question.Type == "mc" && importQuestionForm.selectedQuestion.Type != "mc")
                {
                    for (int j = 0; j < 4 && j < question.Choices.Count; j++)
                    {
                        DB_Delete.DeleteChoice(question.Choices[j].Id);
                    }
                }
                // going from other type of question to multiple choice, make the choices
                else if (question.Type != "mc" && importQuestionForm.selectedQuestion.Type == "mc")
                {
                    question.Choices = new List<Choice>(new Choice[4]);
                    for (int j = 0; j < 4 && j < question.Choices.Count; j++)
                    {
                        question.Choices[j] = new Choice();
                        question.Choices[j].QuestionId = (int)question.Id;
                        question.Choices[j].Index = j;
                        question.Choices[j].Text = importQuestionForm.selectedQuestion.Choices[j].Text;
                        question.Choices[j].Id = DB_Insert.InsertChoice(question.Choices[j]);
                    }
                }
                //if both are multiple choice, just do a simple update
                else if (question.Type == "mc" && importQuestionForm.selectedQuestion.Type == "mc")
                {
                    for (int j = 0; j < 4; j++)
                    {
                        question.Choices[j].Text = importQuestionForm.selectedQuestion.Choices[j].Text;
                        DB_Update.UpdateChoice(question.Choices[j]);
                    }
                }

                //get info from the selected question (not a complete clone because the IDs have to be different)
                question.Type = importQuestionForm.selectedQuestion.Type;
                question.QuestionText = importQuestionForm.selectedQuestion.QuestionText;
                question.Answer = importQuestionForm.selectedQuestion.Answer;



                frmEditQuestion_Load(sender, e); //reload this form with the info
            }

        }

        private void importQuestionFromOtherGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnImport_Click(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string helpFilePath = Directory.GetCurrentDirectory() + @"\JeopardyHelpFiles\jeopardyhelp.chm";


                System.Diagnostics.Process process = new Process();
                process.StartInfo.FileName = helpFilePath;
                process.Start();

            }
            catch (Exception ex)
            {
                MessageBox.Show("This feature is not working yet");
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
