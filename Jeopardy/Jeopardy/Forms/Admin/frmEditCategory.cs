using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Jeopardy
{
    public partial class frmEditCategory : Form
    {
        private frmImportCategory importCategoryForm;
        private Category category;

        public frmEditCategory(Category theCategory)
        {
            category = theCategory;

            InitializeComponent();
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {
            txtTitle.Text = category.Title;
            txtSubtitle.Text = category.Subtitle;

            txtTitle.Focus();
            txtTitle.SelectAll();
        }

        //MARK: Button Event Handlers
        private void btnOK_Click(object sender, EventArgs e)
        {
            string subtitle = txtSubtitle.Text;

            // allows user to enter in a blank subtitle
            if(subtitle == "" || subtitle == null)
            {
                subtitle = " ";
            }

            if (ValidateData.ValidateCategoryTitle(txtTitle.Text) && ValidateData.ValidateCategorySubtitle(subtitle))
            {
                category.Title = txtTitle.Text;
                category.Subtitle = txtSubtitle.Text;

                if (!DB_Update.UpdateCategory(category))
                {
                    MessageBox.Show("Updating Category Failed");
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
            DialogResult dialogResult1 = DialogResult.Yes;
            DialogResult dialogResult2 = DialogResult.OK;

            DisableAllControls();

            foreach (Question q in category.Questions)
            {
                if (q.State != "no question")
                {
                    dialogResult1 = MessageBox.Show("Warning. You already have Questions in this category. Importing questions from another game may overwrite the Questions in this Category that you already have. Do you still wish to procede?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    break;
                }
            }

            if (dialogResult1 == DialogResult.Yes)
            {
                importCategoryForm = new frmImportCategory();
                dialogResult2 = importCategoryForm.ShowDialog();
            }
            else
            {
                EnableAllControls();
            }

            if (dialogResult1 == DialogResult.Yes && dialogResult2 == DialogResult.OK)
            {
                category.Title = importCategoryForm.selectedCategory.Title;       //can't go in bw because accessing stuff from form thread
                category.Subtitle = importCategoryForm.selectedCategory.Subtitle; //can't go in bw because accessing stuff from form thread

                bwImportCategory.RunWorkerAsync(); //import the questions from the category in background thread

                if (importCategoryForm.selectedCategory.Questions.Count > category.Questions.Count)
                {
                    MessageBox.Show("Warning. The Category that you are importing has more Questions in it than the Number of Questions Per Category in the Current Game. If you want to import all of the Questions from this category, you will need to increase the number of Questions Per Category from " + category.Questions.Count.ToString() + " to " + importCategoryForm.selectedCategory.Questions.Count.ToString() + ". The Questions that fit will still be imported.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                EnableAllControls();
            }
        }

        private void importCategoryFromOtherGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnImport_Click(sender, e); //just simulates clicking the import button
        }

        private void bwImportCategory_DoWork(object sender, DoWorkEventArgs e)
        {
            if (importCategoryForm.selectedCategory.Questions.Count > 0) //only import questions if there are any
            {
                //only imports questions to the max size of the grid and the max size of the other game grid
                for (int i = 0; i < category.Questions.Count && i < importCategoryForm.selectedCategory.Questions.Count; i++)
                {
                    //if going from multiple choice to another type, delete the choices
                    if (category.Questions[i].Type == "mc" && importCategoryForm.selectedCategory.Questions[i].Type != "mc")
                    {
                        for (int j = 0; j < 4 && j < category.Questions[i].Choices.Count; j++)
                        {
                            DB_Delete.DeleteChoice(category.Questions[i].Choices[j].Id);
                        }
                    }
                    // going from other type of question to multiple choice, make the choices
                    else if (category.Questions[i].Type != "mc" && importCategoryForm.selectedCategory.Questions[i].Type == "mc")
                    {
                        category.Questions[i].Choices = new List<Choice>(new Choice[4]);
                        for (int j = 0; j < 4 && j < category.Questions[i].Choices.Count; j++)
                        {
                            category.Questions[i].Choices[j] = new Choice();
                            category.Questions[i].Choices[j].QuestionId = (int)category.Questions[i].Id;
                            category.Questions[i].Choices[j].Index = j;
                            category.Questions[i].Choices[j].Text = importCategoryForm.selectedCategory.Questions[i].Choices[j].Text;
                            category.Questions[i].Choices[j].Id = DB_Insert.InsertChoice(category.Questions[i].Choices[j]);
                        }
                    }
                    //if both are multiple choice, just do a simple update
                    else if (category.Questions[i].Type == "mc" && importCategoryForm.selectedCategory.Questions[i].Type == "mc")
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            category.Questions[i].Choices[j].Text = importCategoryForm.selectedCategory.Questions[i].Choices[j].Text;
                            DB_Update.UpdateChoice(category.Questions[i].Choices[j]);
                        }
                    }

                    //set the other new properties of the importing questions. This needs to go after the previous code
                    category.Questions[i].Type = importCategoryForm.selectedCategory.Questions[i].Type;
                    category.Questions[i].QuestionText = importCategoryForm.selectedCategory.Questions[i].QuestionText;
                    category.Questions[i].Answer = importCategoryForm.selectedCategory.Questions[i].Answer;

                    //update the question (import the question)
                    DB_Update.UpdateQuestion(category.Questions[i]);
                }
            }
        }

        private void bwImportCategory_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            EnableAllControls();
            btnCancel.Enabled = false; //can't cancel after import
            frmEditCategory_Load(sender, e); //reload form and new info should show
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //MARK: Other Private Methods
        private void DisableAllControls()
        {
            txtTitle.Enabled = false;
            txtSubtitle.Enabled = false;
            btnCancel.Enabled = false;
            btnImport.Enabled = false;
            btnOK.Enabled = false;
            importCategoryFromOtherGameToolStripMenuItem.Enabled = false;
        }
        private void EnableAllControls()
        {
            txtTitle.Enabled = true;
            txtSubtitle.Enabled = true;
            btnCancel.Enabled = true;
            btnImport.Enabled = true;
            btnOK.Enabled = true;
            importCategoryFromOtherGameToolStripMenuItem.Enabled = true;
        }
    }
}
