using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmEditQuestion : Form
    {
        private int gameId;
        private string categoryName;
        private Question question;

        private bool shouldRemoveChoices = false;

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

            if (question.Type == "fb")
            {
                rdoFillInTheBlank.Checked = true;
            }
            else if (question.Type == "mc")
            {
                rdoMultipleChoice.Checked = true;

                if (question.Choices.Count >= 4)
                {
                    txtChoiceA.Text = question.Choices[0].Text;
                    txtChoiceB.Text = question.Choices[1].Text;
                    txtChoiceC.Text = question.Choices[2].Text;
                    txtChoiceD.Text = question.Choices[3].Text;

                    SelectMCAnswer();
                }
                else
                {
                    bwCreateChoices.RunWorkerAsync();
                    //MessageBox.Show("This multiple choice question has no choices. Creating now. Your database may be corrupt.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    question.Choices[i].CreateBlankChoice((int)question.Id, i);
                    question.Choices[i].Id = DB_Insert.InsertChoice(question.Choices[i]);
                }
            }
        }

        private void bwCreateChoices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableTypeRadioButtons();
            EnableMCControls();
        }

        private void bwRemoveChoices_DoWork(object sender, DoWorkEventArgs e) //now only runs on form close
        {
            if (question.Choices != null && question.Choices.Count > 0)
            {
                foreach (Choice c in question.Choices)
                {
                    DB_Delete.DeleteChoice(c.Id);
                }
            }
        }

        private void bwRemoveChoices_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) //depriciated since only runs on form close
        {
            //question.Choices = new List<Choice>(); //reset to null
            //EnableTypeRadioButtons();
        }

        private void rdoType_CheckChanged(object sender, EventArgs e)
        {
            DisableTypeRadioButtons(); //they will be re-enabled again once safe

            if (!bwCreateChoices.IsBusy && !bwRemoveChoices.IsBusy)
            {
                if (rdoFillInTheBlank.Checked && question.Type != "fb")
                {
                    if (question.Type == "mc") //if was multiple choice
                    {
                        question.DetermineState();

                        if (question.State == "no choices") //ok to delete choices because they are blank
                        {
                            question.Type = "fb";
                            EnableFBControls();
                            shouldRemoveChoices = true;
                            btnCancel.Enabled = false;
                        }
                        else //if choices are not blank, warn that they will be deleted
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete the choices for this question?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                question.Type = "fb";
                                EnableFBControls();
                                shouldRemoveChoices = true;
                                btnCancel.Enabled = false; //after changing a question's type, you can no longer cancel
                            }
                            else
                            {
                                frmEditQuestion_Load(null, null);
                                EnableTypeRadioButtons();
                                EnableMCControls();
                            }
                        }
                    }
                    else //from tf to fb
                    {
                        EnableFBControls();
                        EnableTypeRadioButtons();
                    }
                }
                else if (rdoFillInTheBlank.Checked && question.Type == "fb")
                {
                    EnableFBControls();
                    EnableTypeRadioButtons();
                }
                else if (rdoMultipleChoice.Checked && question.Type != "mc")
                {
                    question.Type = "mc";
                    shouldRemoveChoices = false;
                    bwCreateChoices.RunWorkerAsync();
                }
                else if (rdoMultipleChoice.Checked && question.Type == "mc")
                {
                    shouldRemoveChoices = false;
                    EnableMCControls();
                    EnableTypeRadioButtons();
                }
                else if (rdoTrueFalse.Checked && question.Type != "tf")
                {
                    if (question.Type == "mc") //if was multiple choice
                    {
                        question.DetermineState();

                        if (question.State == "no choices") //ok to delete choices because they are blank
                        {
                            question.Type = "tf";
                            EnableTFControls();
                            shouldRemoveChoices = true;
                            btnCancel.Enabled = false;
                        }
                        else //if choices are not blank, warn that they will be deleted
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to delete the choices for this question?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (dialogResult == DialogResult.Yes)
                            {
                                question.Type = "tf";
                                EnableTFControls();
                                shouldRemoveChoices = true;
                                btnCancel.Enabled = false;
                            }
                            else
                            {
                                frmEditQuestion_Load(null, null); //reload the form to simulate a cancel of radio change
                                EnableTypeRadioButtons();
                                EnableMCControls();
                            }
                        }
                    }
                    else //from fb to tf
                    {
                        EnableTFControls();
                        EnableTypeRadioButtons();
                    }
                }
                else if (rdoTrueFalse.Checked && question.Type == "tf")
                {
                    EnableTFControls();
                    EnableTypeRadioButtons();
                }
                else
                {
                    //EnableTypeRadioButtons();
                }
            }
            else //if it gets here then it was not safe to re-enable the buttons yet
            {
                DisableTypeRadioButtons();
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

        private void frmEditQuestion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldRemoveChoices && question.Type != "mc")
            {
                bwRemoveChoices.RunWorkerAsync();
            }

            //check for major unsaved changes if closing via the X button instead of ok button
            if (rdoFillInTheBlank.Checked && question.Type != "fb")
            {
                DialogResult dialogResult = MessageBox.Show("You changed the question type to Fill in the Blank. Do you want to save changes?", "Save Changes?", MessageBoxButtons.YesNo);
                
                if(dialogResult == DialogResult.Yes)
                {
                    btnOK_Click(sender, e);
                }
            }
            else if (rdoMultipleChoice.Checked && question.Type != "mc")
            {
                DialogResult dialogResult = MessageBox.Show("You changed the question type to Multiple Choice. Do you want to save changes?", "Save Changes?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    btnOK_Click(sender, e);
                }
            }
            else if (rdoTrueFalse.Checked && question.Type != "tf")
            {
                DialogResult dialogResult = MessageBox.Show("You changed the question type to True/False. Do you want to save changes?", "Save Changes?", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    btnOK_Click(sender, e);
                }
            }
        }

        private void txtQuestionText_TextChanged(object sender, EventArgs e)
        {
            if (txtQuestionText.TextLength > 298)
            {
                lblLimitWarning.Show();
            }
            else
            {
                lblLimitWarning.Hide();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //MARK: Menu Bar Item Event Handlers
        private void importQuestionFromOtherGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnImport_Click(sender, e);
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOK_Click(sender, e);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB_Conn.OpenHelpFile();
        }

        //MARK: Other Private Methods
        private void EnableTypeRadioButtons()
        {
            rdoFillInTheBlank.Enabled = true;
            rdoMultipleChoice.Enabled = true;
            rdoTrueFalse.Enabled = true;
        }

        private void DisableTypeRadioButtons()
        {
            rdoFillInTheBlank.Enabled = false;
            rdoMultipleChoice.Enabled = false;
            rdoTrueFalse.Enabled = false;
        }

        private void EnableFBControls()
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

            txtAnswer.ReadOnly = false;
            if (txtAnswer.Text != null && txtAnswer.Text.Trim() != "True" && txtAnswer.Text.Trim() != "False")
            {
                txtAnswer.Text = question.Answer.Trim();
            }
        }

        private void EnableMCControls()
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

            if (question.Choices.Count > 0 && question.Choices[0].Text.Length > 1)
            {
                txtChoiceA.Text = question.Choices[0].Text.Trim();
            }
            else
            {
                txtChoiceA.Text = "";
            }

            if (question.Choices.Count > 1 && question.Choices[1].Text.Length > 1)
            {
                txtChoiceB.Text = question.Choices[1].Text.Trim();
            }
            else
            {
                txtChoiceB.Text = "";
            }

            if (question.Choices.Count > 2 && question.Choices[2].Text.Length > 1)
            {
                txtChoiceC.Text = question.Choices[2].Text.Trim();
            }
            else
            {
                txtChoiceC.Text = "";
            }

            if (question.Choices.Count > 3 && question.Choices[3].Text.Length > 1)
            {
                txtChoiceD.Text = question.Choices[3].Text.Trim();
            }
            else
            {
                txtChoiceD.Text = "";
            }

            txtChoiceA.Enabled = true;
            txtChoiceB.Enabled = true;
            txtChoiceC.Enabled = true;
            txtChoiceD.Enabled = true;

            txtAnswer.ReadOnly = true;
            txtAnswer.Text = "";

            SelectMCAnswer();
        }

        private void EnableTFControls()
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

            txtAnswer.ReadOnly = true;
            txtAnswer.Text = "";
            SelectTFAnswer();
        }

        private void SelectTFAnswer()
        {
            if (question.Answer == "True")
            {
                rdoChoiceA.Checked = true;
            }
            else if (question.Answer == "False")
            {
                rdoChoiceC.Checked = true;
            }
        }

        private void SelectMCAnswer()
        {
            if (question.Choices.Count >= 4)
            {
                if (question.Choices[0].Text == question.Answer || question.Answer == txtChoiceA.Text)
                {
                    if (rdoChoiceA.Checked == false)
                    {
                        rdoChoiceA.Checked = true;
                    }
                }
                else if (question.Choices[1].Text == question.Answer || question.Answer == txtChoiceB.Text)
                {
                    if (rdoChoiceB.Checked == false)
                    {
                        rdoChoiceB.Checked = true;
                    }
                }
                else if (question.Choices[2].Text == question.Answer || question.Answer == txtChoiceC.Text)
                {
                    if (rdoChoiceC.Checked == false)
                    {
                        rdoChoiceC.Checked = true;
                    }
                }
                else if (question.Choices[3].Text == question.Answer || question.Answer == txtChoiceD.Text)
                {
                    if (rdoChoiceD.Checked == false)
                    {
                        rdoChoiceD.Checked = true;
                    }
                }
            }
        }
    }
}
